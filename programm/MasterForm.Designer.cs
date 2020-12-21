
namespace programm
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.Склад1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Repair_serviceDataSet = new programm.Repair_serviceDataSet();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mSwitch = new MetroFramework.Controls.MetroToggle();
            this.btnClose = new MetroFramework.Controls.MetroLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Склад1TableAdapter = new programm.Repair_serviceDataSetTableAdapters.Склад1TableAdapter();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.listBox = new MetroFramework.Controls.MetroListView();
            this.btnCompl = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Склад1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repair_serviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Склад1BindingSource
            // 
            this.Склад1BindingSource.DataMember = "Склад1";
            this.Склад1BindingSource.DataSource = this.Repair_serviceDataSet;
            // 
            // Repair_serviceDataSet
            // 
            this.Repair_serviceDataSet.DataSetName = "Repair_serviceDataSet";
            this.Repair_serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(519, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "LightTheme";
            // 
            // mSwitch
            // 
            this.mSwitch.AutoSize = true;
            this.mSwitch.Checked = true;
            this.mSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mSwitch.Location = new System.Drawing.Point(510, 33);
            this.mSwitch.Name = "mSwitch";
            this.mSwitch.Size = new System.Drawing.Size(80, 17);
            this.mSwitch.Style = MetroFramework.MetroColorStyle.Teal;
            this.mSwitch.TabIndex = 17;
            this.mSwitch.Text = "On";
            this.mSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mSwitch.UseSelectable = true;
            this.mSwitch.CheckedChanged += new System.EventHandler(this.mSwitch_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(611, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(13, 19);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = " ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Склад1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "programm.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(402, 276);
            this.reportViewer1.TabIndex = 19;
            // 
            // Склад1TableAdapter
            // 
            this.Склад1TableAdapter.ClearBeforeFill = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(477, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(156, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Выберите номер заказа";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Location = new System.Drawing.Point(519, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 29);
            this.comboBox1.Style = MetroFramework.MetroColorStyle.Teal;
            this.comboBox1.TabIndex = 24;
            this.comboBox1.UseSelectable = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBox.FullRowSelect = true;
            this.listBox.Location = new System.Drawing.Point(455, 151);
            this.listBox.Name = "listBox";
            this.listBox.OwnerDraw = true;
            this.listBox.Size = new System.Drawing.Size(207, 137);
            this.listBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.listBox.TabIndex = 27;
            this.listBox.TileSize = new System.Drawing.Size(200, 46);
            this.listBox.UseCompatibleStateImageBehavior = false;
            this.listBox.UseSelectable = true;
            this.listBox.View = System.Windows.Forms.View.List;
            // 
            // btnCompl
            // 
            this.btnCompl.ActiveControl = null;
            this.btnCompl.Location = new System.Drawing.Point(455, 303);
            this.btnCompl.Name = "btnCompl";
            this.btnCompl.Size = new System.Drawing.Size(207, 49);
            this.btnCompl.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCompl.TabIndex = 48;
            this.btnCompl.Text = "Заказ выполнен";
            this.btnCompl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompl.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnCompl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCompl.UseSelectable = true;
            this.btnCompl.Click += new System.EventHandler(this.btnCompl_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel3.Location = new System.Drawing.Point(602, 31);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "ВЫЙТИ";
            this.metroLabel3.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MasterForm
            // 
            this.AcceptButton = this.btnCompl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 372);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnCompl);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mSwitch);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Панель мастера";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Склад1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repair_serviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle mSwitch;
        private MetroFramework.Controls.MetroLabel btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Склад1BindingSource;
        private Repair_serviceDataSet Repair_serviceDataSet;
        private Repair_serviceDataSetTableAdapters.Склад1TableAdapter Склад1TableAdapter;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroListView listBox;
        private MetroFramework.Controls.MetroTile btnCompl;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}