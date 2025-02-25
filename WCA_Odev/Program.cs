namespace WCA_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Bir fabrikada sabit maaşla çalışan işçiler, aile durumlarına göre ek maaş almaktadır.Bekar olanlar sadece maaş, evli ve çocuğu olmayanlar % 3 ek maaş, çocuk sayısı 1 olanlar % 5 ek maaş, çocuk sayısı 2 olanlar % 10 ek maaş, çocuk sayısı 3 ve daha fazla olanlar ise % 15 kadar ek maaş almaktadır. Bu göre, kullanıcıdan işçinin maaşı ve çocuk sayısını isteyerek, gerekli hesaplamayı yapıp ekrana yazdıran program

        //    int cocukSayisi = 0;
        //    double ekmaasorani = 0;
        //    double ekMaas = 0;
        //    double toplamMaas = 0;
        //    double maas = 0;

        //maasadon:
        //    Console.WriteLine("Maaşınız : ");
        //    maas = Convert.ToDouble(Console.ReadLine());

        //    if (maas >= 0)
        //    {
        //    medenidurum:
        //        Console.WriteLine("Evliyseniz: E \nBekarsanız : B\nDulsanız : D\nTuşuna Basınız...");
        //        ConsoleKeyInfo medenidurum = Console.ReadKey();
        //        if (medenidurum.Key == ConsoleKey.E || medenidurum.Key == ConsoleKey.B || medenidurum.Key == ConsoleKey.D)
        //        {
        //            switch (medenidurum.Key)
        //            {
        //                case ConsoleKey.E:

        //                    Console.WriteLine("\nEVLİ");
        //                    Console.WriteLine("\nÇocuk sayısını girin : ");

        //                    cocukSayisi = Convert.ToInt32(Console.ReadLine());

        //                    if (cocukSayisi >= 0)
        //                    {
        //                        if (cocukSayisi == 0)
        //                        {
        //                            ekmaasorani = 0.03;

        //                        }
        //                        else if (cocukSayisi == 1)
        //                        {
        //                            ekmaasorani = 0.05;
        //                        }
        //                        else if (cocukSayisi == 2)
        //                        {
        //                            ekmaasorani = 0.10;
        //                        }
        //                        else
        //                        {
        //                            ekmaasorani = 0.15;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Geçerli bir cocuk sayısı gir!");
        //                    }
        //                    break;

        //                case ConsoleKey.B:
        //                    Console.WriteLine("\nBEKAR");
        //                    ekmaasorani = 0;
        //                    break;

        //                case ConsoleKey.D:
        //                    Console.WriteLine("\nDUL");
        //                    Console.WriteLine("\nÇocuk sayısını girin : ");

        //                    cocukSayisi = Convert.ToInt32(Console.ReadLine());

        //                    if (cocukSayisi >= 0)
        //                    {
        //                        if (cocukSayisi == 0)
        //                        {
        //                            ekmaasorani = 0;

        //                        }
        //                        else if (cocukSayisi == 1)
        //                        {
        //                            ekmaasorani = 0.05;
        //                        }
        //                        else if (cocukSayisi == 2)
        //                        {
        //                            ekmaasorani = 0.10;
        //                        }
        //                        else
        //                        {
        //                            ekmaasorani = 0.15;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Geçerli bir cocuk sayısı gir!");
        //                    }
        //                    break;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Hatalı tuşlama yaptınız. Lütfen E - B - D Seçeneklerinden birini seçin...");
        //            goto medenidurum;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Maaş 0'dan büyük olmalıdır.");
        //        goto maasadon;
        //    }

        //    ekMaas = maas * ekmaasorani;
        //    toplamMaas = maas + ekMaas;


        //    Console.WriteLine($"Çocuk sayınıza göre ek maaş oranınız %{ekmaasorani} --- Ek maaş: {ekMaas} TL\n");
        //    Console.WriteLine($"Toplam maaş: {toplamMaas} TL");


        ///////////////////////////////////////////////////////////////////////////////faktoriyel hesaplama

        //Console.WriteLine("Faktoriyel hesaplama için bir sayı girin: ");
        //int sayi = Convert.ToInt32(Console.ReadLine());

        //if (sayi >= 0)
        //{
        //    int faktoriyel = 1;
        //    for (int i = 1; i <= sayi; i++)
        //    {
        //        faktoriyel *= i;
        //    }
        //    Console.WriteLine($"{sayi}! = {faktoriyel}");
        //}
        //else
        //{
        //    Console.WriteLine("Geçerli bir sayı girin!");
        //}


        ///////////////////////////////////////////////////////////////////////////////faktoriyel hesaplama HOCANIN ÖRNEGİ


        Tekar:
            Console.WriteLine("Faktoriyel sayısını gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;

        BasaDon:
            if (sayi == 1)
            {
                Console.WriteLine(faktoriyel);
                Console.WriteLine("Tekrar Hesaplama İçin E");

                if (Console.ReadKey().Key == ConsoleKey.E)
                {
                    goto Tekar;
                }
                return;
            }
            else
            {
                faktoriyel *= sayi;
                sayi--;
                goto BasaDon;
            }

            decimal maas = 0;
            Console.WriteLine("Maaşı gir");
            maas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Medeni Hal : E/B ");

            if (Console.ReadKey().Key == ConsoleKey.B)
            {
                Console.WriteLine("Ek Hakediş yok");
                return;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int cocuksayisi = 0;
            Console.WriteLine("Çocuk sayısını gir");
            cocuksayisi = Convert.ToInt32(Console.ReadLine());

            switch (cocuksayisi)
            {
                case 1:
                    Console.WriteLine($"{cocuksayisi} ve {maas} maaş alan bir kişi {maas * 0.05m} ek hakediş alır");
                case 2:
                    Console.WriteLine($"{cocuksayisi} ve {maas} maaş alan bir kişi {maas * 0.10m} ek hakediş alır");
                case 3:
                    Console.WriteLine($"{cocuksayisi} ve {maas} maaş alan bir kişi {maas * 0.15m} ek hakediş alır");
                default:
                    Console.WriteLine($"{cocuksayisi} ve {maas} maaş alan bir kişi {maas * 0.03m} ek hakediş alır");
                    break;
            }
        }
    }
}
