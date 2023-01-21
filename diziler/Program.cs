using System;
namespace diziler
{
class Program
{
    static void Main(string[] args)
    {
        string[] renkler=new string[5];

        string[] hayvanlar={"köpek","kedi","at","zürafa"};

        int []dizi;
        dizi=new int[5];

        renkler[0]="Mavi";
        dizi[3]=10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

//Döngülerle dizi kullanımı
//klavyeden girilen n tane sayının ortalamasını bulan program

Console.Write("Lütfen dizinin eleman sayisini giriniz: ");
int a=Convert.ToInt32(Console.ReadLine());
int[] eleman=new int[a];

for (int i = 0; i < a; i++)
{
    Console.Write("Lütfen {0}.sayisini giriniz: ", i+1);
    eleman[i]=Convert.ToInt32(Console.ReadLine());
}

int toplam=0;
foreach (var sayi in eleman)
    toplam+=sayi;
    Console.WriteLine("Ortalama: " + toplam/a);


    }
}

}