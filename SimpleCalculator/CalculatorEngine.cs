using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
   public class CalculatorEngine
    {
        public double calculate(string operation,double FirstNumber,double SecondNumber)
        {

            double result;
            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    result = FirstNumber + SecondNumber;
                    break;

                case "substruct":
                case "-":
                    result = FirstNumber - SecondNumber;
                    break;

                case "multiply":
                case "*":
                    result = FirstNumber * SecondNumber;
                    break;



                case "divide":
                case "/":
                    result = FirstNumber / SecondNumber;
                    break;

                default:
                    throw new InvalidOperationException("specified operation not reconized");

            }
            return result;

        }


    }
}
