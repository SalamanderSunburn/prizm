﻿namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    partial class InspectionAddEditXtraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectionAddEditXtraForm));
            this.rootLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.factString = new DevExpress.XtraEditors.LookUpEdit();
            this.status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.factBool = new DevExpress.XtraEditors.CheckEdit();
            this.code = new DevExpress.XtraEditors.ComboBoxEdit();
            this.inspectors = new Prizm.Main.Controls.InspectorSelectionControl();
            this.date = new DevExpress.XtraEditors.DateEdit();
            this.expected = new DevExpress.XtraEditors.TextEdit();
            this.name = new DevExpress.XtraEditors.TextEdit();
            this.category = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.rootLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.operationLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.categoryLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.nameLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.codeLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.delimiterEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cancelLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.resultLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.expectedLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectorsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.bottomEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.factDiapasonLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.factLimitLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.factBoolLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.factBoolLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.factStringLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.factStringLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.footerEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factLimit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControl)).BeginInit();
            this.rootLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factBool.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expected.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimiterEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expectedLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factDiapasonLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factLimitLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factBoolLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factBoolLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factStringLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factStringLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factLimit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rootLayoutControl
            // 
            this.rootLayoutControl.Controls.Add(this.factString);
            this.rootLayoutControl.Controls.Add(this.status);
            this.rootLayoutControl.Controls.Add(this.factBool);
            this.rootLayoutControl.Controls.Add(this.code);
            this.rootLayoutControl.Controls.Add(this.inspectors);
            this.rootLayoutControl.Controls.Add(this.date);
            this.rootLayoutControl.Controls.Add(this.expected);
            this.rootLayoutControl.Controls.Add(this.name);
            this.rootLayoutControl.Controls.Add(this.category);
            this.rootLayoutControl.Controls.Add(this.saveButton);
            this.rootLayoutControl.Controls.Add(this.cancelButton);
            this.rootLayoutControl.Controls.Add(this.factLimit);
            this.rootLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutControl.Name = "rootLayoutControl";
            this.rootLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(464, 158, 637, 658);
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rootLayoutControl.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.rootLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rootLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rootLayoutControl.Root = this.rootLayoutGroup;
            this.rootLayoutControl.Size = new System.Drawing.Size(816, 586);
            this.rootLayoutControl.TabIndex = 0;
            this.rootLayoutControl.Text = "layoutControl1";
            // 
            // factString
            // 
            this.factString.Location = new System.Drawing.Point(35, 226);
            this.factString.Name = "factString";
            this.factString.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.factString.Properties.NullText = "";
            this.factString.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.factString.Size = new System.Drawing.Size(319, 20);
            this.factString.StyleController = this.rootLayoutControl;
            this.factString.TabIndex = 17;
            this.factString.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.factString_ProcessNewValue);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(32, 466);
            this.status.Name = "status";
            this.status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.status.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.status.Size = new System.Drawing.Size(325, 20);
            this.status.StyleController = this.rootLayoutControl;
            this.status.TabIndex = 16;
            // 
            // factBool
            // 
            this.factBool.Location = new System.Drawing.Point(35, 293);
            this.factBool.Name = "factBool";
            this.factBool.Properties.Caption = "Результат";
            this.factBool.Size = new System.Drawing.Size(319, 19);
            this.factBool.StyleController = this.rootLayoutControl;
            this.factBool.TabIndex = 14;
            this.factBool.CheckedChanged += new System.EventHandler(this.factBool_CheckedChanged);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(32, 67);
            this.code.Name = "code";
            this.code.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.code.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.code.Size = new System.Drawing.Size(123, 20);
            this.code.StyleController = this.rootLayoutControl;
            this.code.TabIndex = 12;
            this.code.EditValueChanged += new System.EventHandler(this.code_EditValueChanged);
            // 
            // inspectors
            // 
            this.inspectors.DataSource = null;
            this.inspectors.InspectionDate = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            this.inspectors.Location = new System.Drawing.Point(371, 166);
            this.inspectors.Name = "inspectors";
            this.inspectors.Size = new System.Drawing.Size(413, 361);
            this.inspectors.TabIndex = 11;
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Location = new System.Drawing.Point(32, 416);
            this.date.Name = "date";
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Size = new System.Drawing.Size(325, 20);
            this.date.StyleController = this.rootLayoutControl;
            this.date.TabIndex = 10;
            this.date.EditValueChanged += new System.EventHandler(this.date_EditValueChanged);
            // 
            // expected
            // 
            this.expected.Location = new System.Drawing.Point(32, 166);
            this.expected.Name = "expected";
            this.expected.Properties.ReadOnly = true;
            this.expected.Size = new System.Drawing.Size(325, 20);
            this.expected.StyleController = this.rootLayoutControl;
            this.expected.TabIndex = 7;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(462, 67);
            this.name.Name = "name";
            this.name.Properties.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(322, 20);
            this.name.StyleController = this.rootLayoutControl;
            this.name.TabIndex = 6;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(169, 67);
            this.category.Name = "category";
            this.category.Properties.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(279, 20);
            this.category.StyleController = this.rootLayoutControl;
            this.category.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(560, 551);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 22);
            this.saveButton.StyleController = this.rootLayoutControl;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "&Принять";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(695, 551);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 22);
            this.cancelButton.StyleController = this.rootLayoutControl;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отменить";
            // 
            // rootLayoutGroup
            // 
            this.rootLayoutGroup.CustomizationFormText = "Root";
            this.rootLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rootLayoutGroup.GroupBordersVisible = false;
            this.rootLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.operationLayoutControlGroup,
            this.saveLayoutControlItem,
            this.delimiterEmptySpaceItem,
            this.cancelLayoutControlItem,
            this.resultLayoutControlGroup,
            this.footerEmptySpaceItem});
            this.rootLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutGroup.Name = "rootLayoutGroup";
            this.rootLayoutGroup.Size = new System.Drawing.Size(816, 586);
            this.rootLayoutGroup.Text = "rootLayoutGroup";
            this.rootLayoutGroup.TextVisible = false;
            // 
            // operationLayoutControlGroup
            // 
            this.operationLayoutControlGroup.CustomizationFormText = "Контрольная операция";
            this.operationLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.categoryLayoutControlItem,
            this.nameLayoutControlItem,
            this.codeLayoutControlItem});
            this.operationLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.operationLayoutControlGroup.Name = "operationLayoutControlGroup";
            this.operationLayoutControlGroup.Size = new System.Drawing.Size(796, 99);
            this.operationLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.operationLayoutControlGroup.Text = "Контрольная операция";
            // 
            // categoryLayoutControlItem
            // 
            this.categoryLayoutControlItem.Control = this.category;
            this.categoryLayoutControlItem.CustomizationFormText = "Категория";
            this.categoryLayoutControlItem.Location = new System.Drawing.Point(137, 0);
            this.categoryLayoutControlItem.Name = "categoryLayoutControlItem";
            this.categoryLayoutControlItem.Size = new System.Drawing.Size(293, 50);
            this.categoryLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.categoryLayoutControlItem.Text = "Категория";
            this.categoryLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.categoryLayoutControlItem.TextSize = new System.Drawing.Size(62, 13);
            // 
            // nameLayoutControlItem
            // 
            this.nameLayoutControlItem.Control = this.name;
            this.nameLayoutControlItem.CustomizationFormText = "Название";
            this.nameLayoutControlItem.Location = new System.Drawing.Point(430, 0);
            this.nameLayoutControlItem.Name = "nameLayoutControlItem";
            this.nameLayoutControlItem.Size = new System.Drawing.Size(336, 50);
            this.nameLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.nameLayoutControlItem.Text = "Название";
            this.nameLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.nameLayoutControlItem.TextSize = new System.Drawing.Size(62, 13);
            // 
            // codeLayoutControlItem
            // 
            this.codeLayoutControlItem.Control = this.code;
            this.codeLayoutControlItem.CustomizationFormText = "Код";
            this.codeLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.codeLayoutControlItem.Name = "codeLayoutControlItem";
            this.codeLayoutControlItem.Size = new System.Drawing.Size(137, 50);
            this.codeLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.codeLayoutControlItem.Text = "Код";
            this.codeLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.codeLayoutControlItem.TextSize = new System.Drawing.Size(62, 13);
            // 
            // saveLayoutControlItem
            // 
            this.saveLayoutControlItem.Control = this.saveButton;
            this.saveLayoutControlItem.CustomizationFormText = "Сохранить";
            this.saveLayoutControlItem.Location = new System.Drawing.Point(540, 539);
            this.saveLayoutControlItem.Name = "saveLayoutControlItem";
            this.saveLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 2);
            this.saveLayoutControlItem.Size = new System.Drawing.Size(125, 27);
            this.saveLayoutControlItem.Text = "Сохранить";
            this.saveLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveLayoutControlItem.TextVisible = false;
            // 
            // delimiterEmptySpaceItem
            // 
            this.delimiterEmptySpaceItem.AllowHotTrack = false;
            this.delimiterEmptySpaceItem.CustomizationFormText = "emptySpaceItem1";
            this.delimiterEmptySpaceItem.Location = new System.Drawing.Point(665, 539);
            this.delimiterEmptySpaceItem.MaxSize = new System.Drawing.Size(10, 27);
            this.delimiterEmptySpaceItem.MinSize = new System.Drawing.Size(10, 27);
            this.delimiterEmptySpaceItem.Name = "delimiterEmptySpaceItem";
            this.delimiterEmptySpaceItem.Size = new System.Drawing.Size(10, 27);
            this.delimiterEmptySpaceItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.delimiterEmptySpaceItem.Text = "delimiterEmptySpaceItem";
            this.delimiterEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cancelLayoutControlItem
            // 
            this.cancelLayoutControlItem.Control = this.cancelButton;
            this.cancelLayoutControlItem.CustomizationFormText = "Отменить";
            this.cancelLayoutControlItem.Location = new System.Drawing.Point(675, 539);
            this.cancelLayoutControlItem.Name = "cancelLayoutControlItem";
            this.cancelLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 2);
            this.cancelLayoutControlItem.Size = new System.Drawing.Size(121, 27);
            this.cancelLayoutControlItem.Text = "Отменить";
            this.cancelLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cancelLayoutControlItem.TextVisible = false;
            // 
            // resultLayoutControlGroup
            // 
            this.resultLayoutControlGroup.CustomizationFormText = "Результат";
            this.resultLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.expectedLayoutControlItem,
            this.inspectorsLayoutControlItem,
            this.bottomEmptySpaceItem,
            this.factDiapasonLayoutControlGroup,
            this.factBoolLayoutControlGroup,
            this.factStringLayoutControlGroup,
            this.dateLayoutControlItem,
            this.statusLayoutControlItem});
            this.resultLayoutControlGroup.Location = new System.Drawing.Point(0, 99);
            this.resultLayoutControlGroup.Name = "resultLayoutControlGroup";
            this.resultLayoutControlGroup.Size = new System.Drawing.Size(796, 440);
            this.resultLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.resultLayoutControlGroup.Text = "Результат";
            // 
            // expectedLayoutControlItem
            // 
            this.expectedLayoutControlItem.Control = this.expected;
            this.expectedLayoutControlItem.CustomizationFormText = "Ожидаемый";
            this.expectedLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.expectedLayoutControlItem.Name = "expectedLayoutControlItem";
            this.expectedLayoutControlItem.Size = new System.Drawing.Size(339, 50);
            this.expectedLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.expectedLayoutControlItem.Text = "Ожидаемый";
            this.expectedLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.expectedLayoutControlItem.TextSize = new System.Drawing.Size(62, 13);
            // 
            // inspectorsLayoutControlItem
            // 
            this.inspectorsLayoutControlItem.Control = this.inspectors;
            this.inspectorsLayoutControlItem.CustomizationFormText = "Инспекторы";
            this.inspectorsLayoutControlItem.Location = new System.Drawing.Point(339, 0);
            this.inspectorsLayoutControlItem.Name = "inspectorsLayoutControlItem";
            this.inspectorsLayoutControlItem.Size = new System.Drawing.Size(427, 391);
            this.inspectorsLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.inspectorsLayoutControlItem.Text = "Инспекторы";
            this.inspectorsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectorsLayoutControlItem.TextSize = new System.Drawing.Size(62, 13);
            // 
            // bottomEmptySpaceItem
            // 
            this.bottomEmptySpaceItem.AllowHotTrack = false;
            this.bottomEmptySpaceItem.CustomizationFormText = "emptySpaceItem3";
            this.bottomEmptySpaceItem.Location = new System.Drawing.Point(0, 350);
            this.bottomEmptySpaceItem.Name = "bottomEmptySpaceItem";
            this.bottomEmptySpaceItem.Size = new System.Drawing.Size(339, 41);
            this.bottomEmptySpaceItem.Text = "bottomEmptySpaceItem";
            this.bottomEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // factDiapasonLayoutControlGroup
            // 
            this.factDiapasonLayoutControlGroup.CustomizationFormText = "Фактический";
            this.factDiapasonLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.factLimitLayout});
            this.factDiapasonLayoutControlGroup.Location = new System.Drawing.Point(0, 183);
            this.factDiapasonLayoutControlGroup.Name = "factDiapasonLayoutControlGroup";
            this.factDiapasonLayoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 9, 9);
            this.factDiapasonLayoutControlGroup.Size = new System.Drawing.Size(339, 67);
            this.factDiapasonLayoutControlGroup.Text = "Фактический";
            this.factDiapasonLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // factLimitLayout
            // 
            this.factLimitLayout.Control = this.factLimit;
            this.factLimitLayout.CustomizationFormText = "От";
            this.factLimitLayout.Location = new System.Drawing.Point(0, 0);
            this.factLimitLayout.Name = "factLimitLayout";
            this.factLimitLayout.Size = new System.Drawing.Size(323, 24);
            this.factLimitLayout.Text = "От";
            this.factLimitLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.factLimitLayout.TextSize = new System.Drawing.Size(0, 0);
            this.factLimitLayout.TextToControlDistance = 0;
            // 
            // factBoolLayoutControlGroup
            // 
            this.factBoolLayoutControlGroup.CustomizationFormText = "Фактический";
            this.factBoolLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.factBoolLayoutControlItem});
            this.factBoolLayoutControlGroup.Location = new System.Drawing.Point(0, 117);
            this.factBoolLayoutControlGroup.Name = "factBoolLayoutControlGroup";
            this.factBoolLayoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 9, 9);
            this.factBoolLayoutControlGroup.Size = new System.Drawing.Size(339, 66);
            this.factBoolLayoutControlGroup.Text = "Фактический";
            this.factBoolLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // factBoolLayoutControlItem
            // 
            this.factBoolLayoutControlItem.Control = this.factBool;
            this.factBoolLayoutControlItem.CustomizationFormText = "Логический";
            this.factBoolLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.factBoolLayoutControlItem.Name = "factBoolLayoutControlItem";
            this.factBoolLayoutControlItem.Size = new System.Drawing.Size(323, 23);
            this.factBoolLayoutControlItem.Text = "factBoolLayoutControlItem";
            this.factBoolLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.factBoolLayoutControlItem.TextVisible = false;
            // 
            // factStringLayoutControlGroup
            // 
            this.factStringLayoutControlGroup.CustomizationFormText = "Фактический";
            this.factStringLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.factStringLayout});
            this.factStringLayoutControlGroup.Location = new System.Drawing.Point(0, 50);
            this.factStringLayoutControlGroup.Name = "factStringLayoutControlGroup";
            this.factStringLayoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 9, 9);
            this.factStringLayoutControlGroup.Size = new System.Drawing.Size(339, 67);
            this.factStringLayoutControlGroup.Text = "Фактический";
            this.factStringLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // factStringLayout
            // 
            this.factStringLayout.Control = this.factString;
            this.factStringLayout.CustomizationFormText = "factStringLayout";
            this.factStringLayout.Location = new System.Drawing.Point(0, 0);
            this.factStringLayout.Name = "factStringLayout";
            this.factStringLayout.Size = new System.Drawing.Size(323, 24);
            this.factStringLayout.Text = "factStringLayout";
            this.factStringLayout.TextSize = new System.Drawing.Size(0, 0);
            this.factStringLayout.TextVisible = false;
            // 
            // dateLayoutControlItem
            // 
            this.dateLayoutControlItem.Control = this.date;
            this.dateLayoutControlItem.CustomizationFormText = "Дата";
            this.dateLayoutControlItem.Location = new System.Drawing.Point(0, 250);
            this.dateLayoutControlItem.Name = "dateLayoutControlItem";
            this.dateLayoutControlItem.Size = new System.Drawing.Size(339, 50);
            this.dateLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.dateLayoutControlItem.Text = "Дата";
            this.dateLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.dateLayoutControlItem.TextSize = new System.Drawing.Size(62, 13);
            // 
            // statusLayoutControlItem
            // 
            this.statusLayoutControlItem.Control = this.status;
            this.statusLayoutControlItem.CustomizationFormText = "Статус";
            this.statusLayoutControlItem.Location = new System.Drawing.Point(0, 300);
            this.statusLayoutControlItem.Name = "statusLayoutControlItem";
            this.statusLayoutControlItem.Size = new System.Drawing.Size(339, 50);
            this.statusLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.statusLayoutControlItem.Text = "Статус";
            this.statusLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.statusLayoutControlItem.TextSize = new System.Drawing.Size(62, 13);
            // 
            // footerEmptySpaceItem
            // 
            this.footerEmptySpaceItem.AllowHotTrack = false;
            this.footerEmptySpaceItem.CustomizationFormText = "emptySpaceItem2";
            this.footerEmptySpaceItem.Location = new System.Drawing.Point(0, 539);
            this.footerEmptySpaceItem.Name = "footerEmptySpaceItem";
            this.footerEmptySpaceItem.Size = new System.Drawing.Size(540, 27);
            this.footerEmptySpaceItem.Text = "footerEmptySpaceItem";
            this.footerEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // factLimit
            // 
            this.factLimit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.factLimit.Location = new System.Drawing.Point(35, 359);
            this.factLimit.Name = "factLimit";
            this.factLimit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.factLimit.Properties.Mask.EditMask = "\\d+([\\.\\,]\\d{0,2})?";
            this.factLimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.factLimit.Size = new System.Drawing.Size(319, 20);
            this.factLimit.StyleController = this.rootLayoutControl;
            this.factLimit.TabIndex = 15;
            this.factLimit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.factLimit_ParseEditValue);
            // 
            // InspectionAddEditXtraForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(816, 586);
            this.Controls.Add(this.rootLayoutControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InspectionAddEditXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InspectionAddEditXtraForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InspectionAddEditXtraForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InspectionAddEditXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.InspectionAddEditXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControl)).EndInit();
            this.rootLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.factString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factBool.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expected.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimiterEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expectedLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factDiapasonLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factLimitLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factBoolLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factBoolLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factStringLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factStringLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factLimit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl rootLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup rootLayoutGroup;
        private Controls.InspectorSelectionControl inspectors;
        private DevExpress.XtraEditors.DateEdit date;
        private DevExpress.XtraEditors.TextEdit expected;
        private DevExpress.XtraEditors.TextEdit name;
        private DevExpress.XtraEditors.TextEdit category;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlGroup operationLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem categoryLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem nameLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup resultLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem expectedLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem dateLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem inspectorsLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem saveLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem delimiterEmptySpaceItem;
        private DevExpress.XtraLayout.LayoutControlItem cancelLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem footerEmptySpaceItem;
        private DevExpress.XtraLayout.EmptySpaceItem bottomEmptySpaceItem;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private System.Windows.Forms.BindingSource inspectorsBindingSource;
        private DevExpress.XtraEditors.ComboBoxEdit code;
        private DevExpress.XtraLayout.LayoutControlItem codeLayoutControlItem;
        private DevExpress.XtraEditors.CheckEdit factBool;
        private DevExpress.XtraLayout.LayoutControlGroup factDiapasonLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem factLimitLayout;
        private DevExpress.XtraLayout.LayoutControlGroup factBoolLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem factBoolLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup factStringLayoutControlGroup;
        private DevExpress.XtraEditors.ComboBoxEdit status;
        private DevExpress.XtraLayout.LayoutControlItem statusLayoutControlItem;
        private DevExpress.XtraEditors.LookUpEdit factString;
        private DevExpress.XtraLayout.LayoutControlItem factStringLayout;
        private DevExpress.XtraEditors.TextEdit factLimit;
    }
}