using System;

namespace Ejercicio3
{
    // Clase que contiene la lógica de las operaciones con matrices
    public class OperacionesMatriz
    {
        // Método que realiza la suma de dos matrices y la imprime
        public static void SumarMatrices(int[,] matriz1, int[,] matriz2)
        {
            Console.WriteLine("\n--- La suma de las matrices es: ---");
            int[,] resultado = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write($"{resultado[i, j],-5}");
                }
                Console.WriteLine();
            }
        }

        // Método que realiza la resta de dos matrices y la imprime
        public static void RestarMatrices(int[,] matriz1, int[,] matriz2)
        {
            Console.WriteLine("\n--- La resta de las matrices es: ---");
            int[,] resultado = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultado[i, j] = matriz1[i, j] - matriz2[i, j];
                    Console.Write($"{resultado[i, j],-5}");
                }
                Console.WriteLine();
            }
        }

        // Método que realiza la multiplicación de dos matrices (producto simple) y la imprime
        public static void MultiplicarMatrices(int[,] matriz1, int[,] matriz2)
        {
            Console.WriteLine("\n--- El producto de las matrices es: ---");
            int[,] resultado = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultado[i, j] = matriz1[i, j] * matriz2[i, j];
                    Console.Write($"{resultado[i, j],-5}");
                }
                Console.WriteLine();
            }
        }

        // Método que realiza la división de dos matrices y la imprime
        public static void DividirMatrices(int[,] matriz1, int[,] matriz2)
        {
            Console.WriteLine("\n--- La división de las matrices es: ---");
            // Usamos 'double' para la división para evitar la pérdida de decimales
            double[,] resultado = new double[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    // Manejo de excepciones para evitar la división por cero
                    if (matriz2[i, j] == 0)
                    {
                        Console.Write("NaN  "); // Not a Number
                    }
                    else
                    {
                        // Realizamos el 'casting' para asegurar la división decimal
                        resultado[i, j] = (double)matriz1[i, j] / matriz2[i, j];
                        Console.Write($"{resultado[i, j],-5:F2}"); // Formato con 2 decimales
                    }
                }
                Console.WriteLine();
            }
        }
    }

    // Clase principal para la interacción con el usuario y la ejecución
    class Program
    {
        // Método auxiliar para leer los valores de una matriz desde la consola
        public static int[,] LeerMatriz(string nombreMatriz)
        {
            Console.WriteLine($"\nIngrese los valores para la {nombreMatriz} (2x2):");
            int[,] matriz = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    try
                    {
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Entrada no válida. Saliendo del programa.");
                        Environment.Exit(1);
                    }
                }
            }
            return matriz;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Operaciones con Matrices ---");

            // Leemos las dos matrices que el usuario va a ingresar
            int[,] matriz1 = LeerMatriz("Matriz 1");
            int[,] matriz2 = LeerMatriz("Matriz 2");

            // Llamamos a los métodos de la clase 'OperacionesMatriz' para realizar y mostrar los resultados
            OperacionesMatriz.SumarMatrices(matriz1, matriz2);
            OperacionesMatriz.RestarMatrices(matriz1, matriz2);
            OperacionesMatriz.MultiplicarMatrices(matriz1, matriz2);
            OperacionesMatriz.DividirMatrices(matriz1, matriz2);

            Console.WriteLine("\n--- Fin del programa ---");
        }
    }
}