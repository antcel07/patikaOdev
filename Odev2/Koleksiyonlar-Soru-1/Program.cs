using System;
using System.Collections;

namespace Koleksiyonlar
{
class Program
{
    static void Main(string[] args)
{

List<int> asal = new List<int>() { };
List<int> normalSayi = new List<int>() { };
List<int> arr = new List<int>() { };
while(arr.Count < 20)
{
	try
	{
		Console.Write("Sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
		if(sayi < 0)
		{
			Console.WriteLine("Pozitif tam sayi giriniz.");
			
		}
		else
		{
            arr.Add(sayi);
		}
    }
	catch (Exception)
	{
		Console.WriteLine("Sayi formatinda bir değer giriniz.");
		
	}

foreach (var item in arr)
{
    int n = 0;
    for (int i = 2; i < item; i++)
    {

        if (item % i == 0)
        {
            n++;
        }
        else
        {
            continue;
        }
    }
    if (n == 0)
    {
        asal.Add(item);
    }
    else
    {
        normalSayi.Add(item);
    }
}
asal.Sort(); //Küçükten büyüğe sıralar.
normalSayi.Sort();
asal.Reverse(); //Tersine çevirir.
normalSayi.Reverse();
Console.Write("Asal Sayilar: ");
double asalTotal = 0;

foreach (var item in asal)
{
    asalTotal += item;
    Console.Write(item + " ");
}
Console.WriteLine();
double notAsalTotal = 0;
Console.Write("Asal Olmayan Sayilar: ");
foreach (var item in normalSayi)
{
    notAsalTotal += item;
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine($"{asal.Count} adet asal sayi vardir. Bu sayilarin ortalamasi {asalTotal/asal.Count} değerine eşittir.");
Console.WriteLine($"{normalSayi.Count} adet asal olmayan sayi vardir. Bu sayilarin ortalamasi {notAsalTotal/normalSayi.Count} değerine eşittir.");




}
}}}
