namespace WCA_AylaraGoreMevsimler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            int ay = dateTime.Month;

            if (ay == 12 || ay == 1 || ay == 2)
            {
                Console.WriteLine("Kış Mevsimindesiniz");
            }
            else if (ay == 3 || ay == 4 || ay == 5)
            {
                Console.WriteLine("İlkbahar Mevsimindesiniz");
            }
            else if (ay == 6 || ay == 7 || ay == 8)
            {
                Console.WriteLine("Yaz Mevsimindesiniz");
            }
            else if (ay == 9 || ay == 10 || ay == 11)
            {
                Console.WriteLine("Sonbahar Mevsimindesiniz");
            }

            switch (ay)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Kış Mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimindesiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimindesiniz");
                    break;
            }
        }
    }
}
