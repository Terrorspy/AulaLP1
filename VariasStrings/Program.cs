using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
         string s = "Um tab\t e um copyright\u03A9";
         string e = @"Nao e um codigo Unicode \u1234, nao e nova linha \n";
         string a = "a" + 2;
         string b = $"valor de x e";
         string c = String.Format("Não Funciona??, please help");
         Console.WriteLine(@"Verbatim com x = {0}");
         Console.WriteLine(a);
         Console.WriteLine(b);
         Console.WriteLine(s);
         Console.WriteLine(e);
         Console.WriteLine(c);
        }
    }
}
