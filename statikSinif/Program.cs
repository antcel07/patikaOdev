using System;
using System.Collections;

namespace sinifKavrami
{
class Program
{
    static void Main(string[] args)
{
Console.WriteLine("Çalisan sayisi {0}",Calisan.CalisanSayisi);

Calisan calisan=new Calisan("Ali","Ahlas","IK");
Console.WriteLine("Çalisan sayisi {0}",Calisan.CalisanSayisi);
Calisan calisan1=new Calisan("Samet","İnan","Bilgi İşlem");
Calisan calisan2=new Calisan("Kamil","Servun","Ulasim");
Console.WriteLine("Çalisan sayisi {0}",Calisan.CalisanSayisi);


//burada static methoda direkt adıyla parametrelerine eriştik
Console.WriteLine("Toplama işlemi sonucu: {0}",Islemler.Topla(100,200));
Console.WriteLine("Çikarma işlemi sonucu: {0}",Islemler.Cikarma(452,268));



}
}

class Calisan
{
    //burada kapsülleme yaptık.Private değeri public olarak sadece okuma amaçlı tanımladım.
    private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            calisanSayisi=0;
        }


//yukarıdakilerden parametre ile calışan içine ekleriz
        public Calisan(string isim, string soyisim, string departman)
        {
            //private olan değerleri constructor ile belirlediğimiz değişkenlere atıp privatedan publice kullanımını sağlarız
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
            
        }



    }



//static olan methodlara sınıfın ismiyle direkt erişiriz , eger static değilse nesneler aracılıgıyla erişiriz.
static class Islemler{

public static long  Topla(int sayi1,int sayi2)
{
    return sayi1+sayi2;
}

public static long  Cikarma(int sayi1,int sayi2)
{
    return sayi1-sayi2;
}

    }

}