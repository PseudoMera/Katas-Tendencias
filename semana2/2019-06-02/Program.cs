using System;
using NUnit.Framework;

namespace _2019_06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum("1\n2,3");
        }

        public static int Sum(string str) 
        {
            string[] arr = str.Split(new char[] {',', ';', '\n', '\\', '/'});
            int finalSum  = 0;
            foreach(var x in arr) {
                if(x == "" || x == " ")
                    continue;
                finalSum += Int32.Parse(x);
            }

            return finalSum;
        }
    }

    [TestFixture]
    class ProgramTest 
    {

        [TestCase("1,1", 2)]
        [TestCase("1;1", 2)]
        [TestCase(",", 0)]
        [TestCase("1,1,1,1,1,1,1,1", 8)]
        [TestCase("1\n2,3", 6)]
        [TestCase("1,1,", 2)]
        [TestCase("1/1", 2)]
        [TestCase("-1,2",1)]
        public static void SumTest(string str, int z)
        {
            int sum = Program.Sum(str);
            Assert.AreEqual(z, sum);
        }

    }
}
