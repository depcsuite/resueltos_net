
internal class Program1
{
    private static void Main1(string[] args)
    {
        //Condicional();

        //Modificar el código para que muestre que:
        //Si el sueldo está entre 3000 y 10000 paga 10 % de impuestos
        //Si el sueldo está entre 10000 y 25000 paga 20 % de impuestos
        //Si el sueldo es más de 25000 paga 35 % de impuesto.

        //defino variables.
        float sueldo; //SMVL4J
        string linea;

        //Muestro mensajes en consola.
        Console.Write("Ingrese el sueldo:");
        linea = Console.ReadLine();

        //Transformo tipo string en float
        sueldo = float.Parse(linea);

        if (sueldo >= 3000)
        {
            if (sueldo <= 10000)
            {
                Console.WriteLine("Paga 10 % de impuestos");
            }
        }

        if (sueldo >= 10000)
        {
            if (sueldo <= 25000)
            {
                Console.WriteLine("Paga 20 % de impuestos");
            }
        }

        if (sueldo > 25000)
        {
            Console.WriteLine("Paga 35 % de impuestos");
        }
    }

    private static void Condicional()
    {
        //defino variables.
        float sueldo; //SMVL4J
        string linea;

        //Muestro mensajes en consola.
        Console.Write("Ingrese el sueldo:");
        linea = Console.ReadLine();

        //Transformo tipo string en float
        sueldo = float.Parse(linea);

        //Comparo
        if (sueldo > 3000) //SI
        {
            Console.Write("Esta persona debe abonar impuestos");
        }
        else //SINO
        {
            Console.Write("Esta persona NO debe abonar impuestos");
        }

        //Espero que el usuario toque una tecla.
        Console.ReadKey();
    }
}