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
    public partial class FormActual : Form
    {
        public FormActual()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            FormMostrarDepartamentos FM = new FormMostrarDepartamentos();
            FM.Show();
        }

        private void listarDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarDepartamentos FM = new FormMostrarDepartamentos();
            FM.Show();
        }

        private void listarReguistrsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarRegistro FMR = new FormMostrarRegistro();
            FMR.Show();
        }

        private void listarDepartamenroConRegusitroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatosEspecificos FRE = new FormDatosEspecificos();
            FRE.Show();
        }
    }
}
