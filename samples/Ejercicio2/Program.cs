using System;

namespace Ejercicio2
{
    // Clase que se encargará de toda la lógica del Cuadrado Mágico
    public class CuadradoMagico
    {
        private int[,] _matriz;
        private int _n; // Dimensión del cuadrado (n x n)
        private int _constanteMagica;

        // Constructor que recibe la matriz a evaluar
        public CuadradoMagico(int[,] matriz)
        {
            _matriz = matriz;
            _n = matriz.GetLength(0); // Suponemos que es una matriz cuadrada
        }

        // Método principal que valida si es un cuadrado mágico
        public bool EsCuadradoMagico()
        {
            // Paso 1: Calcular la constante mágica a partir de la primera fila.
            // Si las filas no son iguales, esta verificación fallará más adelante.
            _constanteMagica = SumarFila(0);

            // Paso 2: Validar que todas las filas tengan la misma suma
            for (int i = 1; i < _n; i++)
            {
                if (SumarFila(i) != _constanteMagica)
                {
                    return false;
                }
            }

            // Paso 3: Validar que todas las columnas tengan la misma suma
            for (int j = 0; j < _n; j++)
            {
                if (SumarColumna(j) != _constanteMagica)
                {
                    return false;
                }
            }

            // Paso 4: Validar las diagonales
            if (SumarDiagonalPrincipal() != _constanteMagica || SumarDiagonalSecundaria() != _constanteMagica)
            {
                return false;
            }

            // Si pasa todas las validaciones, es un cuadrado mágico
            return true;
        }

        // Métodos privados para la lógica de suma
        private int SumarFila(int fila)
        {
            int suma = 0;
            for (int j = 0; j < _n; j++)
            {
                suma += _matriz[fila, j];
            }
            return suma;
        }

        private int SumarColumna(int columna)
        {
            int suma = 0;
            for (int i = 0; i < _n; i++)
            {
                suma += _matriz[i, columna];
            }
            return suma;
        }

        private int SumarDiagonalPrincipal()
        {
            int suma = 0;
            for (int i = 0; i < _n; i++)
            {
                suma += _matriz[i, i];
            }
            return suma;
        }

        private int SumarDiagonalSecundaria()
        {
            int suma = 0;
            for (int i = 0; i < _n; i++)
            {
                suma += _matriz[i, _n - 1 - i];
            }
            return suma;
        }

        // Método para obtener la constante mágica, si existe
        public int ObtenerConstanteMagica()
        {
            return _constanteMagica;
        }
    }

    // Clase principal para la interacción con el usuario
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Validador de Cuadrados Mágicos ---");
            Console.Write("Ingrese la dimensión del cuadrado (n): ");

            // El manejo de excepciones es un requisito, así que lo aplicamos aquí.
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: El valor ingresado no es un número entero. Saliendo del programa.");
                return;
            }

            int[,] matrizUsuario = new int[n, n];
            Console.WriteLine("Ingrese los valores de la matriz:");

            // Bucle para leer los valores de la matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    try
                    {
                        matrizUsuario[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: El valor ingresado no es un número entero. Saliendo del programa.");
                        return;
                    }
                }
            }

            // Creamos una instancia de la clase CuadradoMagico
            CuadradoMagico cuadrado = new CuadradoMagico(matrizUsuario);

            // Validamos y mostramos el resultado
            if (cuadrado.EsCuadradoMagico())
            {
                Console.WriteLine("\n¡La matriz es un CUADRADO MÁGICO!");
                Console.WriteLine($"La constante mágica es: {cuadrado.ObtenerConstanteMagica()}");
            }
            else
            {
                Console.WriteLine("\nLa matriz NO es un cuadrado mágico.");
            }

            Console.WriteLine("\n--- Fin del programa ---");
        }
    }
}