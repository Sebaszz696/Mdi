using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wMdi
{
    internal class ClsDatosEstudiantes
    {

        string nombre;
        string apellido;
        double    cedula;
        string sexo;
        string fechaNacimiento;
        string ciudad;

    

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Cedula { get => cedula; set => cedula = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public ClsDatosEstudiantes()
        {
            Nombre = "";
            Apellido = "";
            Cedula =0;
            Sexo = "";
            FechaNacimiento = "";
            Ciudad = "";
        }

    }
}
