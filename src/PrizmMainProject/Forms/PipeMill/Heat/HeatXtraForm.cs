﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ninject;
using Ninject.Parameters;
using Prizm.Main.Forms.MainChildForm;
using System.Linq;
using System.Collections.Generic;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Common;
using Prizm.Main.Commands;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill.Heat
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class HeatXtraForm : PrizmForm
    {

        private HeatViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        public HeatXtraForm()
            : this("")
        {

        }

        public HeatXtraForm(string heatNumber)
        {
            InitializeComponent();
            SetControlsTextLength();
            viewModel = (HeatViewModel)Program.Kernel.Get<HeatViewModel>(new ConstructorArgument("heatNumber", heatNumber));

            if(viewModel.Heat == null)
            {
                CreateHeat(heatNumber);
            }
            else
            {
                this.ShowDialog();
            }


            number.SetAsLookUpIdentifier();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(numberLayoutControl, StringResources.Heat_NumberLabel.Id),
                new LocalizedItem(steelLayoutControl, StringResources.Heat_SteelLabel.Id),
                new LocalizedItem(plateManufacturerLayoutControl, StringResources.Heat_PlateManufacturerLabel.Id),

                new LocalizedItem(saveButton, StringResources.Heat_SaveButton.Id),
                new LocalizedItem(cancelButton, StringResources.Heat_CancelButton.Id),

                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.Heat_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void CreateHeat(string heatNumber)
        {
            var numberForm = new HeatNumberXtraForm(heatNumber);

            if(numberForm.ShowDialog() == DialogResult.OK)
            {
                viewModel.NewHeat(numberForm.Number);
                this.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }

        private void HeatXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            steelGrade.DataBindings.Add("EditValue", bindingSource, "SteelGrade");
            number.DataBindings.Add("EditValue", bindingSource, "Heat");
            plateManufacturer.DataBindings.Add("EditValue", bindingSource, "PlateManufacturer");

            RefreshControls();
        }

        private void BindCommands()
        {
            commandManager["Save"].Executor(viewModel.SaveCommand).AttachTo(saveButton);
        }

        private void HeatXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }

        private void RefreshControls()
        {
            number.Properties.Items.Clear();
            SetupHeats();

            plateManufacturer.Properties.Items.Clear();
            SetupManufacturers();

        }

        private void SetupHeats()
        {
            foreach(var item in viewModel.Heats)
            {
                number.Properties.Items.Add(item);
            }
        }

        private void SetupManufacturers()
        {
            foreach(var item in viewModel.Manufacrurers)
            {
                plateManufacturer.Properties.Items.Add(item);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            RefreshControls();
        }

        private void SetControlsTextLength()
        {
            number.Properties.MaxLength = LengthLimit.MaxHeatNumber;
            steelGrade.Properties.MaxLength = LengthLimit.MaxSteelGrade;
        }


    }
}