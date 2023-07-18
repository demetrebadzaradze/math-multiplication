using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

namespace Csharpproject
{
/*
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num1;
            int num2;
            string stringResult = "";
            int result;
            int rightAnswers = 0;
            List<int> HardNums1 = new List<int>();
            List<int> HardNums2 = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                HardNums1.Add(random.Next(6, 9));
                HardNums2.Add(random.Next(6, 9));
            }

            for (int i = 0; i < 20; i++)
            {
                num1 = random.Next(1, 9);
                num2 = random.Next(5, 9);

                Console.Write($"{i + 1})   {num1} X {num2} = ");
                stringResult = Console.ReadLine() ?? "there is no number";

                
                
                result = MyAtoi(stringResult);

                if (Multyplayion(num1, num2, result) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("RIGHT!!");

                    rightAnswers++;

                    Console.ResetColor();
                }
                else
                {
                    HardNums1.Add(num1);
                    HardNums2.Add(num2);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WRONG!!");
                    Console.ResetColor();
                }
            }

            for (int i = 0; i < 15; i++)
            {
                num1 = HardNums1[random.Next(0, HardNums1.Count())];
                num2 = HardNums2[random.Next(0, HardNums2.Count())];

                Console.Write($"{i + 1 + 20})   {num1} X {num2} = ");
                stringResult = Console.ReadLine() ?? "there is no number";

                
                
                result = MyAtoi(stringResult);

                if (Multyplayion(num1, num2, result) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("RIGHT!!");

                    rightAnswers++; 

                    Console.ResetColor();
                }
                else 
                {
                    HardNums1.Add(num1);
                    HardNums2.Add(num2);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WRONG!!");
                    Console.ResetColor();
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{rightAnswers} / 35");


        }
        static bool Multyplayion(int n1, int n2, int res)
        {
            if (n1 * n2 == res)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int MyAtoi(string s)
        {
            string num = "";
            bool WasANum = false;
            bool WasAMinus = false;

            if (s.Length > 5)
            {
                return 0;
            }
            if(s == "")
            {
                return 0;
            }

            if (s[0] == ' ' || s[0] == '+' || s[0] == '-' || char.IsNumber(s[0]))
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsNumber(s[i]) == true)
                    {
                        num += s[i];
                        WasANum = true;
                    }
                    if (s[i] == '-' && WasANum == false && WasAMinus == false)
                    {
                        WasANum = true;
                        WasAMinus = true;
                    }
                }

                if (WasAMinus == true && WasANum == true)
                {
                    long r = Convert.ToInt64(num);

                    return (int)r * -1;
                }
                else
                {
                    long t = Convert.ToInt64(num);
                    return (int)t;
                }
            }

            else
            {
                return 0;
            }
        }
    }*/
}