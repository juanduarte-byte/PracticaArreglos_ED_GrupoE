using System;

// Implementación de la lógica del Ejercicio 4
public static class Ejercicio4
{
    public static int[,] GenerarMatrizIdentidad(int n)
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
}