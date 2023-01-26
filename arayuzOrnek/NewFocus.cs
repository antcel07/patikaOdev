namespace arayuzOrnek{

    public class NewFocus : Otomobil
    {
        //sadece virtual olanı override ederiz 
        public override Marka hangiMarkaninAraci()
        {
            return Marka.Ford;
        }
    }
}