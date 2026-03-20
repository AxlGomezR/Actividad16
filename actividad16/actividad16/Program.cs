Dictionary<int,Producto > productos = new Dictionary<int,Producto>();
bool continuar;
int opcion;
do
{
    Console.WriteLine("Bienvenido, seleccione una opción");
    Console.WriteLine("1) Agregar producto");
    Console.WriteLine("2) Modificar producto");
    Console.WriteLine("3) Eliminar producto");
    Console.WriteLine("4) Buscar producto");
    Console.WriteLine("5) Mostrar todos los productos");
    Console.WriteLine("6) Salir");
    continuar = int.TryParse(Console.ReadLine(), out opcion);
} while (opcion!=6);
class Producto
{
    public string nombre;
    public double precio;
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre del producto: {nombre}");
        Console.WriteLine($"Precio: {precio}\n");
    }
}