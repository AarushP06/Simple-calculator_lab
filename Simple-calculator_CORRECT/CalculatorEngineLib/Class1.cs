using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CalculatorEngineLib
{
    public class CalculatorEngine
    {
        public double Calculate(string op, double left, double right)
        {
            switch (op.ToLower())
            {
                case "+": case "add": return left + right;
                case "-": case "subtract": return left - right;
                case "*": case "x": case "multiply": return left * right;
                case "/": case "divide": return left / right;
                case "^": return Math.Pow(left, right);
                default: throw new InvalidOperationException("Unsupported operator");
            }
        }
    }
}

