using System;

namespace dongulerWhile
{
    class Program
    {

        static void Main(string[] args)
        {
            //1 den başlayarak consoledan girilen sayıya kadar ortalama hesaplayıp
            Console.Write("Lütfen bir sayi giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while(sayac<=sayi)
            {
              toplam+=sayac;
              sayac++;
            }
            Console.WriteLine("ortalamasi: "+toplam/sayi);

            //a dan z ye kadar tüm harfleri consola yazdır.

            char character='a';
            while(character<'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("*****Foreach*****");
            string[] arabalar={"Bmw", "Ford" , "Toyota" , "Nissan"}; 

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            

            
        }
    }
}