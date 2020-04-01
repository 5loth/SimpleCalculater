using System;

namespace calculator
{
    class Program
    {
        static void Main(string[]args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();


                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine();
            }
            catch (Exception ex)
            {      // in real world app we log exceptions
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
