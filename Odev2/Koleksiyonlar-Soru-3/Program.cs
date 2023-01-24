using System;
using System.Collections;

namespace Koleksiyonlar
{
class Program
{
    static void Main(string[] args)
{

char[] sesliHarfler = { 'a', 'e', 'i', 'o', 'ö', 'u', 'ü' };
List<char> arr = new List<char>(){ };
Console.Write("Cümlenizi giriniz: ");
string cumle = Console.ReadLine().ToLower();
foreach (char character in cumle)
{
    foreach (char item in sesliHarfler)
    {
        if (character == item)
        {
            arr.Add(character);
        }
    }
}
foreach (char item in arr)
{
    Console.Write(item);
}

}
}
}
