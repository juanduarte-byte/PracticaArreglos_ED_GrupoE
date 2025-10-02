using System;
using System.Linq;

// Clase que encapsula los ejercicios 7, 8 y 9 (implementados por Alan)
public class EjerciciosSieteANueve
{
    // Ejercicio 7: Análisis de Calificaciones con POO
    public static void Ejercicio7()
    {
        AnalizadorCalificaciones analizador = new AnalizadorCalificaciones();
        analizador.ProcesarCalificaciones();
    }

    // Ejercicio 8: Lista de Compras con POO
    public static void Ejercicio8()
    {
        ListaCompras lista = new ListaCompras();
        lista.GestionarLista();
    }

    // Ejercicio 9: Contador de Números con POO
    public static void Ejercicio9()
    {
        ContadorNumeros contador = new ContadorNumeros();
        contador.ProcesarConteo();
    }
}

// PROGRAMACION ORIENTADA A OBJETOS: Aplicando ENCAPSULACION
public class AnalizadorCalificaciones
{
    // ENCAPSULACION: Atributos privados para proteger los datos
    private double[,] calificaciones;  // ARREGLO BIDIMENSIONAL: Matriz 12x3 con calificaciones
    private int numAlumnos;
    private int numParciales;
    
    // ENCAPSULACION: Constructor publico para inicializar los datos
    public AnalizadorCalificaciones()
    {
        // ARREGLO: Inicializacion de matriz bidimensional con datos predefinidos
        this.calificaciones = new double[,] {
            {5.5, 8.6, 10.0}, {8.0, 5.5, 10.0}, {9.0, 4.1, 7.8}, {10.0, 2.2, 8.1},
            {7.0, 9.2, 7.1}, {9.0, 4.0, 6.0}, {6.5, 5.0, 5.0}, {4.0, 7.0, 4.0},
            {8.0, 8.0, 9.0}, {10.0, 9.0, 9.2}, {5.0, 10.0, 8.4}, {9.0, 4.6, 7.5}
        };
        
        this.numAlumnos = this.calificaciones.GetLength(0);
        this.numParciales = this.calificaciones.GetLength(1);
    }
    
    // ENCAPSULACION: Metodo publico que expone la funcionalidad principal
    public void ProcesarCalificaciones()
    {
        Console.WriteLine("=== EJERCICIO 7: ANALISIS DE CALIFICACIONES ===\n");

        Console.WriteLine("a) Promedio de cada alumno:");
        double[] promedios = this.CalcularPromedios();  // ARREGLO: Array unidimensional de promedios
        for (int i = 0; i < numAlumnos; i++)
        {
            Console.WriteLine($"   Alumno {i + 1}: {promedios[i]:F2}");
        }

        double promedioMaximo = promedios.Max();
        int indiceMaximo = Array.IndexOf(promedios, promedioMaximo);
        Console.WriteLine($"\nb) Promedio mas alto: {promedioMaximo:F2} (Alumno {indiceMaximo + 1})");

        double promedioMinimo = promedios.Min();
        int indiceMinimo = Array.IndexOf(promedios, promedioMinimo);
        Console.WriteLine($"c) Promedio mas bajo: {promedioMinimo:F2} (Alumno {indiceMinimo + 1})");

        int parcialesReprobados = this.ContarParcialesReprobados();
        Console.WriteLine($"\nd) Parciales reprobados (< 7.0): {parcialesReprobados}");

        this.MostrarDistribucion(promedios);
        Console.WriteLine("\n=== FIN DEL EJERCICIO 7 ===");
    }
    
    // ENCAPSULACION: Metodos privados para ocultar la implementacion interna
    private double[] CalcularPromedios()
    {
        double[] promedios = new double[numAlumnos];  // ARREGLO: Array para almacenar promedios
        for (int i = 0; i < numAlumnos; i++)
        {
            double suma = 0;
            for (int j = 0; j < numParciales; j++)
            {
                suma += calificaciones[i, j];  // ARREGLO: Acceso a matriz bidimensional
            }
            promedios[i] = suma / numParciales;
        }
        return promedios;
    }
    
    private int ContarParcialesReprobados()
    {
        int contador = 0;
        for (int i = 0; i < numAlumnos; i++)
        {
            for (int j = 0; j < numParciales; j++)
            {
                if (calificaciones[i, j] < 7.0)  // ARREGLO: Recorrido de matriz
                {
                    contador++;
                }
            }
        }
        return contador;
    }
    
