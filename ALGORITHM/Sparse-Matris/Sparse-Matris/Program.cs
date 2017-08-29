using System;

namespace Sparse_Matris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matris Boyutu Giriniz : ");
            long matrisBoyutu = 0;

            matrisBoyutu = Convert.ToInt32(Console.ReadLine());
            
            for (long i = 0; i < matrisBoyutu; i++)
            {
                for (long j = 0; j < matrisBoyutu; j++)
                {
                    if (i == j)
                        Console.Write("1");       
                    else
                        Console.Write("0");
                }   
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
