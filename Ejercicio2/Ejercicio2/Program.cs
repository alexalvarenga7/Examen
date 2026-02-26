using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el dividendo (entero): ");
                int dividendo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el divisor (entero): ");
                int divisor = int.Parse(Console.ReadLine());

                int resultado = dividendo / divisor;
                Console.WriteLine($"Resultado: {resultado}");

                File.WriteAllText("resultado.txt", $"Resultado: {resultado}");
                Console.WriteLine("El resultado se guardó en resultado.txt");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar números enteros.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: No tienes permisos para escribir el archivo.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de archivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operación finalizada.");
                Console.ReadLine();
            }
        }
    }

}
