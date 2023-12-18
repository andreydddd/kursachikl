using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachikl
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
       // DataBases databases = new DataBases();

        private void main_Load(object sender, EventArgs e)
        {
           // label1.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                ChoiceForm form2 = new ChoiceForm();

                // Показываем Form2 и скрываем Form1
                form2.Show();
                this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
