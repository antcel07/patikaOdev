//kalıtım alınacak sınıf sag tarafta yazılır yani üst sınıfıdır
public class Hayvanlar:Canlilar{
    
    //adaptasyon protected olduğu  için hayvanlar sınıfında erişilir bunu önüne geçmek için constructor ile değeri alırız 
    protected void Adaptasyon(){
        Console.WriteLine("Hayvanlar adapte kurabilir");
    }

    //üst kalıtım aldığımız canlilar sınıfında virtual ile yazılmış methodu burada alt sınıfta override ederek kullanmayı sağlarız buna polymorfism denir 

//sanal haldekini buraya koyarız
    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        Console.WriteLine("Hayvanlar temasa tepki verir");
    }

}

public class Sürüngenler:Hayvanlar{
public  Sürüngenler(){
    base.Adaptasyon();
    base.Beslenme();
    base.Bosaltim();
    base.Solunum();
}



    public void SurunerekHareketEderler(){
        Console.WriteLine("Sürüngenler sürünerek hareket eder");
    }
}

public class Kuslar:Hayvanlar{

    public  Kuslar(){
    base.Adaptasyon();
    base.Beslenme();
    base.Bosaltim();
    base.Solunum();
    base.UyaranlaraTepki();
}

    public void Ucmak(){
        Console.WriteLine("Kuslar Ucar");
    }
}