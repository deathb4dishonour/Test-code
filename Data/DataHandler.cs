using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data
{
    public static class DataHandler
    {
        // Method to get values from input
        public static string[] GetValuesFromInput()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == null) { continue; } // Continue if input is null
                var values = input
                    .ToString()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries); // Split input by comma and remove empty entries
                return values;
            }
        }

        // Method to multiply numbers and uppercase strings
        public static string MultiplyNumbersAndUpperCaseStrings(string[] data, int multiplier = 1)
        {
            var result = new List<string>();
            foreach (string s in data)
            {
                int value;
                if (int.TryParse(s, out value))
                {
                    // If string can be parsed as integer, multiply it by the multiplier
                    result.Add((value * multiplier).ToString());
                }
                else
                {
                    // If not, convert string to uppercase
                    result.Add(s.ToUpper());
                }
            }
            return string.Concat(result); // Concatenate the resulting strings
        }
    }
}
