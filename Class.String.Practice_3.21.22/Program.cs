using System;
using System.Collections.Generic;

namespace Class.String.Practice_3._21._22 {
    class Program {
        static void Main(string[] args) {

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Working with Strings in randomStrings:

            var randomStrings = new[] {
                "KCKMjm1q4ClTkKIm3RGZ",
                "6tTkOZI346hSVyzopihn",
                "4SR5KUmB9qa5uA5gn2vv",
                "CIlitpzKlfpXf8eupwRl",
                "BKNOBaetlnYw0fnJtzw5",
                "Cb7PNe2AEDyeeMwFQYJ8",
                "k1TcQCIboMOKkcRNLlKG",
                "9L4HFK5pkVHyj1iIo8ZK",
                "R7lqTHL52LhiJJ5sDOj7",
                "v8vQirbT5ZCS54WtQ60m",
                "r7uu6zPaeJN0WIaJKKlR",
                "hyd8ZQn1KDG313Gs9kG8",
                "zrux2JoRWjwSHout2ATs",
                "wE7G0gfcIgpDVoPF9Fe4",
                "maDsDqIrVlfN3lbF1cBl",
                "A3p4A5evIIMBiayRYbYf",
                "4M8dv31fSiRhFciCpeJJ",
                "55KSkCWg4xhhtdEs6rPY",
                "6iOicdqGWi6kP5wMXm4Z",
                "QLzfPgWL4PGCOrOaRG09",
                "k68V0RnDF3NOETCyn3DD",
                "zFy1nBUO0CqtuPUaYx1u",
                "kCeVu4voc84T5yExWQMM",
                "EQ2jWgYAagGDawHRf11m",
                "HuwAX0ENxoAkkZMdMat1",
                "5TAAWwO4A4qKCwak2e4r",
                "bUm6ho2m33s7pNcFpEJK",
                "EQldy8TdCNl7SXcb32bU",
                "OrXZVLSLOE1J5Z31bpwD",
                "jwyOANUf35TatQtEgoyO",
                "FKgYnfxTOq2UhQ3YMKAV",
                "YpS3bc4LPeOqiQ6jiiYB",
                "mfgFNelXhLCPA7fjnpba",
                "KndUYncIksi2mtfVbTtR",
                "pOB3HE9DGKnM80mY4Bw5",
                "z0h1FZXSiAUxlsuLPpmA",
                "f186JA3KD5wKwmJXuNul",
                "kJ5UMLzbyCEoiGFg24cE",
                "H45Aejd7AyEfLG4LenjQ",
                "jfdfWmpKwfY9W9DQTiAH",
                "8xV6SgGFnYFvtN2CTKDN",
                "WEHgJ838cK9CcAGI7IQp",
                "RcjCRlrp0Dws9FbbU1bC",
                "ZXCmBS6KM7KeRuDzqeK2",
                "GBQUzKtKIWgzxHxpypL4",
                "9xVgNTUoQoUNJF52hqYw",
                "6InjKmHZUJcoc1iOSvGf",
                "LUJHcl8DSuLiwn5U4mYC",
                "10YFGJ4xSFpSWiGGMKlt",
                "bQ7Txv5mNIWlkdkNrnrT"
            };
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Strings from randomStrings that have a 3 in them
            var count = 0;
            foreach(var strWith3 in randomStrings) {
                if(strWith3.Contains("3")) {
                    count++;
                    //// Prints out list of Strings with a 3 in them
                    //Console.WriteLine(strWith3);
                }
            }
            Console.WriteLine($"\nThere are {count} strings containing a 3.\n\n");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Strings from randomStrings that don't have a 3 in them
            var countWithout3 = 0;
            foreach (var strNo3 in randomStrings) {
                if (!strNo3.Contains("3")) {
                    countWithout3++;
                    //// Prints out list of Strings that don't have a 3 in them
                    //Console.WriteLine(strNo3);
                    continue;
                }
            }
            Console.WriteLine($"\nThere are {countWithout3} strings that don't contain a 3.\n\n");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Finding Strings that don't have an A or B in them
            var countStrWithoutAa_or_Bb = 0;
            foreach(var strNoAorB in randomStrings) {
                if(!strNoAorB.Contains("A") && !strNoAorB.Contains("a") && !strNoAorB.Contains("B") && !strNoAorB.Contains("b")) {
                    countStrWithoutAa_or_Bb++;
                    //// Prints out Strings that don't have a upper or lowercase A and B
                    //Console.WriteLine(strNoAorB);
                }
            }
            Console.WriteLine($"\nThere are {countStrWithoutAa_or_Bb} strings that don't contain a lower or uppercase A and B.\n\n");

            // Another way is:
            var countNoAaOrBb = 0;
            foreach (var s in randomStrings) {
                if (s.IndexOfAny(new char[] { 'a', 'A', 'b', 'B'}) > -1) {
                    continue;
                }
                countNoAaOrBb++;
                //// Prints out List of All strings that match
                //Console.WriteLine(s);
            }
            Console.WriteLine($"\nAnother way of above is that there are {countNoAaOrBb} strings without an A or B.\n\n");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Strings from randomStrings that have a 1 or 5 in them
            var countOf1or5 = 0;
            foreach (var strWith1or5 in randomStrings)
            {
                if (strWith1or5.Contains("1") || strWith1or5.Contains("5")) {
                    countOf1or5++;
                    //// Prints out list of Strings with a 1 or 5 in them
                    Console.WriteLine(strWith1or5);
                }
            }
            Console.WriteLine($"\nThere are {countOf1or5} strings, shown above that contain a 1 or 5.\n\n");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Working with Dictionaries in kvPairs and keys:

            var kvPairs = new Dictionary<string, int>() {
                ["BEQJ"] = 7446,
                ["MCSM"] = 7295,
                ["DYOR"] = 6880,
                ["LYER"] = 6013,
                ["HUPE"] = 5499,
                ["QPED"] = 7673,
                ["IONX"] = 5760,
                ["NCBW"] = 1808,
                ["SKHF"] = 5905,
                ["IZPF"] = 6386,
                ["FVYP"] = 7959,
                ["PLZN"] = 3528,
                ["CMSK"] = 9418,
                ["XCYQ"] = 4560,
                ["UKZD"] = 3235,
                ["OKLE"] = 1179,
                ["IAZV"] = 2944,
                ["LVHG"] = 9761,
                ["FXGX"] = 9317,
                ["NZQY"] = 1097,
                ["WYPX"] = 6016,
                ["JMRW"] = 1615,
                ["HAVQ"] = 2060,
                ["QJTF"] = 3598,
                ["LLVK"] = 5265,
                ["SVUY"] = 5334,
                ["MTDQ"] = 4703,
                ["XVCW"] = 5204,
                ["SBRL"] = 6022,
                ["FKEO"] = 7931,
                ["XZWJ"] = 6374,
                ["SRPM"] = 6189,
                ["EDSG"] = 7631,
                ["YRIB"] = 2651,
                ["ZBGK"] = 1718,
                ["UHCL"] = 1111,
                ["FQAF"] = 6047,
                ["QDSL"] = 4226,
                ["PQAA"] = 9021,
                ["YIQY"] = 3779,
                ["AVOF"] = 3520,
                ["ZUHS"] = 8823,
                ["AAER"] = 3502,
                ["YPTJ"] = 9873,
                ["XIDT"] = 7007,
                ["PICQ"] = 9003,
                ["XLVJ"] = 5946,
                ["WIMS"] = 5822,
                ["AJWE"] = 8274,
                ["UCAB"] = 6710
            };

            var keys = new List<string>() {
                "BEQJ","LYER","IONX","NCBW","SKHF","XCYQ",
                "UKZD","FXGX","HAVQ","MTDQ","XVCW","EDSG","YRIB",
                "FQAF","QDSL","ZUHS","YPTJ","XIDT","PICQ","UCAB"
                };
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Finding sum of numbers in kvPairs based on the keys in key list
            var sumNumsInkvPairs = 0;
            foreach(var key in keys) {
                sumNumsInkvPairs += kvPairs[key];
            }
            Console.WriteLine($"\nThe sum is {sumNumsInkvPairs:n0}.\n\n");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
