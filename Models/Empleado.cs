using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo_Ejercicio_Empleados.Models
{
    public class Empleado(string nombre, string apellido, string numeroIdentificacion, byte edad, string cargo, double salario)
    {
        public Guid Id {get;set;} = Guid.NewGuid();
        public string? Nombre {get;set;} = nombre;
        public string? Apellido {get;set;} = apellido;
        public string? NumeroIdenfiticacion {get;set;} = numeroIdentificacion;
        public byte Edad {get;set;} = edad;
        public string? Cargo {get;set;} = cargo;
        public double Salario {get;set;} = salario;

        private double CalcularBonificacion(){
            var bonificacion = Salario * 0.01;
            return bonificacion + Salario;
        }

        public void MostrarInfo(){
            Console.WriteLine(@$"
            ________________________________________________
            Empleado: {Nombre} {Apellido},
            Identificación: {NumeroIdenfiticacion},
            Edad: {Edad},
            Cargo: {Cargo},
            Salario base: {Salario}, 
            Salario con tu bonificación del 10%: {CalcularBonificacion()}
            ________________________________________________
            ");
        }
    }
}