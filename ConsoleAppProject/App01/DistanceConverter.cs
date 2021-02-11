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
        private const int FEET_IN_MILES = 5280;

        private const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        /// <summary>
        /// Code to convert distance
        /// </summary>

        public void MilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading();
            InputMiles();
            CalculateMetres();
            OutputMetres();
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

        private void InputMetres()
        {
            Console.Write("Please enter the number of metres >");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet >");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres!");
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("        Convert Miles to Feet        ");
            Console.WriteLine("             by Max Roe              ");
            Console.WriteLine("-----------------------------------\n");
        }

    }
}

