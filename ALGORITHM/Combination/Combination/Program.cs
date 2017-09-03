using System;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Değeri Giriniz : ");
            int combNum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci Değeri Giriniz : ");
            int combNum2 = Convert.ToInt32(Console.ReadLine());
            int subtract = 1,
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