    private void MostrarDistribucion(double[] promedios)
    {
        Console.WriteLine("\ne) Distribucion de calificaciones finales:");
        
        int[] distribucion = new int[6];  // ARREGLO: Array para contar rangos de calificaciones
        string[] rangos = {"0.0 - 4.9", "5.0 - 5.9", "6.0 - 6.9", "7.0 - 7.9", "8.0 - 8.9", "9.0 - 10.0"};
        
        foreach (double promedio in promedios)  // ARREGLO: Recorrido del array de promedios
        {
            if (promedio < 5.0) distribucion[0]++;
            else if (promedio < 6.0) distribucion[1]++;
            else if (promedio < 7.0) distribucion[2]++;
            else if (promedio < 8.0) distribucion[3]++;
            else if (promedio < 9.0) distribucion[4]++;
            else distribucion[5]++;
        }

        for (int i = 0; i < distribucion.Length; i++)  // ARREGLO: Recorrido para mostrar resultados
        {
            Console.WriteLine($"   {rangos[i]}: {distribucion[i]} Alumnos");
        }
    }
}

// PROGRAMACION ORIENTADA A OBJETOS: Aplicando ENCAPSULACION
public class ListaCompras
{
    // ENCAPSULACION: Atributos privados para proteger los datos
    private string[] productos;     // ARREGLO UNIDIMENSIONAL: Array de cadenas para productos
    private int cantidadProductos;
    private int capacidadMaxima;

    // ENCAPSULACION: Constructor publico para inicializar
    public ListaCompras(int capacidad = 5)
    {
        this.capacidadMaxima = capacidad;
        this.productos = new string[capacidad];  // ARREGLO: Inicializacion del array
        this.cantidadProductos = 0;
    }

    // ENCAPSULACION: Metodo publico principal
    public void GestionarLista()
    {
        Console.WriteLine("=== EJERCICIO 8: LISTA DE COMPRAS ===\n");
        Console.WriteLine("Bienvenido a tu Lista de Compras");
        Console.WriteLine($"Puedes agregar hasta {capacidadMaxima} productos\n");

        this.AgregarProductos();
        this.MostrarLista();
        this.BuscarProducto();
        this.MostrarResumen();
        Console.WriteLine("\n=== FIN DEL EJERCICIO 8 ===");
    }

    // ENCAPSULACION: Metodos privados para ocultar implementacion
    private void AgregarProductos()
    {
        for (int i = 0; i < capacidadMaxima; i++)  // ARREGLO: Recorrido del array
        {
            Console.Write($"Ingresa el producto {i + 1}: ");
            string producto = Console.ReadLine();

            if (!string.IsNullOrEmpty(producto))
            {
                this.productos[i] = producto;  // ARREGLO: Asignacion en posicion especifica
                this.cantidadProductos++;
                Console.WriteLine("Producto agregado a la lista");
            }
            else
            {
                Console.WriteLine("Producto vacio, continuando...");
                break;
            }
            Console.WriteLine();
        }
    }

    private void MostrarLista()
    {
        Console.WriteLine("=== TU LISTA DE COMPRAS ===");
        if (cantidadProductos > 0)
        {
            for (int i = 0; i < cantidadProductos; i++)  // ARREGLO: Recorrido para mostrar
            {
                Console.WriteLine($"{i + 1}. {productos[i]}");  // ARREGLO: Acceso por indice
            }
        }
        else
        {
            Console.WriteLine("No hay productos en la lista");
        }
    }

    private void BuscarProducto()
    {
        Console.WriteLine("\nQuieres buscar un producto? (s/n): ");
        string respuesta = Console.ReadLine();

        if (!string.IsNullOrEmpty(respuesta) && (respuesta.ToLower() == "s" || respuesta.ToLower() == "si"))
        {
            Console.Write("Ingresa el producto a buscar: ");
            string productoBuscar = Console.ReadLine();

            if (!string.IsNullOrEmpty(productoBuscar))
            {
                int posicion = this.EncontrarProducto(productoBuscar);
                if (posicion != -1)
                {
                    Console.WriteLine($"Encontrado: {productos[posicion]} (posicion {posicion + 1})");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado en la lista");
                }
            }
        }
    }

    private int EncontrarProducto(string productoBuscar)
    {
        for (int i = 0; i < cantidadProductos; i++)  // ARREGLO: Busqueda secuencial en array
        {
            if (productos[i].ToLower() == productoBuscar.ToLower())  // ARREGLO: Comparacion de elementos
            {
                return i;
            }
        }
        return -1;
    }

