using System;

namespace Helezon_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger1 = 1,klavyedenGirilenBoyut = 1 , tasiyici = 0;
            Console.Write("Boyut Sayisi Giriniz : ");
            klavyedenGirilenBoyut = Convert.ToInt32(Console.ReadLine());
            tasiyici = klavyedenGirilenBoyut;

            for (int i = 0; i < klavyedenGirilenBoyut; i++)
            {
                for (int j = 0; j < klavyedenGirilenBoyut; j++)
                {
                    if (j == (klavyedenGirilenBoyut - 1))
                    {
                        for (int k = 0; k < klavyedenGirilenBoyut; k++)
                        {
                            Console.WriteLine(tasiyici + " ");
                            tasiyici++;
                        }
                    }
                    else
                    {
                        Console.Write(deger1 + " ");
                        deger1++;

                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
