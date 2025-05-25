namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, e, grup_mayor_prom, grup_menor_prom, val, tot_valores;
            double prom_men, prom_may, prom;

            prom_may = 0;
            prom_men = 0;
            
            grup_mayor_prom = 0;
            grup_menor_prom = 0;

            for (i = 1; i <= 4; i++)
            {
                tot_valores = 0;
                for (e = 1; e <= 6; e++)
                {
                    Console.WriteLine($"Ingrese el valor {e} del grupo {i}");
                    
                    val = Convert.ToInt32(Console.ReadLine());

                    tot_valores = tot_valores + val;

                }
                prom = tot_valores / 6;

                if (prom < prom_men || i == 1)
                {
                    prom_men = prom;
                    grup_menor_prom = i;
                }
                if (prom < prom_may  || i == 1)
                {
                    prom_may = prom;
                    grup_mayor_prom = i;
                }

            }
            Console.WriteLine($" Grupo con mayor promedio {grup_mayor_prom} con promedio de:{prom_may}\nGrupo con menor promedio {grup_menor_prom} con promedio de {prom_men}");


        }
    }
}
