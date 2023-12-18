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
    public partial class Meal : Form
    {
        public Meal()
        {
            InitializeComponent();
        }

        private void одноместныеНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odnom_meal farma1 = new Odnom_meal();
           
            farma1.Show();
            this.Hide();
        }

        private void двухместныеНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dvum_meal frama1 = new Dvum_meal();

            // Показываем Form2 и скрываем Form1
            frama1.Show();
            this.Hide();
        }

        private void вернутьсяКВыборуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoiceForm farma2 = new ChoiceForm();
            farma2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void посмотретьНаКартеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meal_map farma3 = new Meal_map();
            farma3.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
