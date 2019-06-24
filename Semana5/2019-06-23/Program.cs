using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace _2019_06_23
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool RangeContains(char leftDel, int first, int last, 
        char rightDel, int[] rangeContained)
        {
            foreach(int num in rangeContained)
            {
                if(leftDel == '[' && num < first) return false;
                else if(leftDel == '(' && num <= first) return false;
                else if(rightDel == ')' && num >= last) return false;
                else if(rightDel == ']' && num > last) return false;
            }
            return true;
        }

        public static int[] GetAllPoints(char leftDel, int first, int last, char rightDel)
        {

            List<int> res = new List<int>();   
            if(leftDel == '(' && rightDel == ')')
            {
                for(int i = first + 1; i < last; i++) res.Add(i);
            }
            else if(leftDel == '[' && rightDel == ']')
            {
                for(int i = first; i <= last; i++) res.Add(i);
            }
            else if(leftDel == '(' && rightDel == ']')
            {
                for(int i = first + 1; i <= last; i++) res.Add(i);
            }
            else
            {
                for(int i =  first; i < last; i++) res.Add(i);
            }
            return res.ToArray();
        }
    }

    [TestFixture]
    class TestRange
    {
        //RangeContains [2,4] in [2,6)
        [TestCase('[',2,6,')', new int[] {2,4},true)]
        [TestCase('[', 2, 6, ')',new int[] {-1,1,6,10}, false)]
        [TestCase('(', 2, 6, ')',new int[] {-50, 2, 3, 4}, false)]
        [TestCase('(', 2, 6, ')',new int[] {3, 4, 6}, false)]
        [TestCase('(', 2, 6, ']',new int[] {3, 4, 6}, true)]
        [TestCase('[', 2, 5, ')', new int[] {3,10}, false)]


        public void TestRangeContains(char leftDel, int first, int last, char rightDel,int[] rangeContained,bool answer)
        {
            bool res = Program.RangeContains(leftDel, first, last, rightDel, rangeContained);
            Assert.AreEqual(res, answer);
        }

        [TestCase('[', 2, 6, ')', new int[] {2,3,4,5})]
        [TestCase('(', 2, 6, ']', new int[] {3,4,5,6})]
        [TestCase('[', 2,  6, ']', new int[] {2,3,4,5,6})]
        public void TestGetAllPoints(char leftDel, int first, int last, char rightDel, int[] rangeContained)
        {
            int[] res = Program.GetAllPoints(leftDel, first, last, rightDel);
            Assert.AreEqual(rangeContained, res);

        }

    }
}
