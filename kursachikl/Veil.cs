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
    public partial class Veil : Form
    {
        public Veil()
        {
            InitializeComponent();
        }

        private void одноместныеНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odnom_Veil odnom_Veil = new Odnom_Veil();
            odnom_Veil.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void посмотретьНаКартеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Veil_map veil_Map = new Veil_map();
            veil_Map.Show();
            this.Close();
        }

        private void вернутьсяКВыборуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoiceForm choiceForm = new ChoiceForm();
            choiceForm.Show();
            this.Close();
        }

        private void двухместныеНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dvum_Veil dvum_ = new Dvum_Veil();
            dvum_.Show();
            this.Close();   
        }
    }
}
