using System;
namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 21;
        try
        {
        var greeting = Greeting(timeOfDay);
            Console.WriteLine(greeting);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Invalid data, please try again");
            Console.WriteLine(ex.Message);
        }
        

    }

    public static string Greeting(int timeOfDay)
    {

        string greeting;
        if (timeOfDay < 0 || timeOfDay > 24)
        {
            throw new ArgumentOutOfRangeException("TimeOfDay: " + timeOfDay + " " + "Allowed range 0-24");
        }
        else
        {
            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                greeting = "Good morning!";
            }
            else if (timeOfDay > 12 && timeOfDay <= 18)
            {
                greeting = "Good afternoon!";
            }
            else
            {
                greeting = "Good evening!";
            }
        }
        return greeting;
    }
}