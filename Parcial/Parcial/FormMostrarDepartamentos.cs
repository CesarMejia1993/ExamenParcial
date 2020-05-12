using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class FormMostrarDepartamentos : Form
    {
        List<Departamento> listaDepto = new List<Departamento>();
        public FormMostrarDepartamentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Una lista de objetos alquiler
            //Leer el archivo
            FileStream stream = new FileStream("DepartamentosJson.json", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
                Departamento deptoLeido = JsonConvert.DeserializeObject<Departamento>(lectura);
                listaDepto.Add(deptoLeido);
            }
            reader.Close();
            //Mostrar la lista de alquileres en el gridview
            dataGridView1.DataSource = listaDepto;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
