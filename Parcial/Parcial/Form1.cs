using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {


        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartamento  dep = new FormDepartamento();
            dep.Show();
          
        }

        private void acionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistro fr = new FormRegistro();
            fr.Show();
        }

        private void informacionActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActual fA = new FormActual();
            fA.Show();
        }
    }
}
