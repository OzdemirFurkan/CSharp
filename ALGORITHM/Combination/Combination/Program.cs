using System;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {

            //n! / (r!(n-r)!)

            Console.Write("Birinci Değeri Giriniz : ");
            long combNum1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("Ikinci Değeri Giriniz : ");
            long combNum2 = Convert.ToInt64(Console.ReadLine());
            long subtract = 1,
                result = 1,result2 = 0,result1 = 0,
                endResult;

            subtract = combNum1 - combNum2;

            result = subtract;
            for (int i = 1; i < subtract; i++)
            {
                result *= i;
            }

            result2 = combNum2;
            for (int i = 1; i < combNum2; i++) {
                result2 *= i;
            }

            result1 = combNum1;
            for (int i = 1; i < combNum1; i++) {
                result1 *= i;
            }

            endResult = result1 / (result2 * result);

            Console.WriteLine("Sonuc : " + endResult);

            Console.ReadKey();
        }
    }
}
