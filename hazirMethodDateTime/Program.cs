using System;
namespace hazirMethodDateTime
{
class Program
{
    static void Main(string[] args)
{
    Console.WriteLine(DateTime.Now);
    Console.WriteLine(DateTime.Now.Day);
    Console.WriteLine(DateTime.Now.Minute);
    Console.WriteLine(DateTime.Now.DayOfWeek);
    Console.WriteLine(DateTime.Now.DayOfYear);
    Console.WriteLine(DateTime.Now.ToLongDateString());
    Console.WriteLine(DateTime.Now.ToShortDateString());
    Console.WriteLine(DateTime.Now.ToLongTimeString());
    Console.WriteLine(DateTime.Now.ToShortTimeString());

    Console.WriteLine(DateTime.Now.AddDays(2));
    Console.WriteLine(DateTime.Now.AddHours(3));
    Console.WriteLine(DateTime.Now.AddMonths(5));

    //datetime format
    //GÜN
    Console.WriteLine(DateTime.Now.ToString("dd"));
    Console.WriteLine(DateTime.Now.ToString("ddd"));
    Console.WriteLine(DateTime.Now.ToString("dddd"));
    //AY
    Console.WriteLine(DateTime.Now.ToString("MM"));
    Console.WriteLine(DateTime.Now.ToString("MMM"));
    Console.WriteLine(DateTime.Now.ToString("MMMM"));
    //Yıl
    Console.WriteLine(DateTime.Now.ToString("yy"));
     Console.WriteLine(DateTime.Now.ToString("yyyy"));

    //math kütüphanesi yuvarlama
    Console.WriteLine(Math.Abs(-25));
    Console.WriteLine(Math.Sin(-25));
    Console.WriteLine(Math.Round(35.7));

    Console.WriteLine(Math.Max(2,6));
    Console.WriteLine(Math.Min(2,6));
    //üs alma - karekök
    Console.WriteLine(Math.Pow(3,6));
    Console.WriteLine(Math.Sqrt(49));
    Console.WriteLine(Math.Log(9));








}

}
}