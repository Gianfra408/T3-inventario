using System;

namespace inventario
{
    class Programa
    {
        const int MAX_PRODUCTOS = 100;

        static void Main(string[] args)
        {
            string[] codigos = new string[MAX_PRODUCTOS];
            string[] nombres = new string[MAX_PRODUCTOS];
            double[] precios = new double[MAX_PRODUCTOS];
            int[] cantidades = new int[MAX_PRODUCTOS];
            int cantidadProductos = 0;

            Console.WriteLine("Sistema de inventario de productos");
            Console.WriteLine("Capacidad maxima: " + MAX_PRODUCTOS + " productos");
        }
    }
}
