using System;
using System.IO;

namespace CalculatorDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (; ; )
            {
                string filepath = @"E:\C# Practise\CalculatorDemo\Content\log.txt";
                StreamWriter streamWriter = File.AppendText(filepath);

                int firstNum = 0;
                int secondNum = 0;
                string _val = "";
                string _val2 = "";
                ConsoleKeyInfo key;

                Console.WriteLine("Enter first number");

                do
                {
                    key = Console.ReadKey(true);
                    int val = 0;
                    bool _x = Int32.TryParse(key.KeyChar.ToString(), out val);
                    if (_x)
                    {
                        _val += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                while (key.Key != ConsoleKey.Enter);
                firstNum = Convert.ToInt32(_val);

                streamWriter.WriteLine("Enter first number");
                streamWriter.WriteLine(firstNum);

                Console.WriteLine("\nEnter Second number");
                do
                {
                    key = Console.ReadKey(true);
                    int val2 = 0;
                    bool _x = Int32.TryParse(key.KeyChar.ToString(), out val2);
                    if (_x)
                    {
                        _val2 += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                while (key.Key != ConsoleKey.Enter);

                secondNum = Convert.ToInt32(_val2);
                streamWriter.WriteLine("Enter second number");
                streamWriter.WriteLine(secondNum);

                Console.WriteLine("\nEnter Operator");
                char operation = Convert.ToChar(Console.ReadLine());

                streamWriter.WriteLine("Enter operator");
                streamWriter.WriteLine(operation);

                int result = 0;
                if (operation == '+')
                {
                    Add add = new Add();
                    result = add.Calculate(firstNum, secondNum);
                }
                else if (operation == '-')
                {
                    Substract substract = new Substract();
                    result = substract.Calculate(firstNum, secondNum);
                }
                else if (operation == '*')
                {
                    Multiply multiply = new Multiply();
                    result = multiply.Calculate(firstNum, secondNum);
                }
                else if (operation == '/')
                {
                    Divide divide = new Divide();
                    result = divide.Calculate(firstNum, secondNum);
                }
                else if (operation == '%')
                {
                    Remainder remainder = new Remainder();
                    result = remainder.Calculate(firstNum, secondNum);
                }
                else
                {
                    CalculateValue calculate = new CalculateValue();
                    result = calculate.Calculate(firstNum, secondNum);
                }

                Console.WriteLine("{0} and {1} with Operator {2} result in {3}", firstNum, secondNum, operation, result);
                streamWriter.WriteLine("{0} and {1} with Operator {2} result in {3}", firstNum, secondNum, operation, result);

            }
        }
    }
    public class CalculateValue
    {
        public virtual int Calculate(int firstNum, int secondNum)
        {
            int output = 0;
            return output;
        }
    }
    public class Add : CalculateValue
    {
        public override int Calculate(int firstNum, int secondNum)
        {
            int output = firstNum + secondNum;
            return output;
        }
    }
    public class Substract : CalculateValue
    {
        public override int Calculate(int firstNum, int secondNum)
        {
            int output = firstNum - secondNum;
            return output;
        }
    }
    public class Multiply : CalculateValue
    {
        public override int Calculate(int firstNum, int secondNum)
        {
            int output = firstNum * secondNum;
            return output;
        }
    }
    public class Divide : CalculateValue
    {
        public override int Calculate(int firstNum, int secondNum)
        {
            int output = firstNum / secondNum;
            return output;
        }
    }
    public class Remainder : CalculateValue
    {
        public override int Calculate(int firstNum, int secondNum)
        {
            int output = firstNum / secondNum;
            return output;
        }
    }
}
