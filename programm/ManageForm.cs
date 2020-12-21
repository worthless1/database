﻿using System;
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
        SqlConnection connect = new SqlConnection(@"Data Source = 
            (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True");
        public ManageForm(int id)
        {
            InitializeComponent();
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT TRIM([Фамилия]), TRIM([Имя]), [Отчество] FROM Сотрудники WHERE [Код пользователя] = @id", connect);
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
            pri.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ManageZakazForm mzak = new ManageZakazForm();
            mzak.Show();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Repair_serviceDataSet.diagram1". При необходимости она может быть перемещена или удалена.
            this.diagram1TableAdapter.Fill(this.Repair_serviceDataSet.diagram1);
            this.reportViewer1.RefreshReport();
        }
    }
}
