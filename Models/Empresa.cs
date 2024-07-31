using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo_Ejercicio_Empleados.Models
{
    public class Empresa(string nombre, string direccion)
    {
        public string? Nombre { get; set; } = nombre;
        public string? Direccion { get; set; } = direccion;
        public List<Empleado> ListaEmpleados { get; set; } = new List<Empleado>();

        public void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
            Console.WriteLine($"El empleado {empleado.Nombre} fue agregado satisfactoriamente");
        }

        public Empleado PedirDatos()
        {
            Console.WriteLine($"Escribe el nombre del empleado: ");
            var nombre = Console.ReadLine();

            Console.WriteLine($"Escribe el apellido del empleado: ");
            var apellido = Console.ReadLine();

            Console.WriteLine($"Escribe el número de identificación del empleado: ");
            var numeroIdentificacion = Console.ReadLine();

            Console.WriteLine($"Escribe la edad del empleado: ");
            var edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Escribe el cargo del empleado: ");
            var cargo = Console.ReadLine();

            Console.WriteLine($"Escribe el salario del empleado: ");
            var salario = Convert.ToDouble(Console.ReadLine());
            return new Empleado(nombre, apellido, numeroIdentificacion, edad, cargo, salario);
        }

        public void EliminarEmpleado(string nombre, string apellido)
        {
            var empleado = ListaEmpleados.Find(empleado => empleado.Nombre == nombre && empleado.Apellido == apellido);

            if (empleado != null)
            {
                Console.WriteLine($"¿Está seguro que desea eliminar al empleado {empleado.Nombre} {empleado.Apellido} ? (si, no)");

                var opcion = Console.ReadLine().ToLower();

                if (!string.IsNullOrEmpty(opcion) && opcion == "si")
                {
                    ListaEmpleados.Remove(empleado);
                    Console.WriteLine($"El empleado {empleado.Nombre} {empleado.Apellido} fue eliminado");
                }
            }
            else
            {
                Console.WriteLine($"No fue posible eliminar a {nombre} {apellido}, intente nuevamente");
            }
        }

        public void MostrarEmpleados(List<Empleado> listaEmpleados)
        {
            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarInfo();
            }
        }

        public void ActualizarEmpleado(string numeroIdentificacion)
        {
            var empleado = ListaEmpleados.Find(empleado => empleado.NumeroIdenfiticacion == numeroIdentificacion);
            if (empleado != null)
            {
                var bandera = true;
                while (bandera)
                {
                    Console.WriteLine($"¿Qué información deseas editar?");
                    Console.WriteLine("1. Nombre");
                    Console.WriteLine("2. Apellido");
                    Console.WriteLine("3. Número documento");
                    Console.WriteLine("4. Edad");
                    Console.WriteLine("5. Cargo");
                    Console.WriteLine("6. Salario");
                    Console.WriteLine("0. Salir");

                    var opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "0":
                            bandera = false;
                            break;
                        case "1":
                            Console.WriteLine("Escribe el nuevo nombre: ");
                            var nombreNuevo = Console.ReadLine();
                            empleado.Nombre = nombreNuevo;
                            Console.WriteLine("El nombre fue editado satisfactoriamente");
                            PausarMenu();
                            break;
                        case "2":
                            Console.WriteLine("Escribe el nuevo apellido: ");
                            var apellidoNuevo = Console.ReadLine();
                            empleado.Apellido = apellidoNuevo;
                            Console.WriteLine("El apellido fue editado satisfactoriamente");
                            PausarMenu();
                            break;
                        case "3":
                            Console.WriteLine("Escribe el nuevo número de documento: ");
                            var numeroNuevo = Console.ReadLine();
                            empleado.NumeroIdenfiticacion = numeroNuevo;
                            Console.WriteLine("El número de documento fue editado satisfactoriamente");
                            PausarMenu();
                            break;
                        case "4":
                            Console.WriteLine("Escribe la nueva edad: ");
                            var edadNueva = Convert.ToByte(Console.ReadLine());
                            empleado.Edad = edadNueva;
                            Console.WriteLine("La edad fue editada satisfactoriamente");
                            PausarMenu();
                            break;
                        case "5":
                            Console.WriteLine("Escribe la nueva edad: ");
                            var cargoNuevo = Console.ReadLine();
                            empleado.Cargo = cargoNuevo;
                            Console.WriteLine("El cargo fue editada satisfactoriamente");
                            PausarMenu();
                            break;
                        case "6":
                            Console.WriteLine("Escribe la nueva edad: ");
                            var salarioNuevo = Convert.ToDouble(Console.ReadLine());
                            empleado.Salario = salarioNuevo;
                            Console.WriteLine("La edad fue editada satisfactoriamente");
                            PausarMenu();
                            break;
                        default:
                            Console.WriteLine("Opción invalida, intenta nuevamente");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Empleado no encontrado, intenta de nuevo");
            }
        }

        public void BuscarEmpleado(string numeroIdentificacion)
        {
            var empleado = ListaEmpleados.Find(empleado => empleado.NumeroIdenfiticacion == numeroIdentificacion);
            if (empleado != null)
            {
                Console.WriteLine($"El empleado identificado con {numeroIdentificacion}");
                empleado.MostrarInfo();
            }
            else
            {
                Console.WriteLine("Empleado no encontrado, intenta de nuevo");
            }
        }

        public void BuscarPorCargo(string cargo)
        {
            var empleadosCargo = ListaEmpleados.Where(empleado => empleado.Cargo == cargo).ToList();
            Console.WriteLine($"Los empleados con cargo {cargo}: ");
            MostrarEmpleados(empleadosCargo);
        }

        public void PausarMenu()
        {
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}