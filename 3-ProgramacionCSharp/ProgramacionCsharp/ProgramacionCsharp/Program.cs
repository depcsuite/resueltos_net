using ProgramacionCsharp.POO;
using ProgramacionCsharp.POO.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionCsharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Profesor> profes = GetProfesores();

            Estudiante est = GetEstudiante();

            //Mostrar datos basicos del estudiante
            Console.WriteLine($"Nombre: {est.Nombre}, Promedio: {est.Promedio}  ");
            Console.WriteLine($"Asiste a los siguientes seminarios:");

            var seminarios = GetSeminariosByCode(est.CodSeminarios);

            foreach (var s in seminarios)
            {
                Console.WriteLine($"Seminario: {s.Codigo}-{s.Nombre}");
            }
        }

        private static List<Seminario> GetSeminariosByCode(List<string>codigos)
        {
            var seminarios = new List<Seminario>();

            var seminario = new Seminario()
            {
                Codigo = "z34",
                Nombre = "Fisica nuclear",
                Catedra = "Física"

            };

            seminarios.Add(seminario);

            seminario = new Seminario()
            {
                Codigo = "z15",
                Nombre = "Topologia algebraica",
                Catedra = "Matematicas"
            };
            seminarios.Add(seminario);

            seminario = new Seminario()
            {
                Codigo = "z24",
                Nombre = "Teoria de numeros",
                Catedra = "Matematicas"
            };
            seminarios.Add(seminario);

            seminario = new Seminario()
            {
                Codigo = "z334",
                Nombre = "Calculo multivariable",
                Catedra = "Matematicas"
            };
            seminarios.Add(seminario);

            seminario = new Seminario()
            {
                Codigo = "z243",
                Nombre = "Quimica genereal 1",
                Catedra = "Quimica"
            };
            seminarios.Add(seminario);

            seminario = new Seminario()
            {
                Codigo = "z334",
                Nombre = "Mecanica de los fluidos ",
                Catedra = "Mecanica"
            };
            seminarios.Add(seminario);

            seminario = new Seminario()
            {
                Codigo = "w3324",
                Nombre = "Electroncia del estado solido II",
                Catedra = "Electronica"
            };
            seminarios.Add(seminario);

            seminario = new Seminario()
            {
                Codigo = "z234",
                Nombre = "Sistemas Operativos",
                Catedra = "Sistemas"
            };
            seminarios.Add(seminario);

            seminario = new Seminario()
            {
                Codigo = "z2334",
                Nombre = "Algoritmo y estructura de datos",
                Catedra = "Matematicas"
            };
            seminarios.Add(seminario);

            //Filtramos por codigo
            //A lo bruto
            var seminariosFiltrados = new List<Seminario>(); 
            
            foreach (var s in seminarios)
            {
                if (codigos.Contains(s.Codigo))
                    seminariosFiltrados.Add(s);
            }

            //Filtro por el primer codigo
            seminariosFiltrados = seminarios.Where(c => c.Codigo == codigos[0]).ToList();

            //Filtro por el primer codigo
            seminariosFiltrados = (from s in seminarios
                                   where s.Codigo == codigos[0]
                                   select s).ToList();

            
            return seminariosFiltrados;

        }

        private static List<Profesor> GetProfesores()
        {
            List<Profesor> profes = new List<Profesor>();

            var prof = new Profesor()
            {
                Email = "carlos.mendieta@uni.edu.ar",
                Nombre = "Carlos Jorge Fernandez",
                Salario = 120000,
                Telefono = "555-4543543"
            };

            profes.Add(prof);

            return profes;
        }

        private static Estudiante GetEstudiante()
        {
            var est = new Estudiante()
            {
                Email = "sarasa@gmail.com",
                Nombre = "Juan Perez",
                NroEstudiante = 323,
                Enrolable = false,
                Promedio = 6,
                Telefono = "555-3243423"
            };

            est.CodSeminarios = new List<string> { "z15", "z234", "z243" };

            return est;
        }
    }
}
