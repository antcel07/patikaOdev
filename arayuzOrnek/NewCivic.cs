namespace arayuzOrnek{

    public class NewCivic : Otomobil
    {
        //sadece virtual olanı override ederiz 
        public override Marka hangiMarkaninAraci()
        {
            return Marka.Honda;
        }

         public override Renk standartRengiNe()
        {
            return Renk.Gri;
        }
    }
}