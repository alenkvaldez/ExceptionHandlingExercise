using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        private static IEnumerable<object> numbers;

        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'p', 'a', 'c' };
            var numbers = new List<int>();
            var str = "";


            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            foreach (var item in arr)
            {
                int number;
                try
                {
                    str = item.ToString();
                    number = int.Parse(str);

                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");
                    //character will be the name of each item in your collection

                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
