using System;
using System.Text;
using CalculatorEngineLib;
namespace SimpleCalculator
{
    
    
        class Program
        {
            static void Main(string[] args)
            {
            Console.Write("Enter first number: ");
            double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

            Console.WriteLine("Enter +, -, *, /, ^ or words plus, minus, times, divide, power");
            string op = Console.ReadLine().Trim();

           
            switch (op.ToLower())
            {
                case "plus":
                case "add":
                    op = "+"; break;
                case "minus":
                case "subtract":
                    op = "-"; break;
                case "times":
                case "multiply":
                case "x":
                    op = "*"; break;
                case "divide":
                    op = "/"; break;
                case "power":
                case "pow":
                case "^": op = "^"; break;
            }

            Console.Write("Enter second number: ");
            double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

            var engine = new CalculatorEngine();
            double result = engine.Calculate(op, firstNumber, secondNumber);

            
            string opWords;
            switch (op)
            {
                case "+": opWords = "plus"; break;
                case "-": opWords = "minus"; break;
                case "*": opWords = "times"; break;
                case "/": opWords = "divided by"; break;
                case "^": opWords = "to the power of"; break;
                default: opWords = op; break;
            }

            var sb = new StringBuilder();
            sb.Append("The value ")
              .Append(firstNumber.ToString("0.00"))
              .Append(' ')
              .Append(opWords)
              .Append(" the value ")
              .Append(secondNumber.ToString("0.00"))
              .Append(" equals ")
              .Append(result.ToString("0.00"))
              .Append('.');

            Console.WriteLine();
            Console.WriteLine(sb.ToString());
        }
    }

    }


