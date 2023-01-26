namespace arayuzOrnek{

    public class NewAmg : Otomobil
    {
        //sadece virtual olanı override ederiz 
        public override Marka hangiMarkaninAraci()
        {
            return Marka.Mercedes;
        }
    }
}