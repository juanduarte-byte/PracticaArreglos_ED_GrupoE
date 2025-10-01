# Práctica de Arreglos - Grupo E
## Estructura de Datos - 4to Cuatrimestre

### Descripción del Proyecto
Este repositorio contiene los **9 ejercicios completos** de práctica sobre arreglos y matrices implementados en C# por el **Grupo E**. El proyecto utiliza un menú principal interactivo que permite acceder a todos los ejercicios de manera organizada.

### Estado de los Ejercicios

#### ✅ **Todos los Ejercicios Completados**

**Ejercicios 1-3:**
- **Ejercicio 1**: Contador de Ceros por Renglón
- **Ejercicio 2**: Validador de Cuadrado Mágico  
- **Ejercicio 3**: Operaciones con Matrices 2x2

**Ejercicios 4-6:**
- **Ejercicio 4**: Generador de Matriz de Identidad
- **Ejercicio 5**: Estadísticas de Matriz 5x10 (suma y promedio por filas/columnas)
- **Ejercicio 6**: Análisis de Ventas Anuales (máximo, mínimo, totales por día)

**Ejercicios 7-9:**
- **Ejercicio 7**: Análisis de Calificaciones (12 alumnos, 3 parciales)
- **Ejercicio 8**: Lista de Compras (Arreglo de Cadenas)
- **Ejercicio 9**: Contador de Números (Arreglo de Enteros)

### Características del Sistema

🎯 **Menú Principal Interactivo**: Navegación fácil entre todos los ejercicios
🔄 **Arquitectura Modular**: Cada grupo de ejercicios está encapsulado en su propia clase
📝 **Código Organizado**: Estructura de carpetas clara y mantenible
✅ **Proyecto Completo**: Los 9 ejercicios implementados y funcionales
🛡️ **Manejo de Errores**: Validación robusta de entrada de usuario

### Cómo Ejecutar el Proyecto

```bash
# Opción 1: Compilar y ejecutar (Recomendado)
dotnet build PracticaArreglosGrupoE.csproj
dotnet run

# Opción 2: Usando el compilador de C#
csc *.cs src/*.cs
PracticaArreglosGrupoE.exe
```

### Estructura de Archivos

```
📁 PracticaArreglos_ED_GrupoE/
├── 📄 Program.cs                     # Menú principal del programa
├── 📄 PracticaArreglosGrupoE.csproj  # Archivo de proyecto .NET
├── 📄 README.md                      # Este archivo
├── 📄 .gitignore                     # Archivos a ignorar por Git
├── 📁 src/                           # Código fuente organizado
│   ├── 📄 EjerciciosUnoATres.cs      # Ejercicios 1, 2, 3 ✅
│   ├── 📄 EjerciciosCuatroASeis.cs   # Ejercicios 4, 5, 6 ✅
│   └── 📄 EjerciciosSieteANueve.cs   # Ejercicios 7, 8, 9 ✅
└── 📁 samples/                       # Versiones originales (referencia)
    ├── 📁 Ejercicio1/                # Versión original del ejercicio 1
    ├── 📁 Ejercicio2/                # Versión original del ejercicio 2
    └── 📁 Ejercicio3/                # Versión original del ejercicio 3
```

### Detalles de Implementación

#### **Ejercicios 1-3**: 
- Implementación con programación orientada a objetos
- Manejo robusto de excepciones
- Validación de entrada de usuario

#### **Ejercicios 4-6**: 
- Uso de matrices bidimensionales
- Análisis estadístico avanzado
- Procesamiento de datos estructurados
- Clases encapsuladas para resultados

#### **Ejercicios 7-9**: 
- Operaciones con arreglos de diferentes tipos
- Búsqueda y análisis de frecuencias
- Manejo de listas dinámicas

### Buenas Prácticas Implementadas

✅ **Organización Modular**: Código separado por responsabilidades
✅ **Nombres Descriptivos**: Clases y métodos con nombres claros
✅ **Documentación**: README completo con instrucciones
✅ **Control de Versiones**: .gitignore apropiado para proyectos .NET
✅ **Manejo de Errores**: Validación robusta de entrada de usuario
✅ **Interfaz Consistente**: Menú unificado para todos los ejercicios
✅ **Encapsulación**: Métodos auxiliares privados y clases internas
✅ **Reutilización**: Métodos utilitarios compartidos

### Flujo de Trabajo Git

- **Rama principal**: `main` - Código estable y completo
- **Ramas de desarrollo**: 
  - `Juan-ejercicios-1-3` - Ejercicios iniciales y estructura del proyecto
  - `Alan-ejercicios-7-9` - Ejercicios finales
  - `Angel-ejercicios-4-6` - Ejercicios intermedios
- **Pull Requests**: Para integrar cambios de manera controlada

---

### Instrucciones de Uso

1. Ejecuta el programa con `dotnet run`
2. Usa el menú numérico para seleccionar ejercicios (1-9)
3. Sigue las instrucciones específicas de cada ejercicio
4. Presiona Enter para volver al menú principal
5. Selecciona `0` para salir del programa

### Menú de Navegación

```
==========================================
             MENÚ PRINCIPAL
==========================================

  [1]  Contador de Ceros por Renglón
  [2]  Validador de Cuadrado Mágico
  [3]  Operaciones con Matrices 2x2
  [4]  Generador de Matriz de Identidad
  [5]  Estadísticas de Matriz 5x10
  [6]  Análisis de Ventas Anuales
  [7]  Análisis de Calificaciones
  [8]  Lista de Compras (Arreglo de Cadenas)
  [9]  Contador de Números (Arreglo de Enteros)

  [0]  Salir del programa
==========================================
```

**¡Proyecto completado exitosamente - Los 9 ejercicios están implementados y funcionales!** 🎓

---

### Colaboradores

Este proyecto es el resultado del trabajo colaborativo del **Grupo E**:
- **Juan**: Ejercicios 1, 2, 3 + Arquitectura del proyecto y menú principal
- **Angel**: Ejercicios 4, 5, 6 + Validaciones y análisis estadístico  
- **Alan**: Ejercicios 7, 8, 9 + Manejo de diferentes tipos de datos

### Licencia

Este proyecto es para fines educativos en el contexto de la asignatura de Estructura de Datos.