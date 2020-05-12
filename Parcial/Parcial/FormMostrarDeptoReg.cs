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
    public partial class FormMostrarDeptoReg : Form
    {
        List<Departamento> listaDepto = new List<Departamento>();
        List<Registro> listaReg = new List<Registro>();
        List<Vista> listaVista = new List<Vista>();
        public FormMostrarDeptoReg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sumaMediciones = 0;
            double cantDeptos = 0;
            double promGeneral = 0;
            for (int i = 0; i < listaReg.Count; i++)
            {
                Vista vtemp = new Vista();
                for (int j = 0; j < listaDepto.Count; j++)
                {
                    sumaMediciones = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["MedicionMm"].Value));
                    cantDeptos = Convert.ToInt32(this.dataGridView1.Rows.Count.ToString());
                    promGeneral = sumaMediciones / cantDeptos;
                }
                label7.Text = Convert.ToString(sumaMediciones);
                label2.Text = Convert.ToString(cantDeptos);
                label3.Text = Convert.ToString(promGeneral);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void FormMostrarDeptoReg_Load(object sender, EventArgs e)

        {
            dataGridView1.Visible = false;
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
                        vtemp.NombreDepto = listaDepto[j].NombreDepto;
                        vtemp.MedicionMm = listaReg[i].MedicionMm;
                    }

                }
                vtemp.FechaReg = listaReg[i].FechaRegistro;
                listaVista.Add(vtemp);
            }

            dataGridView1.DataSource = listaVista;
            dataGridView1.Refresh();
        }
    }
}
