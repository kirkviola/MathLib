using System;
using MathLib;
using StringLib;


namespace TestmathLib
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(MathLibrary.Cubed(3));
            Console.WriteLine(MathLibrary.Inverse(5));
            Console.WriteLine(MathLibrary.Modulo(9, 2));
            StringLibrary.Reverse("Jacob").Print();
            StringLibrary.RotateRight("abcdefg").Print();
            StringLibrary.RotateLeft("abcdefg").Print();
            StringLibrary.RemoveVowels("Hello my name is Bob").Print();
            StringLibrary.PigLatin("Jim").Print();

            "Hello World!".Print();
            7.ConcatInt(3).ConcatInt(5).Print();
        }
    }
}
