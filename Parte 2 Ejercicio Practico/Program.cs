using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ejercicio_Practico
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            Console.Write("Ingrese la cantidad de estudiantes que desea registrar: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la edad del estudiante: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el promedio del estudiante: ");
                double promedio = double.Parse(Console.ReadLine());

                estudiantes.Add(new Estudiante(nombre, edad, promedio));
            }

            int index = 0;
            while (index < estudiantes.Count)
            {
                if (estudiantes[index].Promedio >= 70)
                {
                    estudiantes[index].MostrarInfo();
                    if (estudiantes[index].EsMayorDeEdad())
                    {
                        Console.WriteLine("El estudiante es mayor de edad.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("El estudiante es menor de edad.");
                        Console.ReadKey();
                    }
                }
                index++;
            }

            // para que espere que el usuario de una tecla y se cierre, como una cortesia
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}