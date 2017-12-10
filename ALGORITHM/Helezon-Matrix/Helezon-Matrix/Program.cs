using System;

namespace Helezon_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Boyut Sayisi Giriniz : ");
            //Klavyeden okuyup convert işlemini yapıyoruz
            //Dökümantasyonu yazarken klavyeden girilen değeri (4) olarak varsayacağım.
            int klavyedenGirilenBoyut = Convert.ToInt32(Console.ReadLine());
            
            //İki boyutlu bir dizi oluşturuyoruz. 4 x 4'lük bir dizi oluşacaktır
            int[,] eksenler = new int[klavyedenGirilenBoyut,klavyedenGirilenBoyut];
            
            int tasiyici = 1,
                deger1 = 0,
                deger2 = klavyedenGirilenBoyut - 1;
            //index 0'dan başladığı için -1 yaptık
            //Değişken tanımlama kısmı bitti

            //İpucunda verildiği gibi klavyeden girilen değerin üssüne ulaşana kadar while döngüsüne sokuyoruz
            while (tasiyici <= klavyedenGirilenBoyut * klavyedenGirilenBoyut)
            {
                /*Salyangoz kabugu benzeri bir sayı artışı çizmek istediğimi için
                sırasıyla "sağ - alt - sol - yukarı" atamasını yapacak for döngüleri yazıldı */
                //Döngü boyunca satır ve sütün değişkenleri değişecek

                //Sağ yöne doğru (x ekseni) 
                for (int i = deger1; i <= deger2; i++)
                    //Satır indexi(deger1) 0'da kalacak sadece sütün indexi(i) artacak
                    //"tasiyici" her adımda atama işlemini yapacak 
                    eksenler[deger1, i] = tasiyici++; 
                
                //Alt yöne doğru (-y ekseni)
                for (int j = deger1 + 1; j <= deger2; j++)
                    //"j" (1)değerini vererek satır indexini(j) 1 yapıldı ve boyutumuz kadar arttırmaya devam etti
                    //Sütün indeximiz aynı kaldı ve "tasiyici" kaldigi yerden atamaya devam etti
                    //for döngülerinin devamında benzeri işlemler yapıldı
                    eksenler[j, deger2] = tasiyici++;

                //Sol yöne doğru (-x ekseni)
                for (int i = deger2 - 1; i >= deger1; i--)
                    eksenler[deger2, i] = tasiyici++;
                //Yukarı yöne doğru (y ekseni)
                for (int j = deger2 - 1; j >= deger1 + 1; j--)
                    eksenler[j, deger1] = tasiyici++;
                deger1++;
                deger2--;
            }
            
            //Ters Kosegen Matrisi ve Sparse matrisde de kullandığımız for içinde for döngüsünü ekrana yazdırmak için kullanıldı.

            for (int i = 0; i < klavyedenGirilenBoyut; i++)
            {
                for (int j = 0; j < klavyedenGirilenBoyut; j++)
                {
                    //Icini doldugurdugumuz dizinin satir ve sutun indexleri arttiriliyor
                    //Valuesi ekrana basiliyor
                    Console.Write(eksenler[i,j] + " ");    
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
