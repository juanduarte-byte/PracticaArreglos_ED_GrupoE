using System;

// Clase que encapsula los ejercicios 4, 5 y 6 (implementados por Angel)
public class EjerciciosCuatroASeis
{
    // Ejercicio 4: Matriz de Identidad
    public static void Ejercicio4()
    {
        Console.WriteLine("=== EJERCICIO 4: MATRIZ DE IDENTIDAD ===\n");
        Console.WriteLine("Análisis: Entrada(Tamaño N) -> Proceso(Crear Matriz) -> Salida(Imprimir Matriz)");

        // Entrada: Validación de datos de entrada
        int size = LeerEntero("Ingrese el tamaño (N) de la matriz cuadrada: ", 1);

        Console.WriteLine("\nMatriz de identidad generada:");
        int[,] matrix = GenerarMatrizIdentidad(size);
        ImprimirMatriz(matrix);

        Console.WriteLine("\n=== FIN DEL EJERCICIO 4 ===");
    }

    // Ejercicio 5: Estadísticas de Matriz 5x10
    public static void Ejercicio5()
    {
        Console.WriteLine("=== EJERCICIO 5: ESTADÍSTICAS DE MATRIZ 5x10 ===\n");
        Console.WriteLine("Análisis: Entrada(Ninguna, matriz aleatoria) -> Proceso(Cálculo Suma/Promedio) -> Salida(Resultados)");
        
        // Proceso
        ResultadosEstadisticos resultados = CalcularEstadisticas();

        Console.WriteLine("\nMATRIZ GENERADA (5x10 con números aleatorios):");
        ImprimirMatriz(resultados.Matriz);

        // Salida: Imprimir resultados con el formato solicitado
        Console.WriteLine("\nRESULTADOS POR FILA (Arreglos A y B):");
        for (int i = 0; i < FILAS; i++)
        {
            Console.WriteLine($"Fila {i + 1}: Suma (A) = {resultados.SumasFilaA[i],-4} | Promedio (B) = {resultados.PromediosFilaB[i]:F2}");
        }

        Console.WriteLine("\nRESULTADOS POR COLUMNA (Arreglos C y D):");
        for (int j = 0; j < COLUMNAS; j++)
        {
            Console.WriteLine($"Col. {j + 1}: Suma (C) = {resultados.SumasColumnaC[j],-4} | Promedio (D) = {resultados.PromediosColumnaD[j]:F2}");
        }

        Console.WriteLine("\n=== FIN DEL EJERCICIO 5 ===");
    }

    // Ejercicio 6: Análisis de Ventas
    public static void Ejercicio6()
    {
        Console.WriteLine("=== EJERCICIO 6: ANÁLISIS DE VENTAS ===\n");
        Console.WriteLine("Análisis: Entrada(Matriz Inicializada) -> Proceso(Búsqueda/Suma) -> Salida(Estadísticas)");
        
        // Proceso
        ResultadosAnalisis resultados = AnalizarVentas();
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

        Console.WriteLine("\n=== FIN DEL EJERCICIO 6 ===");
    }

