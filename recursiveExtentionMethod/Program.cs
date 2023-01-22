using System;

namespace recursiveExtentionMethod
{
class Program
{
static void Main(string[] args)
{
//Rekürsif-Öz yinelemeli

int sonuc=1;
for (int i = 1; i < 5; i++){
    sonuc=sonuc*3;
    Console.WriteLine(sonuc);

Islemler inst=new Islemler();
   Console.WriteLine(inst.Expo(3,4));


//Extension Methodlar direk veriyi çağırabiliriz.
string ifade="Kerem Çelik";
bool cikti=ifade.CheckSpaces();
Console.WriteLine(cikti);
if(cikti)
{
    Console.WriteLine(ifade.RemoveWithSpaces());

     Console.WriteLine(ifade.MakeUpperCase());

     int [] dizi={9,3,1,6,7,0,2};

     dizi.SortArray();
dizi.EkranaYazdir();

int sayi=5;
Console.WriteLine(sayi.IsEverNumber());
Console.WriteLine(ifade.GetFirstCharacter());
}
    





}

}
}
public class Islemler{

    public int Expo(int sayi,int us){

        if(us<2)
        return sayi;
        return Expo(sayi,us-1)*sayi;
    }

}

public static class MyExtension{

    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }
  public static string RemoveWithSpaces(this string param)
    {
        string[] dizi=param.Split(" ");
        return string.Join("",dizi);
    }


        public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

            public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

           public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }


    public static void EkranaYazdir(this int[] param)
    {
       foreach (int item in param)
       {
        Console.WriteLine(item);
       }
    }

    public static bool IsEverNumber(this int param)
    {
      return param%2==0;
    }

    public static string GetFirstCharacter(this string param)
    {
      return param.Substring(0,1);
    }



}



}
