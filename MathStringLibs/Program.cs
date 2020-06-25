using System;

using StringLib;
using MathLib;

namespace MathStringLibs {
    class Program {
        static void Main(string[] args) {

            var strlib = new Str();
            var inStr = "sflj";
            var outStr = strlib.Reverse(inStr);
            Console.WriteLine("{0} reversed is {1}"
                        , inStr, outStr);

            inStr = "abcdefg";
            outStr = strlib.Rotate(inStr);
            Console.WriteLine($"{inStr} rotated is {outStr}");

            inStr = "Gregory";
            outStr = strlib.RemoveVowels(inStr);
            Console.WriteLine($"{inStr} without vowels is {outStr}");

            var mathLib = new Algebra();
        }
    }
}
