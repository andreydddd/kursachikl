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
using System.Data.Entity;


namespace kursachikl
{
    public partial class Dvum_meal : Form
    {
        public Dvum_meal()
        {
            InitializeComponent();
        }

        private void CreateComponent()
        {
            dataGridView2.Columns.Add("id_odnom", "id");
            dataGridView2.Columns.Add("id_hotel", "id отеля");
            dataGridView2.Columns.Add("odnom_name", "номер");
            dataGridView2.Columns.Add("price_odnom", "цена за номер");
            dataGridView2.Columns.Add("id_status", "id статус");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            try
            {
                dgw.Rows.Add(
                    record.GetInt32(0),
                    record.GetInt32(1),
                    record.GetString(2),
                    record.GetInt32(3),
                    record.GetInt32(4)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DataBases dataBases = new DataBases();

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from dvum1";
            SqlCommand cmd = new SqlCommand(querystring, dataBases.getConnection());

            dataBases.openConnection();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Meal frmp5 = new Meal();

            // Показываем Form2 и скрываем Form1
            frmp5.Show();
            this.Hide();
        }

        private void Dvum_meal_Load(object sender, EventArgs e)
        {
            CreateComponent();
            RefreshDataGrid(dataGridView2);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from dvum1 where concat (id_dvum, id_hotel, dvum_name, price_dvum, id_status) like '%" + textBox_searchy.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBases.getConnection());
            dataBases.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void textBox_searchy_TextChanged_1(object sender, EventArgs e)
        {
            Search(dataGridView2);
        }
    }
}

