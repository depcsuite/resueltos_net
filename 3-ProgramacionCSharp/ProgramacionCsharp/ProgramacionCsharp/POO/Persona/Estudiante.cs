using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionCsharp.POO.Persona
{
    public class Estudiante : Persona
    {
        public int NroEstudiante { get; set; }
        public decimal Promedio { get; set; }

        public bool Enrolable { get; set; }

        public List<string> CodSeminarios { get; set; }
    }
}
