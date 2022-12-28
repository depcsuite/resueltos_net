internal partial class Program4
{
    private static void Main2(string[] args)
    {
        //Condicional1();

        //Operadores logicos
        //OR  AND  y convinaciones.
        //OR   || 
        //AND  &&

        //OR Tabla de verdad
        //V || V -> V
        //V || F -> V
        //F || V -> V
        //F || F -> F

        //---/ ---
        //        ()
        //---/ ---


        //AND Tabla de verdad
        //V && V -> V
        //V && F -> F
        //F && V -> F
        //F && F -> F

        //---/---/ ---
        //------------


        bool a, b;
        a = false; b = false;

        if (a || b)
            Console.WriteLine("FALSO");

        bool c = 2 > 5;
        bool d = false;

        Console.WriteLine(c);
        Console.WriteLine(3 < 10);
        Console.WriteLine(c || a);

        int sueldo = 5000;
        Console.WriteLine((sueldo >= 0 && sueldo <= 10000) || d);
        //V                  //V        //F            
        //V                      //F        //V   


        Console.WriteLine(sueldo >= 0 && sueldo <= 10000 || d);


        Console.ReadLine();
    }

    private static void Condicional1()
    {
        float sueldo;
        string linea;

        Console.Write("Ingrese el sueldo:");
        linea = Console.ReadLine();


        sueldo = float.Parse(linea);

        if (sueldo >= 0)
        {
            if (sueldo <= 10000)
            {
                Console.WriteLine("Paga % de impuestos");
            }

        }
        if (sueldo >= 10000)
        {
            if (sueldo <= 25000)
            {
                Console.WriteLine("Esta persona debe pagar impuestos");

            }
        }

        if (sueldo > 25000)
            Console.WriteLine("Esta persona debe pagar MUCHOS impuestos");

        Console.ReadKey();
    }
}