using System;
namespace ConsoleAppProject { }


public class ConsoleHelper
{
    public ConsoleAppProject.App03.StudentGrades StudentGrades
    {
        get => default;
        set
        {
        }
    }

    public static void OutputMenu(string[] choices)
    {
        int choiceNo = 0;

        foreach (string choice in choices)
        {
            choiceNo++;
            Console.WriteLine(choiceNo + ". " + choice);
        }
    }

    public static int MakeChoice(string[] choices)
    {
        // Display all the choices

        DisplayChoices(choices);

        // Get the user's choice

        int choiceNo = (int)InputNumber("\n Please enter a number: ",
                                        1, choices.Length);
        return choiceNo;
    }

    private static void DisplayChoices(string[] choices)
    {
        int choiceNo = 0;

        foreach (string choice in choices)
        {
            choiceNo++;
            Console.WriteLine($"    {choiceNo}.  {choice}");
        }
    }

    public static double InputNumber(string prompt)
    {
        double number = 0;
        bool isValid = false;

        do
        {
            Console.Write(prompt);
            string value = Console.ReadLine();

            try
            {
                number = Convert.ToDouble(value);
                isValid = true;
            }
            catch (Exception)
            {
                isValid = false;
                Console.WriteLine(" The number that you entered is invalid, please try again.");
            }

        } while (!isValid);

        return number;
    }

    public static double InputNumber(string prompt, double min, double max)
    {
        bool isValid = false;
        double number = 0;

        do
        {
            number = InputNumber(prompt);

            if (number < min || number > max)
            {
                isValid = false;
                Console.WriteLine($"Your number must be between {min} and {max}");
            }
            else isValid = true;

        } while (!isValid);

        return number;



    }

    public static void OutputHeading(string title)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("\n ---------------------------------");
        Console.WriteLine($"    {title}          ");
        Console.WriteLine("              by Max Roe           ");
        Console.WriteLine(" ---------------------------------" +
            "\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    public static void OutputTitle(string title)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"\n {title}");
        Console.Write(" ");

        for (int count = 0; count <= title.Length; count++)
        {
            Console.Write(" ");
        }

        Console.WriteLine("\n");
        Console.ResetColor();
    }
}