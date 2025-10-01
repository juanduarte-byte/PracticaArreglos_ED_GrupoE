using System;
using System.Linq;

class Ejercicio7
{
    public static void Ejecutar()
    {
        // Datos de calificaciones: 12 alumnos, 3 parciales cada uno
        double[,] calificaciones = {
            {5.5, 8.6, 10.0},   // Alumno 1
            {8.0, 5.5, 10.0},   // Alumno 2
            {9.0, 4.1, 7.8},    // Alumno 3
            {10.0, 2.2, 8.1},   // Alumno 4
            {7.0, 9.2, 7.1},    // Alumno 5
            {9.0, 4.0, 6.0},    // Alumno 6
            {6.5, 5.0, 5.0},    // Alumno 7
            {4.0, 7.0, 4.0},    // Alumno 8
            {8.0, 8.0, 9.0},    // Alumno 9
            {10.0, 9.0, 9.2},   // Alumno 10
            {5.0, 10.0, 8.4},   // Alumno 11
            {9.0, 4.6, 7.5}     // Alumno 12
        };

        int numAlumnos = calificaciones.GetLength(0);
        int numParciales = calificaciones.GetLength(1);
        
        Console.WriteLine("=== EJERCICIO 7: ANALISIS DE CALIFICACIONES ===\n");

        // a) Promedio de cada alumno
        Console.WriteLine("a) Promedio de cada alumno:");
        double[] promedios = new double[numAlumnos];
        for (int i = 0; i < numAlumnos; i++)
        {
            double suma = 0;
            for (int j = 0; j < numParciales; j++)
            {
                suma += calificaciones[i, j];
            }
            promedios[i] = suma / numParciales;
            Console.WriteLine($"   Alumno {i + 1}: {promedios[i]:F2}");
        }

        // b) Promedio mÃ¡s alto
        double promedioMaximo = promedios.Max();
        int indiceMaximo = Array.IndexOf(promedios, promedioMaximo);
        Console.WriteLine($"\nb) Promedio mas alto: {promedioMaximo:F2} (Alumno {indiceMaximo + 1})");

        // c) Promedio mÃ¡s bajo
        double promedioMinimo = promedios.Min();
        int indiceMinimo = Array.IndexOf(promedios, promedioMinimo);
        Console.WriteLine($"c) Promedio mas bajo: {promedioMinimo:F2} (Alumno {indiceMinimo + 1})");

        // d) CuÃ¡ntos parciales fueron reprobados (< 7.0)
        int parcialesReprobados = 0;
        for (int i = 0; i < numAlumnos; i++)
        {
            for (int j = 0; j < numParciales; j++)
            {
                if (calificaciones[i, j] < 7.0)
                {
                    parcialesReprobados++;
                }
            }
        }
        Console.WriteLine($"\nd) Parciales reprobados (< 7.0): {parcialesReprobados}");

        // e) DistribuciÃ³n de calificaciones finales
        Console.WriteLine("\ne) Distribucion de calificaciones finales:");
        
        int[] distribucion = new int[6]; // 6 rangos: 0-4.9, 5.0-5.9, 6.0-6.9, 7.0-7.9, 8.0-8.9, 9.0-10.0
        
        foreach (double promedio in promedios)
        {
            if (promedio >= 0.0 && promedio < 5.0)
                distribucion[0]++;
            else if (promedio >= 5.0 && promedio < 6.0)
                distribucion[1]++;
            else if (promedio >= 6.0 && promedio < 7.0)
                distribucion[2]++;
            else if (promedio >= 7.0 && promedio < 8.0)
                distribucion[3]++;
            else if (promedio >= 8.0 && promedio < 9.0)
                distribucion[4]++;
            else if (promedio >= 9.0 && promedio <= 10.0)
                distribucion[5]++;
        }

        string[] rangos = {
            "0.0 - 4.9",
            "5.0 - 5.9", 
            "6.0 - 6.9",
            "7.0 - 7.9",
            "8.0 - 8.9",
            "9.0 - 10.0"
        };

        for (int i = 0; i < distribucion.Length; i++)
        {
            Console.WriteLine($"   {rangos[i]}: {distribucion[i]} Alumnos");
        }

        Console.WriteLine("\n=== FIN DEL EJERCICIO 7 ===");
    }
}