    // ===== MÉTODOS AUXILIARES PARA EJERCICIO 4 =====
    private static int[,] GenerarMatrizIdentidad(int n)
    {
        // Análisis: Entradas(n), Proceso(Llenado de matriz), Salida(Matriz)
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Lógica: La diagonal principal contenga 1's (i == j), las demás 0's.
                matrix[i, j] = (i == j) ? 1 : 0;
            }
        }
        return matrix;
    }

    // ===== MÉTODOS AUXILIARES PARA EJERCICIO 5 =====
    private const int FILAS = 5;
    private const int COLUMNAS = 10;
    
    // Clase POO para encapsular la Salida del Proceso (similar a un DTO)
    private class ResultadosEstadisticos
    {
        public int[,] Matriz { get; set; }
        public int[] SumasFilaA { get; set; }    // Arreglo A
        public double[] PromediosFilaB { get; set; }  // Arreglo B
        public int[] SumasColumnaC { get; set; }    // Arreglo C
        public double[] PromediosColumnaD { get; set; }  // Arreglo D
    }

    // Proceso: Calcular suma y promedio por fila y columna.
    private static ResultadosEstadisticos CalcularEstadisticas()
    {
        Random rand = new Random();
        int[,] matriz = new int[FILAS, COLUMNAS];
        
        // Inicializar arreglos de salida
        int[] sumasFilaA = new int[FILAS];
        double[] promediosFilaB = new double[FILAS];
        int[] sumasColumnaC = new int[COLUMNAS];
        double[] promediosColumnaD = new double[COLUMNAS];

        // Llenado de la matriz con números aleatorios (1-9)
        // y cálculo de Suma y Promedio por Fila (A y B)
        for (int i = 0; i < FILAS; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < COLUMNAS; j++)
            {
                matriz[i, j] = rand.Next(1, 10);
                sumaFila += matriz[i, j];
            }
            sumasFilaA[i] = sumaFila;                  
            promediosFilaB[i] = (double)sumaFila / COLUMNAS;
        }

        // Cálculo de Suma y Promedio por Columna (C y D)
        for (int j = 0; j < COLUMNAS; j++)
        {
            int sumaColumna = 0;
            for (int i = 0; i < FILAS; i++)
            {
                sumaColumna += matriz[i, j];
            }
            sumasColumnaC[j] = sumaColumna;                     
            promediosColumnaD[j] = (double)sumaColumna / FILAS;
        }
        
        return new ResultadosEstadisticos {
            Matriz = matriz,
            SumasFilaA = sumasFilaA, PromediosFilaB = promediosFilaB,
            SumasColumnaC = sumasColumnaC, PromediosColumnaD = promediosColumnaD
        };
    }

    // ===== MÉTODOS AUXILIARES PARA EJERCICIO 6 =====
    private static readonly string[] NombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
    private static readonly string[] NombresDiasEj6 = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
    
    // Arreglo de datos (12 meses x 7 días) inicializado con la información del PDF
    private static int[,] datosVentas = {
        // L   M   Mi  J   V   S   D
        {  5, 10, 24, 55, 11, 15, 12 }, 
        { 16, 12, 40, 10, 18, 41, 50 }, 
        { 10, 78, 51, 35, 22, 81, 12 }, 
        { 12, 71, 10, 20, 70, 40, 60 }, 
        { 24, 28, 22, 50, 50, 50, 36 }, 
        { 40, 25, 40, 70, 40, 11, 20 }, 
        { 55, 20, 20, 20, 30, 12, 18 }, 
        { 10, 40, 32, 13, 16, 50,  3 }, 
        { 11, 24, 15, 82, 40, 46, 15 }, 
        { 18, 46, 22, 0, 0, 0, 0 },   // Se completan con 0s los datos faltantes
        { 15, 0, 0, 0, 0, 0, 0 }, 
        { 12, 0, 0, 0, 0, 0, 0 }  
    };
    
    // Clase POO para encapsular la Salida del Proceso
    private class ResultadosAnalisis
    {
        public int VentaMinima { get; set; }
        public string UbicacionMinima { get; set; }
        public int VentaMaxima { get; set; }
        public string UbicacionMaxima { get; set; }
        public long VentaTotal { get; set; }
        public int[] VentaPorDia { get; set; } // Arreglo para la suma por día
    }

    // Proceso: Analizar el arreglo de ventas
    private static ResultadosAnalisis AnalizarVentas()
    {
        // Inicializar con el primer elemento para asegurar que la ubicación inicial es correcta
        int ventaMinima = datosVentas[0, 0];
        string ubicacionMinima = $"{NombresMeses[0]} - {NombresDiasEj6[0]}";
        int ventaMaxima = datosVentas[0, 0];
        string ubicacionMaxima = $"{NombresMeses[0]} - {NombresDiasEj6[0]}";
        long ventaTotal = 0;
        int[] ventaPorDia = new int[NombresDiasEj6.Length]; 

        int numFilas = datosVentas.GetLength(0);
        int numColumnas = datosVentas.GetLength(1);

        for (int i = 0; i < numFilas; i++) // Filas = Meses
        {
            for (int j = 0; j < numColumnas; j++) // Columnas = Días
            {
                int ventaActual = datosVentas[i, j];
                ventaTotal += ventaActual;
                
                // Lógica de búsqueda de Max y Min
                if (ventaActual > ventaMaxima)
                {
                    ventaMaxima = ventaActual;
                    ubicacionMaxima = $"{NombresMeses[i]} - {NombresDiasEj6[j]}";
                }

                if (ventaActual < ventaMinima)
                {
                    ventaMinima = ventaActual;
                    ubicacionMinima = $"{NombresMeses[i]} - {NombresDiasEj6[j]}";
                }

                // Lógica de suma por columna (Venta por Día)
                ventaPorDia[j] += ventaActual;
            }
        }

        return new ResultadosAnalisis
        {
            VentaMinima = ventaMinima, UbicacionMinima = ubicacionMinima,
            VentaMaxima = ventaMaxima, UbicacionMaxima = ubicacionMaxima,
            VentaTotal = ventaTotal,
            VentaPorDia = ventaPorDia
        };
    }

    // ===== MÉTODOS UTILITARIOS GENERALES =====
    
    // Método para leer un entero, con manejo de excepciones (Try-Parse)
    private static int LeerEntero(string prompt, int minValue = 1)
    {
        int number;
        bool isValid = false;
        
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number >= minValue)
            {
                isValid = true;
            }
            else
            {
                // Mensaje adecuado de error por excepción de formato o dato faltante
                Console.WriteLine("🛑 Error: Introducir solo números enteros válidos. Dato faltante o incorrecto.");
                Console.WriteLine($"El valor debe ser al menos {minValue}.");
            }

        } while (!isValid);

        return number;
    }

    // Método genérico para imprimir una matriz
    private static void ImprimirMatriz<T>(T[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                // Formato limpio y alineado
                Console.Write($"{matrix[i, j],-8}");
            }
            Console.WriteLine();
        }
    }
}