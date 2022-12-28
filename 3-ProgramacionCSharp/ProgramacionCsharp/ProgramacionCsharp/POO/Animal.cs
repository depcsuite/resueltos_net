using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionCsharp.POO
{

    public class Animal
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public virtual string GetDetalle()
        {
            return $"Nombre {Nombre} - Raza {Raza}";
        }

    
    }

   
}
