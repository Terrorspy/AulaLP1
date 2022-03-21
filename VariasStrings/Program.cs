using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
         double xx = 0.1234;
         string x = "Ido";
         string y = "Odi";

         string s = "Um tab\t e um copyright\u03A9";
         string e = @"Nao e um codigo Unicode \u1234, nao e nova linha \n";
         string a = "a" + 2;
         string b = $"valor de x e";
         string c = String.Format("Y e {1}, X e {0}", x, y);
         string k = String.Format("{1,6:f2} e {0:p1}", 0.1234, 18);
         string h = $"x={xx:f2}";
         string l = String.Format("{1,6:x2} e {0:c1}", 0.1234, 18);

         Console.WriteLine(".{0,4: x}. e .{1,-4:x}.", 10, 11);
         Console.WriteLine(@"Verbatim com x = {0}");
         Console.WriteLine(a);
         Console.WriteLine(b);
         Console.WriteLine(s);
         Console.WriteLine(e);
         Console.WriteLine(c);
         Console.WriteLine(k);
         Console.WriteLine(h);
         Console.WriteLine(l);
        }
    }
}
