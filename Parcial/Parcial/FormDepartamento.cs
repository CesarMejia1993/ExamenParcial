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
    public partial class FormDepartamento : Form
    {
        public FormDepartamento()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMostrarDepartamentos fmd = new FormMostrarDepartamentos();
            fmd.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Error debe introducir el campo No. de Indentificacion", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (textBox1.Text.Length > 2)
            {
                MessageBox.Show("Error este campo no admite más de tres números", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox1.Text) > 20)
            {
                MessageBox.Show("Error este campo no admite números menores a 0 y mayores a 20", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Error debe introducir el campo Nombre del Departamento", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                //Declarar un objeto de Clase cliente
                Departamento deptoJson = new Departamento();
                //Asignarle valores al cliente
                deptoJson.IdDepto = textBox1.Text;
                deptoJson.NombreDepto = textBox2.Text;
                //Convertir el objeto en una cadena JSON
                string salida = JsonConvert.SerializeObject(deptoJson);
                //Guardar el archivo de texto, con extension Json
                FileStream stream = new FileStream("DepartamentosJson.json", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                MessageBox.Show("Departamento Ingresado Exitosamente!!");
                writer.WriteLine(salida);
                writer.Close();
                textBox1.Clear();
                textBox2.Clear();
            }

        }
    }
}
