using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Serisi
{
    class Program
    {
        static void Main(string[] args)
        {
            long klavyedenGirilenSayiKadar,fibo1 = 0, fibo2 = 1,tasiyici;
            
            Console.Write("Fibonacci Serisi Eleman Sayisi Giriniz : ");
            klavyedenGirilenSayiKadar = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i < klavyedenGirilenSayiKadar; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(fibo2);
                }

                tasiyici = fibo1 + fibo2;
                Console.WriteLine(tasiyici);

                fibo1 = fibo2;
                fibo2 = tasiyici;
                
            }

            Console.ReadKey();
        }
    }
}
