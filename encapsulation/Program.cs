using System;
using System.Collections;

namespace sinifKavrami
{
class Program
{
    static void Main(string[] args)
{

Ogrenci ogrenci=new Ogrenci();
ogrenci.Isim="Selim";
ogrenci.Soyisim="Ay";
ogrenci.OgrenciNo=258;
ogrenci.Sinif=11;

ogrenci.OgrenciBilgileriniGetir();


Ogrenci ogrenci1=new Ogrenci("İsa","Kara",621,4);
ogrenci1.SinifDusur();
ogrenci1.OgrenciBilgileriniGetir();

}

}

class Ogrenci
{
    private String isim;
    private string soyisim;
    private int ogrencino;
    private int sinif;

        public string Isim { 
            get {return isim; } 
            set {isim=value;}
             }

       
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrencino; set => ogrencino = value; }

    

        public int Sinif { 
            get => sinif;
         set{
            if(value<1)
            {
                Console.WriteLine("sinif en az 1 olabilir.");
                sinif=1;
            }
            else{
              sinif = value;  
            }
             
         } 
         }

    
        public Ogrenci(string isim, string soyisim, int ogrencino,int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo=ogrencino;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("**** Ogrenci Bilgileri ****");
            Console.WriteLine("Öğrenci Adi :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadi :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sinifi :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif=this.Sinif+1;
        }

        public void SinifDusur()
        {
            this.Sinif=this.Sinif-1;
        }


    }


}