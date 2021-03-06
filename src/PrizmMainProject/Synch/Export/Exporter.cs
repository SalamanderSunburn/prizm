﻿using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using Prizm.UnitTests.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.Export
{
   public abstract class Exporter : IExporter
   {
       private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Exporter));
      readonly protected IEncryptor encryptor;
      readonly protected IHasher hasher;

      protected Exporter(IEncryptor encryptor, IHasher hasher)
      {
         this.encryptor = encryptor;
         this.hasher = hasher;
      }


      public event Action OnDone;

      public event Action<ExportException> OnError;

      public event Action<string> OnMessage;

      public string ArchiveName { get; set; }

      public abstract ExportResult Export();

      public abstract ExportResult Export(Portion portion);

      protected void ZipContent(string tempDir)
      {
          if (ArchiveName == null)
          {
              var ex = new ExportException("ArchiveName property should be set before exporting.");
              log.Error(ex.Message);
              throw ex;
          }

         if (System.IO.File.Exists(ArchiveName))
         {
            System.IO.File.Delete(ArchiveName);
         }
         ZipFile.CreateFromDirectory(tempDir, ArchiveName);
      }

      protected void WriteData<T>(string tempDir, T data)
      {
         XmlSerializer serializer = new XmlSerializer(typeof(T));
         byte[] encryptedData;
         using (FileStream dataStream = new FileStream(Path.Combine(tempDir, "Data"), FileMode.CreateNew))
         {
            StringWriter sw = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sw);
            serializer.Serialize(sw, data);

            byte[] rawData = Encoding.Unicode.GetBytes(sw.ToString());
            encryptedData = encryptor.Encrypt(rawData, "^PRIZM_ENCRYPTION_KEY$");

            dataStream.Write(encryptedData, 0, encryptedData.Length);
         }

         System.IO.File.WriteAllText(Path.Combine(tempDir, "Data.sha1"), hasher.GetHash(encryptedData));
      }


      protected void WriteManifest(string tempDir, Guid portionId, int portionNumber, DateTime exportDateTime, WorkstationType workstationType)
      {
         Manifest manifest = new Manifest();
         manifest.ExportDateTime = exportDateTime;
         manifest.PortionID = portionId;
         manifest.PortionNumber = portionNumber;
         manifest.WorkstationType = workstationType;

         XmlSerializer serializer = new XmlSerializer(typeof(Manifest));
         byte[] encryptedData;
         using (FileStream dataStream = new FileStream(Path.Combine(tempDir, "Manifest"), FileMode.CreateNew))
         {
            StringWriter sw = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sw);
            serializer.Serialize(sw, manifest);

            byte[] rawData = Encoding.Unicode.GetBytes(sw.ToString());
            encryptedData = encryptor.Encrypt(rawData, "^PRIZM_ENCRYPTION_KEY$");

            dataStream.Write(encryptedData, 0, encryptedData.Length);
         }

         System.IO.File.WriteAllText(Path.Combine(tempDir, "Manifest.sha1"), hasher.GetHash(encryptedData));
      }

      protected void FireMessage(string message)
      {
         if (OnMessage != null)
            OnMessage(message);
      }

      protected void FireDone()
      {
         if (OnDone != null)
            OnDone();
      }

      protected ExportResult FireError(Exception e)
      {
         if (OnError != null)
         {
            OnError(new ExportException(e.Message, e));
            return ExportResult.Failed;
         }
         else
         {
            var ex = new ExportException(e.Message, e);
            log.Error(ex.Message);
            throw ex;
         }
      }
   }
}
