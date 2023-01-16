using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionCsharp.POO.Animal
{
    internal class Perro : Animal
    {
        public Perro(string nombre, string raza)
        {
            Nombre = nombre;
            Raza = raza;
        }

        public string Nombre { get; set; }
        public string Raza { get; set; }

        public override string GetDetalle()
        {
            return $"Detalles del Perro, Nombre {Nombre}, Raza {Raza}";
        }
    }
}
