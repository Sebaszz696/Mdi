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

namespace wMdi
{
    public partial class formDatosAcademicos : Form
    {
        public formDatosAcademicos()
        {
            InitializeComponent();
        }

        private void formDatosAcademicos_Load(object sender, EventArgs e)
        {

        }



        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {//salir
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {//cerrar
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {//Guardar en variables 
            try { 
            ClsDatosAcademicos datosAcademicos = new ClsDatosAcademicos();

            datosAcademicos.Materia = cboMateria.Text;
            datosAcademicos.ActividadEstudiante = cboActividad.Text;
            datosAcademicos.Semestre = Convert.ToDouble(txtSemestre.Text);


                txtGuardar.Text = Convert.ToString(datosAcademicos.Materia + "\n " + datosAcademicos.ActividadEstudiante + "\n " + datosAcademicos.Semestre);

                MessageBox.Show(txtGuardar.Text);

                //Guarda el contenido
                try
                {
                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                {

                    Stream strGuardar = saveFileDialog1.OpenFile();
                    StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                    foreach (string linea in txtGuardar.Lines)
                    {
                        wrtGuardar.WriteLine(linea);
                    }

                    wrtGuardar.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {//Borrar
            cboMateria.SelectedIndex = -1;
            cboActividad.SelectedIndex = -1;
            txtSemestre.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {//salir
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDatosAcademicos datosAcademicos = new ClsDatosAcademicos();

                datosAcademicos.Materia = cboMateria.Text;
                datosAcademicos.ActividadEstudiante = cboActividad.Text;
                datosAcademicos.Semestre = Convert.ToDouble(txtSemestre.Text);


                txtGuardar.Text = Convert.ToString(datosAcademicos.Materia + "\n " + datosAcademicos.ActividadEstudiante + "\n " + datosAcademicos.Semestre);

                MessageBox.Show(txtGuardar.Text);

                //Guarda el contenido
                try
                {
                    if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                    {

                        Stream strGuardar = saveFileDialog1.OpenFile();
                        StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                        foreach (string linea in txtGuardar.Lines)
                        {
                            wrtGuardar.WriteLine(linea);
                        }

                        wrtGuardar.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
