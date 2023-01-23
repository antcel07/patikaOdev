using System;
namespace genericList
{
class Program
{
    static void Main(string[] args)
{
//List<T>class
//System.Colletions.Generic
//T->object türündendir.Generic olmasını sağlar.Hangi türden veri tutacağını belirler.

List<int> sayiListesi=new List<int>();
sayiListesi.Add(21);
sayiListesi.Add(94);
sayiListesi.Add(39);
sayiListesi.Add(48);

Console.WriteLine(sayiListesi.Count);

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}

sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));

//listeden eleman çıkarma
sayiListesi.Remove(4);
sayiListesi.RemoveAt(1);

//Liste içinde arama
if(sayiListesi.Contains(12))
{
    Console.WriteLine("12 liste içinde bulundu");
}
//Eleman ile index erişme
Console.WriteLine(sayiListesi.BinarySearch(39));

//Diziyi listeye çevirme
string[]hayvanlar={"İnek","Ayi","Karga","Köpek"};
List<string>hayvanListesi=new List<string>(hayvanlar);

hayvanListesi.Clear();

//List içerisinde nesne tutmak
List<Kullanicilar>kullaniciListesi=new List<Kullanicilar>();

Kullanicilar kullanici1=new Kullanicilar();
kullanici1.Isim="Ahmet";
kullanici1.Soyisim="Tanpinar";
kullanici1.Yas=24;

Kullanicilar kullanici2=new Kullanicilar();
kullanici2.Isim="Ahmet";
kullanici2.Soyisim="Tanpinar";
kullanici2.Yas=24;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar>yeniListe=new List<Kullanicilar>();
yeniListe.Add(new Kullanicilar(){
Isim="Salih",
Soyisim="Cavus",
Yas=56

});

foreach (var kullanici in kullaniciListesi)
{
    Console.WriteLine("Kullanici Adi: "+ kullanici.Isim);
     Console.WriteLine("Kullanici Soyadi: "+ kullanici.Soyisim);
      Console.WriteLine("Kullanici Yas: "+ kullanici.Yas);
}
}
}public class Kullanicilar
{   
    private string isim;
private string soyisim;
   private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }


}