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

            
        }
            catch (Exception)
            {

                MessageBox.Show("Por favor revisar que en cedula solo existan numeros sin puntos ni comas ni letras \n Ningun campo debe quedar vacio");
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

               
            }
            catch (Exception )
            {

                MessageBox.Show("Por favor revisar que en cedula solo existan numeros sin puntos ni comas ni letras \n Ningun campo debe quedar vacio ");
            }
        }

        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClsDatosAcademicos datosAcademicos = new ClsDatosAcademicos();

                datosAcademicos.Materia = cboMateria.Text;
                datosAcademicos.ActividadEstudiante = cboActividad.Text;
                datosAcademicos.Semestre = Convert.ToDouble(txtSemestre.Text);


                txtGuardar.Text = Convert.ToString(datosAcademicos.Materia + "\n " + datosAcademicos.ActividadEstudiante + "\n " + datosAcademicos.Semestre);

                MessageBox.Show(txtGuardar.Text);


            }
            catch (Exception)
            {

                MessageBox.Show("Por favor revisar que en cedula solo existan numeros sin puntos ni comas ni letras \n Ningun campo debe quedar vacio ");
            }
        }
    }
}
