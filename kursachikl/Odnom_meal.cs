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

namespace kursachikl
{

    public partial class Odnom_meal : Form
    {
        DataBases dataBases = new DataBases();


        public Odnom_meal()
        {
            InitializeComponent();
        }

        private void CreateComponent()
        {
            dataGridView1.Columns.Add("id_odnom", "id");
            dataGridView1.Columns.Add("id_hotel", "id отеля");
            dataGridView1.Columns.Add("odnom_name", "номер");
            dataGridView1.Columns.Add("price_odnom", "цена за номер");
            dataGridView1.Columns.Add("id_status", "id статус");

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record) 
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4), DataRowState.Modified);        
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from odnom1";
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
            Meal frmp2 = new Meal();

            // Показываем Form2 и скрываем Form1
            frmp2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Odnom_meal_Load(object sender, EventArgs e)
        {
            CreateComponent();
            RefreshDataGrid(dataGridView1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from odnom1 where concat (id_odnom, id_hotel, odnom_name, price_odnom, id_status) like '%" + textBox_search.Text + "%'";  
            
            SqlCommand com = new SqlCommand(searchString, dataBases.getConnection());
            dataBases.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
    }
}
