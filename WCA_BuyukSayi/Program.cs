

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
