using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Geçerli bir değer giriniz : ");
            long factorialNumber = Convert.ToInt64(Console.ReadLine());
            long result = 0,carry = 1;

            carry = factorialNumber;
            if (factorialNumber > 0)
            {
                for (int i = 1; i < factorialNumber; i++)
                {
                    carry *= i;
                }
                Console.WriteLine("Faktöriyeli : " + carry);
            }
            else
            {
                Console.WriteLine("Geçersiz değer....");
            }
            
            Console.ReadKey();
        }
    }
}
