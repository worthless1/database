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
            this.helpBtn = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.LogBox = new MetroFramework.Controls.MetroTextBox();
            this.PassBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mSwitch
            // 
            this.mSwitch.AutoSize = true;
            this.mSwitch.Checked = true;
            this.mSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mSwitch.Cursor = System.Windows.Forms.Cursors.Default;
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
            // helpBtn
            // 
            this.helpBtn.AutoSize = true;
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.helpBtn.Location = new System.Drawing.Point(107, 225);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(120, 19);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.Text = "Не можете войти?";
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogin.Location = new System.Drawing.Point(118, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 27);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
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
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(107, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Логин";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(107, 126);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Пароль";
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
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 308);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mSwitch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Авторизация";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroToggle mSwitch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel helpBtn;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox LogBox;
        private MetroFramework.Controls.MetroTextBox PassBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel btnExit;
    }
}

