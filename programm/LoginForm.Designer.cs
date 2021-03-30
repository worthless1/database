namespace programm
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.mSwitch = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnREg = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.LogBox = new MetroFramework.Controls.MetroTextBox();
            this.PassBox = new MetroFramework.Controls.MetroTextBox();
            this.logLabel = new MetroFramework.Controls.MetroLabel();
            this.passLabel = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroLabel();
            this.checkBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.capchaBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mSwitch
            // 
            this.mSwitch.AutoSize = true;
            this.mSwitch.Checked = true;
            this.mSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mSwitch.Location = new System.Drawing.Point(4, 281);
            this.mSwitch.Name = "mSwitch";
            this.mSwitch.Size = new System.Drawing.Size(80, 17);
            this.mSwitch.Style = MetroFramework.MetroColorStyle.Teal;
            this.mSwitch.TabIndex = 1;
            this.mSwitch.Text = "On";
            this.mSwitch.UseSelectable = true;
            this.mSwitch.CheckedChanged += new System.EventHandler(this.mSwitch_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 259);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "LightTheme";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // btnREg
            // 
            this.btnREg.AutoSize = true;
            this.btnREg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnREg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnREg.Location = new System.Drawing.Point(109, 281);
            this.btnREg.Name = "btnREg";
            this.btnREg.Size = new System.Drawing.Size(120, 19);
            this.btnREg.TabIndex = 6;
            this.btnREg.Text = "Еще нет аккаунта?";
            this.btnREg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogin.ForeColor = System.Drawing.Color.Teal;
            this.btnLogin.Highlight = true;
            this.btnLogin.Location = new System.Drawing.Point(118, 197);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 27);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
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
            this.LogBox.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.LogBox.CustomButton.Name = "";
            this.LogBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.LogBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LogBox.CustomButton.TabIndex = 1;
            this.LogBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LogBox.CustomButton.UseSelectable = true;
            this.LogBox.CustomButton.Visible = false;
            this.LogBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.LogBox.Lines = new string[0];
            this.LogBox.Location = new System.Drawing.Point(107, 95);
            this.LogBox.MaxLength = 32767;
            this.LogBox.Name = "LogBox";
            this.LogBox.PasswordChar = '\0';
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LogBox.SelectedText = "";
            this.LogBox.SelectionLength = 0;
            this.LogBox.SelectionStart = 0;
            this.LogBox.ShortcutsEnabled = true;
            this.LogBox.Size = new System.Drawing.Size(118, 28);
            this.LogBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.LogBox.TabIndex = 0;
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
            this.PassBox.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.PassBox.CustomButton.Name = "";
            this.PassBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.PassBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassBox.CustomButton.TabIndex = 1;
            this.PassBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassBox.CustomButton.UseSelectable = true;
            this.PassBox.CustomButton.Visible = false;
            this.PassBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PassBox.Lines = new string[0];
            this.PassBox.Location = new System.Drawing.Point(107, 148);
            this.PassBox.MaxLength = 32767;
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '\0';
            this.PassBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassBox.SelectedText = "";
            this.PassBox.SelectionLength = 0;
            this.PassBox.SelectionStart = 0;
            this.PassBox.ShortcutsEnabled = true;
            this.PassBox.Size = new System.Drawing.Size(118, 28);
            this.PassBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.PassBox.TabIndex = 1;
            this.PassBox.UseSelectable = true;
            this.PassBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(107, 73);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(47, 19);
            this.logLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.logLabel.TabIndex = 7;
            this.logLabel.Text = "Логин";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(107, 126);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(54, 19);
            this.passLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.passLabel.TabIndex = 8;
            this.passLabel.Text = "Пароль";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(272, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "ВЫХОД";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(109, 230);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 15);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Отображать пароль";
            this.checkBox1.UseSelectable = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // btnVerify
            // 
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVerify.ForeColor = System.Drawing.Color.Teal;
            this.btnVerify.Location = new System.Drawing.Point(118, 182);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(93, 32);
            this.btnVerify.TabIndex = 11;
            this.btnVerify.Text = "Проверить";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Visible = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.Location = new System.Drawing.Point(127, 220);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 12;
            this.btnReplace.Text = "Заменить";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Visible = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // capchaBox
            // 
            // 
            // 
            // 
            this.capchaBox.CustomButton.Image = null;
            this.capchaBox.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.capchaBox.CustomButton.Name = "";
            this.capchaBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.capchaBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.capchaBox.CustomButton.TabIndex = 1;
            this.capchaBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.capchaBox.CustomButton.UseSelectable = true;
            this.capchaBox.CustomButton.Visible = false;
            this.capchaBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.capchaBox.Lines = new string[0];
            this.capchaBox.Location = new System.Drawing.Point(107, 148);
            this.capchaBox.MaxLength = 32767;
            this.capchaBox.Name = "capchaBox";
            this.capchaBox.PasswordChar = '\0';
            this.capchaBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.capchaBox.SelectedText = "";
            this.capchaBox.SelectionLength = 0;
            this.capchaBox.SelectionStart = 0;
            this.capchaBox.ShortcutsEnabled = true;
            this.capchaBox.Size = new System.Drawing.Size(118, 28);
            this.capchaBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.capchaBox.TabIndex = 13;
            this.capchaBox.UseSelectable = true;
            this.capchaBox.Visible = false;
            this.capchaBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.capchaBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 308);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.btnREg);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mSwitch);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.capchaBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Авториазция";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroToggle mSwitch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel btnREg;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox LogBox;
        private MetroFramework.Controls.MetroTextBox PassBox;
        private MetroFramework.Controls.MetroLabel passLabel;
        private MetroFramework.Controls.MetroLabel logLabel;
        private MetroFramework.Controls.MetroLabel btnExit;
        private MetroFramework.Controls.MetroCheckBox checkBox1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnVerify;
        private MetroFramework.Controls.MetroTextBox capchaBox;
    }
}

