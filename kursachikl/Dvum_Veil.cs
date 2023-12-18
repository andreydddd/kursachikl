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

namespace kursachikl
{
    public partial class Dvum_Veil : Form
    {
        public Dvum_Veil()
        {
            InitializeComponent();
        }
        DataBases dataBases = new DataBases();

        private void Odnom_Veil_Load(object sender, EventArgs e)
        {
            CreateComponent();
            RefreshDataGrid(dataGridView1);
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
        private void Dvum_Veil_Load(object sender, EventArgs e)
        {
            CreateComponent();
            RefreshDataGrid(dataGridView1);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from dvum2";
            SqlCommand cmd = new SqlCommand(querystring, dataBases.getConnection());

            dataBases.openConnection();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from dvum2 where concat (id_dvumm, id_hotel, dvumm_name, price_dvumm, id_status) like '%" + textBox_search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBases.getConnection());
            dataBases.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Veil veil = new Veil();
            veil.Show();
            this.Close();
        }

        
    }
}
