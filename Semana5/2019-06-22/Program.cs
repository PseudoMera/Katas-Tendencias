using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace _2019_06_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] res = RangeContains('(', 0, 0, ')');
            foreach(int num in res)
            {
                System.Console.WriteLine(num);
            }
        }

        static public int[] RangeContains(char leftDel, int first, int last, char rightDel)
        {
            List<int> res =  new List<int>();
            if(leftDel == '(' && rightDel == ')' && first == last)
            {
                return res.ToArray();
            }
            if(leftDel == '(')
            {
                res.Add(++first);
            } 
            else if(leftDel == '[')
            {
                res.Add(first);
            }

            if(rightDel == ')')
            {
                res.Add(--last);
            } 
            else if((rightDel == ']'))
            {
                res.Add(last);
            }

            if(res.Count < 2)
                throw new Exception("Invalid Range!");

            
            return res.ToArray();
        }

        static public int[] GetAllPoints(char leftDel, int first, int last, char rightDel)
        {
            List<int> res = new List<int>();
            if(leftDel == '(' && rightDel == ')')
            {
                for(int i = ++first; i < last; i++)
                {
                    res.Add(i);
                }
            }
            else if(leftDel == '[' && rightDel == ']')
            {
                for(int i = first; i <= last; i++)
                {
                    res.Add(i);
                }

            }
            else if(leftDel == '(' && rightDel == ']')
            {
                for(int i = ++first; i <= last; i++) 
                {
                    res.Add(i);
                }

            }
            else if(leftDel == '[' && rightDel == ')')
            {
                for(int i = first; i < last; i++)
                {
                    res.Add(i);
                }

            }
            else
            {
                throw new Exception("Invalid Range!");
            }

            return res.ToArray();
        }
    }

    [TestFixture]
    class TestRange
    {
        
        [TestCase('[', 2,6,')', new int[] {2,5})]
        [TestCase('(', 2, 5, ')', new int[] {3,4})]
        [TestCase('(', 0, 0, ')', new int[]{})]
        [TestCase('(',0, 1,']', new int[]{1,1})]
       public void TestRangeContains(char leftDel, int first, int last, char rightDel, int[] res)
        {   
            int[] res2 = Program.RangeContains(leftDel, first, last, rightDel);
            Assert.AreEqual(res,res2);
        }


        [TestCase('[', 2,6,')',  new int[] {2,3,4,5})]
        [TestCase('[', 2,6,']', new int[] {2,3,4,5,6})]
        [TestCase('(', 2,6,')', new int[] {3,4,5})]
        [TestCase('(', 2,6,']', new int[] {3,4,5,6})]


        public void TestGetAllPoints(char leftDel, int first, int last, char rightDel, int[] res)
        {
            int[] res2 = Program.GetAllPoints(leftDel, first, last, rightDel);
            Assert.AreEqual(res,res2);

        }

    }

    
}
