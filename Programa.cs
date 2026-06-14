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
            int opcion;

            do
            {
                Console.WriteLine("\n===== SISTEMA DE INVENTARIO =====");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Buscar producto por codigo");
                Console.WriteLine("4. Modificar producto");
                Console.WriteLine("5. Insertar producto");
                Console.WriteLine("6. Eliminar producto");
                Console.WriteLine("7. Ordenar productos por precio");
                Console.WriteLine("8. Mostrar resumen");
                Console.WriteLine("9. Salir");
                Console.Write("Seleccione una opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Registro de productos en desarrollo");
                        break;
                    case 2:
                        Console.WriteLine("Listado de productos en desarrollo");
                        break;
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Opcion en desarrollo");
                        break;
                    case 9:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opcion != 9);
        }
    }
}
