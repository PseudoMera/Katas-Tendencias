using System;
using System.Collections.Generic;

namespace _2019_05_24
{
    class Program
    {

        static string Solve(int moneyLength) {
            if(moneyLength == 1) return "";
            else if(moneyLength == 2) return "";
            else if(moneyLength == 3) return "hundred and ";
            else if(moneyLength == 4) return "thousand and ";
            else if(moneyLength == 5) return "thousand and ";
            else if(moneyLength == 6) return "hundred thousand ";
            else if(moneyLength == 7) return "million ";
            else if(moneyLength == 8) return "million ";
            else if(moneyLength == 9) return "hundred million ";
            else return "billion ";
        }
        static string MoneyToWords(string money) {
            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            Dictionary<int, string> dic2 = new Dictionary<int, string>();
            for(int i = 0; i < 10; i++) {
                //Dictionary 1
                if(i == 2)
                    dic1.Add(i,"twenty ");
                 else if(i == 3) {
                     dic1.Add(i,"Thirty ");
                } else if(i == 4) {
                    dic1.Add(i, "Forty ");
                 } else if(i == 5) {
                     dic1.Add(i, "Fifty ");
                 } else if(i == 6) {
                     dic1.Add(i, "Sixty ");
                 } else if(i == 8) {
                     dic1.Add(i, "Eighty ");
                 } else if(i == 7) {
                     dic1.Add(i, "Seventy");
                 }
                 else if(i == 9) {
                     dic1.Add(i, "Ninety ");
                 } else if(i == 1) {
                     dic1.Add(i, "Ten ");
                 }

                //Dictionary 2
                if(i == 1) {
                    dic2.Add(i, "one");
                }
                else if(i == 2)
                    dic2.Add(i,"two ");
                 else if(i == 3) {
                     dic2.Add(i,"Three ");
                } else if(i == 4) {
                    dic2.Add(i, "Four ");
                 } else if(i == 5) {
                     dic2.Add(i, "Five ");
                 } else if(i == 6) {
                     dic2.Add(i, "Six ");
                 } else if(i == 7) {
                     dic2.Add(i, "seven ");
                 } else if(i == 8) {
                     dic2.Add(i, "eight ");
                 } else if(i == 9) {
                     dic2.Add(i, "nine ");
                 } else if(i == 0) {
                     dic2.Add(i, "zero ");
                 }
            }
            
            

            int moneySize = money.Length - 3;
            string Part = Solve(moneySize);
            string result = " ";
            int x = 0;
            foreach(char c in money) {
                int digit = c - 48;
                if(moneySize == 2 && x == 0) {
                    result += dic1[digit];
                    x++;
                    continue;
                } else if(moneySize == 2 && x == 1) {
                    result += dic2[digit];
                    x++;
                    continue;
                }

                 if(digit == 1) {
                     result +=  dic2[digit];
                }
                else if(digit == 2)
                    result +=  dic2[digit];
                 else if(digit == 3) {
                    result +=  dic2[digit];
                } else if(digit == 4) {
                    result +=  dic2[digit];
                 } else if(digit == 5) {
                    result +=  dic2[digit];
                 } else if(digit == 6) {
                    result +=  dic2[digit];
                 } else if(digit == 7) {
                     result +=  dic2[digit];
                 } else if(digit == 8) {
                    result +=  dic2[digit];
                 } else if(digit == 9) {
                    result +=  dic2[digit];
                 }
                x++;
                if(x == 1)
                    result += Part;

            }

            return result += " dollards";
        }
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            string toPrint = MoneyToWords(money);
            System.Console.WriteLine(toPrint);
        }
    }
}
