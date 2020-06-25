using System;
using System.Collections.Generic;
using System.Linq;

namespace StringLib {
    public class Str {
        public string Reverse(string a) {
            string aReversed = "";
            int aLength = a.Length;
            for(var idx = aLength - 1; idx >= 0; idx--) {
                aReversed += a[idx];
            }
            return aReversed;
        }
        public string Rotate(string a) {
            var dict = new Dictionary<string, string>();
            dict.Add("a", "b");
            dict.Add("b", "c");
            dict.Add("c", "d");
            dict.Add("d", "e");
            dict.Add("e", "f");
            dict.Add("f", "g");
            dict.Add("g", "h");
            dict.Add("h", "i");
            dict.Add("i", "j");
            dict.Add("j", "k");
            dict.Add("k", "l");
            dict.Add("l", "m");
            dict.Add("m", "n");
            dict.Add("n", "o");
            dict.Add("o", "p");
            dict.Add("p", "q");
            dict.Add("q", "r");
            dict.Add("r", "s");
            dict.Add("s", "t");
            dict.Add("t", "u");
            dict.Add("u", "v");
            dict.Add("v", "w");
            dict.Add("w", "x");
            dict.Add("x", "y");
            dict.Add("y", "z");
            dict.Add("z", "a");
            var rotated = "";
            foreach(var ch in a.ToCharArray()) {
                rotated += dict[ch.ToString()];
            }
            return rotated;
        }
        public string RemoveVowels(string a) {
            var noVowels = "";
            for(var idx = 0; idx < a.Length; idx++) {
                string ch = a[idx].ToString().ToUpper();
                if(ch == "A" || ch == "E" || ch == "I"
                        || ch == "O" || ch == "U") {
                    continue;
                }
                noVowels += a[idx].ToString();
            }
            return noVowels;
        }
    }
}
