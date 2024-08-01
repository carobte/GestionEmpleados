using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo_Ejercicio_Empleados.Models
{
    public class Persona(string nombre, string apellido, string numeroIdentificacion, int edad)
    {
        public Guid Id {get;set;} = Guid.NewGuid();
        public string? Nombre {get;set;} = nombre;
        public string? Apellido {get;set;} = apellido;
        public string? NumeroIdenfiticacion {get;set;} = numeroIdentificacion;
        public int Edad {get;set;} = edad;

        public virtual void MostrarInfo(){
            Console.WriteLine($"________________________________________________");
            Console.WriteLine($"Persona: {Nombre} {Apellido},");
            Console.WriteLine($"Identificación: {NumeroIdenfiticacion},");
            Console.WriteLine($"Edad: {Edad},");                   
        }
    }
}