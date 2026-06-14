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
                        if (cantidadProductos < MAX_PRODUCTOS)
                        {
                            Console.Write("Ingrese codigo del producto: ");
                            codigos[cantidadProductos] = Console.ReadLine();

                            while (codigos[cantidadProductos] == "")
                            {
                                Console.WriteLine("El codigo no puede estar vacio");
                                Console.Write("Ingrese codigo del producto: ");
                                codigos[cantidadProductos] = Console.ReadLine();
                            }

                            Console.Write("Ingrese nombre del producto: ");
                            nombres[cantidadProductos] = Console.ReadLine();

                            while (nombres[cantidadProductos] == "")
                            {
                                Console.WriteLine("El nombre no puede estar vacio");
                                Console.Write("Ingrese nombre del producto: ");
                                nombres[cantidadProductos] = Console.ReadLine();
                            }

                            Console.Write("Ingrese precio del producto: ");
                            precios[cantidadProductos] = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese cantidad del producto: ");
                            cantidades[cantidadProductos] = int.Parse(Console.ReadLine());

                            cantidadProductos++;
                            Console.WriteLine("Producto registrado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("No se pueden registrar mas productos");
                        }
                        break;
                    case 2:
                        if (cantidadProductos == 0)
                        {
                            Console.WriteLine("No hay productos registrados");
                        }
                        else
                        {
                            Console.WriteLine("\nListado de productos:");

                            for (int i = 0; i < cantidadProductos; i++)
                            {
                                Console.WriteLine("Producto " + (i + 1));
                                Console.WriteLine("Codigo: " + codigos[i]);
                                Console.WriteLine("Nombre: " + nombres[i]);
                                Console.WriteLine("Precio: " + precios[i]);
                                Console.WriteLine("Cantidad: " + cantidades[i]);
                                Console.WriteLine("------------------------");
                            }
                        }
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
