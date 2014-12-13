﻿using System;
using System.Configuration;
using System.Windows.Forms;

using Ninject;

using Data.DAL.Hibernate;

using PrizmMain.Forms.MainChildForm;
using PrizmMain.Properties;
using PrizmMain.Forms.Common;
using PrizmMain.Security;
using Data.DAL.Security;
using Domain.Entity.Security;
using Data.DAL;
using PrizmMain.Forms.MainChildForm.FirstSetupForm;

namespace PrizmMain
{
    internal static class Program
    {
        public static IKernel Kernel { get; private set; }

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            bool cmdLineMode = false;
            try
            {
                // Database
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];

                HibernateUtil.Initialize(settings.ConnectionString);

                // Ninject
                Kernel = new StandardKernel(new PrizmModule());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);


                while(!CreateProject())
                { }
                
                //Login
                while (!Login())
                {
                    MessageBox.Show(Resources.AuthenticationFailed, "PRIZMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Application.Run(new PrizmApplicationXtraForm());
            }
            catch (Exception ex)
            {
                String error = ex.ToString();//String.Format(Resources.IDS_ERROR + Environment.NewLine + "{0}\n{01}", ex.InnerException.Message + Environment.NewLine, ex.InnerException.InnerException.Message + Environment.NewLine);
                if (cmdLineMode)
                {
                    Console.Error.WriteLine(error);
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
        }

        static bool Login()
        {
           LoginForm dlg = new LoginForm();
           if (dlg.ShowDialog() == DialogResult.OK)
           {

              string login = dlg.Login;
              string password = dlg.Password;

               #if DEBUG
              if(string.IsNullOrWhiteSpace(dlg.Login) || string.IsNullOrWhiteSpace(dlg.Password))
              {
                  login = "admin";
                  password = "admin";
              }
               #endif

              User user = new User() { IsActive = false, Login = "system" };

              IUserRepository userRepo = Kernel.Get<IUserRepository>();
              user = userRepo.FindByLogin(login);

              if (user == null || !user.IsActive)
                 return false;

              string hash = PasswordEncryptor.EncryptPassword(password);

              if (user.PasswordHash != hash)
                 return false;
              
              ISecurityContext ctx = Kernel.Get<ISecurityContext>();
              ctx.LoggedUser = user;

              HibernateUtil.CurrentUser = ctx.GetLoggedPerson();
              return true;
           }
           else
           {
              System.Environment.Exit(0);
           }

           return false;
        }

        static bool CreateProject()
        {
            bool result = false;
            IProjectRepository repo = (IProjectRepository)Program.Kernel.Get(typeof(IProjectRepository));

            if(repo.GetSingle() == null)
            {
                using(var setupDialog = (FirstSetupXtraForm)Program.Kernel.Get(typeof(FirstSetupXtraForm)))
                {
                        setupDialog.ShowDialog();
                        if(setupDialog.DialogResult == DialogResult.Cancel)
                        {
                            System.Environment.Exit(0);
                        }
                }
            }
            else
            {
                result = true;
            }

            return result;
        }
    }
}