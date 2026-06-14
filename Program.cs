using System;
namespace inventario
{
    class Program
    {
        static void Main(string[] args)
        {
          //Inventario de productos
         string[] productos = new string[5];
        productos[0] = "Camiseta";
        productos[1] = "Pantalón";
        productos[2] = "Zapatos";
        productos[3] = "Gorra";
        productos[4] = "Bolsa";
        Console.WriteLine("Inventario de Productos:");
        for (int i = 0; i < productos.Length; i++)
        {
            Console.WriteLine(productos[i]);
        }

    }
}
}