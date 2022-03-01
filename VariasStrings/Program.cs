using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
         string s = "Um tab\t e um copyright\u03A9";
         string d = @"Nao e’ um codigo Unicode \u1234, nao e’ nova linha \n";
         Console.WriteLine(s);
         Console.WriteLine(d);
        }
    }
}
