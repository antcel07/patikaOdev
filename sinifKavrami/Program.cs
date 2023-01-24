using System;
using System.Collections;

namespace sinifKavrami
{
class Program
{
    static void Main(string[] args)
{

Calisan cls=new Calisan();
cls.ad="Semih" ;
cls.soyad="Sentürk";
cls.departman="Futbol";
cls.no=2311904;

cls.CalisanBilgileri();

Calisan cls2=new Calisan();
cls2.ad="İsmail" ;
cls2.soyad="Çam";
cls2.departman="İnsan Kaynaklari";
cls2.no=3578641;

cls2.CalisanBilgileri();

}
}


class  Calisan{
public string ad;
public string soyad;
public int no;

public string departman;

public void CalisanBilgileri()
{
Console.WriteLine("Çalisanin Adi:{0}",ad);
Console.WriteLine("Çalisanin Soyadi:{0}",soyad);
Console.WriteLine("Çalisanin Numarasi:{0}",no);
Console.WriteLine("Çalisanin Departman:{0}",departman);
}


}
}