using ProgramacionCsharp.POO.Producto.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionCsharp.POO.Producto
{

    public class Producto1
    {

        public Producto1()
        {

        }

        public Producto1(string sku, string marca, string modelo, string detalle)
        {
            //Id = id; //El id esta asociado a la base de datos. Se genera automaticamente.
            Sku = sku;
            Marca = marca;
            Modelo = modelo;
            Detalle = detalle;
        }

        public int Id { get; set; }
        public string Sku { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Detalle { get; set; }
        public Especificaciones Especificaciones { get; set; }
    }
}
