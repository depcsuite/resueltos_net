

//Se pide ingresar numeros desde la consola sumarlos y al salir mostrar esa suma
//Se sale cuando el usuario carga un 0.

/*

using System;

Console.WriteLine("Ingrese un numero (0 para salir)");

//int num = int.Parse(Console.ReadLine());
if (int.TryParse(Console.ReadLine(), out int num))
{
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Debe cargar un numero!!!");
}


int acum = 0;
int n = 0;

//for( valor_inicial; condicion;incremento)
for ( n = 0; num != 0; n++)
{
    acum += num;
    Console.WriteLine("Ingrese un numero (0 para salir)");
    num = int.Parse(Console.ReadLine());
}



//do
//{
//    acum += num;
//    Console.WriteLine("Ingrese un numero (0 para salir)");
//    num = int.Parse(Console.ReadLine());
//    n = n + 1; //n++
//} while (num != 0);



//while (num != 0)
//{
//    acum += num;
//    Console.WriteLine("Ingrese un numero (0 para salir)");
//    num = int.Parse(Console.ReadLine());
//    n = n + 1; //n++
//}

Console.WriteLine($"Suma de todos los {n} numeros cargados: {acum}"); //Recomendada
Console.WriteLine("Suma de todos los " + n + " numeros cargados: " + acum);
Console.WriteLine(String.Format("Suma de todos los {0} numeros cargados: {1} ",n, acum));

Console.ReadLine();
*/