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
    public partial class registren : Form
    {

        public registren()
        {
            InitializeComponent();
        }
        DataBases dataBases = new DataBases();
        private void show_glas_Click(object sender, EventArgs e)
        {
            passbox.UseSystemPasswordChar = false;
            show_glas.Visible = false;
            hide_glaz.Visible = true;
        }

        private void hide_glaz_Click(object sender, EventArgs e)
        {
            passbox.UseSystemPasswordChar = true;
            show_glas.Visible = true;
            hide_glaz.Visible = false;
        }
        private Boolean checkuser()
        {
            var loginuser = textBox.Text;
            var passworduser = passbox.Text;

            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginuser}' and password_user = '{passworduser}'";
            SqlCommand command = new SqlCommand(querystring, dataBases.getConnection());

            Adapter.SelectCommand = command;
            Adapter.Fill(table);

            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("takoi uzhe sushestvuet");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void register_button_Click(object sender, EventArgs e)
        {
            
          if (checkuser())
          {
                return;
          }

            var login = textBox.Text;
            var password = passbox.Text;

            string querystring = $"insert into register(login_user, password_user) values ('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBases.getConnection());

            dataBases.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("accaunt succesful create!");
                fun frmlgn = new fun();
                this.Hide();
                frmlgn.ShowDialog();
            }
            else
            {
                MessageBox.Show("akkaunt ne sozdan");
            }
           
            dataBases.closeConnection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}