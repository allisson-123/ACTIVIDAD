using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO04
{
    using System;

    class Program
    {
        static void Main()
        {
            int N;
            double suma = 0;
            double promedio;
            double maxima;
            double minima;
            Console.Write("Ingrese el número de alumnos: ");
            N = int.Parse(Console.ReadLine());
            double[] notas = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());

                suma = suma + notas[i];
            }
            maxima = notas[0];
            minima = notas[0];
            for (int i = 1; i < N; i++)
            {
                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }

                if (notas[i] < minima)
                {
                    minima = notas[i];
                }
            }
            promedio = suma / N;
            Console.WriteLine("\nPromedio de notas: " + promedio);
            Console.WriteLine("Máxima nota: " + maxima);
            Console.WriteLine("Mínima nota: " + minima);
        }
    }
}