    private void MostrarResumen()
    {
        Console.WriteLine($"\nTotal de productos en la lista: {cantidadProductos}");
    }
}

// PROGRAMACION ORIENTADA A OBJETOS: Aplicando ENCAPSULACION
public class ContadorNumeros
{
    // ENCAPSULACION: Atributo privado para proteger los datos
    private int[] numeros;  // ARREGLO UNIDIMENSIONAL: Array de enteros predefinidos

    // ENCAPSULACION: Constructor publico para inicializar
    public ContadorNumeros()
    {
        // ARREGLO: Inicializacion con datos predefinidos
        this.numeros = new int[] { 5, 3, 7, 3, 9, 3, 1, 3, 8, 3, 2, 3, 6, 3, 4 };
    }

    // ENCAPSULACION: Metodo publico principal
    public void ProcesarConteo()
    {
        Console.WriteLine("=== EJERCICIO 9: CONTADOR DE NUMEROS ===\n");

        Console.WriteLine("Lista de numeros:");
        this.MostrarArreglo();
        this.SolicitarYContarNumero();
        this.MostrarEstadisticas();
        Console.WriteLine("\n=== FIN DEL EJERCICIO 9 ===");
    }

    // ENCAPSULACION: Metodos privados para ocultar implementacion
    private void MostrarArreglo()
    {
        for (int i = 0; i < numeros.Length; i++)  // ARREGLO: Recorrido del array
        {
            Console.Write($"{numeros[i]} ");  // ARREGLO: Acceso por indice
        }
        Console.WriteLine();
    }

    private void SolicitarYContarNumero()
    {
        Console.Write("\nQue numero quieres contar? ");

        try
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error: Debes ingresar un numero valido");
                return;
            }

            int numeroBuscar = int.Parse(input);
            this.ContarYMostrarOcurrencias(numeroBuscar);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debes ingresar un numero valido");
        }
    }

    private void ContarYMostrarOcurrencias(int numeroBuscar)
    {
        int contador = this.ContarOcurrencias(numeroBuscar);
        Console.WriteLine($"\nEl numero {numeroBuscar} aparece {contador} veces en la lista");

        if (contador > 0)
        {
            Console.WriteLine("Posiciones donde aparece:");
            this.MostrarPosiciones(numeroBuscar);
        }
    }

    private int ContarOcurrencias(int numero)
    {
        int contador = 0;
        for (int i = 0; i < numeros.Length; i++)  // ARREGLO: Recorrido para contar
        {
            if (numeros[i] == numero)  // ARREGLO: Comparacion de elementos
            {
                contador++;
            }
        }
        return contador;
    }

    private void MostrarPosiciones(int numero)
    {
        for (int i = 0; i < numeros.Length; i++)  // ARREGLO: Busqueda de posiciones
        {
            if (numeros[i] == numero)  // ARREGLO: Comparacion para encontrar posiciones
            {
                Console.WriteLine($"  - Posicion {i + 1}");
            }
        }
    }

    private void MostrarEstadisticas()
    {
        Console.WriteLine("\n=== ESTADISTICAS ===");
        Console.WriteLine($"Total de numeros en la lista: {numeros.Length}");  // ARREGLO: Propiedad Length
        Console.WriteLine($"Numero mas frecuente: {this.EncontrarNumeroMasFrecuente()}");
        Console.WriteLine($"Numeros unicos en la lista: {this.ContarNumerosUnicos()}");
    }

    private int EncontrarNumeroMasFrecuente()
    {
        int numeroMasFrecuente = numeros[0];  // ARREGLO: Acceso al primer elemento
        int maxFrecuencia = 0;

        for (int i = 0; i < numeros.Length; i++)  // ARREGLO: Recorrido completo
        {
            int frecuencia = this.ContarOcurrencias(numeros[i]);  // ARREGLO: Acceso por indice

            if (frecuencia > maxFrecuencia)
            {
                maxFrecuencia = frecuencia;
                numeroMasFrecuente = numeros[i];
            }
        }
        return numeroMasFrecuente;
    }

    private int ContarNumerosUnicos()
    {
        int unicos = 0;

        for (int i = 0; i < numeros.Length; i++)  // ARREGLO: Recorrido principal
        {
            bool esUnico = true;
            for (int j = 0; j < i; j++)  // ARREGLO: Recorrido de verificacion
            {
                if (numeros[i] == numeros[j])  // ARREGLO: Comparacion de elementos
                {
                    esUnico = false;
                    break;
                }
            }

            if (esUnico)
            {
                unicos++;
            }
        }
        return unicos;
    }
}