using System;
using System.Linq;

// Clase que encapsula los ejercicios 7, 8 y 9
public class EjerciciosSieteANueve
{
    // Ejercicio 7: Análisis de Calificaciones
    public static void Ejercicio7()
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
        
        Console.WriteLine("=== EJERCICIO 7: ANÁLISIS DE CALIFICACIONES ===\n");

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

        // b) Promedio más alto
        double promedioMaximo = promedios.Max();
        int indiceMaximo = Array.IndexOf(promedios, promedioMaximo);
        Console.WriteLine($"\nb) Promedio más alto: {promedioMaximo:F2} (Alumno {indiceMaximo + 1})");

        // c) Promedio más bajo
        double promedioMinimo = promedios.Min();
        int indiceMinimo = Array.IndexOf(promedios, promedioMinimo);
        Console.WriteLine($"c) Promedio más bajo: {promedioMinimo:F2} (Alumno {indiceMinimo + 1})");

        // d) Cuántos parciales fueron reprobados (< 7.0)
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

        // e) Distribución de calificaciones finales
        Console.WriteLine("\ne) Distribución de calificaciones finales:");
        
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

    // Ejercicio 8: Lista de Compras
    public static void Ejercicio8()
    {
        Console.WriteLine("=== EJERCICIO 8: LISTA DE COMPRAS ===\n");
        
        // Arreglo para almacenar productos
        string[] productos = new string[5];
        int cantidadProductos = 0;
        
        Console.WriteLine("Bienvenido a tu Lista de Compras");
        Console.WriteLine("Puedes agregar hasta 5 productos\n");
        
        // Agregar productos
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingresa el producto " + (i + 1) + ": ");
            string producto = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(producto))
            {
                productos[i] = producto;
                cantidadProductos++;
                Console.WriteLine("Producto agregado a la lista");
            }
            else
            {
                Console.WriteLine("Producto vacío, continuando...");
                break;
            }
            Console.WriteLine();
        }
        
        // Mostrar lista completa
        Console.WriteLine("=== TU LISTA DE COMPRAS ===");
        if (cantidadProductos > 0)
        {
            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.WriteLine((i + 1) + ". " + productos[i]);
            }
        }
        else
        {
            Console.WriteLine("No hay productos en la lista");
        }
        
        // Buscar un producto
        Console.WriteLine("\n¿Quieres buscar un producto? (s/n): ");
        string respuesta = Console.ReadLine();
        
        if (respuesta.ToLower() == "s" || respuesta.ToLower() == "si")
        {
            Console.Write("Ingresa el producto a buscar: ");
            string productoBuscar = Console.ReadLine();
            
            bool encontrado = false;
            for (int i = 0; i < cantidadProductos; i++)
            {
                if (productos[i].ToLower() == productoBuscar.ToLower())
                {
                    Console.WriteLine("Encontrado: " + productos[i] + " (posición " + (i + 1) + ")");
                    encontrado = true;
                    break;
                }
            }
            
            if (!encontrado)
            {
                Console.WriteLine("Producto no encontrado en la lista");
            }
        }
        
        Console.WriteLine("\nTotal de productos en la lista: " + cantidadProductos);
        Console.WriteLine("\n=== FIN DEL EJERCICIO 8 ===");
    }

    // Ejercicio 9: Contador de Números
    public static void Ejercicio9()
    {
        Console.WriteLine("=== EJERCICIO 9: CONTADOR DE NÚMEROS ===\n");
        
        // Arreglo con números predefinidos
        int[] numeros = { 5, 3, 7, 3, 9, 3, 1, 3, 8, 3, 2, 3, 6, 3, 4 };
        
        Console.WriteLine("Lista de números:");
        MostrarArreglo(numeros);
        
        // Pedir al usuario qué número quiere contar
        Console.Write("\n¿Qué número quieres contar? ");
        int numeroBuscar;
        
        try
        {
            numeroBuscar = int.Parse(Console.ReadLine());
            
            // Contar cuántas veces aparece el número
            int contador = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscar)
                {
                    contador++;
                }
            }
            
            // Mostrar resultado
            Console.WriteLine($"\nEl número {numeroBuscar} aparece {contador} veces en la lista");
            
            if (contador > 0)
            {
                Console.WriteLine("Posiciones donde aparece:");
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == numeroBuscar)
                    {
                        Console.WriteLine($"  - Posición {i + 1}");
                    }
                }
            }
            
            // Estadísticas adicionales
            Console.WriteLine($"\n=== ESTADÍSTICAS ===");
            Console.WriteLine($"Total de números en la lista: {numeros.Length}");
            Console.WriteLine($"Número más frecuente: {EncontrarNumeroMasFrecuente(numeros)}");
            Console.WriteLine($"Números únicos en la lista: {ContarNumerosUnicos(numeros)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debes ingresar un número válido");
        }
        
        Console.WriteLine("\n=== FIN DEL EJERCICIO 9 ===");
    }
    
    // Métodos auxiliares para el Ejercicio 9
    private static void MostrarArreglo(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }
    
    private static int EncontrarNumeroMasFrecuente(int[] arr)
    {
        int numeroMasFrecuente = arr[0];
        int maxFrecuencia = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            int frecuencia = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    frecuencia++;
                }
            }
            
            if (frecuencia > maxFrecuencia)
            {
                maxFrecuencia = frecuencia;
                numeroMasFrecuente = arr[i];
            }
        }
        
        return numeroMasFrecuente;
    }
    
    private static int ContarNumerosUnicos(int[] arr)
    {
        int unicos = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            bool esUnico = true;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j])
                {
                    esUnico = false;
                    break;
                }
            }
            
            if (esUnico)
            {
                unicos++;
            }
        }
        
        return unicos;
    }
}