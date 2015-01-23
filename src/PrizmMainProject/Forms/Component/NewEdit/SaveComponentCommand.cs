﻿using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Properties;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.Component.NewEdit
{
    public class SaveComponentCommand: ICommand
    {
        private readonly IComponentRepositories repos;
        private readonly ComponentNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SaveComponentCommand(
            ComponentNewEditViewModel viewModel,
            IComponentRepositories repo, 
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.ValidatableView.Validate())
            {
                return;
            }

            var c = repos.ComponentRepo.GetActiveByNumber(viewModel.Component);
            foreach (var component in c)
            {
                repos.ComponentRepo.Evict(component);
            }

            if (c != null && c.Count > 0)
            {
                notify.ShowInfo(
                    string.Concat(Resources.DLG_COMPONENT_DUPLICATE, viewModel.Number),
                    Resources.DLG_COMPONENT_DUPLICATE_HEDER);
                viewModel.Number = string.Empty;
            }
            else
            {
                try
                {
                    viewModel.Component.InspectionStatus = viewModel.Component.GetPartInspectionStatus();
                    repos.BeginTransaction();
                    repos.ComponentRepo.SaveOrUpdate(viewModel.Component);
                    repos.Commit();
                    repos.ComponentRepo.Evict(viewModel.Component);
                    viewModel.ModifiableView.IsModified = false;
                    viewModel.ModifiableView.UpdateState();

                    //saving attached documents
                    if (viewModel.FilesFormViewModel != null)
                    {
                        viewModel.FilesFormViewModel.Item = viewModel.Component.Id;
                        viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                        viewModel.FilesFormViewModel = null;
                    }

                    notify.ShowSuccess(
                         string.Concat(Resources.DLG_COMPONENT_SAVED, viewModel.Number),
                         Resources.DLG_COMPONENT_SAVED_HEADER);
                }
                catch (RepositoryException ex)
                {
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);
                }
            }
            RefreshVisualStateEvent();
        }


        public bool CanExecute()
        {
            return !string.IsNullOrEmpty(viewModel.Number)
                && viewModel.Type != null
                && viewModel.Component.IsActive
                && ctx.HasAccess(viewModel.IsNew
                                    ? global::Domain.Entity.Security.Privileges.NewDataEntry
                                    : global::Domain.Entity.Security.Privileges.EditData);
        }
               
    }
}
