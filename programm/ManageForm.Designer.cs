namespace programm
{
    partial class ManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            this.diagram1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Repair_serviceDataSet = new programm.Repair_serviceDataSet();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mSwitch = new MetroFramework.Controls.MetroToggle();
            this.btnClose = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.diagram1TableAdapter = new programm.Repair_serviceDataSetTableAdapters.diagram1TableAdapter();
            this.btnPrice = new MetroFramework.Controls.MetroTile();
            this.btnOrder = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repair_serviceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // diagram1BindingSource
            // 
            this.diagram1BindingSource.DataMember = "diagram1";
            this.diagram1BindingSource.DataSource = this.Repair_serviceDataSet;
            // 
            // Repair_serviceDataSet
            // 
            this.Repair_serviceDataSet.DataSetName = "Repair_serviceDataSet";
            this.Repair_serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(316, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "LightTheme";
            // 
            // mSwitch
            // 
            this.mSwitch.AutoSize = true;
            this.mSwitch.Checked = true;
            this.mSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mSwitch.Location = new System.Drawing.Point(307, 35);
            this.mSwitch.Name = "mSwitch";
            this.mSwitch.Size = new System.Drawing.Size(80, 17);
            this.mSwitch.Style = MetroFramework.MetroColorStyle.Teal;
            this.mSwitch.TabIndex = 14;
            this.mSwitch.Text = "On";
            this.mSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mSwitch.UseSelectable = true;
            this.mSwitch.CheckedChanged += new System.EventHandler(this.mSwitch_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(408, 33);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 19);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "ВЫЙТИ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(35, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(188, 19);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Василькова Анна евгеньевна";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.diagram1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "programm.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(405, 220);
            this.reportViewer1.TabIndex = 29;
            // 
            // diagram1TableAdapter
            // 
            this.diagram1TableAdapter.ClearBeforeFill = true;
            // 
            // btnPrice
            // 
            this.btnPrice.ActiveControl = null;
            this.btnPrice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrice.Location = new System.Drawing.Point(34, 322);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(195, 50);
            this.btnPrice.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPrice.TabIndex = 30;
            this.btnPrice.Text = "Прайс-листы";
            this.btnPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrice.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPrice.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPrice.UseSelectable = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.ActiveControl = null;
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrder.Location = new System.Drawing.Point(248, 322);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(192, 50);
            this.btnOrder.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnOrder.TabIndex = 31;
            this.btnOrder.Text = "Оформить заказ";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrder.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnOrder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnOrder.UseSelectable = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 382);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mSwitch);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Панель менеджера";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repair_serviceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle mSwitch;
        private MetroFramework.Controls.MetroLabel btnClose;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource diagram1BindingSource;
        private Repair_serviceDataSet Repair_serviceDataSet;
        private Repair_serviceDataSetTableAdapters.diagram1TableAdapter diagram1TableAdapter;
        private MetroFramework.Controls.MetroTile btnPrice;
        private MetroFramework.Controls.MetroTile btnOrder;
    }
}