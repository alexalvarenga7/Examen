using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_POO
{
    public class EmpxHora : Empleado
    {
        private double TarifaPorHora { get; set; }
        private int HorasTrabajadas { get; set; }

        public EmpxHora(string nombre, string identidad, double tarifaPorHora, int horasTrabajadas) : base(nombre, identidad, 0)
        {
            TarifaPorHora = tarifaPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public override double CalcularSalario()
        {
            return TarifaPorHora * HorasTrabajadas;
        }
    }
}
