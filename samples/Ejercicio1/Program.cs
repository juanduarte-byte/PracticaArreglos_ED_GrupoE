using System;

// Definimos el namespace de nuestro proyecto
namespace Ejercicio1
{
    // Esta clase contendrá la lógica principal para contar los ceros
    public class ContadorDeCeros
    {
        // Declara la matriz de números como un campo de la clase.
        // Es un arreglo bidimensional, indicado por las comas.
        private int[,] _arregloDeNumeros;

        // El constructor recibe la matriz de datos cuando se crea el objeto
        public ContadorDeCeros(int[,] arreglo)
        {
            _arregloDeNumeros = arreglo;
        }

        // Este método público realizará la lógica para contar los ceros por renglón
        public void ContarCerosPorRenglon()
        {
            // El método GetLength(0) nos da el número de renglones (filas) de la matriz.
            int numRenglones = _arregloDeNumeros.GetLength(0);

            // Usamos un ciclo 'for' para recorrer cada renglón de la matriz.
            for (int i = 0; i < numRenglones; i++)
            {
                // Inicializamos un contador para los ceros de cada renglón.
                int cerosEnRenglon = 0;

                // El método GetLength(1) nos da el número de columnas de la matriz.
                int numColumnas = _arregloDeNumeros.GetLength(1);

                // Usamos un segundo ciclo 'for' anidado para recorrer cada columna del renglón actual.
                for (int j = 0; j < numColumnas; j++)
                {
                    // Si el elemento en la posición actual es igual a cero, incrementamos el contador.
                    if (_arregloDeNumeros[i, j] == 0)
                    {
                        cerosEnRenglon++;
                    }
                }
                
                // Al terminar de recorrer el renglón, imprimimos el resultado.
                Console.WriteLine($"El renglón {i + 1} tiene {cerosEnRenglon} cero(s).");
            }
        }
    }

    // Esta es la clase principal del programa, donde se inicia la ejecución
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Contador de Ceros por Renglón ---");
            
            // Creamos la matriz con los datos del ejercicio.
            // Los arreglos bidimensionales se inicializan con { { }, { } }.
            int[,] miArreglo = new int[,]
            {
                { 0, 2, 5, 7, 6 },
                { 0, 0, 0, 3, 8 },
                { 2, 9, 6, 3, 4 },
                { 1, 5, 6, 1, 4 },
                { 0, 9, 2, 5, 0 }
            };

            // Creamos una instancia de nuestra clase `ContadorDeCeros`,
            // pasándole la matriz como argumento.
            ContadorDeCeros contador = new ContadorDeCeros(miArreglo);

            // Llamamos al método que realiza la lógica.
            contador.ContarCerosPorRenglon();

            Console.WriteLine("\n--- Fin del programa ---");
        }
    }
}