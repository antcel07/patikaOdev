//sealed kalıtımı engeller
public  class Canlilar {
    protected void Beslenme(){
        Console.WriteLine("Canlilar beslenir.");        
    }

    protected void Solunum(){
        Console.WriteLine("Canlilar solunum yapar."); 
    }

    protected void Bosaltim()
    {
        Console.WriteLine("Canlilar boşaltim Yapar."); 
    }


   public virtual void UyaranlaraTepki()
   {
    Console.WriteLine("Canlilar uyaranlara tepki verir.");

   }

}