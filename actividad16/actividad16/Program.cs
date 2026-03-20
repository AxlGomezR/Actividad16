Dictionary<int,Producto > productos = new Dictionary<int,Producto>();
bool continuar;
int opcion, codigo;
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
    Console.Clear();
    if (continuar && (opcion>=1 && opcion<=6))
    {
        switch (opcion)
        {
            case 1:
                
                do
                {
                    Console.WriteLine("Ingrese el código del producto");
                    continuar= int.TryParse(Console.ReadLine(), out codigo);
                    if (continuar)
                    {
                        if (productos.ContainsKey(codigo))
                        {
                            Console.Clear();
                            Console.WriteLine("El codigo ingresado ya existe");
                        }
                        else
                        {
                            Producto p = new Producto();
                            Console.WriteLine("Ingrese el nombre del producto");
                            p.nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio del producto");
                            continuar = double.TryParse(Console.ReadLine(), out p.precio);
                            if(continuar && p.precio > 0)
                            {
                                Console.Clear();
                                productos.Add(codigo, p);
                                Console.WriteLine("El producto se ha agregado correctamente");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Asegurese de ingresar un precio válido");
                                continuar = false;
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Asegurese de ingresar solo números enteros");
                    }
                } while (continuar==false);
                break;
            case 2:
                Console.Clear();
                if (productos.Count == 0)
                {
                    Console.WriteLine("No se ha ingresado ningún producto");
                }
                else
                {
                    do
                    {
                        int verificar;
                        Console.WriteLine("Ingrese el código del producto que desea modificar");
                        continuar = int.TryParse(Console.ReadLine(), out verificar);
                        if (continuar)
                        {
                            if (productos.ContainsKey(verificar))
                            {
                                Producto p = new Producto();
                                Console.WriteLine("Ingrese el nuevo nombre del producto");
                                p.nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el nuevo precio");
                                continuar=double.TryParse(Console.ReadLine() , out p.precio);
                                if (continuar && p.precio > 0)
                                {
                                    
                                }
                                else
                                {
                                    Console.WriteLine("El precio ingresado no es válido");
                                }
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Aegurese de ingresar un código válido");
                        }
                    } while (continuar==false);
                }
                break;
        }
    }
    else
    {
        Console.WriteLine("Opción ingresada inválida");
    }
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