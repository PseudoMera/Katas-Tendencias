using System;

namespace _2019_05_25
{
    class Program
    {

        static string Solve(int moneySize) {
                if(moneySize == 3) return "hundred ";
                if(moneySize == 4 || moneySize == 5) return "thousand ";
                if(moneySize == 6) return "hundred thousand ";
                if(moneySize == 7) return "million ";

                throw new Exception("Not valid number");
        }   

        static string OneToNine(string digit, int index) {
            if(digit[index] == '0') return " zero ";
            if(digit[index] == '1') return " one ";
            if(digit[index] == '2') return " two ";
            if(digit[index] == '3') return " three ";
            if(digit[index] == '4') return " four ";
            if(digit[index] == '5') return " five ";
            if(digit[index] == '6') return " six ";
            if(digit[index] == '7') return " seven ";
            if(digit[index] == '8') return " eight ";
            if(digit[index] == '9') return " nine ";

            throw new Exception("Not valid number");
        }


        static string TwoDigit(string money) {
            string temp = "";
            if(money[0] == '2') temp+= "twenty ";
            if(money[0] == '3') temp += "thirty ";
            if(money[0] == '4') temp += "forty ";
            if(money[0] == '5') temp += "fifty ";
            if(money[0] == '6') temp += "sixty ";
            if(money[0] == '7') temp += "seventy ";
            if(money[0] == '8') temp += "eighty ";
            if(money[0] == '9') temp += "nighty ";
            if(money[0] == '1') {
                if(money[1] == '0') return "ten ";
                if(money[1] == '1') return "eleven ";
                if(money[1] == '2') return "twelve ";
                if(money[1] == '3') return "thirdteen ";
                if(money[1] == '4') return "fourteen ";
                if(money[1] == '5') return "fifteen ";
                if(money[1] == '6') return "sixteen";
                if(money[1] == '7') return "seventeen ";
                if(money[1] == '8') return "eighteen ";
                if(money[1] == '9') return "nineteen ";
              
            }

            if(money[1] != 0 && money[0] != 1) 
                temp += OneToNine(money, 1);

            return temp;
        }


        static string MoneyToWords(string money) {
            int moneyLength = money.Length - 3;
            string result =  "";
            if(moneyLength == 2) 
                result = TwoDigit(money);
            else if(moneyLength == 1) {
                   result += OneToNine(money,0);
            } else if( moneyLength == 3) {
                result += OneToNine(money,0);
                result += Solve(moneyLength);
                result += OneToNine(money, 1);
                result += OneToNine(money, 2);
            } else if(moneyLength == 4) {
                result += OneToNine(money, 0);
                result += Solve(moneyLength);
                result += OneToNine(money, 1);
                result += OneToNine(money, 2);
                result += OneToNine(money, 3);
            } else if(moneyLength == 5) {
                 result += OneToNine(money, 0);
                result += Solve(moneyLength);
                result += OneToNine(money, 1);
                result += OneToNine(money, 2);
                result += OneToNine(money, 3);
                result += OneToNine(money, 4);
            } else if(moneyLength == 6) {
                result += OneToNine(money, 0);
                result += Solve(moneyLength);
                result += OneToNine(money, 1);
                result += OneToNine(money, 2);
                result += OneToNine(money, 3);
                result += OneToNine(money, 4);              
                result += OneToNine(money, 5);
            } else if(moneyLength == 7) {
                 result += OneToNine(money, 0);
                result += Solve(moneyLength);
                result += OneToNine(money, 1);
                result += OneToNine(money, 2);
                result += OneToNine(money, 3);
                result += OneToNine(money, 4);
                 result += OneToNine(money, 5);
                result += OneToNine(money, 6);
               
            }

            return result;
        }
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            string result = MoneyToWords(money);
            System.Console.WriteLine(result += "dollards");

        }
    }
}
