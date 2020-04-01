using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class CalculatorEngine
    {
        public double Calculate (string Operation, double firstNumber, double secondNumber)
        {
            double result;
            switch(Operation.ToLower())
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "subtract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "mutiply":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("specifyoperation PLZ.");   
            }
            return result;

        }
    }
}
