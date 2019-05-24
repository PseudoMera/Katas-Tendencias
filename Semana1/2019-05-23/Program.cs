using System;

namespace _2019_05_23
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

        static string ConvertMoneyToWords(string money, int moneyLength) {
            string variable = Solve(moneyLength);
            string res = "";
            int i = 0;
            foreach(char digit in money) {
                i++;
                if(digit == '.') {
                    res += "dollars and ";
                    continue;
                }
                switch(digit) {
                    case '0':
                    res += "zero ";
                        break;
                    case '1':
                        res += "one ";
                        break;
                    case '2':
                    res += "two ";
                        break;
                    case '3':
                    res += "three ";
                        break;
                    case '4':
                    res += "four ";
                        break;
                    case '5':
                    res += "five ";
                        break;
                    case '6':
                    res += "six ";
                        break;
                    case '7':
                    res += "seven ";
                        break;
                    case '8':
                    res += "eight ";
                        break;
                    case '9':
                    res += "nine ";
                        break;
                }
                if(i == 1) {
                    res += variable;
                }
            }

            return res += "cents";
        }
        static void Main(string[] args)
        {
           

            string amountToTransfer = Console.ReadLine();
            int howLong = amountToTransfer.Length - 3;
            string result = ConvertMoneyToWords(amountToTransfer, howLong);
            System.Console.WriteLine(amountToTransfer + "\\$ (amount in numbers)");
            System.Console.WriteLine(result + "(amount in words)");
           
        }
    }
}
