﻿namespace Prizm.Main.Forms.Reports.Mill
{
    partial class AdditionToTheReport
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionToTheReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.productionDateLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lengthLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.numberLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.heatNumberLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.weightLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.additionToTheReportHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.reportDateTimeInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipesWeight = new DevExpress.XtraReports.UI.XRLabel();
            this.pipesLength = new DevExpress.XtraReports.UI.XRLabel();
            this.totalCount = new DevExpress.XtraReports.UI.XRLabel();
            this.pipesWeightLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.pipesLengthLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.totalCountLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.calculatedField2 = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField3 = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel7,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel6});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.number")});
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(161.0477F, 23F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.weight")});
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(321.0477F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(114.2927F, 23F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLabel9
            // 
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Heat_number")});
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(161.0477F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(160F, 23F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "xrLabel9";
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.length")});
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(435.3404F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(107.6599F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.shippingDate")});
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(543.0002F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(120F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "xrLabel6";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 49F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 55F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PrismDatabase";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "CustomSqlQuery";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.LocationFloat = new DevExpress.Utils.PointFloat(543.0002F, 0F);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.productionDateLabel.SizeF = new System.Drawing.SizeF(120F, 36F);
            this.productionDateLabel.StyleName = "FieldCaption";
            this.productionDateLabel.Text = "production Date";
            // 
            // lengthLabel
            // 
            this.lengthLabel.LocationFloat = new DevExpress.Utils.PointFloat(435.3404F, 0F);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lengthLabel.SizeF = new System.Drawing.SizeF(107.6599F, 36F);
            this.lengthLabel.StyleName = "FieldCaption";
            this.lengthLabel.Text = "length";
            // 
            // numberLabel
            // 
            this.numberLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.numberLabel.SizeF = new System.Drawing.SizeF(161.0477F, 36F);
            this.numberLabel.StyleName = "FieldCaption";
            this.numberLabel.Text = "number";
            // 
            // heatNumberLabel
            // 
            this.heatNumberLabel.LocationFloat = new DevExpress.Utils.PointFloat(161.0477F, 0F);
            this.heatNumberLabel.Name = "heatNumberLabel";
            this.heatNumberLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.heatNumberLabel.SizeF = new System.Drawing.SizeF(160F, 36F);
            this.heatNumberLabel.StyleName = "FieldCaption";
            this.heatNumberLabel.Text = "Heat number";
            // 
            // weightLabel
            // 
            this.weightLabel.LocationFloat = new DevExpress.Utils.PointFloat(321.0477F, 0F);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.weightLabel.SizeF = new System.Drawing.SizeF(114.2926F, 36F);
            this.weightLabel.StyleName = "FieldCaption";
            this.weightLabel.Text = "weight";
            // 
            // pageFooterBand
            // 
            this.pageFooterBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
            this.pageFooterBand.HeightF = 23F;
            this.pageFooterBand.Name = "pageFooterBand";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Format = "{0:dddd, d MMMM, yyyy HH:mm:ss}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0.9401321F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(320.1076F, 23F);
            this.xrPageInfo1.StyleName = "PageInfo";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Format = "{0} / {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(321.0477F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(341.9524F, 23F);
            this.xrPageInfo2.StyleName = "PageInfo";
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.additionToTheReportHeaderLabel,
            this.reportDateTimeInfo,
            this.xrLabel12});
            this.reportHeaderBand1.HeightF = 71.555F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrLabel16
            // 
            this.xrLabel16.ForeColor = System.Drawing.Color.Black;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(543.0002F, 50.055F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(120F, 21.5F);
            this.xrLabel16.StyleName = "Title";
            this.xrLabel16.StylePriority.UseForeColor = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.ForeColor = System.Drawing.Color.Black;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(435.3404F, 50.055F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(107.6598F, 21.5F);
            this.xrLabel15.StyleName = "Title";
            this.xrLabel15.StylePriority.UseForeColor = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.ForeColor = System.Drawing.Color.Black;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(321.0477F, 50.055F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(114.2926F, 21.5F);
            this.xrLabel14.StyleName = "Title";
            this.xrLabel14.StylePriority.UseForeColor = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.ForeColor = System.Drawing.Color.Black;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(161.0477F, 50.055F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(160F, 21.5F);
            this.xrLabel13.StyleName = "Title";
            this.xrLabel13.StylePriority.UseForeColor = false;
            // 
            // additionToTheReportHeaderLabel
            // 
            this.additionToTheReportHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.37501F);
            this.additionToTheReportHeaderLabel.Name = "additionToTheReportHeaderLabel";
            this.additionToTheReportHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.additionToTheReportHeaderLabel.SizeF = new System.Drawing.SizeF(663.0001F, 32.68F);
            this.additionToTheReportHeaderLabel.StyleName = "Title";
            this.additionToTheReportHeaderLabel.Text = "Приложение к отчету";
            // 
            // reportDateTimeInfo
            // 
            this.reportDateTimeInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.reportDateTimeInfo.Format = "{0:dd-MM-yyyy H:mm:ss}";
            this.reportDateTimeInfo.LocationFloat = new DevExpress.Utils.PointFloat(321.0477F, 0F);
            this.reportDateTimeInfo.Name = "reportDateTimeInfo";
            this.reportDateTimeInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportDateTimeInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.reportDateTimeInfo.SizeF = new System.Drawing.SizeF(341.9524F, 17.375F);
            this.reportDateTimeInfo.StylePriority.UseFont = false;
            this.reportDateTimeInfo.StylePriority.UseTextAlignment = false;
            this.reportDateTimeInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.ForeColor = System.Drawing.Color.Black;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50.055F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(161.0477F, 21.5F);
            this.xrLabel12.StyleName = "Title";
            this.xrLabel12.StylePriority.UseForeColor = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.pageHeaderLabel,
            this.pipesWeight,
            this.pipesLength,
            this.totalCount,
            this.pipesWeightLabel,
            this.pipesLengthLabel,
            this.totalCountLabel});
            this.GroupFooter1.HeightF = 67.50003F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel21
            // 
            this.xrLabel21.ForeColor = System.Drawing.Color.Black;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(543.0002F, 0F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(119.9998F, 21.5F);
            this.xrLabel21.StyleName = "Title";
            this.xrLabel21.StylePriority.UseForeColor = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.ForeColor = System.Drawing.Color.Black;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(435.3404F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(107.6598F, 21.5F);
            this.xrLabel20.StyleName = "Title";
            this.xrLabel20.StylePriority.UseForeColor = false;
            // 
            // xrLabel19
            // 
            this.xrLabel19.ForeColor = System.Drawing.Color.Black;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(321.0477F, 0F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(114.2927F, 21.5F);
            this.xrLabel19.StyleName = "Title";
            this.xrLabel19.StylePriority.UseForeColor = false;
            // 
            // xrLabel18
            // 
            this.xrLabel18.ForeColor = System.Drawing.Color.Black;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(161.0477F, 0F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(160F, 21.5F);
            this.xrLabel18.StyleName = "Title";
            this.xrLabel18.StylePriority.UseForeColor = false;
            // 
            // pageHeaderLabel
            // 
            this.pageHeaderLabel.ForeColor = System.Drawing.Color.Black;
            this.pageHeaderLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageHeaderLabel.Name = "pageHeaderLabel";
            this.pageHeaderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageHeaderLabel.SizeF = new System.Drawing.SizeF(161.0477F, 21.5F);
            this.pageHeaderLabel.StyleName = "Title";
            this.pageHeaderLabel.StylePriority.UseForeColor = false;
            // 
            // pipesWeight
            // 
            this.pipesWeight.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.pipesWeight.LocationFloat = new DevExpress.Utils.PointFloat(321.0477F, 44.5F);
            this.pipesWeight.Name = "pipesWeight";
            this.pipesWeight.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipesWeight.SizeF = new System.Drawing.SizeF(114.2926F, 23F);
            this.pipesWeight.StylePriority.UseFont = false;
            this.pipesWeight.Text = "pipesWeight";
            // 
            // pipesLength
            // 
            this.pipesLength.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.pipesLength.LocationFloat = new DevExpress.Utils.PointFloat(161.0477F, 44.5F);
            this.pipesLength.Name = "pipesLength";
            this.pipesLength.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipesLength.SizeF = new System.Drawing.SizeF(159.9999F, 23F);
            this.pipesLength.StylePriority.UseFont = false;
            this.pipesLength.Text = "pipesLength";
            // 
            // totalCount
            // 
            this.totalCount.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.totalCount.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.5F);
            this.totalCount.Name = "totalCount";
            this.totalCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.totalCount.SizeF = new System.Drawing.SizeF(161.0477F, 23F);
            this.totalCount.StylePriority.UseFont = false;
            this.totalCount.Text = "totalCount";
            // 
            // pipesWeightLabel
            // 
            this.pipesWeightLabel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.pipesWeightLabel.LocationFloat = new DevExpress.Utils.PointFloat(321.0477F, 21.50002F);
            this.pipesWeightLabel.Name = "pipesWeightLabel";
            this.pipesWeightLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipesWeightLabel.SizeF = new System.Drawing.SizeF(114.2926F, 23F);
            this.pipesWeightLabel.StylePriority.UseFont = false;
            this.pipesWeightLabel.Text = "Total weight:";
            // 
            // pipesLengthLabel
            // 
            this.pipesLengthLabel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.pipesLengthLabel.LocationFloat = new DevExpress.Utils.PointFloat(161.0477F, 21.50002F);
            this.pipesLengthLabel.Name = "pipesLengthLabel";
            this.pipesLengthLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pipesLengthLabel.SizeF = new System.Drawing.SizeF(160F, 23F);
            this.pipesLengthLabel.StylePriority.UseFont = false;
            this.pipesLengthLabel.Text = "Total Length:";
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.totalCountLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.50002F);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.totalCountLabel.SizeF = new System.Drawing.SizeF(161.0477F, 23F);
            this.totalCountLabel.StylePriority.UseFont = false;
            this.totalCountLabel.Text = "Total count:";
            // 
            // calculatedField2
            // 
            this.calculatedField2.DataMember = "CustomSqlQuery";
            this.calculatedField2.Expression = "[].Sum([weight])";
            this.calculatedField2.Name = "calculatedField2";
            // 
            // calculatedField3
            // 
            this.calculatedField3.DataMember = "CustomSqlQuery";
            this.calculatedField3.Name = "calculatedField3";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.numberLabel,
            this.heatNumberLabel,
            this.weightLabel,
            this.lengthLabel,
            this.productionDateLabel});
            this.GroupHeader1.HeightF = 36F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // AdditionToTheReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageFooterBand,
            this.reportHeaderBand1,
            this.GroupFooter1,
            this.GroupHeader1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedField2,
            this.calculatedField3});
            this.ComponentStorage.Add(this.sqlDataSource1);
            this.DataMember = "Pipe";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(83, 81, 49, 55);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel productionDateLabel;
        private DevExpress.XtraReports.UI.XRLabel weightLabel;
        private DevExpress.XtraReports.UI.XRLabel lengthLabel;
        private DevExpress.XtraReports.UI.XRLabel heatNumberLabel;
        private DevExpress.XtraReports.UI.XRLabel numberLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel additionToTheReportHeaderLabel;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel pipesWeightLabel;
        private DevExpress.XtraReports.UI.XRLabel pipesLengthLabel;
        private DevExpress.XtraReports.UI.XRLabel totalCountLabel;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField2;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField3;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel totalCount;
        private DevExpress.XtraReports.UI.XRLabel pipesWeight;
        private DevExpress.XtraReports.UI.XRLabel pipesLength;
        private DevExpress.XtraReports.UI.XRPageInfo reportDateTimeInfo;
        private DevExpress.XtraReports.UI.XRLabel pageHeaderLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
    }
}
