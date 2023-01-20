using System;

namespace ifElse
{
 class Program
 {
    static void Main(string[] args)
    {
        int time=DateTime.Now.Hour;
        if(time<=10)
        {
            Console.WriteLine("Günaydin");
        }
        else if(time>10 && time<18)
        {
            Console.WriteLine("İyi Günler");
        }
        else{
            Console.WriteLine("İyi Akşamlar");
        }


        string sonuc=time<18 ? "İyi günler" : "İyi aksamlar";
sonuc=time>6 && time<11 ? "Günaydin" : time<18 ? "İyi günler" : "İyi aksamlar";
Console.WriteLine(sonuc);

    }
 }  
}

