using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_POO
{
    public class Nomina
    {
        private List<Empleado> Empleados { get; set; }

        public Nomina()
        {
            Empleados = new List<Empleado>();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            if (empleado != null)
            {
                Empleados.Add(empleado);
            }
        }

        public double TotalNomina()
        {
            double total = 0;
            foreach (Empleado empleado in Empleados)
            {
                total += empleado.CalcularSalario;
            }
            return total;
        }

        public void ImprimirDetalle()
        {
            foreach (Empleado empleado in Empleados)
            {
                Console.WriteLine($"{empleado.Nombre} - {empleado.GetType().Name} - {empleado.CalcularSalario}");
            }
        }
    }
}
