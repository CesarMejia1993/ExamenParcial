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
    public partial class FormRegistro : Form
    {
        List<Departamento> listaDepto = new List<Departamento>();
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaI = Convert.ToDateTime("2020-01-01T00:00:00-00:00");
            DateTime fechaF = Convert.ToDateTime("2020-06-01T00:00:00-00:00");
            if (dateTimePicker1.Value.Date < fechaI || dateTimePicker1.Value.Date > fechaF)
            {
                MessageBox.Show("Error la fecha de ser desde el 1 de Enero hasta el 31 de mayo de 2019", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                //Declarar un objeto de Clase cliente
                Registro regJson = new Registro();
                //Asignarle valores al cliente
                regJson.IdDepto = comboBox1.SelectedValue.ToString();
                regJson.MedicionMm = textBox1.Text;
                regJson.FechaRegistro = dateTimePicker1.Value.Date;
                //Convertir el objeto en una cadena JSON
                string salida = JsonConvert.SerializeObject(regJson);
                //Guardar el archivo de texto, con extension Json
                FileStream stream = new FileStream("RegistrosJson.json", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                MessageBox.Show("Registro Ingresado Exitosamente!!");
                writer.WriteLine(salida);
                writer.Close();
            }
        }

        private void Guardar(Registro r)
        {
            //Abrir el archivo: Write sobreescribe el archivo, Append agrega al final del archivo
            FileStream stream = new FileStream("RegistrosJson.json", FileMode.Append, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribie linea por linea
            //Write escribe en la misma linea.
            //Esta linea la debemos cambiar para leer los datos desde algun control, por ejemplo un
            //ComboBox
            writer.WriteLine(r.IdDepto);
            writer.WriteLine(r.MedicionMm);
            writer.WriteLine(r.FechaRegistro);
            //Cerrar el archivo
            writer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("DepartamentosJson.json", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
               Departamento deptoLeido = JsonConvert.DeserializeObject<Departamento>(lectura);
                listaDepto.Add(deptoLeido);
            }
            reader.Close();

            comboBox1.DataSource = listaDepto;
            comboBox1.DisplayMember = "NombreDepto";
            comboBox1.ValueMember = "IdDepto";
            comboBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            FormMostrarRegistro frmMR = new FormMostrarRegistro();
            frmMR.Show();
        }
    }
}