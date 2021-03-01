using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Max Roe version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "miles";

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

<<<<<<< HEAD
        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }

=======
>>>>>>> 41fdf28bbf222d0aaa5a0bc766c1f1b39ee243ea
        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>

        public void ConvertDistance()
        {
            OutputHeading();

            FromUnit = SelectUnit(" Please select the form distance unit > ");
            ToUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" Please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        public void CalculateDistance()
        {
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit ==METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        { 
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {FEET}");
            Console.WriteLine($"2. {METRES}");
            Console.WriteLine($"3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles,
        /// metres or feet.
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Code to display the final calculations that the user has
        /// typed in.
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance} {FromUnit}" +
                $" is {ToDistance} {ToUnit}!");
        }


        /// <summary>
        /// Code to display a heading at the top of the program,
        /// that shows what the program is and the author.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("          Distance Converter         ");
            Console.WriteLine("             by Max Roe              ");
            Console.WriteLine("-----------------------------------\n");

        }

    }
}

