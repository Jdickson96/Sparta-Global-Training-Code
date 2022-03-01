using System;
namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int ageOfViewer = 21;
        var rating = AvailableClassifications(ageOfViewer);
        Console.WriteLine(rating);

    }
    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;
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
        return result;
    }
}