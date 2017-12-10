using System;

namespace Havuz_Problemi
{
    class Program
    {
        static void Main(string[] args)
        {
            double aMus, bMus, cMus, sonuc;


            // Klavyeden deger okuma ve eksi giris kontrolu

            Console.Write("A musluğu değeri : ");
            aMus = Convert.ToInt32(Console.ReadLine());

            if (aMus <= 0)
            {
                Console.WriteLine("Gecersiz Deger");
                Console.ReadKey();
                return;
            }

            Console.Write("B musluğu değeri : ");
            bMus = Convert.ToInt32(Console.ReadLine());

            if (bMus <= 0)
            {
                Console.WriteLine("Gecersiz Deger");
                Console.ReadKey();
                return;
            }

            Console.Write("C musluğu değeri : ");
            cMus = Convert.ToInt32(Console.ReadLine());

            if (cMus <= 0)
            {
                Console.WriteLine("Gecersiz Deger");
                Console.ReadKey();
                return;
            }

            sonuc = (1 / aMus) + (1 / bMus) + (1 / cMus);

            Console.WriteLine(sonuc + " Saat");
            Console.ReadKey();
        }
    }
}
