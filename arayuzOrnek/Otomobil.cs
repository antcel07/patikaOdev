namespace arayuzOrnek{
//abstrac örnekler için uygulama
// Abstract class'ları sadece kalıtım için kullanılan sınıflar gibi düşünebilirsiniz. 
// Bazı özellikleri ile sınıflara benzerlerken bazı özellikleriyle arayüzlere benzerler.
//  Abstract sınıfları arayüz ve virtual metotların birleşimi gibi davranış gösterirler.


// ÖNEMLI: Abstract sınıf içerisinde metot bildirimi yapabilmek için metodun erişim
//  belirtecinden sonra "abstract" anahtar kelimesi mutlaka yazılmalıdır.
// ÖNEMLI: Abstract metotdan türetilmiş sınıf 
// içerisinde abstract metodun kullanılabilmesi için de override anahtar kelimesinin kullanılması gerekir.


public abstract class Otomobil{
    public int kacTekerlektenOlusur(){
        return 4;
    }

    public virtual Renk standartRengiNe(){
   return Renk.Beyaz;
    }

    public abstract Marka hangiMarkaninAraci();
  
    
}

}