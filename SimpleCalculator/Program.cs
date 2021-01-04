using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double FirstNumber = inputConverter.ConvetInputToNumeric(Console.ReadLine());
                double SecondNumber = inputConverter.ConvetInputToNumeric(Console.ReadLine());

                string operation = Console.ReadLine();

                double result = calculatorEngine.calculate(operation, FirstNumber, SecondNumber);
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            


        }
    }
}
