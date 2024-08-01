using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo_Ejercicio_Empleados.Models
{
    public class Empleado(string nombre, string apellido, string numeroIdentificacion, int edad, string cargo, decimal salario) : Persona(nombre, apellido, numeroIdentificacion, edad)
    {
        public string? Cargo { get; set; } = cargo;
        public decimal Salario { get; set; } = salario;

        private decimal CalcularBonificacion(){
            var bonificacion = Salario * Convert.ToDecimal(0.10);
            return bonificacion + Salario;
        }

        public override void MostrarInfo(){
            base.MostrarInfo();
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario base: {Salario},");
            Console.WriteLine($"Salario con tu bonificación del 10%: {CalcularBonificacion()}");
            Console.WriteLine("________________________________________________");
        }
    }
}