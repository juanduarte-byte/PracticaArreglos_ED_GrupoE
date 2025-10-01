# PracticaArreglos_ED_GrupoE


# PracticaArreglos_1PED

## Descripción

Este repositorio contiene la implementación en **C#** de los **Ejercicios 4, 5 y 6** de la práctica de Estructura de Datos (Arreglos y Matrices), siguiendo un enfoque de Programación Orientada a Objetos (POO) y una arquitectura que separa la lógica del usuario.

### Estructura de Archivos

La solución está organizada para garantizar la legibilidad y la **separación de responsabilidades**:

* **`Program.cs`**: Archivo principal que implementa el **Menú de Opciones** y maneja la interacción con la consola (I/O).
* **`Logic/`**: Carpeta que contiene la lógica de negocio pura de cada ejercicio.
    * `Ejercicio4.cs` - Lógica de Matriz de Identidad.
    * `Ejercicio5.cs` - Lógica de Estadísticas de Matriz.
    * `Ejercicio6.cs` - Lógica de Análisis de Ventas.
* **`Utilities.cs`**: Clase esencial para la **validación de entradas numéricas** y el manejo de errores en la consola.

---

## Ejercicios Incluidos

### Ejercicio 4: Matriz de Identidad

**Objetivo:** Desarrollar una aplicación para llenar una matriz cuadrada con $1$'s en la diagonal principal y $0$'s en las demás posiciones.

**Funcionalidades:**
* Solicita al usuario el tamaño $N$ de la matriz.
* Genera y muestra la matriz de identidad $N \times N$.

### Ejercicio 5: Estadística de Matriz $5 \times 10$

**Objetivo:** Analizar una matriz de $5 \times 10$ llena con números aleatorios.

**Funcionalidades:**
* Genera la matriz y la llena con valores aleatorios.
* Calcula la **Suma y Promedio por cada fila** (almacenados en Arreglos A y B).
* Calcula la **Suma y Promedio por cada columna** (almacenados en Arreglos C y D).
* Imprime la matriz y todos los resultados de los arreglos.

### Ejercicio 6: Análisis de Ventas

**Objetivo:** Analizar una matriz predefinida de ventas (Meses vs. Días de la semana).

**Funcionalidades:**
* Identifica la **menor venta** realizada, especificando el mes y día.
* Identifica la **mayor venta** realizada, especificando el mes y día.
* Calcula la **Venta Total** acumulada.
* Calcula la **Venta por Día** (la suma de ventas para cada día de la semana).

---

## Cómo Ejecutar

La aplicación se ejecuta a través del archivo principal `Program.cs`, el cual presenta un menú de opciones para seleccionar cada ejercicio.

### Opción 1: Compilar y Ejecutar

Asegúrate de estar en el directorio raíz del proyecto (`C:\Users\angel\OneDrive\Desktop\Arreglos`).

```bash
dotnet build
dotnet run
