using System.Security.AccessControl;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero, acumulador,prom;
            int contador;

            contador = 0;
            acumulador = 0;

            Console.WriteLine("Ingrese un numero (-1 para salir )");
            numero = Convert.ToDouble(Console.ReadLine());

            while (numero != -1)
            {
                contador++;
                acumulador = acumulador + numero;
                numero=Convert.ToDouble(Console.ReadLine());
            }

            if (contador != 0)
            {
                prom = acumulador / contador;
                Console.WriteLine($"El promedio es {prom}");
            }
            else
            { Console.WriteLine("No se ingresaron numeros "); }

        }
    }
}

