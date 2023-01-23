using System;
namespace algoritmaOdevi
{
class Program
{
    static void Main(string[] args)
{
string degisken="hosgeldiniz";
string degisken2="bugün pazartesi tekrardan hosgeldiniz";

Console.WriteLine(degisken.Length);
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());
//birleştirme
Console.WriteLine(String.Concat(degisken,"Merhaba"));//0,1,-1
//karşışaştırıyor uzunluklarını
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(String.Compare(degisken,degisken2,true));

//içerme içinde geçikoyormu kontrolü
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken2.EndsWith("hosgeldiniz"));
Console.WriteLine(degisken2.StartsWith("bugün"));

//buldugu indexi verir,ekler,son istenileni verir vs.
Console.WriteLine(degisken2.IndexOf("gel"));
Console.WriteLine(degisken.Insert(0,"merhaba"));
Console.WriteLine(degisken.LastIndexOf("i"));

//araya boşluk yada karakter koyabiliriz.
Console.WriteLine(degisken+degisken2.PadLeft(30));
Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

//remove
Console.WriteLine(degisken.Remove(5,3));

//replace(değiştirme)
Console.WriteLine(degisken2.Replace("pazartesi","cuma"));

//Split(dizi oluştırma kelimeleri ayırma)
Console.WriteLine(degisken2.Split(' ')[1]);

//substring belirlenen indexden başlayarak cümlenin sonuna kadar getirir yada belirnene aralıkı getirir.
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));
}

}
}