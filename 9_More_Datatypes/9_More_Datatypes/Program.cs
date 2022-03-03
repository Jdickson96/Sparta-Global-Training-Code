using System;
using System.Diagnostics;
using System.Text;

namespace More_DataTypes;

public enum suits
{
    HEARTS, CLUBS, DIAMONDS, SPADES
}

public class MoreDataTypes
{
    static void Main(string[] args)
    {
        // var myString = " C# list fundamentals ";
        // Console.WriteLine(StringVersion(myString));
        // Console.WriteLine(StringBuilderVersion(myString));
        /*
        var spartaString = String.Concat("This", "Is", "Sparta");
        Console.WriteLine(spartaString);
        StringInterpolation("Example");

        var num1 = 2;
        var num2 = 3;
        var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
        Console.WriteLine(fString);

        var fString2 = $"That will be {num1 / 3.0:C}, please";  //this would give the result as GBP
                                                                //Formating N gives 2dp, P gives percentage
        Console.WriteLine(fString2);
        */
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        long total = 0;
        for (int i = 0; i < int.MaxValue; i++)
        {
            total += i;
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        Console.WriteLine(stopwatch.ElapsedTicks);
    }

    public static void ParsingStrings()
    {
        bool isSuccess = true;
        ConsoleKeyInfo cki;
        do {
            Console.WriteLine("How Many Apples?");
            string input = Console.ReadLine();
            isSuccess = Int32.TryParse(input, out int numApples);
            Console.WriteLine($"{numApples} apples");
            if (!isSuccess)
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine("Continue or Leave? Press Esc to leave");
            cki = Console.ReadKey();
        } while (cki.Key != ConsoleKey.Escape);
        }

    public static void StringInterpolation(string str)
    {
        Console.WriteLine("My name is : " + str + " using +");
        Console.WriteLine($"My name is {str} using interpolation");
    }

    private static string StringBuilderVersion(string input)
    {
        var trimmedUpperString = input.Trim().ToUpper();
        var nPos = trimmedUpperString.IndexOf('n');
        StringBuilder sb = new StringBuilder(trimmedUpperString);
        sb.Replace('L', '*').Replace('T','*');
        sb.Remove(nPos + 1, sb.Length - nPos - 1);
        sb.Append(" and is better than c++ and Java");
        return sb.ToString();
    }

    private string StringVersion(string input)
    {
        string trimmedUpperString = input.Trim().ToUpper();
        string changedData1 = trimmedUpperString.Replace('L', '*');
        string changedData2 = changedData1.Replace('T', '*');
        var nPos = changedData2.IndexOf('N');
        return changedData2.Remove(nPos + 1);
    }

    public static void DateTimeMethods()
    {
        var now = DateTime.Now;
        Console.WriteLine($"The time is {now}");
        Console.WriteLine($"In ticks this is now {now.Ticks}");
        Console.WriteLine(DateTime.MinValue);
        Console.WriteLine(DateTime.MaxValue);
    }

    public static void JaggedArrays()
    {
        int[][] intJArray = new int[2][];
        intJArray[0] = new int[4];
        intJArray[1] = new int[2];

        intJArray[0][2] = 3; //This sets a single cell in the array
    }

}