using System;
using System.ComponentModel;

using Ninject.Parameters;
using Ninject;

using DevExpress.XtraEditors;

using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.MainChildForm;

using PrizmMain.DummyData;
using System.Windows.Forms;
using Domain.Entity.Mill;
using System.Collections.Generic;
using PrizmMain.Properties;
using Domain.Entity.Setup;

namespace PrizmMain.Forms.PipeMill.Search
{
    public partial class MillPipeSearchXtraForm : ChildForm
    {
        private MillPipeSearchViewModel viewModel;
        private Dictionary<PipeMillStatus, string> statusTypeDict 
            = new Dictionary<PipeMillStatus, string>();

        public MillPipeSearchXtraForm()
        {
            InitializeComponent();
        }

        private void BindToViewModel()
        {
            MillPipeSearchBindingSource.DataSource = viewModel;

            foreach (var s in viewModel.PipeTypes)
            {
                pipeSize.Properties.Items.Add(s);
            }
            foreach (var s in viewModel.StatusTypes)
            {
                pipeMillStatus.Properties.Items.Add(s);
            }

            pipesSearchResult.DataBindings
                .Add("DataSource", MillPipeSearchBindingSource, "Pipes");
            pipeNumber.DataBindings
                .Add("EditValue", MillPipeSearchBindingSource, "PipeNumber");
            pipeMillStatus.DataBindings
                .Add("EditValue", MillPipeSearchBindingSource, "PipeMillStatus");      

            statusTypeDict.Clear();
            statusTypeDict.Add(PipeMillStatus.Produced, Resources.Produced);
            statusTypeDict.Add(PipeMillStatus.Shipped, Resources.Shipped);
            statusTypeDict.Add(PipeMillStatus.Stocked, Resources.Stocked);
            statusTypeDict.Add(PipeMillStatus.Undefined, Resources.Undefined);
            repositoryLookUpEditStatus.DataSource = statusTypeDict;

        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
        }

        private void MillPipeSearchXtraForm_Load(object sender, System.EventArgs e)
        {
            viewModel = (MillPipeSearchViewModel)Program.Kernel.GetService(typeof(MillPipeSearchViewModel));

            BindCommands();
            BindToViewModel();
        }

        private void pipeRepositoryButtonEdit_Click(object sender, System.EventArgs e)
        {

            int selectedPipe = pipesSearchResultView.GetFocusedDataSourceRowIndex();

            var parent = this.MdiParent as PrizmApplicationXtraForm;

            parent.CreateChildForm(
                    typeof(MillPipeNewEditXtraForm),
                    new ConstructorArgument(
                        "pipeId",
                        viewModel.Pipes[selectedPipe].Id));
        }

        private void pipesSearchResultView_DoubleClick(object sender, EventArgs e)
        {
            pipeRepositoryButtonEdit_Click(sender, e);
        }

        private void pipesSearchResultView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pipeRepositoryButtonEdit_Click(sender, e);
            }
        }

        private void repositoryLookUpEditStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            try
            {
                if (e.Value is PipeMillStatus)
                {
                    e.DisplayText = statusTypeDict[(PipeMillStatus)e.Value];
                }
            }
            catch (KeyNotFoundException exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void pipeSize_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            viewModel.CheckedPipeTypes.Clear();

            for(int i = 0; i < pipeSize.Properties.Items.Count; ++i)
            {
                if (pipeSize.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    viewModel.CheckedPipeTypes
                        .Add(pipeSize.Properties.Items[i].Value as PipeMillSizeType);
                }
            }
        }

    }
}