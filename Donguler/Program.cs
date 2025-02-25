namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////////////////////////////////
            ///Ödevler 


            /////////////////////////////////////////////////////////////////////////////////// Ödev 1
            ///faktoriyel cıktısı şu şekilde olacak 5! = 5*4*3*2*1 = 120
            ///

            Console.WriteLine("Faktoriyel çıktısı örneği --> 5! = 5*4*3*2*1 = 120 - ödev 1");
            Console.WriteLine("");
            Console.WriteLine("");
            try
            {
                Console.Write("Faktoriyeli hesaplanacak Sayıyı gir : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                int faktoriyel = 1;

                Console.Write(sayi + "! = ");

                for (int i = sayi; i > 0; i--)
                {
                    faktoriyel *= i;
                    Console.Write(i);

                    if (i > 1)
                    {
                        Console.Write(" * ");
                    }
                }

                Console.Write(" = " + faktoriyel);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            catch (Exception)
            {

                Console.WriteLine("Hata");
            }

            /////////////////////////////////////////////////////////////////////////////////// Ödev 2
            ///içi dolu kare çizdirme
            ///**********
            ///**********
            ///**********
            ///**********
            ///
            Console.WriteLine("");
            Console.WriteLine("Yıldızlardan kare oluşturma - ödev 2");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }



            // 1'den 10'a kadar olan sayıları ekrana yazdırma FOR DONGUSU

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("BilgeAdam");
            //}


            //0 ile 100 arasındaki çift ve tek sayıları ekrana yazdırma

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} Sayı çift");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} Sayı tektir");
            //    }

            //    Console.WriteLine("");
            //    Console.WriteLine("----------------------------------------");
            //    Console.WriteLine("");
            //}


            ///////////////////////////////////////////////////////////////////////////////////
            ///klavyeden girilen sayının faktoriyelini hesaplama döngü ile
            ///


            //try
            //{
            //    Console.WriteLine("Faktoriyeli hesaplanacak Sayıyı gir : ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    int faktoriyel = 1;

            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        faktoriyel *= i;
            //    }
            //    Console.WriteLine(faktoriyel);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Hata");
            //}


            ////////////////////////////////////////////////////
            ///1 - 100 arasu sayıların asal olup olamdığını bulma
            ///

            //for (int i = 2; i <= 100; i++)
            //{
            //    int sayac = 0;

            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            sayac++;
            //        }
            //    }

            //    if (sayac == 2)
            //    {
            //        Console.WriteLine(i + " Asal");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + " Değil");
            //    }
            //}
        }
    }
}
