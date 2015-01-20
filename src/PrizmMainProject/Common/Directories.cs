﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public static class Directories
    {
        public static string FilesToAttachFolder = Path.Combine(Directory.GetCurrentDirectory(), "Data\\Attachments\\FilesToAttach\\");
        public static string TargetPath = Path.Combine(Directory.GetCurrentDirectory(), "Data\\Attachments\\");
        public static string TargetPathForView = Path.Combine(Directory.GetCurrentDirectory(), "Data\\Attachments\\tmp\\");

        public const string LanguagesFolderName = "Languages";
        public const string BaseLanguageFileName = "Strings";
        public static string Languages = Path.Combine(Directory.GetCurrentDirectory(), LanguagesFolderName);
    }
}
