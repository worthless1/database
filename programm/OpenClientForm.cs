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
    public partial class OpenClientForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public OpenClientForm(int id)
        {
            InitializeComponent();
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT TRIM(Фамилия), TRIM(Имя), TRIM(Отчество) FROM Клиенты WHERE Код_пользователя = @id", connect);
            sql.Parameters.AddWithValue("@id", id);

            SqlCommand sql1 = new SqlCommand("Zakazi_klienta", connect);
            sql1.CommandType = CommandType.StoredProcedure;
            sql1.Parameters.AddWithValue("@polz", id);

            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    nameLabel.Text = Convert.ToString(reader.GetValue(0));
                    nameLabel.Text = nameLabel.Text + " " + Convert.ToString(reader.GetValue(1));
                    nameLabel.Text = nameLabel.Text + " " + Convert.ToString(reader.GetValue(2));
                }
            }
            reader.Close();

            reader = sql1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(Convert.ToString(reader.GetValue(0)));
                }
            }
            reader.Close();
            connect.Close();
        }

        private void OpenClientForm_Load(object sender, EventArgs e)
        {
            //проверка включена ли темная тема для правильного отображения переключателя
            if (this.StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                mSwitch.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Clear();
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Заказы WHERE Номер_заказа = @id", connect);
            sql.Parameters.AddWithValue("@id", comboBox1.Text);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBox.Items.Add(Convert.ToString("Дата заказа: " + reader.GetValue(2)));
                    listBox.Items.Add(Convert.ToString("Описание: " + reader.GetValue(3)));
                    listBox.Items.Add(Convert.ToString("Статус: " + reader.GetValue(4)));
                    listBox.Items.Add(Convert.ToString("Дата закрытия: " + reader.GetValue(5)));
                }
            }
            reader.Close();
            connect.Close();
        }

        private void mSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (mSwitch.Checked) StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            else StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }
    }
}
