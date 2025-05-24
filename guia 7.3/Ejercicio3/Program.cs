namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;
            double numero,mayor,menor;


            Console.WriteLine("Ingrese el primer numero (-1 para salir)");
            numero=Convert.ToDouble(Console.ReadLine());

            contador = 0;
            mayor = 0;
            menor = 0;

            while (numero !=-1)  
            {
                
                if (numero< menor || contador==1 ) 
                {
                    menor = numero;
                }
                if (numero > mayor || contador == 0)
                {
                    mayor = numero;
                }
                contador++;
                Console.WriteLine("Ingrese el siguiente numero (-1 para salir )");
                numero = Convert.ToDouble(Console.ReadLine());

            }
            if (contador != 0)
            {
                Console.WriteLine($"El numero mayor es {mayor} y el numero menor es {menor} ");
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros ");
            }

        }
    }
}
