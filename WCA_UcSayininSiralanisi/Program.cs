namespace WCA_UcSayininSiralanisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        BasaDon:
            try
            {
                Console.WriteLine("Birinci Sayı : ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci Sayı : ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Üçüncü Sayı : ");
                int sayi3 = Convert.ToInt32(Console.ReadLine());

                if (sayi1 > sayi2 && sayi1 > sayi3)
                {
                    Console.WriteLine("Birinci Girilen sayı en büyük sayıdır : {0}", sayi1);
                }
                else if (sayi2 > sayi1 && sayi2 > sayi3)
                {
                    Console.WriteLine("İkinci Girilen sayı en büyük sayıdır : {0}", sayi2);
                }
                else if (sayi3 > sayi1 && sayi3 > sayi2)
                {
                    Console.WriteLine("Üçüncü Girilen sayı en büyük sayıdır : {0}", sayi3);
                }
                else { Console.WriteLine("Sayılar eşit"); }
            }
            catch (Exception ex)
            {
                Console.Clear();
                goto BasaDon;
            }

            goto BasaDon;
        }
    }
}
