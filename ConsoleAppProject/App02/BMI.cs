using System;
using System.Text;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app has been developed to show the user their BMI, their body mass index.
    /// </summary>
    /// <author
    /// Max Roe version 0.1
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

        public const double Underweight = 18.5;
        public const double Normal = 24.9;
        public const double Overweight = 29.9;

        public const double Obese1 = 34.9;
        public const double Obese2 = 39.9;
        public const double Obese3 = 40.0;

        public ConsoleHelper ConsoleHelper
        {
            get => default;
            set
            {
            }
        }

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
                Console.WriteLine("Enter your weight in KGs: ");
                weight = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter your weight in Stones: ");
                double stones = Convert.ToDouble(Console.ReadLine());
                weight = stones * 14;
                Console.WriteLine("Enter your weight in Pounds: ");
                double pounds = Convert.ToDouble(Console.ReadLine());
                weight += pounds;
            }
            return weight;
        }

        public double GetHeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Enter your height in CMs: ");
                height = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter your number of Feet: ");
                double feet = Convert.ToDouble(Console.ReadLine());
                height = feet * 12;
                Console.WriteLine("Enter your number of Inches: ");
                double inches = Convert.ToDouble(Console.ReadLine());
                height += inches;
            }
            return height;
        }


            public void CalculateBMI()
            {
                if (SelectedUnit == METRIC)
                {
                    bmiResult = (weight / height / height) * 10000;
                }
                if (SelectedUnit == IMPERIAL)
                {
                    bmiResult = (weight * 703) / (height * height);
                }
            }

            public void OutputResult()
            {
                Console.WriteLine(SelectedUnit);

                if (bmiResult < Underweight)
                {
                    Console.WriteLine("Your bmi is: " + bmiResult
                        + "\nYou are Underweight!");
                }
                else if (bmiResult < Normal)
                {
                    Console.WriteLine("Your bmi is: " + bmiResult
                        + "\nYou are a normal weight!");
                }
                else if (bmiResult < Overweight)
                {
                    Console.WriteLine("Your bmi is: " + bmiResult
                        + "\nYou are Overweight!");
                }
                else if (bmiResult < Obese1)
                {
                    Console.WriteLine("Your bmi is: " + bmiResult
                        + "\nYou are slightly obese");
                }
                else if (bmiResult < Obese2)
                {
                    Console.WriteLine("Your bmi is: " + bmiResult
                        + "\nYou are obese!");
                }
                else if (bmiResult >= Obese3)
                {
                    Console.WriteLine("Your bmi is: " + bmiResult
                        + "\nYou are very obese");
                }
            }

            public void PrintHeading()
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine("          BMI Calculator             ");
                Console.WriteLine("             by Max Roe              ");
                Console.WriteLine("-----------------------------------\n");
            }
        }
    }

