# T3 Inventario

Sistema de gestion de inventario desarrollado como aplicacion de consola en C#.

## Datos del proyecto

- Curso: Fundamentos de Algoritmos
- Evaluacion: T3 - Trabajo grupal
- Lenguaje: C#
- Rubro: Inventario de productos
- Estructura principal: arreglos unidimensionales paralelos

## Campos del producto

- Codigo
- Nombre
- Precio
- Stock

## Funcionalidades requeridas

1. Registrar productos.
2. Mostrar todos los productos.
3. Buscar producto por codigo.
4. Modificar los datos de un producto.
5. Insertar un producto en una posicion especifica.
6. Eliminar un producto.
7. Ordenar productos usando el metodo burbuja.
8. Mostrar resumen del inventario.
9. Salir del sistema.

## Estructura sugerida del codigo

- `Main`: controla el menu principal.
- `MostrarMenu`: muestra las opciones del sistema.
- `RegistrarProducto`: agrega productos al inventario.
- `MostrarProductos`: lista los productos registrados.
- `BuscarProductoPorCodigo`: consulta un producto por codigo.
- `ModificarProducto`: actualiza los datos de un producto.
- `InsertarProducto`: inserta un producto en una posicion indicada.
- `EliminarProducto`: elimina un producto del inventario.
- `OrdenarPorPrecioBurbuja`: ordena manualmente por precio.
- `MostrarResumen`: muestra totales, mayor precio, menor precio y suma total.

## Flujo de ramas

- `master`: version estable final.
- `develop`: integracion del trabajo del equipo.
- `feature/menu-registro-listado`: menu, registro y listado.
- `feature/busqueda-modificacion-validaciones`: busqueda, modificacion y validaciones.
- `feature/insercion-eliminacion-ordenamiento`: insercion, eliminacion, ordenamiento y resumen.

## Como ejecutar

```bash
dotnet run
```

## Declaracion requerida

Al final del archivo principal debe incluirse la declaracion indicada en la guia del trabajo.
