using System;

// Clase utilitaria para operaciones de consola y validación de entrada
public static class Utilities
{
    // Método para leer un entero, con manejo de excepciones (Try-Parse)
    public static int ReadInt(string prompt, int minValue = 1)
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
    public static void PrintMatrix<T>(T[,] matrix)
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