using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvetInputToNumeric(string text)
        {

            double convertedNumber;

            if (!double.TryParse(text, out convertedNumber)) throw new ArgumentException("expected numeric value");

            return convertedNumber;
        }


    }
}
