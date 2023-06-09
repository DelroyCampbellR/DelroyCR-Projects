﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte i, j, numAlumnos, salones;
            double sumaCalif = 0, sumaCalifSalon, totalAlumnos = 0, promedio, califMin = 100, califMax = 0;

            Console.WriteLine("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            double[][] calificaciones = new double[salones][];
            Console.WriteLine();

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Ingrese el número de alumnos para el salón {0}", i + 1);
                {
                    numAlumnos = Convert.ToByte(Console.ReadLine());
                    totalAlumnos += numAlumnos;

                    calificaciones[i] = new double[numAlumnos];
                }
            }

            double[] califMinSalon = new double[salones]; 
            double[] califMaxSalon = new double[salones];
            double[] promedioSalon = new double[salones];

            for (i = 0; i < salones; i++)
            {
                sumaCalifSalon = 0;
                califMax = 0;
                califMin = 100;

                Console.WriteLine();
                Console.WriteLine($"Salon {i + 1}");
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("Ingresa la calificación del alumno {0}", j + 1);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    sumaCalif += calificaciones[i][j];
                    sumaCalifSalon += calificaciones[i][j];

                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }

                    califMinSalon[i] = califMin;

                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }

                    califMaxSalon[i] = califMax;
                }

                promedioSalon[i] = sumaCalifSalon / calificaciones[i].Length;
            }

            promedio = sumaCalif / totalAlumnos;

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }

                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Datos de la escuela!");
            Console.WriteLine();

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Salón {0}", i + 1);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine($"El alumno {j + 1}, tiene {calificaciones[i][j]} de calificación.");
                }
                Console.WriteLine();
            }

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Información del salón {0}", i + 1);
                Console.WriteLine("Calificación máxima: {0} calificación mínima: {1}", califMaxSalon[i], califMinSalon[i]);
                Console.WriteLine("Promedio: {0}", promedioSalon[i]);
            }

            Console.WriteLine();

            Console.WriteLine("El promedio total de la escuela es: {0}", promedio.ToString("F2"));
            Console.WriteLine($"La calificación mínima de la escuela es: {califMin}");
            Console.WriteLine($"La calificación máxima de la escuela es: {califMax}");
        }
    }
}
