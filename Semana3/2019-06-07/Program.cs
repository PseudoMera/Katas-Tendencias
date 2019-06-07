using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace _2019_06_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4,2,1,5,3};
            Program program = new Program();
            int [] result = program.SelectionSort(arr);
        }

        private bool Less(IComparable a, IComparable b) 
        {
            return a.CompareTo(b) == -1;
        }

        private void Swap<A> (A[] arr, int i, int j) where A : IComparable 
        {  
            A temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public A[] SelectionSort<A> ( A[] arr) where A : IComparable
        {
            for(int i = 0; i < arr.Length; i++) {
                int min = i;
                for(int j = i + 1; j < arr.Length; j++) {
                    if(Less(arr[j], arr[min])) {
                        min = j;
                    }
                }
                Swap(arr, min, i);
            }

            return arr;
        }



         
    }

    [TestFixture]
    class SortingTest
    {
        [TestCase(new int[] {}, new int[] {})]
        [TestCase(new int[] {1}, new int[] {1})]
        [TestCase(new int[] {2,1}, new int[] {1,2})]
        [TestCase(new int[] {4,2,1,5,3}, new int[] {1,2,3,4,5})]
        [TestCase(new int[] {-5,-1,0,4,5,6,-10,-100,1,2,0,6,5}, 
        new int[] {-100, -10, -5, -1, 0, 0, 1, 2, 4, 5, 5, 6, 6})]
        public void SortedNUmbers(int[] arr, int [] res)
        {
            Program program = new Program();
            int[] resBalls = program.SelectionSort(arr);
            Assert.AreEqual(res, resBalls);
            
        }

    }


}
