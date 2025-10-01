using System;

// Clase que encapsula los ejercicios 1, 2 y 3
public class EjerciciosUnoATres
{
    // Ejercicio 1: Contador de Ceros por Renglón
    public static void Ejercicio1()
    {
        Console.WriteLine("=== EJERCICIO 1: CONTADOR DE CEROS POR RENGLÓN ===\n");
        
        // Matriz predefinida del ejercicio original
        int[,] miArreglo = new int[,]
        {
            { 0, 2, 5, 7, 6 },
            { 0, 0, 0, 3, 8 },
            { 2, 9, 6, 3, 4 },
            { 1, 5, 6, 1, 4 },
            { 0, 9, 2, 5, 0 }
        };

        Console.WriteLine("Matriz a analizar:");
        MostrarMatriz(miArreglo);
        Console.WriteLine();

        // Lógica para contar ceros por renglón
        int numRenglones = miArreglo.GetLength(0);
        for (int i = 0; i < numRenglones; i++)
        {
            int cerosEnRenglon = 0;
            int numColumnas = miArreglo.GetLength(1);
            
            for (int j = 0; j < numColumnas; j++)
            {
                if (miArreglo[i, j] == 0)
                {
                    cerosEnRenglon++;
                }
            }
            
            Console.WriteLine($"El renglón {i + 1} tiene {cerosEnRenglon} cero(s).");
        }

        Console.WriteLine("\n=== FIN DEL EJERCICIO 1 ===");
    }

    // Ejercicio 2: Validador de Cuadrado Mágico
    public static void Ejercicio2()
    {
        Console.WriteLine("=== EJERCICIO 2: VALIDADOR DE CUADRADOS MÁGICOS ===\n");
        
        int n = 0;
        bool entradaValida = false;
        
        while (!entradaValida)
        {
            Console.Write("Ingrese la dimensión del cuadrado (n): ");
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Error: La dimensión debe ser un número positivo.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: El valor ingresado no es un número entero válido.");
            }
        }

        int[,] matrizUsuario = new int[n, n];
        Console.WriteLine("Ingrese los valores de la matriz:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                entradaValida = false;
                while (!entradaValida)
                {
                    Console.Write($"[{i},{j}]: ");
                    try
                    {
                        matrizUsuario[i, j] = int.Parse(Console.ReadLine());
                        entradaValida = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: El valor ingresado no es un número entero válido.");
                    }
                }
            }
        }

        // Validar si es cuadrado mágico
        bool esCuadradoMagico = ValidarCuadradoMagico(matrizUsuario, n, out int constanteMagica);

        if (esCuadradoMagico)
        {
            Console.WriteLine("\n¡La matriz es un CUADRADO MÁGICO!");
            Console.WriteLine($"La constante mágica es: {constanteMagica}");
        }
        else
        {
            Console.WriteLine("\nLa matriz NO es un cuadrado mágico.");
        }

        Console.WriteLine("\n=== FIN DEL EJERCICIO 2 ===");
    }

    // Ejercicio 3: Operaciones con Matrices 2x2
    public static void Ejercicio3()
    {
        Console.WriteLine("=== EJERCICIO 3: OPERACIONES CON MATRICES 2x2 ===\n");

        // Leer las dos matrices
        int[,] matriz1 = LeerMatriz("Matriz 1");
        int[,] matriz2 = LeerMatriz("Matriz 2");

        // Realizar operaciones
        SumarMatrices(matriz1, matriz2);
        RestarMatrices(matriz1, matriz2);
        MultiplicarMatrices(matriz1, matriz2);
        DividirMatrices(matriz1, matriz2);

        Console.WriteLine("\n=== FIN DEL EJERCICIO 3 ===");
    }

    // Métodos auxiliares para el Ejercicio 1
    private static void MostrarMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"{matriz[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    // Métodos auxiliares para el Ejercicio 2
    private static bool ValidarCuadradoMagico(int[,] matriz, int n, out int constanteMagica)
    {
        // Calcular constante mágica de la primera fila
        constanteMagica = 0;
        for (int j = 0; j < n; j++)
        {
            constanteMagica += matriz[0, j];
        }

        // Validar filas
        for (int i = 1; i < n; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < n; j++)
            {
                sumaFila += matriz[i, j];
            }
            if (sumaFila != constanteMagica) return false;
        }

        // Validar columnas
        for (int j = 0; j < n; j++)
        {
            int sumaColumna = 0;
            for (int i = 0; i < n; i++)
            {
                sumaColumna += matriz[i, j];
            }
            if (sumaColumna != constanteMagica) return false;
        }

        // Validar diagonal principal
        int sumaDiagonalPrincipal = 0;
        for (int i = 0; i < n; i++)
        {
            sumaDiagonalPrincipal += matriz[i, i];
        }
        if (sumaDiagonalPrincipal != constanteMagica) return false;

        // Validar diagonal secundaria
        int sumaDiagonalSecundaria = 0;
        for (int i = 0; i < n; i++)
        {
            sumaDiagonalSecundaria += matriz[i, n - 1 - i];
        }
        if (sumaDiagonalSecundaria != constanteMagica) return false;

        return true;
    }

    // Métodos auxiliares para el Ejercicio 3
    private static int[,] LeerMatriz(string nombreMatriz)
    {
        Console.WriteLine($"\nIngrese los valores para la {nombreMatriz} (2x2):");
        int[,] matriz = new int[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                bool entradaValida = false;
                while (!entradaValida)
                {
                    Console.Write($"[{i},{j}]: ");
                    try
                    {
                        matriz[i, j] = int.Parse(Console.ReadLine());
                        entradaValida = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número entero.");
                    }
                }
            }
        }
        return matriz;
    }

    private static void SumarMatrices(int[,] matriz1, int[,] matriz2)
    {
        Console.WriteLine("\n--- La suma de las matrices es: ---");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                int resultado = matriz1[i, j] + matriz2[i, j];
                Console.Write($"{resultado,-5}");
            }
            Console.WriteLine();
        }
    }

    private static void RestarMatrices(int[,] matriz1, int[,] matriz2)
    {
        Console.WriteLine("\n--- La resta de las matrices es: ---");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                int resultado = matriz1[i, j] - matriz2[i, j];
                Console.Write($"{resultado,-5}");
            }
            Console.WriteLine();
        }
    }

    private static void MultiplicarMatrices(int[,] matriz1, int[,] matriz2)
    {
        Console.WriteLine("\n--- El producto de las matrices es: ---");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                int resultado = matriz1[i, j] * matriz2[i, j];
                Console.Write($"{resultado,-5}");
            }
            Console.WriteLine();
        }
    }

    private static void DividirMatrices(int[,] matriz1, int[,] matriz2)
    {
        Console.WriteLine("\n--- La división de las matrices es: ---");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (matriz2[i, j] == 0)
                {
                    Console.Write("NaN  ");
                }
                else
                {
                    double resultado = (double)matriz1[i, j] / matriz2[i, j];
                    Console.Write($"{resultado,-5:F2}");
                }
            }
            Console.WriteLine();
        }
    }
}