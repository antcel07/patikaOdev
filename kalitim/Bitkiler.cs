//default olarak private tanımlanır
//: ile kalıtım alıncak üst sınıfı belirtiriz
public class Bitkiler:Canlilar{

//protected ile sadece içeridekiler erişebilir dışarıya kapalı
//bunun için erişim belirleyicisi constructor kullanırız
    protected void FotosentezYapmak()
    {
        Console.WriteLine("bitkiler fotosentez yapar.");

    }


     public override void UyaranlaraTepki()
    {
        //base.UyaranlaraTepki();
        Console.WriteLine("Bitkiler güneşe tepki verir");
    }
}
//constructor oluşturarak nesne oluşturulduğunda çağrılmasını sağladık

public class TohumluBitkiler:Bitkiler{
//base anahtarı ile üst sınıflardaki metotlara erişebiliyoruz
public TohumluBitkiler(){
base.FotosentezYapmak();
base.Beslenme();
base.Bosaltim();
base.Solunum();
base.UyaranlaraTepki();
}


    public void TohumlaCogalma(){
        Console.WriteLine("tohumlu bitkiler tohumla çogalir");
    }
}

public class TohumsuzBitkiler:Bitkiler{

public TohumsuzBitkiler(){
base.FotosentezYapmak();
base.Beslenme();
base.Bosaltim();
base.Solunum();

}

    public void SporlaCogalma(){
        Console.WriteLine("tohumsuz bitkiler sporla çogalir");
    }
}