using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionCsharp.POO.Persona
{
    public class Seminario
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public Profesor Profesor { get; set; }

        public string Catedra { get; set; }
    }
}
