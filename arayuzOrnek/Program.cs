using System;

namespace arayuzOrnek;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("******************INTERFACE****************");
     Focus focus=new Focus();
     Console.WriteLine(focus.hangiMarkaninAraci().ToString());
     Console.WriteLine(focus.kacTekerlektenOlusur().ToString());
     Console.WriteLine(focus.standartRengiNe().ToString());

     Amg amg=new Amg();
     Console.WriteLine(amg.hangiMarkaninAraci().ToString());
     Console.WriteLine(amg.kacTekerlektenOlusur().ToString());
     Console.WriteLine(amg.standartRengiNe().ToString());

     Civic civic=new Civic();
     Console.WriteLine(civic.hangiMarkaninAraci().ToString());
     Console.WriteLine(civic.kacTekerlektenOlusur().ToString());
     Console.WriteLine(civic.standartRengiNe().ToString());

  Console.WriteLine("******************ABSTRACT****************");

//-----------------------------------------------------------------

     NewFocus focus1=new NewFocus();
     Console.WriteLine(focus1.hangiMarkaninAraci().ToString());
     Console.WriteLine(focus1.kacTekerlektenOlusur().ToString());
     Console.WriteLine(focus1.standartRengiNe().ToString());

     NewAmg amg1=new NewAmg();
     Console.WriteLine(amg1.hangiMarkaninAraci().ToString());
     Console.WriteLine(amg1.kacTekerlektenOlusur().ToString());
     Console.WriteLine(amg1.standartRengiNe().ToString());

     NewCivic civic1=new NewCivic();
     Console.WriteLine(civic1.hangiMarkaninAraci().ToString());
     Console.WriteLine(civic1.kacTekerlektenOlusur().ToString());
     Console.WriteLine(civic1.standartRengiNe().ToString());



 


    }

}   