using System;
using System.Collections.Generic;

namespace StringLib
{
    public static class StringLibrary
    {
       
        public static string Reverse(string s)
        {
            var arr = s.ToCharArray();
            var reverseds = "";
            for (int i = 0; i < s.Length; i++)
            {
                var idx2 = s.Length - i - 1;
                reverseds += arr[idx2];
            }
            return reverseds;
        }
        public static string RotateRight(string s)
        {
            return s[s.Length-1] + s.Substring(0,s.Length - 1);
        }
        public static string RotateLeft(string s)
        {
            return s.Substring(1, s.Length - 1) + s[0];
        }

        //public static string RotateRight(string s)
        //{
        //    var arr = s.ToCharArray();
        //    var rotated = "";
        //    for (int idx = 0; idx < s.Length; idx++)
        //    {
        //        if(idx == s.Length - 1)
        //        {
        //            rotated += arr[0];
        //            break;
        //        }
        //        rotated += arr[idx + 1];
        //    }
        //    return rotated;
        //}
        //public static string RotateLeft(string s)
        //{
        //    var arr = s.ToCharArray();
        //    var rotated = "";
        //    for (int idx = 0; idx < s.Length; idx++)
        //    {
        //        if (idx == 0)
        //        {
        //            rotated += arr[s.Length - 1];
        //            continue;
        //        }
        //        rotated += arr[idx - 1];
        //    }
        //    return rotated;
        //}
        public static string RemoveVowels(string s)
        {
            var arr = s.ToCharArray();
            var vowelless = "";
            var vowels = new List<char>();
            vowels = VowelList();
            for (int idx = 0; idx < s.Length; idx++)
            {
                if (vowels.Contains(arr[idx]))
                    continue;
                else
                    vowelless += arr[idx];
            }
            return vowelless;
        }
        //public static string RemoveVowels(string s)
        //{
        //    var counter = s.Length;
        //    for (int idx = 0; idx < counter; idx++)
        //    {
        //        if (s[idx] == 'a' || s[idx] == 'e' || s[idx] == 'i' || s[idx]== 'o' || s[idx] == 'u')
        //        {
        //            s.Remove(s[idx]);
        //            counter
        //        }
        //    }
        //    return s;
    
        // Splices string apart after the first vowel is detected
        // Reorders and appends the "ay" sound to the end of the text
        public static string PigLatin(string s)
        {
            var arr = s.ToCharArray();
            var Ending = "";
            var BodyText = "";
            var vowels = new List<char>();
            vowels = VowelList();
            for(int idx = 0; idx < s.Length; idx++)
            {
                if (!vowels.Contains(arr[idx]))
                {
                    Ending += arr[idx];
                }
                else
                {
                    for(int idx2 = idx; idx2 < s.Length; idx2++)
                    {
                        BodyText += arr[idx2];
                    }
                    break;
                }
            }
            return BodyText + Ending + "ay";
        }

        // Replaces all vowels with specified vowel
        public static string VowelReplacer(string s, string v)
        {
            var vowels = new List<char>();
            vowels = VowelList();
            var arr = s.ToCharArray();
            var FinalText = "";
            for(int idx = 0; idx < s.Length; idx++)
            {
                if (vowels.Contains(arr[idx]))
                    FinalText += v;
                else
                    FinalText += arr[idx];
            }
            return FinalText;
        }
        // Generates the list of the vowels
        public static List<char> VowelList()
        {
            var vowels = new List<char>();
            vowels.Add('a'); vowels.Add('A'); vowels.Add('e'); vowels.Add('E');
            vowels.Add('i'); vowels.Add('I'); vowels.Add('o'); vowels.Add('O');
            vowels.Add('u'); vowels.Add('U');
            return vowels;
        }
    }
}
