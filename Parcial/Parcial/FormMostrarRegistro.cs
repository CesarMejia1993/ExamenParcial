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
    public partial class FormMostrarRegistro : Form
    {
        List<Registro> listaReg = new List<Registro>();
        public FormMostrarRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Una lista de objetos alquiler
            //Leer el archivo
            FileStream stream = new FileStream("RegistrosJson.json", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
                Registro regLeido = JsonConvert.DeserializeObject<Registro>(lectura);
                listaReg.Add(regLeido);
            }
            reader.Close();
            //Mostrar la lista de alquileres en el gridview
            dataGridView1.DataSource = listaReg;
            dataGridView1.Refresh();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
