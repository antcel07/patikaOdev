using System;

namespace dongulerFor
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayi giriniz:");
            int sayac=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=sayac; i++)
            {
                if(i%2==1)
                Console.WriteLine(i);
            }
           // 1-1000 arası çift ve tek sayıların toplamlarını yazdır.
            int tekToplam=0;
            int ciftToplam=0;
            for (int k = 1; k <= 1000; k++)
            {
                if(k%2==0)
                {
                    ciftToplam+=k;
                }
                else
                {
                    tekToplam+=k;
                }
            }

            Console.WriteLine("tekToplam:"+tekToplam);
                Console.WriteLine("ciftToplam:"+ciftToplam);



                for (int i = 1; i < 10; i++)
                {
                    if(i==4)
                    //işlemi bitirir.
                        break;
                        Console.WriteLine(i);
                }

                

                for (int i = 1; i < 10; i++)
                {
                    if(i==4)
                    
                    //atlar
                        continue;
                        Console.WriteLine(i);
                }
        }
    }
}
