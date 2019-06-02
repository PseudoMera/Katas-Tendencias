using System;
using NUnit.Framework;

namespace _2019_06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add("");
        
        }

        public static int Add(string element) {
            string[] save = element.Split(new string[] {";", ","}, StringSplitOptions.None);
            int result = 0;
            foreach(string str in save) {
                if(str == "" || str == " ")
                    continue;

                result += Int32.Parse(str);
            }

            return result;
        }

       
    }

    [TestFixture]
    class ProgramTests 
    {
        [TestCase("1,2,", 3)]
        [TestCase("1;3", 4)]
        [TestCase("", 0)]
       // [TestCase("5,a",5)]
        //[TestCase(,2)]
        public void sum(string x,  int z) {
            var result = Program.Add(x);
            Assert.AreEqual(z, result);
        }

    }
}
