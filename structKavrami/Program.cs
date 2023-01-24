using System;
using System.Collections;

namespace sinifKavrami
{
class Program
{
    static void Main(string[] args)
{
Dikdortgen dikdortgen=new Dikdortgen();
dikdortgen.kisaKenar=3;
dikdortgen.uzunKenar=5;

Console.WriteLine("Class Alan Hesabi :{0}",dikdortgen.alanHesapla());

//baktığımızda struct kullanımı aynı class gibidir
DikdortgenStruct dikdortgen1=new DikdortgenStruct();
dikdortgen1.kisaKenar=4;
dikdortgen1.uzunKenar=7;

Console.WriteLine("Struct Alan Hesabi : {0}",dikdortgen1.alanHesapla());

}
}


class Dikdortgen{

public int kisaKenar;
public int uzunKenar;

public long alanHesapla ()
{
    return this.kisaKenar*this.uzunKenar;
}
}

//parametresi olmayan constructorı default olarak tanımlayamayız struct için
//struct daha ufak veriler saklamak için , class gibidir performansa göre kullanılır
//Class referans tipli, struct değer tipli
struct DikdortgenStruct
{
    public int kisaKenar { get; set; }
    public int uzunKenar { get; set; }

    public long alanHesapla()
    {
          return this.kisaKenar*this.uzunKenar;
    }
}



}
