using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public static class StringExtensionMethods
    {
        // 'this' is the critical keyword for extension methods
        public static void Print(this string str) // this defines the object that is being extended
        {
            
            Console.WriteLine(str);
        }
        public static void Print(this int i)
        {
            Console.WriteLine(i);
        }
        public static int ConcatInt(this int i, int j)
        {
            return i * 10 + j;
        }
    }
}
