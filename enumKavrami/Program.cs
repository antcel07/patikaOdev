using System;
using System.Collections;
namespace sinifKavrami
{
class Program
{
    static void Main(string[] args)
{
Console.WriteLine(Gunler.Persembe);
Console.WriteLine((int)Gunler.Persembe);
int derece=28;
if(derece<=(int)HavaDurumu.Normal)
{
    Console.WriteLine("Disari çikmak için biraz bekleyelim");
}
else if(derece>(int)HavaDurumu.Sicak )
{
      Console.WriteLine("Disari çikmak için cok sicak biraz bekleyelim");
}
else if(derece>=(int)HavaDurumu.Normal && derece<(int)HavaDurumu.CokSicak )
{
      Console.WriteLine("Disari çikabiliriz");
}
}
}
//otomatik olarak string tutmasını sağladık
//burada dizi gibi sıralı sekilde gider 0...6 kadar eger istersek kendimizde günlere = ile istediğimiz değeri verebilriz
enum Gunler
{
Pazartesi,
Sali,
Carsamba,
Persembe,
Cuma,
Cumaertesi,
Pazar

}
enum HavaDurumu{
    Soguk=10,
    Normal=20,
    Sicak=30,
    CokSicak=40
}
}