using System;
using System.Collections;

namespace arrayList
{
class Program
{
    static void Main(string[] args)
{
ArrayList liste=new ArrayList();
liste.Add("Ayse");
liste.Add(2);
liste.Add(true);
liste.Add('A');

//içerisindeki verilere erişim
Console.WriteLine(liste[1]);
foreach (var item in liste)
{
    Console.WriteLine(item);
}
//AddRange
Console.WriteLine("***** Add Range *****");
string[] renkler={"kirmizi","sari","yesil"};
List<int> sayilar=new List<int>(){13,81,38,9,13,4,7,69};

liste.AddRange(renkler);
liste.AddRange(sayilar);
foreach (var item in liste)
{
    Console.WriteLine(item);
}
//sort
Console.WriteLine("***** Sort *****");
liste.Sort();
foreach (var item in liste)
{
    Console.WriteLine(item);
}
//Binary Search kacinci index oldugunu bulur
Console.WriteLine("***** Binary Search *****");
Console.WriteLine(liste.BinarySearch(9));


//reverse tersden sıralar
Console.WriteLine("***** Reverse *****");
liste.Reverse();
foreach (var item in liste)
{
    Console.WriteLine(item);
}

//clear 
Console.WriteLine("***** Clear *****");
liste.Clear();
foreach (var item in liste)
{
    Console.WriteLine(item);
}

}

}
}