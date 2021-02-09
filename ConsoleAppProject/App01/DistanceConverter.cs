using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a given distance
    /// measured in miles to the equivalent distanced measured
    /// in feet.
    /// </summary>
    /// <author>
    /// Max Roe version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;

        private double feet;

        /// <summary>
        /// Code to convert distance
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles.
        /// Input the miles as a double number.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {

        }

        private void OutputFeet()
        {

        }
    }
}

