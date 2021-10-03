using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace XOcomparer
{
    class ArrayAnalyser
    {
        public static bool XOComparerMeth1(string input)
        {
            //1-й вариант
            Regex matchX = new Regex(@"x", RegexOptions.IgnoreCase);
            int a = matchX.Matches(input).Count;
            Regex matchO = new Regex(@"o", RegexOptions.IgnoreCase);
            int b = matchO.Matches(input).Count;
            bool c = a - b == 0;
            return c;
        }
        public static bool XOComparerMeth2(string input)
        {
            //2-й вариант
            return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string text = "ooXoOxx";
            Console.WriteLine(ArrayAnalyser.XOComparerMeth1(text));
        }
    }

}
