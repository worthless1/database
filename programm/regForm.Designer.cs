
namespace programm
{
    partial class regForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regForm));
            this.checkBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.btnExit = new MetroFramework.Controls.MetroLabel();
            this.passLabel = new MetroFramework.Controls.MetroLabel();
            this.logLabel = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.LogBox = new MetroFramework.Controls.MetroTextBox();
            this.PassBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mSwitch = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.nameBox = new MetroFramework.Controls.MetroTextBox();
            this.famBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.otchBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.telBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(129, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 15);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Отображать пароль";
            this.checkBox1.UseSelectable = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(329, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "ВЫХОД";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(201, 60);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(54, 19);
            this.passLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.passLabel.TabIndex = 21;
            this.passLabel.Text = "Пароль";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(40, 60);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(47, 19);
            this.logLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.logLabel.TabIndex = 20;
            this.logLabel.Text = "Логин";
            // 
            // btnLogin
            // 
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogin.ForeColor = System.Drawing.Color.Teal;
            this.btnLogin.Highlight = true;
            this.btnLogin.Location = new System.Drawing.Point(111, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 33);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Зарегистрироваться";
            this.btnLogin.UseCustomForeColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LogBox
            // 
            // 
            // 
            // 
            this.LogBox.CustomButton.Image = null;
            this.LogBox.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.LogBox.CustomButton.Name = "";
            this.LogBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.LogBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LogBox.CustomButton.TabIndex = 1;
            this.LogBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LogBox.CustomButton.UseSelectable = true;
            this.LogBox.CustomButton.Visible = false;
            this.LogBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.LogBox.Lines = new string[0];
            this.LogBox.Location = new System.Drawing.Point(40, 82);
            this.LogBox.MaxLength = 32767;
            this.LogBox.Name = "LogBox";
            this.LogBox.PasswordChar = '\0';
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LogBox.SelectedText = "";
            this.LogBox.SelectionLength = 0;
            this.LogBox.SelectionStart = 0;
            this.LogBox.ShortcutsEnabled = true;
            this.LogBox.Size = new System.Drawing.Size(149, 28);
            this.LogBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.LogBox.TabIndex = 14;
            this.LogBox.UseSelectable = true;
            this.LogBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LogBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PassBox
            // 
            // 
            // 
            // 
            this.PassBox.CustomButton.Image = null;
            this.PassBox.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.PassBox.CustomButton.Name = "";
            this.PassBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.PassBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassBox.CustomButton.TabIndex = 1;
            this.PassBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassBox.CustomButton.UseSelectable = true;
            this.PassBox.CustomButton.Visible = false;
            this.PassBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PassBox.Lines = new string[0];
            this.PassBox.Location = new System.Drawing.Point(201, 82);
            this.PassBox.MaxLength = 32767;
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '●';
            this.PassBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassBox.SelectedText = "";
            this.PassBox.SelectionLength = 0;
            this.PassBox.SelectionStart = 0;
            this.PassBox.ShortcutsEnabled = true;
            this.PassBox.Size = new System.Drawing.Size(149, 28);
            this.PassBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.PassBox.TabIndex = 15;
            this.PassBox.UseSelectable = true;
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 312);
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
            this.mSwitch.Cursor = System.Windows.Forms.Cursors.Default;
            this.mSwitch.Location = new System.Drawing.Point(7, 334);
            this.mSwitch.Name = "mSwitch";
            this.mSwitch.Size = new System.Drawing.Size(80, 17);
            this.mSwitch.Style = MetroFramework.MetroColorStyle.Teal;
            this.mSwitch.TabIndex = 16;
            this.mSwitch.Text = "On";
            this.mSwitch.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(201, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Фамилия";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Имя";
            // 
            // nameBox
            // 
            // 
            // 
            // 
            this.nameBox.CustomButton.Image = null;
            this.nameBox.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.nameBox.CustomButton.Name = "";
            this.nameBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.nameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameBox.CustomButton.TabIndex = 1;
            this.nameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameBox.CustomButton.UseSelectable = true;
            this.nameBox.CustomButton.Visible = false;
            this.nameBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.nameBox.Lines = new string[0];
            this.nameBox.Location = new System.Drawing.Point(40, 146);
            this.nameBox.MaxLength = 32767;
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = '\0';
            this.nameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameBox.SelectedText = "";
            this.nameBox.SelectionLength = 0;
            this.nameBox.SelectionStart = 0;
            this.nameBox.ShortcutsEnabled = true;
            this.nameBox.Size = new System.Drawing.Size(149, 28);
            this.nameBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.nameBox.TabIndex = 24;
            this.nameBox.UseSelectable = true;
            this.nameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // famBox
            // 
            // 
            // 
            // 
            this.famBox.CustomButton.Image = null;
            this.famBox.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.famBox.CustomButton.Name = "";
            this.famBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.famBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.famBox.CustomButton.TabIndex = 1;
            this.famBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.famBox.CustomButton.UseSelectable = true;
            this.famBox.CustomButton.Visible = false;
            this.famBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.famBox.Lines = new string[0];
            this.famBox.Location = new System.Drawing.Point(201, 146);
            this.famBox.MaxLength = 32767;
            this.famBox.Name = "famBox";
            this.famBox.PasswordChar = '\0';
            this.famBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.famBox.SelectedText = "";
            this.famBox.SelectionLength = 0;
            this.famBox.SelectionStart = 0;
            this.famBox.ShortcutsEnabled = true;
            this.famBox.Size = new System.Drawing.Size(149, 28);
            this.famBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.famBox.TabIndex = 25;
            this.famBox.UseSelectable = true;
            this.famBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.famBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 190);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Отчество";
            // 
            // otchBox
            // 
            // 
            // 
            // 
            this.otchBox.CustomButton.Image = null;
            this.otchBox.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.otchBox.CustomButton.Name = "";
            this.otchBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.otchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.otchBox.CustomButton.TabIndex = 1;
            this.otchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.otchBox.CustomButton.UseSelectable = true;
            this.otchBox.CustomButton.Visible = false;
            this.otchBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.otchBox.Lines = new string[0];
            this.otchBox.Location = new System.Drawing.Point(40, 212);
            this.otchBox.MaxLength = 32767;
            this.otchBox.Name = "otchBox";
            this.otchBox.PasswordChar = '\0';
            this.otchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.otchBox.SelectedText = "";
            this.otchBox.SelectionLength = 0;
            this.otchBox.SelectionStart = 0;
            this.otchBox.ShortcutsEnabled = true;
            this.otchBox.Size = new System.Drawing.Size(149, 28);
            this.otchBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.otchBox.TabIndex = 28;
            this.otchBox.UseSelectable = true;
            this.otchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.otchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(204, 190);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel6.TabIndex = 33;
            this.metroLabel6.Text = "Телефон";
            // 
            // telBox
            // 
            // 
            // 
            // 
            this.telBox.CustomButton.Image = null;
            this.telBox.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.telBox.CustomButton.Name = "";
            this.telBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.telBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.telBox.CustomButton.TabIndex = 1;
            this.telBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telBox.CustomButton.UseSelectable = true;
            this.telBox.CustomButton.Visible = false;
            this.telBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.telBox.Lines = new string[0];
            this.telBox.Location = new System.Drawing.Point(204, 212);
            this.telBox.MaxLength = 11;
            this.telBox.Name = "telBox";
            this.telBox.PasswordChar = '\0';
            this.telBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telBox.SelectedText = "";
            this.telBox.SelectionLength = 0;
            this.telBox.SelectionStart = 0;
            this.telBox.ShortcutsEnabled = true;
            this.telBox.Size = new System.Drawing.Size(146, 28);
            this.telBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.telBox.TabIndex = 32;
            this.telBox.UseSelectable = true;
            this.telBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.telBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.telBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telBox_KeyPress);
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 357);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.otchBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.famBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mSwitch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "regForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Регистрация";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox checkBox1;
        private MetroFramework.Controls.MetroLabel btnExit;
        private MetroFramework.Controls.MetroLabel passLabel;
        private MetroFramework.Controls.MetroLabel logLabel;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox LogBox;
        private MetroFramework.Controls.MetroTextBox PassBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle mSwitch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox nameBox;
        private MetroFramework.Controls.MetroTextBox famBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox otchBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox telBox;
    }
}