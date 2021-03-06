﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class SelectDiameterDialog : PrizmForm
    {

        public decimal Diameter { get; set; }

        public SelectDiameterDialog()
        {
            InitializeComponent();

            saveChosenDiameter.Enabled = false;
        }

        public SelectDiameterDialog(List<Connector> duplicates): this()
        {
            InitializeSelectDiameter(duplicates);
        }

        public void InitializeSelectDiameter(List<Connector> duplicates)
        {
            diametersIntersection.Properties.Items.Clear();
            foreach (var t in duplicates)
            {
                diametersIntersection.Properties.Items.Add(t);
            }
            diametersIntersection.SelectedIndex = -1;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(diametersIntersectionLayout, StringResources.SelectDiameterDialog_DiametersIntersectionLayout.Id),
                new LocalizedItem(saveChosenDiameter, StringResources.SelectDiameterDialog_SaveChosenDiameter.Id),

                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.SelectDiameterDialog_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void diametersIntersection_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cntr = diametersIntersection.EditValue as Connector;

            if (cntr != null) Diameter = cntr.Diameter;

            saveChosenDiameter.Enabled = (diametersIntersection.EditValue != null);
        }
    }
}