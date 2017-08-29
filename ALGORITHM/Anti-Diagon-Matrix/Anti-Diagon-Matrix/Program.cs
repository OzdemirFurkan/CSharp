using System;

namespace Anti_Diagon_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int tasiyici , klavyedenGirilenSayiKadar = 0;
            Console.Write("Matris Eleman Sayisi Giriniz : ");
            klavyedenGirilenSayiKadar = Convert.ToInt32(Console.ReadLine());
            tasiyici = klavyedenGirilenSayiKadar;

            for (int i = 0; i < klavyedenGirilenSayiKadar; i++)
            {
                for (int j = 0; j < klavyedenGirilenSayiKadar; j++)
                {
                    if (j == (tasiyici - 1))
                    {
                        Console.Write("1");
                        tasiyici--;
                    }
                    else
                        Console.Write("0");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
