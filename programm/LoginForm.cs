using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace programm
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True"); // Подключение к БД
        SqlDataReader reader;
        string login, password;
        int attempts = 0;
        int first, second;
        public LoginForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            PassBox.PasswordChar = '•';
        }

        private void mSwitch_CheckedChanged(object sender, EventArgs e)
        {
            //смена темы
            if (mSwitch.Checked)
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            else
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            regForm rg = new regForm();
            this.StyleManager.Clone(rg);
            this.Hide();
            rg.Show();

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //показ пароля
            if (checkBox1.Checked)
                PassBox.PasswordChar = '\0';
            else
                PassBox.PasswordChar = '•';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //авторизация
            int role, id;
            login = LogBox.Text;
            password = getHashSha256(PassBox.Text);

            connect.Open();
            SqlCommand sql = new SqlCommand($"SELECT * FROM Пользователи WHERE Логин = '{login}' and Пароль = '{password}'", connect);
            reader = sql.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    role = reader.GetInt32(3);
                    id = reader.GetInt32(0);

                    switch (role)
                    {
                        case 1:
                            AdminForm adm = new AdminForm();
                            this.StyleManager.Clone(adm);
                            this.Hide();
                            adm.Show();
                            break;
                        case 2:
                            ManageForm mng = new ManageForm(id);
                            this.StyleManager.Clone(mng);
                            this.Hide();
                            mng.Show();
                            break;
                        case 3:
                            MasterForm mst = new MasterForm();
                            this.StyleManager.Clone(mst);
                            mst.Show();
                            break;
                        case 4:
                            OpenClientForm oclt = new OpenClientForm(id);
                            this.StyleManager.Clone(oclt);
                            this.Hide();
                            oclt.Show();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль, попробуйте снова", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                attempts++;
                PassBox.Clear();
            }
            reader.Close();
            connect.Close();

            if (attempts >= 3)
                capcha();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            //проверка капчи
            if (first + second == Convert.ToInt32(capchaBox.Text))
            {
                btnVerify.Visible = false;
                btnReplace.Visible = false;
                capchaBox.Visible = false;

                checkBox1.Visible = true;
                LogBox.Visible = true;
                PassBox.Visible = true;
                btnLogin.Visible = true;
                logLabel.Text = "Логин";
                passLabel.Text = "Пароль";
            }
            else
                getCapcha();
        }

        private string getHashSha256(string text)
        {
            //Хэширование пароля
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString.ToString();
        }

        void capcha()
        {
            //подготовка капчи
            logLabel.Text = "Вы не робот?";
            btnVerify.Visible = true;
            btnReplace.Visible = true;
            capchaBox.Visible = true;

            LogBox.Visible = false;
            PassBox.Visible = false;
            btnLogin.Visible = false;
            checkBox1.Visible = false;

            getCapcha();
        }

        private void capchaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ввод в окно капчи только цифр и использование служебных кнопок
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void PassBox_Click(object sender, EventArgs e)
        {

        }

        void getCapcha()
        {
            //получение капчи
            Random rdn = new Random();
            first = rdn.Next(1, 10);
            second = rdn.Next(1, 20);
            passLabel.Text = Convert.ToString(first) + " + " + Convert.ToString(second) + " = ?";
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            getCapcha();
        }
    }
}
