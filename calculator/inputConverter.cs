using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string TextInput)
        {
            double convertedNumber;
            if (!double.TryParse(TextInput, out convertedNumber)) throw new ArgumentException("expectic a numeric value");
            return convertedNumber;
        }
    }
}
