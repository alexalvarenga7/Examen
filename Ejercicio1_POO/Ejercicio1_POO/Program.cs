using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_POO
{
    public class Empleado
    {
        public string Nombre { get; private set; }
        public string Identidad { get; private set; }
        public double Salario { get; private set; }

        public Empleado(string nombre, string identidad, double salario)
        {
            Nombre = nombre;
            Identidad = identidad;
            Salario = salario;
        }

        public abstract double CalcularSalario();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Nomina nomina = new Nomina();
            EmpAsalariado empleado1 = new EmpAsalariado("Alex Zelaya", "12345", 8000);
            EmpxHora empleado2 = new EmpxHora("Josue Alberto", "01234", 10,200);
            EmpxHora empleado3 = new EmpxHora("Carlos Valle", "23456", 15,250);

            nomina.AgregarEmpleado(empleado1);
            nomina.AgregarEmpleado(empleado2);
            nomina.AgregarEmpleado(empleado3);

            nomina.ImprimirDetalle();
            Console.WriteLine($"Total de la nómina: {nomina.TotalNomina()}");
            Console.ReadLine();
        }
    }

}
