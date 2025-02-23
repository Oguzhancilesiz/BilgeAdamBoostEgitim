namespace WCA_KarmaOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //geridon:
        //    string kAdi = "admin";
        //    string pass = "1234";

        //    Console.WriteLine("Kullanıcı Adı : ");
        //    string kullaniciAdi = Console.ReadLine();

        //    Console.WriteLine("Şifre : ");
        //    string sifre = Console.ReadLine();

        //    if (kAdi == kullaniciAdi && pass == sifre)
        //    {
        //        Console.WriteLine("Giriş Başarılı");
        //    }
        //    else if(kAdi != kullaniciAdi)
        //    {
        //        Console.WriteLine("Kullanıcı Adı Hatalı");
        //        goto geridon;
        //    }
        //    else if (pass != sifre)
        //    {
        //        Console.WriteLine("Şifre Hatalı");
        //        goto geridon;
        //    }
        //        goto geridon;



        //geridon:
        //    Console.WriteLine("----------------------");
        //    Console.WriteLine("Sayı Giriniz: ");

        //    int sayigir = Convert.ToInt32(Console.ReadLine());

        //    if (sayigir == 0)
        //    {
        //        Console.WriteLine("Sayı Sıfırdır");
        //    }
        //    else if (sayigir % 2 == 0)
        //    {
        //        Console.WriteLine("Sayı Çifttir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sayı Tektir");
        //    }
        //    goto geridon;



        geri:
            Console.WriteLine("----------------------");
            Console.WriteLine("Sayı Giriniz: ");

            int sayii = Convert.ToInt32(Console.ReadLine());
            int islem;
            if (sayii == 0)
            {
                Console.WriteLine("Sayı Sıfırdır");
            }
            else if (sayii % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir");
                islem = sayii / 2;
                Console.WriteLine("ikiye bölümü : {0}",islem);
            }
            else
            {

                islem = sayii * 2;
                Console.WriteLine("Sayı Tektir");
                Console.WriteLine("iki katı : {0}", islem);
            }
            goto geri;


        }
    }
}
