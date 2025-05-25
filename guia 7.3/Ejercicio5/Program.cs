namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int encuestados, opinion1,opinion2,opinion3,opinion;
            double porc1,porc2,porc3;
            Console.WriteLine("Ingrese la primera opinion");
            Console.WriteLine("0=positivo \n1=negativo \n2=indevviso \n-1=salir");
            opinion = Convert.ToInt32(Console.ReadLine());

            encuestados = 0;
            opinion1 = 0;
            opinion2 = 0;
            opinion3 = 0;

            while (opinion != -1)
            {
                switch (opinion)
                {
                    case 0:
                        opinion1++;

                        break;
                    case 1:
                        opinion2++;
                        break;
                    case 2:
                        opinion3++;
                        break;
                    default:
                        Console.WriteLine("Opinion no valida ");
                        break;
                }
                Console.WriteLine("Ingrese la siguiente opinion ");
                Console.WriteLine("0=positivo \n1=negativo \n2=indeciso \n-1=salir");
                opinion= Convert.ToInt32(Console.ReadLine());
                encuestados++;
            }
            if (encuestados!=0) 
            {
                porc1 = (opinion1/encuestados)*100;
                porc2 = (opinion2/encuestados)*100;
                porc3 = (opinion3/encuestados)*100;

                Console.WriteLine($"porcentajes deopinion: \npositivo%{porc1}\nnegativo{porc2}\nindeciso{porc3}");
            }
            else { Console.WriteLine("No hubo encuestados "); }


        }
    }
}
