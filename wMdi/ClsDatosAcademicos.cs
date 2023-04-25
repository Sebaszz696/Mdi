using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wMdi
{
    internal class ClsDatosAcademicos
    {

        string materia;
        string actividadEstudiante;
        double semestre;

        public ClsDatosAcademicos()
        {
           materia = "";
           actividadEstudiante = "";
           semestre = 0;
        }

        public string Materia { get => materia; set => materia = value; }
        public string ActividadEstudiante { get => actividadEstudiante; set => actividadEstudiante = value; }
        public double Semestre { get => semestre; set => semestre = value; }
    }
}
