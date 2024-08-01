
using Poo_Ejercicio_Empleados.Models;


// Datos quemados
var empresa = new Empresa("Carites", "De moda outlet");
empresa.AgregarEmpleado(new Empleado("caro", "bte", "123", 27, "supervisor", 5000000)); 
empresa.AgregarEmpleado(new Empleado("cami", "c", "456", 26, "supervisor", 5000000)); 
empresa.AgregarEmpleado(new Empleado("cami", "b", "789", 25, "vendedor", 3000000)); 
empresa.AgregarEmpleado(new Empleado("val", "p", "012", 27, "asesor", 2000000)); 

void Menu()
{
    var bandera = true;
    while (bandera)
    {
        Console.WriteLine("Selecciona una opción:");
        Console.WriteLine("1. Crear un nuevo Empleado");
        Console.WriteLine("2. Mostrar todos los Empleados");
        Console.WriteLine("3. Actualizar un Empleado");
        Console.WriteLine("4. Eliminar un Empleado");
        Console.WriteLine("5. Buscar Empleado por número de identificación");
        Console.WriteLine("6. Buscar Empleados por cargo");
        Console.WriteLine("0. Salir");

        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "0":
            bandera = false;
            break;

            case "1":
            empresa.AgregarEmpleado(empresa.PedirDatos());
            empresa.PausarMenu();
            break;

            case "2":
            empresa.MostrarEmpleados(empresa.ListaEmpleados);
            empresa.PausarMenu();
            break;
            
            case "3":
            Console.WriteLine("Ingresa el número de documento del empleado a actualizar: ");
            empresa.ActualizarEmpleado(Console.ReadLine());
            break;
          
            case "4":
            Console.WriteLine("Escribe el nombre del empleado a eliminar");
            var nombre = Console.ReadLine();
            Console.WriteLine("Escribe el apellido del empleado a eliminar");
            var apellido = Console.ReadLine();
            empresa.EliminarEmpleado(nombre, apellido);
            empresa.PausarMenu();
            break;
 
            case "5":
            Console.WriteLine("Escribe el número de documento del empleado");
            empresa.BuscarEmpleado(Console.ReadLine());
            break;
                        
            case "6":
            Console.WriteLine("Escribe el cargo");
            empresa.BuscarPorCargo(Console.ReadLine());
            break;

            default:
            Console.WriteLine("Opción invalida, intente nuevamente");
            break;
        }
    }
}

Menu();
