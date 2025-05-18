# M-todos-de-B-squeda-en-C-
Objetivo: Los alumnos implementarán distintos métodos de búsqueda en C# y los evaluarán en términos de eficiencia y aplicabilidad. Además, documentarán el proyecto en un repositorio de GitHub siguiendo buenas prácticas.

# La comparación de Métodos de Búsqueda en C#

En este proyecto, ayuda a implementar y comparar tres distintos algoritmos clásicos de búsqueda en estructuras de datos usando el lenguaje C#. 
Los métodos fueron evaluados en diferentes tamaños de datos para poder analizar su eficiencia y aplicabilidad en distintos contextos dados en sus datos.

---

## Introducción

Se implementaron los siguientes métodos de búsqueda:

- **Búsqueda Secuencial**: Ayuda a recorrer todos los elementos del arreglo uno a la vez, todo para encontrar el valor buscado. Es ineficiente  para grandes volúmenes de datos aun siendo tand simple.
- **Búsqueda Binaria**: Ayuda utilizar la estrategia de "divide y vencerás" para poder buscar en arreglos ordenados. Es más rápida que la búsqueda secuencial como resultado.
- **Transformación de Claves (Hashing)**: Usa una tabla hash para poder encontrar elementos en tiempo constante promedio. Lo que lo hace ideal para las búsquedas rápidas y múltiples.
---

## Instalación y Ejecución
1. Clona este repositorio:
   ```bash

2. Asegúrate de tener el SDK de .NET instalado (versión 6 o superior):
dotnet --version

3. Ejecuta el proyecto:
dotnet run

4. Explicación del Código
Busquedas
├── Secuencial.cs           # Implementación de búsqueda secuencial
├── Binaria.cs              # Implementación de búsqueda binaria
├── TransformacionClave.cs  # Implementación de tabla hash para búsqueda
Program.cs    

5. Análisis de Rendimiento
Tamaño	Secuencial	Binaria	Transformación de Clave
1,000	    0–1 ms	   <1 ms	          <1 ms
10,000	  2–5 ms	   <1 ms	          <1 ms
100,000	  15–30 ms  1–2 ms	          <1 ms

## En Conclución
- Las búsquedas secuencial son fáciles de implementar pero es ineficiente para arreglos grandes.
- Las búsquedas binaria son muy eficientes, pero solamente funciona en arreglos ordenados.
- Las transformaciones de claves (hash) son las más rápidas en promedio, pero se requiere usar más memoria.
