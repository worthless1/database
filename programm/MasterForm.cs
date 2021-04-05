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
    public partial class MasterForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Repair_serviceDataSet.Склад1". При необходимости она может быть перемещена или удалена.
            this.Склад1TableAdapter.Fill(this.Repair_serviceDataSet.Склад1);
            this.reportViewer1.RefreshReport();
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Заказы WHERE Статус = 'В работе'", connect);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(Convert.ToString(reader.GetValue(0)));
                }
            }
            reader.Close();
            connect.Close();

            //проверка включена ли темная тема для правильного отображения переключателя
            if (this.StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                mSwitch.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.StyleManager.Clone(log);
            this.Hide();
            log.Show();
        }

        private void mSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (mSwitch.Checked) 
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            else 
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
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
                }
            }
            reader.Close();
            connect.Close();
        }

        private void btnCompl_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") 
                MessageBox.Show("Выберите заказ для закрытия", "Выполнение заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlCommand sql = new SqlCommand("UPDATE Заказы SET Статус = @st, Дата_закрытия = @dataz WHERE Номер_заказа = @stroka", connect);
                sql.Parameters.AddWithValue("@st", "Выполнен");
                sql.Parameters.AddWithValue("@dataz", DateTime.Now);
                sql.Parameters.AddWithValue("@stroka", comboBox1.Text);
                connect.Open();
                sql.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Заказ был закрыт", "Выполнение заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                listBox.Clear();
            }
        }
    }
}
