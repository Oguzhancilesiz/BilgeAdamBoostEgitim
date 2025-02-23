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






        //geri:
        //    Console.WriteLine("----------------------");
        //    Console.WriteLine("Sayı Giriniz: ");

        //    int sayii = Convert.ToInt32(Console.ReadLine());
        //    int islem;
        //    if (sayii == 0)
        //    {
        //        Console.WriteLine("Sayı Sıfırdır");
        //    }
        //    else if (sayii % 2 == 0)
        //    {
        //        Console.WriteLine("Sayı Çifttir");
        //        islem = sayii / 2;
        //        Console.WriteLine("ikiye bölümü : {0}",islem);
        //    }
        //    else
        //    {

        //        islem = sayii * 2;
        //        Console.WriteLine("Sayı Tektir");
        //        Console.WriteLine("iki katı : {0}", islem);
        //    }
        //    goto geri;






        //int vize;
        //int final;
        //int ortalama;

        //Console.WriteLine("vize gir : ");
        //vize = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("final gir : ");
        //final = Convert.ToInt32(Console.ReadLine());

        //ortalama = (vize * 40 / 100) + (final * 60 / 100);

        //if (ortalama >= 89)
        //{
        //    Console.WriteLine("Vize = {0} , Final = {1} , Ortalama = {2} , Not = AA", vize, final, ortalama);
        //}
        //else if (ortalama >= 74)
        //{
        //    Console.WriteLine("Vize = {0} , Final = {1} , Ortalama = {2} , Not = BB", vize, final, ortalama);
        //}
        //else if (ortalama >= 59)
        //{
        //    Console.WriteLine("Vize = {0} , Final = {1} , Ortalama = {2} , Not = CC", vize, final, ortalama);
        //}
        //else if (ortalama >= 44)
        //{
        //    Console.WriteLine("Vize = {0} , Final = {1} , Ortalama = {2} , Not = DD", vize, final, ortalama);
        //}
        //else
        //{
        //    Console.WriteLine("Vize = {0} , Final = {1} , Ortalama = {2} , Not = FF", vize, final, ortalama);
        //}






        //basadon:

        //    Console.WriteLine("İlk sayıyı gir : ");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("İkinci Sayıyı gir : ");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Yapılmak istenilen işlemi seç!");

        //islemsec:
        //    Console.WriteLine("Toplama = T , Çıkarma = C , Çarpma = X , Bölme = B , Mod = M , Üs = U");

        //    char islem = Convert.ToChar(Console.ReadKey().KeyChar);
        //    islem = Char.ToLower(islem);

        //    float sonuc = 0;

        //    Console.WriteLine($"Seçili işlem : {islem}");

        //    switch (islem)
        //    {
        //        case 't':
        //            sonuc = sayi1 + sayi2;
        //            Console.WriteLine("--------------------------");
        //            Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
        //            Console.WriteLine("--------------------------");
        //            break;

        //        case 'c':
        //            sonuc = sayi1 - sayi2;
        //            Console.WriteLine("--------------------------");
        //            Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
        //            Console.WriteLine("--------------------------");
        //            break;

        //        case 'x':
        //            sonuc = sayi1 * sayi2;
        //            Console.WriteLine("--------------------------");
        //            Console.WriteLine($"Sonuç: {sayi1} × {sayi2} = {sonuc}");
        //            Console.WriteLine("--------------------------");
        //            break;

        //        case 'b':
        //            if (sayi2 == 0)
        //            {
        //                Console.WriteLine("Hata: Sıfıra bölme işlemi yapılamaz!");
        //            }
        //            else
        //            {
        //                sonuc = sayi1 / sayi2;
        //                Console.WriteLine("--------------------------");
        //                Console.WriteLine($"Sonuç: {sayi1} ÷ {sayi2} = {sonuc}");
        //                Console.WriteLine("--------------------------");
        //            }
        //            break;

        //        case 'm':
        //            if (sayi2 == 0)
        //            {
        //                Console.WriteLine("Hata: Sıfıra göre mod alma işlemi yapılamaz!");
        //            }
        //            else
        //            {
        //                sonuc = sayi1 % sayi2;
        //                Console.WriteLine("--------------------------");
        //                Console.WriteLine($"Sonuç: {sayi1} % {sayi2} = {sonuc}");
        //                Console.WriteLine("--------------------------");
        //            }
        //            break;

        //        case 'u':
        //            sonuc = (float)Math.Pow(sayi1, sayi2);
        //            Console.WriteLine("--------------------------");
        //            Console.WriteLine($"Sonuç: {sayi1}^{sayi2} = {sonuc}");
        //            Console.WriteLine("--------------------------");
        //            break;

        //        default:
        //            Console.WriteLine("Geçersiz işlem seçimi! Harf Seç!");
        //            break;
        //    }

        //    Console.WriteLine("İşlem değiştirek için = 1 , Başa dönmek için = 2");


        //    char dongu = Convert.ToChar(Console.ReadKey().KeyChar);
        //    switch (dongu)
        //    {
        //        case '1':
        //            goto islemsec;

        //            break;
        //        case '2':
        //            goto basadon;
        //            break;
        //    }






        }
    }
}
