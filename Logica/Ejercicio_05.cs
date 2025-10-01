using System;

// Implementación de la lógica del Ejercicio 5
public static class Ejercicio5
{
    private const int FILAS = 5;
    private const int COLUMNAS = 10;
    
    // Clase POO para encapsular la Salida del Proceso (similar a un DTO)
    public class ResultadosEstadisticos
    {
        public int[,] Matriz { get; set; }
        public int[] SumasFilaA { get; set; }    // Arreglo A
        public double[] PromediosFilaB { get; set; }  // Arreglo B
        public int[] SumasColumnaC { get; set; }    // Arreglo C
        public double[] PromediosColumnaD { get; set; }  // Arreglo D
    }

    // Proceso: Calcular suma y promedio por fila y columna.
    public static ResultadosEstadisticos CalcularEstadisticas()
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
}