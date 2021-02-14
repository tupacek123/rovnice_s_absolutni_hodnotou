using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lineární rovnice s absolutní hodnotou.
            //1, |ax + b| = Rcislo (y)

            double vysledek;
            double nulovy_bod;
            double koren_1;
            double koren_2;
            Console.Write("Zadej hodnotu a: ");
            double a =  Convert.ToDouble(Console.ReadLine());
            Console.Write("Zadej hodnotu b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zadej hodnotu y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (y > 0)
            {
                if (b == 0)
                {
                    if (a > 0)
                    {
                        vysledek = y / a;
                        Console.WriteLine("K = {" + vysledek + ";" + " " + (vysledek * (-1)) + "}");
                    }

                    else if (a < 0)
                    {
                        vysledek = y / a;
                        Console.WriteLine("K = {" + (vysledek * (-1)) + ";" + " " + vysledek + "}");
                    }

                    else if (a == 0)
                    {
                        Console.WriteLine("Nedefinováno");
                    }                        
                    
                    
                }

                else if (b != 0)
                {
                    if (a != 0)
                    {
                        nulovy_bod = -b / a;
                        koren_1 = (y + b) / (-a);
                        koren_2 = (y - b) / a;
                        Console.WriteLine("K = {" + koren_1 + ";" + " " + koren_2 + "}");
                   
                    }

                    else if (a == 0 && b == y)
                    {
                        Console.WriteLine("Nekonečno řešení");
                    }

                    else if (a == 0 && -b == y)
                    {
                        Console.WriteLine("Nekonečno řešení");
                    }

                    else
                    {
                        Console.WriteLine("Nedefinováno");
                    }




                }
                

            
            }

            
        
        
        
        }
    }
}
