
namespace programm
{
    partial class PriceListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceListForm));
            this.Услуги3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Repair_serviceDataSet = new programm.Repair_serviceDataSet();
            this.Услуги1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Услуги2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Услуги1TableAdapter = new programm.Repair_serviceDataSetTableAdapters.Услуги1TableAdapter();
            this.Услуги2TableAdapter = new programm.Repair_serviceDataSetTableAdapters.Услуги2TableAdapter();
            this.Услуги3TableAdapter = new programm.Repair_serviceDataSetTableAdapters.Услуги3TableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mSwitch = new MetroFramework.Controls.MetroToggle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Услуги3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repair_serviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Услуги1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Услуги2BindingSource)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage6.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Услуги3BindingSource
            // 
            this.Услуги3BindingSource.DataMember = "Услуги3";
            this.Услуги3BindingSource.DataSource = this.Repair_serviceDataSet;
            // 
            // Repair_serviceDataSet
            // 
            this.Repair_serviceDataSet.DataSetName = "Repair_serviceDataSet";
            this.Repair_serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Услуги1BindingSource
            // 
            this.Услуги1BindingSource.DataMember = "Услуги1";
            this.Услуги1BindingSource.DataSource = this.Repair_serviceDataSet;
            // 
            // Услуги2BindingSource
            // 
            this.Услуги2BindingSource.DataMember = "Услуги2";
            this.Услуги2BindingSource.DataSource = this.Repair_serviceDataSet;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.metroTabControl1.Controls.Add(this.metroTabPage6);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 51);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(622, 400);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.Controls.Add(this.reportViewer6);
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(614, 355);
            this.metroTabPage6.TabIndex = 5;
            this.metroTabPage6.Text = "Сканеры";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // reportViewer6
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Услуги3BindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "programm.Report3.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(0, 3);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(614, 352);
            this.reportViewer6.TabIndex = 8;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.reportViewer1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(614, 355);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Принтеры";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Услуги1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "programm.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(614, 352);
            this.reportViewer1.TabIndex = 6;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.reportViewer3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(614, 355);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Факсимильные аппараты";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Услуги1BindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "programm.Report1.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(614, 352);
            this.reportViewer3.TabIndex = 8;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.reportViewer2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(614, 355);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Копировальные аппараты";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // reportViewer2
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.Услуги1BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "programm.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(614, 352);
            this.reportViewer2.TabIndex = 7;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.reportViewer4);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(614, 355);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "МФУ";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // reportViewer4
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.Услуги1BindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "programm.Report1.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(614, 352);
            this.reportViewer4.TabIndex = 8;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.reportViewer5);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(614, 355);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "Плоттеры";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // reportViewer5
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.Услуги2BindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "programm.Report2.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(614, 352);
            this.reportViewer5.TabIndex = 8;
            // 
            // Услуги1TableAdapter
            // 
            this.Услуги1TableAdapter.ClearBeforeFill = true;
            // 
            // Услуги2TableAdapter
            // 
            this.Услуги2TableAdapter.ClearBeforeFill = true;
            // 
            // Услуги3TableAdapter
            // 
            this.Услуги3TableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(564, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "LightTheme";
            // 
            // mSwitch
            // 
            this.mSwitch.AutoSize = true;
            this.mSwitch.Checked = true;
            this.mSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mSwitch.Location = new System.Drawing.Point(555, 31);
            this.mSwitch.Name = "mSwitch";
            this.mSwitch.Size = new System.Drawing.Size(80, 17);
            this.mSwitch.Style = MetroFramework.MetroColorStyle.Teal;
            this.mSwitch.TabIndex = 16;
            this.mSwitch.Text = "On";
            this.mSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mSwitch.UseSelectable = true;
            this.mSwitch.CheckedChanged += new System.EventHandler(this.mSwitch_CheckedChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // PriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 465);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mSwitch);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PriceListForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Прайс-лист";
            this.Load += new System.EventHandler(this.PriceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Услуги3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repair_serviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Услуги1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Услуги2BindingSource)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage6.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private System.Windows.Forms.BindingSource Услуги1BindingSource;
        private Repair_serviceDataSet Repair_serviceDataSet;
        private Repair_serviceDataSetTableAdapters.Услуги1TableAdapter Услуги1TableAdapter;
        private System.Windows.Forms.BindingSource Услуги2BindingSource;
        private Repair_serviceDataSetTableAdapters.Услуги2TableAdapter Услуги2TableAdapter;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource Услуги3BindingSource;
        private Repair_serviceDataSetTableAdapters.Услуги3TableAdapter Услуги3TableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle mSwitch;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}