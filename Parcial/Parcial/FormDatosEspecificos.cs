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
    public partial class FormDatosEspecificos : Form
    {
        List<Departamento> listaDepto = new List<Departamento>();
        List<Registro> listaReg = new List<Registro>();
        List<Vista> listaVista = new List<Vista>();
        public FormDatosEspecificos()
        {
            InitializeComponent();
        }

        private void FormDatosEspecificos_Load(object sender, EventArgs e)
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

            stream = new FileStream("RegistrosJson.json", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
                Registro regLeido = JsonConvert.DeserializeObject<Registro>(lectura);
                listaReg.Add(regLeido);
            }
            reader.Close();

            //Mostrar la lista de alquileres en el gridview
            for (int i = 0; i < listaReg.Count; i++)
            {
                Vista vtemp = new Vista();
                for (int j = 0; j < listaDepto.Count; j++)
                {
                    if (listaReg[i].IdDepto == listaDepto[j].IdDepto)
                    {
                        int cont = 0;
                        for (int k = 0; k < listaVista.Count; k++)
                        {
                            if (listaDepto[j].NombreDepto == listaVista[k].NombreDepto)
                            {
                                cont++;
                            }

                        }
                        if (cont == 0)
                        {
                            vtemp.NombreDepto = listaDepto[j].NombreDepto;
                            vtemp.IdDepto = listaReg[i].IdDepto;
                            listaVista.Add(vtemp);
                        }
                    }
                }

            }

            comboBox1.DataSource = listaVista;
            comboBox1.DisplayMember = "NombreDepto";
            comboBox1.ValueMember = "IdDepto";
            comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string nombre = "";
            string medicion = "";
            string fecha = "";
            //Ciclo para recorrer cada fila del gridview
            for (int i = 0; i < listaReg.Count; i++)
            {
                for (int j = 0; j < listaDepto.Count; j++)
                {
                    if (listaReg[i].IdDepto == listaDepto[j].IdDepto)
                    {
                        if (comboBox1.SelectedValue.ToString() == listaReg[i].IdDepto)
                        {
                            nombre = listaDepto[j].NombreDepto;
                            medicion = listaReg[i].MedicionMm;
                            fecha = Convert.ToString(listaReg[i].FechaRegistro);
                            listBox1.Items.Add("Nombre del Departamento: " + nombre + "," + " Medición Registrada (mm): " + medicion + "," + " Fecha de Registro: " + fecha);
                        }
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormMostrarDeptoReg frmMD = new FormMostrarDeptoReg();
            frmMD.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}