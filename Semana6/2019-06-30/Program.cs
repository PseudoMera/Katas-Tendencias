using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace _2019_06_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string ConvertToNumeral(int number) 
        {
            Dictionary<int, string> numerals = new Dictionary<int, string>();
            numerals.Add(0, "X");
            numerals.Add(1,"I");
            numerals.Add(2,"II");
            numerals.Add(3,"III");
            numerals.Add(4,"IV");
            numerals.Add(5,"V");
            numerals.Add(6,"VI");
            numerals.Add(7,"VII");
            numerals.Add(8,"VIII");
            numerals.Add(9,"IX");
            numerals.Add(10,"X");
            numerals.Add(50,"L");
            numerals.Add(100, "C");
            numerals.Add(500, "D");
            numerals.Add(1000, "M");
            string res = "";
            if(numerals.ContainsKey(number)) return numerals[number];
            else 
            {
                if(number < 40)
                {
                    string res2 = "";
                    int lastDigit = number % 10;
                    res += numerals[lastDigit];
                    number /= 10;
                    for(int i = 0; i< number; i++)
                        res2 += "X";
                    return res2 + res;
                }
                else if(number < 50)
                {
                    res += "XL";
                    int lastDigit = number % 10;
                    return number == 40 ?  res : res + numerals[lastDigit];

                }
                else
                {
                    res += "L";
                    int quant = Math.Abs(number/10 - 50/10);
                    for(int i = 0; i < quant; i++)
                        res += "X";

                    int lastDigit = number%10;
                    return res + numerals[lastDigit];    
                }
            }
        }
    }

    [TestFixture]
    class TestNumerals
    {

        [TestCase(1, "I")]
        [TestCase(10, "X")]
        [TestCase(7, "VII")]
        [TestCase(5, "V")]
        [TestCase(15, "XV")]
        [TestCase(40, "XL")]
        [TestCase(35, "XXXV")]
        [TestCase(17, "XVII")]
        [TestCase(29, "XXIX")]
        [TestCase(45, "XLV")]
        [TestCase(50, "L")]
        [TestCase(75, "LXXV")]
        [TestCase(83, "LXXXIII")]
        public void TestConvert(int number, string numeral)
        {
            string result = Program.ConvertToNumeral(number);
            Assert.AreEqual(result, numeral);
        }
    }
}
