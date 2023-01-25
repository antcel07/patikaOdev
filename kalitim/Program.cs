class Program{

    static void Main(string[] args)
    {
        //protected erişim belirleyicisidir
        //nesne oluşturduk nesne aracılığıyla sınıf içinde methodlarına erişicez
        TohumluBitkiler tohumluBitkiler=new TohumluBitkiler();
      

        tohumluBitkiler.TohumlaCogalma();
        
        Console.WriteLine("***********");

        Kuslar karga=new Kuslar();
        //protected olduğu için erişime kapalı hale geldi
        // karga.Beslenme();
        // karga.Bosaltim();
        // karga.Solunum();
        // karga.Ucmak();
    }
}