using System;
namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
         int ageOfViewer = 21;
         var rating = AvailableClassifications(ageOfViewer);
         Console.WriteLine(rating);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Invalid data, please try again");
            Console.WriteLine(ex.Message);
        }
    }
    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;
        if (ageOfViewer < 0 || ageOfViewer > 150)
        {
            throw new ArgumentOutOfRangeException("ageOfViewer: " + ageOfViewer + " " + "Allowed range 0-150");
        }
        else
        {
                if (ageOfViewer < 12)
            {
                result = "U, PG films are available.";
            }
            else if (ageOfViewer >= 12 && ageOfViewer < 15)
            {
                result = "U, PG & 12 films are available.";
            }
            else if (ageOfViewer >= 15 && ageOfViewer < 18)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else
            {
                result = "All films are available.";
            }
        }
        return result;
            }
}