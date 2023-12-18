using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachikl
{
    public partial class fun : Form
    {
        DataBases dataBases = new DataBases();
        public fun()
        {
            InitializeComponent();
        }

        private void fun_Load(object sender, EventArgs e)
        {
           
        }


        private void label2_Click(object sender, EventArgs e)
        {
            registren form3 = new registren();

            // Показываем Form2 и скрываем Form1
            form3.Show();
            this.Hide();
        }

        public void voiti_Click(object sender, EventArgs e)
        {
            var loginuser = textBoxname1.Text;
            var passUser = textBoxpass1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginuser}' and password_user ='{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBases.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("uraa pobeda");
                main frm1 = new main();
                frm1.ShowDialog();
                this.Show();
                this.Hide();
                
            }
            else
                MessageBox.Show("takogo chela net pizdui v registration");
        }

        private void show_box_Click(object sender, EventArgs e)
        {
            textBoxpass1.UseSystemPasswordChar = false;
            show_box.Visible = false;
            hide_box.Visible = true;
        }

        private void hide_box_Click(object sender, EventArgs e)
        {
            textBoxpass1.UseSystemPasswordChar = true;
            show_box.Visible = true;
            hide_box.Visible = false;
        }

        private void textBoxpass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
