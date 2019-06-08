using System;
using NUnit.Framework;

namespace _2019_06_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // string tst = "When not studying nuclear physics, Bambi likes to play beach volleyball.";
            // Program program = new Program();
            // char[] tst2 = program.SortC(tst);
            // foreach(var x in tst2)
            //     System.Console.Write(x);
        }


        private bool Compare(IComparable a, IComparable b) 
        {
            return a.CompareTo(b) == -1;
        }

        private void Swap<A>(A[] arr, int a, int b) where A : IComparable 
        {
            A tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }


        public A[] SortB<A>(A[] arr) where A : IComparable
        {
            for(int i = 0; i < arr.Length; i++) {
                for(int j = 0; j < arr.Length; j++) {
                    if(Compare(arr[i], arr[j])) {
                        Swap(arr, i, j);
                    }
                }
            }

            return arr;
        }

        // public char[] SortC(string str) 
        // {
        //     char[] chstr = str.ToCharArray();
        //     Array.Sort<char>(chstr);
        //     return chstr;
        // }
    }


    [TestFixture]
    class SortTest
    {

        [TestCase(new int[] {}, new int[] {})]
        [TestCase(new int[] {2,1}, new int[] {1,2})]
        [TestCase(new int[] {5}, new int[] {5})]
        [TestCase(new int[] {5,6,2,3,4,100,-1,-25}, 
        new int[] {-25,-1,2,3,4,5,6,100})]
        public void TestBalls(int[] arr, int[] finalRes) 
        {
            Program program = new Program();
            int[] res = program.SortB(arr);
            Assert.AreEqual(finalRes, res);
        }

        // [TestCase("","")]
        // [TestCase("dba", "abd")]
        // [TestCase("When not studying nuclear physics, Bambi likes to play beach volleyball.", "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy")]
        // public void TestChars(string msg, string res) 
        // {   
        //     Program program = new Program();
        //     char[] arr = program.SortC(msg);
        //     string srtMsg =  new string(arr);
        //     Assert.AreEqual(res, srtMsg);

        // }

        

    }

}
