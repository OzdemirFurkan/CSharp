using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Geçerli bir değer giriniz : ");
            long factorialNumber = Convert.ToInt64(Console.ReadLine());
            long result = 0;



            if (factorialNumber > 0)
            {
                for (int i = 1; i <= factorialNumber; i++)
                {
                    result = factorialNumber * i;
                }
                Console.WriteLine("Faktöriyeli : " + result);
            }
            else
            {
                Console.WriteLine("Geçersiz değer....");
            }
            
            Console.ReadKey();
        }
    }
}
