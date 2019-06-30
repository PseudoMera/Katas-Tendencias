using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace _2019_06_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string ConvertNumeral(int num)
        {
            Dictionary<int, string> numerals = new Dictionary<int, string>();
            numerals.Add(1,"I");
            numerals.Add(5,"V");
            numerals.Add(9, "IX");
            numerals.Add(10,"X");
            numerals.Add(50,"L");
            numerals.Add(100,"C");
            numerals.Add(500,"D");
            numerals.Add(1000,"M");
            string res = "";
            if(!numerals.ContainsKey(num))
            {
                if(num < 4)
                {
                    for(int i = 0; i < num; i++) 
                    {
                        res += numerals[1];
                    }
                }
                else if(num < 9)
                {
                    for(int i = 0; i < num; i++)
                    {
                        if(num == 4 && i == 0) res += numerals[1];
                        if(num == 4 && i == 1) {
                            res += numerals[5];
                            break;
                        }

                        if(num != 4)
                        {
                            if(i == 0) res += numerals[5];
                            else res += numerals[1];
                            num--;

                        }
                    }
                }
                return res;
            }

            return numerals[num];
        }
    }

    [TestFixture]
    class TestRomanNumerals
    {

        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        public void testConvertNumeral(int num, string res)
        {
            string answer = Program.ConvertNumeral(num);
            Assert.AreEqual(answer, res);
        }
    }
}
