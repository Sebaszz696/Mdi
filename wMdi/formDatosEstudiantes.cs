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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace wMdi
{
    public partial class formDatosEstudiantes : Form
    {
        public formDatosEstudiantes()
        {
            InitializeComponent();
        }

      
        private void formDatosEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {//salir
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {//Cerrar
             this.Close();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {//Guardar valores del form a las variables
            try
            {

           
            ClsDatosEstudiantes datosEstudiantes = new ClsDatosEstudiantes();

            datosEstudiantes.Nombre = txtNombre.Text;
            datosEstudiantes.Apellido = txtApellidos.Text;
            datosEstudiantes.Cedula = Convert.ToDouble(txtCedula.Text);
            datosEstudiantes.Sexo = cboSexo.Text;
            datosEstudiantes.FechaNacimiento = dtFecha.Text;
            datosEstudiantes.Ciudad = txtCiudad.Text;



            txtGuardar.Text = Convert.ToString(datosEstudiantes.Nombre + "\n" + datosEstudiantes.Apellido + "\n" + datosEstudiantes.Cedula + "\n" + datosEstudiantes.Sexo + "\n" + datosEstudiantes.FechaNacimiento + "\n" + datosEstudiantes.Ciudad);

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
        {
            //Limpiar
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            dtFecha.Text = Convert.ToString(DateTime.Now);
            txtCiudad.Clear();

            //Limpia el Cbo
            cboSexo.SelectedIndex = -1;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {//Boton de slair
            this.Close();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guardar valores del form a las variables
            try
            {


                ClsDatosEstudiantes datosEstudiantes = new ClsDatosEstudiantes();

                datosEstudiantes.Nombre = txtNombre.Text;
                datosEstudiantes.Apellido = txtApellidos.Text;
                datosEstudiantes.Cedula = Convert.ToDouble(txtCedula.Text);
                datosEstudiantes.Sexo = cboSexo.Text;
                datosEstudiantes.FechaNacimiento = dtFecha.Text;
                datosEstudiantes.Ciudad = txtCiudad.Text;



                txtGuardar.Text = Convert.ToString(datosEstudiantes.Nombre + "\n" + datosEstudiantes.Apellido + "\n" + datosEstudiantes.Cedula + "\n" + datosEstudiantes.Sexo + "\n" + datosEstudiantes.FechaNacimiento + "\n" + datosEstudiantes.Ciudad);

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
