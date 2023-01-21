
using System;

namespace dizilerMethod
{

class Program
{
    static void Main(string[] args)
    {
        int[] sayiDizisi={12,56,52,82,47,31};
       Console.WriteLine("*****Sirasiz Dizi******");
       foreach (var sayi in sayiDizisi)
       Console.WriteLine(sayi);

       Console.WriteLine("*****Sirali Dizi******");
      Array.Sort(sayiDizisi);
     
    foreach (var sayi in sayiDizisi)
       Console.WriteLine(sayi);
//Clear

       Console.WriteLine("*****Clear Dizi******");
       //2.indexten 2 adım giderek silmiş oluruz.
           Array.Clear(sayiDizisi,2,2);
 foreach (var sayi in sayiDizisi)
       Console.WriteLine(sayi);
    
//Reverse
Console.WriteLine("*****Reverse Dizi******");
Array.Reverse(sayiDizisi);
 foreach (var sayi in sayiDizisi)
       Console.WriteLine(sayi);
    
//IndexOf
Console.WriteLine("*****İndexOf Dizi******");
Console.WriteLine(Array.IndexOf(sayiDizisi,52));
 
 //Resize
Console.WriteLine("*****Array Resize******");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8]=94;
 foreach (var sayi in sayiDizisi)
       Console.WriteLine(sayi);
       
}

}


}