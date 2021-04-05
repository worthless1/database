using MetroFramework.Components;
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
    public partial class regForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public regForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //показ пароля
            if (checkBox1.Checked)
                PassBox.PasswordChar = '\0';
            else
                PassBox.PasswordChar = '•';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LogBox.Text!=""||PassBox.Text!=""||famBox.Text!="")
            {
                string password = getHashSha256(PassBox.Text);
                SqlCommand sql = new SqlCommand("EXEC reg @log, @pass, @name, @fam, @otch, @tel", connect);
                sql.Parameters.AddWithValue("@log", LogBox.Text);
                sql.Parameters.AddWithValue("@pass", password);
                sql.Parameters.AddWithValue("@name", nameBox.Text);
                sql.Parameters.AddWithValue("@fam", famBox.Text);
                sql.Parameters.AddWithValue("@otch", otchBox.Text);
                sql.Parameters.AddWithValue("@tel", telBox.Text);
                connect.Open();
                sql.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Запись была успешно добавлена в базу данных", "Добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoginForm log = new LoginForm();
                this.StyleManager.Clone(log);
                this.Close();
                log.Show();
            }
            else
                MessageBox.Show("Заполните все поля!");
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

        private void telBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ввод в окно телефона только цифр и использование служебных кнопок
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void regForm_Load(object sender, EventArgs e)
        {
            //проверка включена ли темная тема для правильного отображения переключателя
            if (this.StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                mSwitch.Checked = false;
        }

        private void mSwitch_CheckedChanged(object sender, EventArgs e)
        {
            //смена темы
            if (mSwitch.Checked)
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            else
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }
    }
}
