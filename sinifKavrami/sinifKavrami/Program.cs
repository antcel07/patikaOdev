using System;
using System.Collections;

namespace sinifKavrami
{
class Program
{
    static void Main(string[] args)
{

Console.WriteLine("***** Çalişan1 *****");
Calisan cls=new Calisan("Semih","Sentürk",2311904,"Futbol");
// cls.Ad="Semih" ;
// cls.Soyad="Sentürk";
// cls.Departman="Futbol";
// cls.No=2311904;
cls.CalisanBilgileri();

Console.WriteLine("***** Çalişan2 *****");
Calisan cls2=new Calisan();
cls2.Ad="İsmail" ;
cls2.Soyad="Çam";
cls2.No=3578641;
cls2.Departman="İnsan Kaynaklari";

cls2.CalisanBilgileri();


Console.WriteLine("***** Çalişan3 *****");
Calisan cls3=new Calisan("Kerem","Çelik");
cls3.CalisanBilgileri();
}
}


class  Calisan{
public string Ad;
public string Soyad;
public int No;
public string Departman;


//constructor ile aynı sınıfa ulaşıp değer atıyoruz
public Calisan(string ad,string soyad, int no, string departman)
{
    this.Ad=ad;
    this.Soyad=soyad;
    this.No=no;
    this.Departman=departman;
}

public Calisan(string ad,string soyad)
{
    this.Ad=ad;
    this.Soyad=soyad;
  
}

public Calisan(){}


public void CalisanBilgileri()
{
Console.WriteLine("Çalisanin Adi:{0}",Ad);
Console.WriteLine("Çalisanin Soyadi:{0}",Soyad);
Console.WriteLine("Çalisanin Numarasi:{0}",No);
Console.WriteLine("Çalisanin Departman:{0}",Departman);
}

}
}