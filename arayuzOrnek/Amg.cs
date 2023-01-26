namespace arayuzOrnek{

    public class Amg : IOtomobil
    {
        public Marka hangiMarkaninAraci()
        {
            return Marka.Mercedes;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;

        }

        public Renk standartRengiNe()
        {
            return Renk.Beyaz;
        }
    }

}