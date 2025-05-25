namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n_ventas, rub1_compras, rub2_compras, rub3_compras, rub4_compras, rub5_compras, cant_compra, Rubr, res, mayor_compra;
            double Rubro1, Rubro2, Rubro3, Rubro4, Rubro5, mont_comp, rec_tot, porc1, porc2, porc3, porc4, porc5, m_mayor_compra;
            bool seguir;

            n_ventas = 0;

            Rubro1 = 1930;
            Rubro2 = 340;
            Rubro3 = 330;
            Rubro4 = 990;
            Rubro5 = 10;

            rub1_compras = 0;
            rub2_compras = 0;
            rub3_compras = 0;
            rub4_compras = 0;
            rub5_compras = 0;

            rec_tot = 0;

            mayor_compra = 0;
            m_mayor_compra = 0;

            seguir = true;
            Console.WriteLine("Desea realizar una compra 1=si 2=no");
            res=Convert.ToInt32(Console.ReadLine());

            if (res==1) 
            {
                do
                {
                    n_ventas++;

                    Console.WriteLine("Que rubro quiere comprar?\n1=Rubro 1\n2=Rubro 2\n3=Rubro 3\n4=Rubro 4\n5=Rubro5");
                    Rubr = Convert.ToInt32(Console.ReadLine());

                    switch (Rubr) 
                    {
                        case 1:
                            do 
                            {
                                Console.WriteLine("Ingrese cuantos quiere comprar");
                                cant_compra = Convert.ToInt32(Console.ReadLine());
                            }
                            while (cant_compra<0);
                            mont_comp = cant_compra * Rubro1;
                            rub1_compras++;
                            rec_tot=rec_tot + mont_comp;

                            if (mont_comp > m_mayor_compra) 
                            {
                                m_mayor_compra = mont_comp;
                                mayor_compra = n_ventas;
                            } 

                            break;
                        case 2:
                            do
                            {
                                Console.WriteLine("Ingrese cuantos quiere comprar");
                                cant_compra = Convert.ToInt32(Console.ReadLine());
                            }
                            while (cant_compra < 0);
                            mont_comp = cant_compra * Rubro2;
                            rub2_compras++;
                            rec_tot = rec_tot + mont_comp;
                            if (mont_comp > m_mayor_compra)
                            {
                                m_mayor_compra = mont_comp;
                                mayor_compra = n_ventas;
                            }
                            break;
                        case 3:
                            do
                            {
                                Console.WriteLine("Ingrese cuantos quiere comprar");
                                cant_compra = Convert.ToInt32(Console.ReadLine());
                            }
                            while (cant_compra < 0);
                            mont_comp = cant_compra * Rubro3;
                            rub3_compras++;
                            rec_tot = rec_tot + mont_comp;
                            if (mont_comp > m_mayor_compra)
                            {
                                m_mayor_compra = mont_comp;
                                mayor_compra = n_ventas;
                            }
                            break;
                        case 4:
                            do
                            {
                                Console.WriteLine("Ingrese cuantos quiere comprar");
                                cant_compra = Convert.ToInt32(Console.ReadLine());
                            }
                            while (cant_compra < 0);
                            mont_comp = cant_compra * Rubro4;
                            rub4_compras++;
                            rec_tot = rec_tot + mont_comp;
                            if (mont_comp > m_mayor_compra)
                            {
                                m_mayor_compra = mont_comp;
                                mayor_compra = n_ventas;
                            }
                            break;
                        case 5:
                            do
                            {
                                Console.WriteLine("Ingrese cuantos quiere comprar");
                                cant_compra = Convert.ToInt32(Console.ReadLine());
                            }
                            while (cant_compra < 0);
                            mont_comp = cant_compra * Rubro5;
                            rub5_compras++;
                            rec_tot = rec_tot + mont_comp;
                            if (mont_comp > m_mayor_compra)
                            {
                                m_mayor_compra = mont_comp;
                                mayor_compra = n_ventas;
                            }
                            break;
                        default:
                            Console.WriteLine("Rubro no existente ");
                            break;
                    }
                    Console.WriteLine("Desea continuar comprando ? 1=si 2=no");
                    res = Convert.ToInt32(Console.ReadLine());
                    if (res!=1) { seguir = false; }


                }
                while (seguir);
            }
            porc1 = rub1_compras * 100 / n_ventas;
            porc2 = rub2_compras * 100 / n_ventas;
            porc3 = rub3_compras * 100 / n_ventas;
            porc4 = rub4_compras * 100 / n_ventas;
            porc5 = rub5_compras * 100 / n_ventas;


            Console.WriteLine($"Se realizaron {n_ventas} ventas\nLa mayor venta fue la N{mayor_compra} se gasto un total de {m_mayor_compra}\nEl % de compras del rubro 1 es de %{porc1}\nEl % de compras del rubro 2 es de %{porc2}\nEl % de compras del rubro 3 es de %{porc3}\nEl % de compras del rubro 1 es de %{porc4}\nEl % de compras del rubro 1 es de %{porc5}");
        }
    }
}
