using System;
using System.Numerics;
using System.Reflection.Metadata;
using Test.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var programRunning = true;
        while (programRunning)
        {
            Console.WriteLine("Please input comma separated data");
            string[] inputData = DataHandler.GetValuesFromInput(); // Get input data as an array of strings

            Console.WriteLine("Please choose a way to handle this data, please enter number corresponding to selected option e.g 1");
            Console.WriteLine("1. Merge into single string");
            Console.WriteLine("2. Multiply numbers and uppercase strings");
            int choice = Convert.ToInt32(Console.ReadLine()); // Get user's choice as an integer

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Input as single string: {string.Concat(inputData)}"); // Concatenate input data into a single string and display
                    break;
                case 2:
                    Console.WriteLine("Enter value to multiply numbers by:");
                    int multiplicationFactor = Convert.ToInt32(Console.ReadLine()); // Get multiplication factor from user
                    Console.WriteLine($"Result: {DataHandler.MultiplyNumbersAndUpperCaseStrings(inputData, multiplicationFactor)}"); // Call a method to multiply numbers and uppercase strings, and display the result
                    break;
                default:
                    Console.WriteLine("Invalid value, please try again"); // Display error message for invalid input
                    break;
            }  
        }
    }
}