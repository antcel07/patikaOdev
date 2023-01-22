using System;

namespace methodlar
{

    class Program
    {

        static void Main(string[] args)
        {
        int a=3;
        int b=5;
        Console.WriteLine(a+b);

        int sonuc=Topla(a,b);
        Console.WriteLine(sonuc);

        Methodlar ornek=new Methodlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc));

        
        int sonuc2=ornek.ArttirveTopla(ref a, ref b);
        ornek.EkranaYazdir(Convert.ToString(sonuc2));
        ornek.EkranaYazdir(Convert.ToString(a+b));
    }

static int Topla(int sayi1, int sayi2)
{
    return (sayi1+sayi2);
}

}

class Methodlar{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirveTopla(ref int sayi1,ref int sayi2)
    {
        sayi1+=1;
        sayi2+=2;
        return(sayi1+sayi2);
    }
}




}