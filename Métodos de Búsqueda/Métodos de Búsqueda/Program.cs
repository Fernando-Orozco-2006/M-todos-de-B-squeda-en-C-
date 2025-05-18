using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public static class Secuencial
{
    public static int Buscar(int[] arreglo, int objetivo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == objetivo)
                return i;
        }
        return -1;
    }
}

public static class Binaria
{
    public static int Buscar(int[] arreglo, int objetivo)
    {
        int izquierda = 0, derecha = arreglo.Length - 1;
        while (izquierda <= derecha)
        {
            int medio = (izquierda + derecha) / 2;
            if (arreglo[medio] == objetivo)
                return medio;
            else if (arreglo[medio] < objetivo)
                izquierda = medio + 1;
            else
                derecha = medio - 1;
        }
        return -1;
    }
}

public static class TransformacionClave
{
    public static Dictionary<int, int> CrearTablaHash(int[] arreglo)
    {
        var hashTable = new Dictionary<int, int>();
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (!hashTable.ContainsKey(arreglo[i]))
                hashTable[arreglo[i]] = i;
        }
        return hashTable;
    }

    public static int Buscar(Dictionary<int, int> tablaHash, int objetivo)
    {
        return tablaHash.TryGetValue(objetivo, out int indice) ? indice : -1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] tamaños = new int[] { 1000, 10000, 100000 };

        foreach (int n in tamaños)
        {
            Console.WriteLine($"\nTamaño del array: {n}");

            // Generar datos aleatorios
            var datos = Enumerable.Range(1, n).OrderBy(x => Guid.NewGuid()).ToArray();
            int objetivo = datos[n / 2]; // Elegimos un objetivo que sí existe

            // Búsqueda Secuencial
            var sw = Stopwatch.StartNew();
            Secuencial.Buscar(datos, objetivo);
            sw.Stop();
            Console.WriteLine($"Secuencial: {sw.ElapsedMilliseconds} ms");

            // Búsqueda Binaria (requiere ordenar el arreglo)
            Array.Sort(datos);
            sw.Restart();
            Binaria.Buscar(datos, objetivo);
            sw.Stop();
            Console.WriteLine($"Binaria: {sw.ElapsedMilliseconds} ms");

            // Búsqueda por Transformación de Clave (Hash)
            var tabla = TransformacionClave.CrearTablaHash(datos);
            sw.Restart();
            TransformacionClave.Buscar(tabla, objetivo);
            sw.Stop();
            Console.WriteLine($"Transformación de Clave (Hash): {sw.ElapsedMilliseconds} ms");
        }
    }
}
