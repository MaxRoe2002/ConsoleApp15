using System;
using System.Text;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        public const string METRIC = "METRIC";
        public const string IMPERIAL = "IMPERIAL";

        public double weight;
        public double height;

        public string SelectedUnit;

        public double bmiResult;

        public string[] MenuChoices = { METRIC, IMPERIAL };

        public void OutputUnits()
        {
            Console.WriteLine("Please choose between: ");
            ConsoleHelper.OutputMenu(MenuChoices);
        }
        public string GetUnit()
        {
            SelectedUnit = Console.ReadLine().ToUpper();
            return SelectedUnit;
        }

        public double GetWeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter your weight in KGs:");
            }
            else
            {
                Console.WriteLine("Please enter your weight in Stones:");
                Console.WriteLine("Please enter your weight in Pounds:");
            }
            weight = Convert.ToDouble(Console.ReadLine());
            return weight;
        }

        public double GetHeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter your height in CMs:");
            }
            else
            {
                Console.WriteLine("Please enter your height in Feet:");
                Console.WriteLine("Please enter your height in Inches:");
            }
            height = Convert.ToDouble(Console.ReadLine());
            return height;
        }

        public void CalculateBMI()
        {
            if (SelectedUnit == METRIC)
            {
                bmiResult = (weight / height / height) * 10000;
            }
        }


        public void OutputResult()
        {
            Console.WriteLine(SelectedUnit + " " + bmiResult);
        }

        public void PrintHeading()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("          Distance Converter         ");
            Console.WriteLine("             by Max Roe              ");
            Console.WriteLine("-----------------------------------\n");
        }
    }
}
