using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wMdi
{
    /// <summary>
    /// Sebastian Velasquez y Mateo Becerra
    /// formulario mdi estudiantes academicos
    /// 25/04/2023
    /// camelCase
    /// </summary>
    public partial class formMenuPrincipal : Form
    {
        public formMenuPrincipal()
        {
            InitializeComponent();
        }

        private void datosEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //comprueba que no haya ningun formularo hijo abierto
            Form frmHijo = this.ActiveMdiChild;
            if (frmHijo != null)
            {

                frmHijo.Close();
            }
            //Abre datos estudiantes
            formDatosEstudiantes frmDatosEstudiantes = new formDatosEstudiantes();
            frmDatosEstudiantes.MdiParent = this;
            frmDatosEstudiantes.Show();
        }

        private void datosAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //comprueba que no haya ningun formularo hijo abierto
            Form frmHijo = this.ActiveMdiChild;
            if (frmHijo != null)
            {

                frmHijo.Close();
            }
         //Abre datos academicos
                formDatosAcademicos frmDatosAcademicos = new formDatosAcademicos();
                frmDatosAcademicos.MdiParent = this;
                frmDatosAcademicos.Show();
            
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //salir
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //comprueba que no haya ningun formularo hijo abierto
            Form frmHijo = this.ActiveMdiChild;
            if (frmHijo != null)
            {

                frmHijo.Close();
            }

        }

        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
