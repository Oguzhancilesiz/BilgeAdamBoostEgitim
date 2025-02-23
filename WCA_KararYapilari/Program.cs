
////karar yapilari else if
//int sayi = 10;
//if (sayi >0)
//{
//    Console.WriteLine("Pozitif");
//}
//else if (sayi == 0)
//{
//    Console.WriteLine("sıfır");
//}
//else
//{
//    Console.WriteLine("Negatif");
//}



////coklu örneklendirme

//DateTime dateTime = DateTime.Now;

//if (dateTime.DayOfWeek == DayOfWeek.Monday)
//{
//    Console.WriteLine("Pazartesi");
//}
//else if (dateTime.DayOfWeek == DayOfWeek.Tuesday)
//{
//    Console.WriteLine("Salı");
//}
//else if (dateTime.DayOfWeek == DayOfWeek.Wednesday)
//{
//    Console.WriteLine("Çarşamba");
//}
//else if (dateTime.DayOfWeek == DayOfWeek.Thursday)
//{
//    Console.WriteLine("Persembe");
//}
//else if (dateTime.DayOfWeek == DayOfWeek.Friday)
//{
//    Console.WriteLine("Cuma");
//}
//else if (dateTime.DayOfWeek == DayOfWeek.Saturday)
//{
//    Console.WriteLine("Cumartesi");
//}
//else
//{
//    Console.WriteLine("Pazar");
//}

//Console.WriteLine("Sıcaklık gir : ");
//double sicaklik = double.Parse(Console.ReadLine());

//if (sicaklik > 99)
//{
//    Console.WriteLine("Kaynatma noktası");
//}
//else if (sicaklik > 0)
//{
//    Console.WriteLine("Sıvı");
//}
//else
//{
//    Console.WriteLine("Katı");
//}


Console.WriteLine("Sayı 1 : ");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Sayı 2 : ");
int sayi2 = int.Parse(Console.ReadLine());

if (sayi1 > sayi2)
{
    Console.WriteLine("Büyük olan sayı : " + sayi1);
}
else if (sayi1 < sayi2)
{
    Console.WriteLine("Büyük olan sayı : " + sayi2);
}
else
{
    Console.WriteLine("Sayılar eşit");
}
