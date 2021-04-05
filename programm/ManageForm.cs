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
    public partial class ManageForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public ManageForm(int id)
        {
            InitializeComponent();
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT TRIM(Фамилия), TRIM(Имя), TRIM(Отчество) FROM Сотрудники WHERE Код_пользователя = @id", connect);
            sql.Parameters.AddWithValue("@id", id);
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
            connect.Close();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            PriceListForm pri = new PriceListForm();
            this.StyleManager.Clone(pri);
            pri.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            this.StyleManager.Clone(log);
            log.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ManageZakazForm mzak = new ManageZakazForm();
            this.StyleManager.Clone(mzak);
            mzak.Show();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Repair_serviceDataSet.diagram1". При необходимости она может быть перемещена или удалена.
            this.diagram1TableAdapter.Fill(this.Repair_serviceDataSet.diagram1);
            this.reportViewer1.RefreshReport();

            //проверка включена ли темная тема для правильного отображения переключателя
            if (this.StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                mSwitch.Checked = false;
        }

        private void mSwitch_CheckedChanged(object sender, EventArgs e)
        {
            //переключатель темной темы
            if (mSwitch.Checked)
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            else
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }
    }
}
