using ProgramacionCsharp.POO.Animal;
using ProgramacionCsharp.POO.Producto;
using ProgramacionCsharp.POO.Producto.Producto;

namespace ProgramacionCsharp
{
    internal class Program1
    {
        private static void Main1(string[] args)
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Perro("Toby", "Chiguagua"));
            animales.Add(new Gato("Tom", "Siames"));

            Console.WriteLine($"Animal: {animales[0].GetDetalle()}");
            Console.WriteLine($"Perro: {((Perro)animales[0]).GetDetalle()}");
            Console.WriteLine($"Gato:  {((Gato)animales[1]).GetDetalle()}");
        


            //perro.Raza, perro.Nombre, perro.GetDetalle();


            Producto1[] prods = new Producto1[3];
            //prods = CargarProducto1s(prods);

            //Collecciones son agregaciones de tamaño variable 
            //List --> En la práctica es una arreglo de tamaño dinámico.
            //Dictionary --> Hasmap, Map, Key/Value 

            //Generics o genericos (System.Collections.Generic) permite definir tipo
            //de datos genéricos, es decir tipo que NO se conocen su definición.


            List<string> list = new List<string>();
            list.Add("elemento1");
            list.Add("elemento2");
            list.Add("elemento3");
            list.Add("elemento4");
            list.Add("elemento5");

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            foreach (var n in list)
                Console.WriteLine(n);


            List<int> nlist = new List<int>();
            nlist.Add(1);
            nlist.Add(2);
            nlist.Add(3);
            nlist.Add(4);
            nlist.Add(5);

            for (int i = 0; i < nlist.Count; i++)
                Console.WriteLine(nlist[i]);

            foreach (var n in nlist)
                Console.WriteLine(n);

            List<Producto1> Producto1s = CargarListaProducto1s();

            foreach (var p in Producto1s)
            {
                Console.WriteLine($"Producto1: {p.Sku}:");
                Console.WriteLine(p.Marca);
                Console.WriteLine(p.Modelo);
                Console.WriteLine(p.Sku);
                Console.WriteLine(p.Detalle);
                Console.WriteLine(p.Especificaciones.CodBarras);
            }

            //Console.WriteLine($"Marca y modelo del prod1: {prods[0].Marca},{prods[0].Modelo}");
            //Console.WriteLine($"Marca y modelo del prod2: {prods[1].Marca},{prods[1].Modelo}");
            //Console.WriteLine($"Marca y modelo del prod3: {prods[2].Marca},{prods[2].Modelo}");
            Console.ReadLine();

        }

        private static List<Producto1> CargarListaProducto1s()
        {
            List<Producto1> Producto1s = new List<Producto1>();
            Producto1s.Add(new Producto1()
            {
                Detalle = "Detalles 2",
                Marca = "TALENT",
                Modelo = "Modelo 2",
                Sku = "t9000",
                Especificaciones = new Especificaciones()
                {
                    CodBarras = "77774843838238",
                    IRAM = true,
                    Nacional = false
                }
            });
            Producto1s.Add(new Producto1()
            {
                Detalle = "Detalles 3",
                Marca = "TALENT",
                Modelo = "Modelo 2",
                Sku = "t9000",
                Especificaciones = new Especificaciones()
                {
                    CodBarras = "7785954393489569834",
                    IRAM = false,
                    Nacional = true
                }
            });
            Producto1s.Add(new Producto1()
            {
                Detalle = "Detalles 2",
                Marca = "SDFSDF",
                Modelo = "Modelo 2",
                Sku = "t9000",
                Especificaciones = new Especificaciones()
                {
                    CodBarras = "5684309654587960754",
                    IRAM = true,
                    Nacional = true
                }
            });

            Producto1s.Add(new Producto1()
            {
                Detalle = "Detalles 2",
                Marca = "FDSFDS",
                Modelo = "Modelo 2",
                Sku = "t9000",
                Especificaciones = new Especificaciones()
                {
                    CodBarras = "009804856943854309",
                    IRAM = true,
                    Nacional = true
                }
            });
            Producto1s.Add(new Producto1()
            {
                Detalle = "Detalles 2",
                Marca = "TALENT",
                Modelo = "FDSFSDF 2",
                Sku = "t90FDSFDSFSDF00",
                Especificaciones = new Especificaciones()
                {
                    CodBarras = "5743957439753",
                    IRAM = true,
                    Nacional = false
                }
            });
            return Producto1s;
        }

        private static Producto1[] CargarProducto1s(Producto1[] prods)
        {

            //Carga datos en Producto1s
            //Primera opcion, usando constructor vacio
            prods[0] = new Producto1();
            prods[0].Detalle = "Detalles 1";
            prods[0].Marca = "HITACHI";
            prods[0].Modelo = "Modelo 1";
            prods[0].Sku = "p1000";

            //Otra forma
            var prod2 = new Producto1()
            {
                Detalle = "Detalles 2",
                Marca = "TALENT",
                Modelo = "Modelo 2",
                Sku = "t9000"
            };

            prods[1] = prod2;


            //Otra forma
            var prod3 = new Producto1("x5600", "AIWA", "djklf", "Detalles 3");

            prods[2] = prod3;

            return prods;
        }


        private static void CargarProducto1s()
        {
            //Carga datos en Producto1s
            //Primera opcion, usando constructor vacio
            var prod = new Producto1();
            prod.Detalle = "Detalles 1";
            prod.Marca = "HITACHI";
            prod.Modelo = "Modelo 1";
            prod.Sku = "p1000";

            //Otra forma
            var prod2 = new Producto1()
            {
                Detalle = "Detalles 2",
                Marca = "TALENT",
                Modelo = "Modelo 2",
                Sku = "t9000"
            };

            //Otra forma
            var prod3 = new Producto1("x5600", "AIWA", "djklf", "Detalles 3");

           
        }

    }
}
