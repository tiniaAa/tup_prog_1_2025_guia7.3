namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double acumulador, num,prom;
            int contador;

            acumulador = 0;
            contador = 0;
            

            for (int i=1; i <=20 ;i++)
            {
                Console.WriteLine("Ingrese el numero ");
                num = Convert.ToDouble(Console.ReadLine());

                acumulador = acumulador + num;
                contador++;
            }
            prom = acumulador / contador;

            Console.WriteLine($"El promedio es {prom}");


        }
    }
}
