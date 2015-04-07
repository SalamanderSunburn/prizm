﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject.Parameters;
using Prizm.Main;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.Notifications;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Languages;
using Prizm.Main.Properties;


namespace PrizmMain.Forms.Notifications
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class NotificationXtraForm : ChildForm
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotificationXtraForm));
        // Fields
        private NotificationViewModel viewModel;

        // Methods
        public NotificationXtraForm()
        {
            this.components = null;
            this.InitializeComponent();
        }

        private void NotificationXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (NotificationViewModel)Program.Kernel.GetService(typeof(NotificationViewModel));
            BindToViewModel();

        }

        private void BindToViewModel()
        {
            notificationBindingSource.DataSource = viewModel;
            gridControlMessage.DataBindings.Add("DataSource", notificationBindingSource, "Notification");
        }

        private void gridControlMessage_DoubleClick(object sender, EventArgs e)
        {
            int selectedItem = gridViewNotification.GetFocusedDataSourceRowIndex();
            if (selectedItem >= 0)
            {
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                var id = viewModel.Notification[selectedItem].Id;


                OpenEditorForm(id, viewModel.Notification[selectedItem].TypeNotification);
            }
    
        }

        private void OpenEditorForm(Guid id, TypeNotification typeNotification)
        {
            DocumentTypes typeEditor;
            int page = -1;
            switch (typeNotification)
            {
                case TypeNotification.DuplicatePipeNumber:
                    typeEditor = DocumentTypes.MillPipe;
                    break;
                case TypeNotification.DuplicateLogin:
                    typeEditor = DocumentTypes.Settings;
                    page = 6;
                    break;
                case TypeNotification.ExpiredInspectorCertificate:
                    typeEditor = DocumentTypes.Settings;
                    page = 5;
                    break;
                case TypeNotification.ExpiredWelderCertificate:
                    typeEditor = DocumentTypes.Settings;
                    page = 4;
                    break;
                case TypeNotification.NotRequiredInspectionOperation:
                    typeEditor = DocumentTypes.Settings;
                    page = 1;
                    break;
                default:
                    var ex = new NotImplementedException(String.Format("Type editor not set for notification code {0}", typeNotification));
                    log.Error(ex.Message);
                    throw ex;
                    //break; // unreachable code
            }

            if (typeEditor == DocumentTypes.Settings && page >= 0)
            {
                FormManager.Instance.OpenSettingsChildForm(page);
            }
            else
            {
                FormManager.Instance.OpenChildForm(typeEditor, id);
            }
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(layoutControlItemNotification, StringResources.NotificationXtraForm_LayoutControlItemNotification.Id),
                new LocalizedItem(colDate, StringResources.NotificationXtraForm_ColDate.Id),
                new LocalizedItem(colNotification, StringResources.NotificationXtraForm_ColNotification.Id),
                new LocalizedItem(colName, StringResources.NotificationXtraForm_ColName.Id),
                
                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.NotificationXtraForm_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void NotificationXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }

        private void NotificationXtraForm_Activated(object sender, EventArgs e)
        {
            // Refresh list of notification and grid DataSource
            NotificationService.Instance.LoadAllNotifications();
            gridControlMessage.DataSource = NotificationService.Instance.Notifications;
        }




    }
}
