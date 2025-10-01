using System;

// Implementación de la lógica del Ejercicio 6
public static class Ejercicio6
{
    private static readonly string[] NombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
    private static readonly string[] NombresDias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
    
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
    public class ResultadosAnalisis
    {
        public int VentaMinima { get; set; }
        public string UbicacionMinima { get; set; }
        public int VentaMaxima { get; set; }
        public string UbicacionMaxima { get; set; }
        public long VentaTotal { get; set; }
        public int[] VentaPorDia { get; set; } // Arreglo para la suma por día
    }

    // Proceso: Analizar el arreglo de ventas
    public static ResultadosAnalisis AnalizarVentas()
    {
        // Inicializar con el primer elemento para asegurar que la ubicación inicial es correcta
        int ventaMinima = datosVentas[0, 0];
        string ubicacionMinima = $"{NombresMeses[0]} - {NombresDias[0]}";
        int ventaMaxima = datosVentas[0, 0];
        string ubicacionMaxima = $"{NombresMeses[0]} - {NombresDias[0]}";
        long ventaTotal = 0;
        int[] ventaPorDia = new int[NombresDias.Length]; 

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
                    ubicacionMaxima = $"{NombresMeses[i]} - {NombresDias[j]}";
                }

                if (ventaActual < ventaMinima)
                {
                    ventaMinima = ventaActual;
                    ubicacionMinima = $"{NombresMeses[i]} - {NombresDias[j]}";
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
}