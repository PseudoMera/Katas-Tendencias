using System;
using NUnit.Framework;

namespace _2019_06_15
{
    class Wrapper
    {
        static void Main(string[] args)
        {
    
        }

        public static string Wrap(string str, int colum)
        {
            char[] ch = str.ToCharArray();
            string res = "";
            for(int i = 0, counter = 0; i < str.Length; i++) 
            {
                res += ch[i];
                counter++;
                if(counter == colum)
                    res += "\n";
                
            }
            return res;
        }

    }

    [TestFixture]
    class Test
    {
    
    [TestCase("", 2, "")]
    [TestCase("aa", 1, "a" + "\n" + "a")]
    [TestCase("aaa", 2, "aa" + "\n" + "a")]
    [TestCase("abcdefg", 5, "abcde" + "\n" + "fg")]
      public static void WrapTest(string str, int colum, string result)
      {
          //Wrapper wrapper = new Wrapper();
          string res = Wrapper.Wrap(str, colum);
          Assert.AreEqual(res, result);
      } 

    }
}
