using System;
namespace algoritmaOdevi
{
class Program
{
    static void Main(string[] args)
{
    //Soru 1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
#region soru1
Console.Write("Sayi Giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] sayiListesi = new int[n];
for (int i = 0; i < sayiListesi.Length; i++)
{
    Console.Write($"{i+1}.Sayi: ");
    sayiListesi[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int sayi in sayiListesi)
{
    if (sayi % 2 == 0)
    {
        Console.WriteLine(sayi);
    } 
}
#endregion

//Soru 2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın
#region soru2
Console.Write(" Sayi Giriniz: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Sayi Giriniz: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int[] diziListesi = new int[n1];
for (int i = 0; i < diziListesi.Length; i++)
{
    Console.Write($"{i+1}.Sayi: ");
    diziListesi[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int dizi in diziListesi)
{
    if (dizi % n2 == 0 || dizi==n2)
    {
        Console.WriteLine(dizi);
    } 
}

#endregion

//Soru 3: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
#region soru3
Console.Write(" Sayi Giriniz: ");
int s1 = Convert.ToInt32(Console.ReadLine());
string[] kelimeListesi= new string[s1];
for (int i = 0; i < kelimeListesi.Length; i++)
{
    Console.Write($"{i+1}.Kelime: ");
    kelimeListesi[i]=Console.ReadLine();
}
foreach (string kelime in kelimeListesi.Reverse())
{
    Console.WriteLine(kelime);
}

#endregion

//Soru 4: Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
#region soru4
Console.Write("Cümle Yaziniz: ");
string cm = Console.ReadLine();
Console.WriteLine(cm.Length);
#endregion
}






}
}
