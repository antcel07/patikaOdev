using System;

namespace methodlar
{
class Program
{
static void Main(string[] args)
{
    //out parametreler
   string sayi="999";
bool sonuc=int.TryParse(sayi,out int outSayi);
if(sonuc)
{
    Console.WriteLine("Basarili");
    Console.WriteLine(outSayi);
}
else{
    Console.WriteLine("Basarisiz");
}

    Methodlar deg=new Methodlar();
    deg.Topla(7,3,out int toplamSonuc);
    Console.WriteLine(toplamSonuc);
//method aşırı yükleme-overloading

int ifade=356;
deg.EkranaYazdir(Convert.ToString(ifade));
deg.EkranaYazdir(ifade);
//method imzası
//methodadi + parametre sayisi + parametre
deg.EkranaYazdir("Kerem","Çelik");

        }

    }   

class Methodlar
{
    public void Topla(int a,int b,out int toplam)
    {
     toplam=a+b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

     public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

     public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1+veri2);
    }
}



}   