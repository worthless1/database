namespace programm
{
    partial class UpIspDetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpIspDetForm));
            this.comboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnQuit = new MetroFramework.Controls.MetroTile();
            this.textBox3 = new MetroFramework.Controls.MetroTextBox();
            this.labId = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 23;
            this.comboBox2.Location = new System.Drawing.Point(280, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 29);
            this.comboBox2.Style = MetroFramework.MetroColorStyle.Teal;
            this.comboBox2.TabIndex = 2;
            this.comboBox2.UseSelectable = true;
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.Location = new System.Drawing.Point(33, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(323, 45);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Изменить";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Location = new System.Drawing.Point(280, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 29);
            this.comboBox1.Style = MetroFramework.MetroColorStyle.Teal;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(33, 180);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 19);
            this.metroLabel5.TabIndex = 44;
            this.metroLabel5.Text = "Количество";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(33, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "Код детали";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(33, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Номер заказа";
            // 
            // btnQuit
            // 
            this.btnQuit.ActiveControl = null;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(0, 5);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(10, 10);
            this.btnQuit.Style = MetroFramework.MetroColorStyle.White;
            this.btnQuit.TabIndex = 51;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "metroTile1";
            this.btnQuit.UseSelectable = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // textBox3
            // 
            // 
            // 
            // 
            this.textBox3.CustomButton.Image = null;
            this.textBox3.CustomButton.Location = new System.Drawing.Point(114, 2);
            this.textBox3.CustomButton.Name = "";
            this.textBox3.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox3.CustomButton.TabIndex = 1;
            this.textBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox3.CustomButton.UseSelectable = true;
            this.textBox3.CustomButton.Visible = false;
            this.textBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBox3.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.textBox3.Lines = new string[0];
            this.textBox3.Location = new System.Drawing.Point(216, 171);
            this.textBox3.MaxLength = 32767;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '\0';
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox3.SelectedText = "";
            this.textBox3.SelectionLength = 0;
            this.textBox3.SelectionStart = 0;
            this.textBox3.ShortcutsEnabled = true;
            this.textBox3.Size = new System.Drawing.Size(140, 28);
            this.textBox3.Style = MetroFramework.MetroColorStyle.Teal;
            this.textBox3.TabIndex = 3;
            this.textBox3.UseSelectable = true;
            this.textBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labId.Location = new System.Drawing.Point(188, 60);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(25, 19);
            this.labId.TabIndex = 52;
            this.labId.Text = "01";
            // 
            // UpIspDetForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(392, 288);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpIspDetForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Изменение использ. деталей";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.UpIspDetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox comboBox2;
        private MetroFramework.Controls.MetroTile btnAdd;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnQuit;
        private MetroFramework.Controls.MetroTextBox textBox3;
        private MetroFramework.Controls.MetroLabel labId;
    }
}