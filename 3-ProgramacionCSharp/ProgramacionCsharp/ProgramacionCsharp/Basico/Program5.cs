using System.Diagnostics;

internal partial class Program5
{
    static void Main1(string[] args)
    {

        int[] numeros = { 32, 12, 43, 82, 15, 34, 79, 55, 64, -54 ,34,32,43,43,82,15,15};

        //int resultado = Aleatorio(numeros);

        //var (max, min) = MaxMin(numeros);

        ////Console.WriteLine(numeros[Aleatorio(numeros)]);
        //int resultado = Maximo(numeros);
        //int resultado2 = Minimo(numeros);

        //int max2 = Maximo(numeros);
        //int min2 = Minimo(numeros);

        //Console.WriteLine($"Maximo es {resultado} y el minimo es {resultado2}");

        //Console.WriteLine($"Maximo es {max} y el minimo es {min}");

        //Console.WriteLine($"Maximo es {max2} y el minimo es {min2}");


        MostrarMultiples(numeros);


        Console.ReadLine();



    }

    /// <summary>
    /// Muestra por pantalla "cantidad : numero"
    /// </summary>
    /// <param name="numeros"></param>
    /// <exception cref="NotImplementedException"></exception>
    private static void MostrarMultiples(int[] numeros)
    {
        int[] aux = new int[numeros.Length];

        foreach (var n in numeros)
        { 
                        
        }

    }

    
    private static (int, int) MaxMin(int[] numeros)
    {
        int max = Maximo(numeros);
        int min = Minimo(numeros);

        return (max, min);
    }
    
    // 
    /// <summary>
    /// Función que devuelve un número aleatorio entre los numeros de un vector recibido por parametro
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    static int Aleatorio(int[] numeros)
    {
        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();



        sw.Stop();
        var rand = new Random((int)sw.ElapsedMilliseconds);

        int elegido = rand.Next() % numeros.Length;

        return elegido;

    }

    static int Maximo(int[] numeros)
    {
        int max = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > max)
            {
                max = numeros[i];
            }
        }
        return max;
    }

    static int Maximo2(int[] numeros)
    {
        int max = 0;

        foreach(var n in numeros)
        {
            if (n > max)
                max = n;
        }


        return max;
    }


    static int Minimo2(int[] numeros)
    {
        int min = 0;

        foreach (var n in numeros)
        {
            if (n < min)
                min = n;
        }


        return min;
    }


    static int Minimo(int[] numeros)
    {
        int min = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
            {
                min = numeros[i];
            }
        }
        return min;
    }
}