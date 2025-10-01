
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Práctica Estructura de Datos - Arreglos";
        MostrarMenuPrincipal();
    }

    static void MostrarMenuPrincipal()
    {
        string opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║      MENÚ DE OPCIONES - PRÁCTICA ARREGLOS ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");
            // Implementar un menú de opciones para listar de forma ordenada los nombres
            Console.WriteLine("1. Matriz de Identidad (Ejercicio 4)");
            Console.WriteLine("2. Estadísticas de Matriz 5x10 (Ejercicio 5)");
            Console.WriteLine("3. Análisis de Ventas (Ejercicio 6)");
            Console.WriteLine("6. Salir"); // Menú ordenado y con opción de Salir
            Console.WriteLine("---------------------------------------------");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case "1": EjecutarEjercicio4(); break;
                    case "2": EjecutarEjercicio5(); break;
                    case "3": EjecutarEjercicio6(); break;
                    case "6": Console.WriteLine("\nSaliendo del programa. ¡Gracias!"); break;
                    default: Console.WriteLine("❌ Opción no válida. Por favor, intente con una de las opciones listadas."); break;
                }
            }
            // Captura de excepción general para cualquier fallo inesperado (validar excepciones)
            catch (Exception ex)
            {
                Console.WriteLine($"\n🚨 Ocurrió un error inesperado durante la ejecución: {ex.Message}");
                Console.WriteLine("Verifique los datos de entrada o contacte al profesor.");
            }

            // Validar que se ejecuten cada uno sin salir y volver a ejecutar todo el proyecto.
            if (opcion != "6")
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }

        } while (opcion != "6");
    }

    // --- Ejecución de Ejercicio 4 ---
    static void EjecutarEjercicio4()
    {
        Console.Clear();
        Console.WriteLine("--- EJERCICIO 4: MATRIZ DE IDENTIDAD ---");
        Console.WriteLine("Análisis: Entrada(Tamaño N) -> Proceso(Crear Matriz) -> Salida(Imprimir Matriz)");

        // Entrada: Validación de datos de entrada (numérico decimal, validar excepciones)
        int size = Utilities.ReadInt("Ingrese el tamaño (N) de la matriz cuadrada: ", 1);

        Console.WriteLine("\nMatriz generada:");
        int[,] matrix = Ejercicio4.GenerarMatrizIdentidad(size);
        Utilities.PrintMatrix(matrix);
    }

    // --- Ejecución de Ejercicio 5 ---
    static void EjecutarEjercicio5()
    {
        Console.Clear();
        Console.WriteLine("--- EJERCICIO 5: ESTADÍSTICAS DE MATRIZ 5x10 ---");
        Console.WriteLine("Análisis: Entrada(Ninguna, matriz aleatoria) -> Proceso(Cálculo Suma/Promedio) -> Salida(Resultados)");
        
        // Proceso
        Ejercicio5.ResultadosEstadisticos resultados = Ejercicio5.CalcularEstadisticas();

        Console.WriteLine("\nMATRIZ GENERADA (5x10 con números aleatorios):");
        Utilities.PrintMatrix(resultados.Matriz);

        // Salida: Imprimir resultados con el formato solicitado
        Console.WriteLine("\nRESULTADOS POR FILA (Arreglos A y B):");
        for (int i = 0; i < Ejercicio5.FILAS; i++)
        {
            Console.WriteLine($"Fila {i + 1}: Suma (A) = {resultados.SumasFilaA[i],-4} | Promedio (B) = {resultados.PromediosFilaB[i]:F2}");
        }

        Console.WriteLine("\nRESULTADOS POR COLUMNA (Arreglos C y D):");
        for (int j = 0; j < Ejercicio5.COLUMNAS; j++)
        {
            Console.WriteLine($"Col. {j + 1}: Suma (C) = {resultados.SumasColumnaC[j],-4} | Promedio (D) = {resultados.PromediosColumnaD[j]:F2}");
        }
    }

    // --- Ejecución de Ejercicio 6 ---
    static void EjecutarEjercicio6()
    {
        Console.Clear();
        Console.WriteLine("--- EJERCICIO 6: ANÁLISIS DE VENTAS ---");
        Console.WriteLine("Análisis: Entrada(Matriz Inicializada) -> Proceso(Búsqueda/Suma) -> Salida(Estadísticas)");
        
        // Proceso
        Ejercicio6.ResultadosAnalisis resultados = Ejercicio6.AnalizarVentas();
        string[] NombresDias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        Console.WriteLine("\nRESUMEN DE VENTAS ANUALES:");
        
        // d) Imprime la venta total
        Console.WriteLine($"- VENTA TOTAL ANUAL: ${resultados.VentaTotal:N2}"); 

        // c) Imprime la mayor venta y su ubicación
        Console.WriteLine($"- MAYOR VENTA: ${resultados.VentaMaxima:N2} (Hecha en: {resultados.UbicacionMaxima})");

        // b) Imprime la menor venta y su ubicación
        Console.WriteLine($"- MENOR VENTA: ${resultados.VentaMinima:N2} (Hecha en: {resultados.UbicacionMinima})");

        // e) Imprime la venta por día
        Console.WriteLine("\nVENTA ACUMULADA POR DÍA DE LA SEMANA:");
        for (int i = 0; i < NombresDias.Length; i++)
        {
            // Formato solicitado: Ej. Lunes: $x.00
            Console.WriteLine($"- {NombresDias[i],-10}: ${resultados.VentaPorDia[i]:N2}"); 
        }
    }
}