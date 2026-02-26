using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_POO
{
    public class EmpAsalariado : Empleado
    {
        private double SalarioMensual { get; set; }

        public EmpAsalariado(string nombre, string identidad, double salarioMensual) : base(nombre, identidad, salarioMensual)
        {
            SalarioMensual = salarioMensual;
        }

        public override double CalcularSalario()
        {
            return SalarioMensual;
        }
    }
}
