using System;
using NUnit.Framework;

namespace _2019_06_16
{
    class Wrapper
    {
        static void Main(string[] args)
        {
            string res = Wrap("aa", 1);
            System.Console.WriteLine(res);
        }

        public static string Wrap(string message, int colum) 
        {
            int counter = 0;
            string wrapedMessage = "";
            foreach(char ch in message) 
            {
                if(counter == colum)
                {
                    counter = 0;
                    wrapedMessage += Environment.NewLine + ch;
                } 
                else
                {
                 wrapedMessage += ch;
                }
              counter++;

            }
            return wrapedMessage;
        }
    }

    [TestFixture]
    class WrapTest
    {

        [TestCase("", 1, "")]
        [TestCase("a",1, "a")]
        [TestCase("aaa", 1, "a" + "\n" + "a" + "\n" + "a")]
        public static void TWrap(string message, int colum, string result)
        {
            string res  = Wrapper.Wrap(message, colum);
            Assert.AreEqual(res, result);

        }

    }
}
