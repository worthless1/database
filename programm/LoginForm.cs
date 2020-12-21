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

namespace programm
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True"); // Подключение к БД
        SqlDataReader reader;
        string login, password;
        public LoginForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void mSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (mSwitch.Checked) 
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            else 
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь за помощью к администратору", "Не можете войти?");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login = LogBox.Text;
            password = PassBox.Text;
            connect.Open();
            SqlCommand sql = new SqlCommand($"SELECT * FROM Пользователи WHERE Логин = '{login}' and Пароль = '{password}'", connect);
            reader = sql.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object Role = reader.GetValue(3);
                    object id = reader.GetValue(0);
                    //admin
                    if (Convert.ToString(Role) == "Администратор")
                    {
                        this.Hide();
                        AdminForm adm = new AdminForm();
                        adm.Show();
                    }
                    //manager
                    else if (Convert.ToString(Role) == "Менеджер")
                    {
                        this.Hide();
                        ManageForm mng = new ManageForm(Convert.ToInt32(id));
                        mng.Show();
                    }
                    //master
                    else if (Convert.ToString(Role) == "Мастер")
                    {
                        this.Hide();
                        MasterForm mst = new MasterForm();
                        mst.Show();
                    }
                    //client
                    else if (Convert.ToString(Role) == "Клиент")
                    {
                        this.Hide();
                        OpenClientForm oclt = new OpenClientForm(Convert.ToInt32(id));
                        oclt.Show();
                    }
                }
            }
            else 
                MessageBox.Show("Неверный логин или пароль, попробуйте снова", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reader.Close();
            connect.Close();
        }
    }
}
