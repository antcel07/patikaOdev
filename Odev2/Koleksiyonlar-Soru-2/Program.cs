using System;
using System.Collections;

namespace Koleksiyonlar
{
class Program
{
    static void Main(string[] args)
{
    List<double>dizi=new List<double>(){};

    while(dizi.Count<20)
    {
	try
	{
		Console.Write("Sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
	dizi.Add(sayi);
    }
	catch (Exception)
	{
		Console.WriteLine("Sayi formatinda bir değer giriniz.");
		
	}   
 }
dizi.Sort();
Console.WriteLine("En Küçük 3 Sayi:"+dizi[0]+" "+dizi[1]+" "+dizi[2]);
Console.WriteLine("En Büyük 3 Sayi:"+ dizi[17]+" "+dizi[18]+" "+dizi[19]);


double enKucukOrt=(dizi[0]+dizi[1]+dizi[2])/3;
double enBuyukOrt=(dizi[17]+dizi[18]+dizi[19])/3;
Console.WriteLine("En küçük 3 sayinin ortalamasi: "+ enKucukOrt);
Console.WriteLine("En büyük 3 sayinin ortalamasi: "+ enBuyukOrt);
Console.WriteLine("Ortalamalarin ortalamasi: "+ (enBuyukOrt+enKucukOrt)/2);
   
    
}
}
}
