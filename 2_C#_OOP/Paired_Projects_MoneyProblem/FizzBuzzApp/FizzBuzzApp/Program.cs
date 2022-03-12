using System;
using System.Text;

namespace FizzBuzzApp;

public class Program
{

    public static void Main(string[] args)
    {
        //Console.WriteLine(StringCalculator.Add("//[***][%%%][$$$]\n1***2%%%3$$$4"));
        
        Console.WriteLine(MoneyProblem.BillConverter(13.61));

        //Console.WriteLine(RomanNumeralCalculator.NumToRomanNumConverter(34));
    }


    public static string RomanNumeralCorrection(string check,string replace, StringBuilder generatedString, string generateTo)
    {
        if (generateTo.Contains(check))
        {
            generatedString.Replace(check, replace);
        }
        return generatedString.ToString();
    }

    //public static string FizzBuzzLogic(int n1, int n2, int range)
    //{
    //    StringBuilder fizzBuzzBuild = new();
    //    for (int i = 0; i < range; i++)
    //    {
    //        if (range % n1 == 0 && range % n2 == 0)
    //        {
    //            fizzBuzzBuild.Append("FizzBuzz");
    //        }
    //        else if (range % n1 == 0)
    //        {
    //            fizzBuzzBuild.Append("Buzz");
    //        }
    //        else if (range % n2 == 0)
    //        {
    //            fizzBuzzBuild.Append("Fizz");
    //        }
    //        else
    //        {
    //            fizzBuzzBuild.Append(i);
    //        }
    //    }
    //    return fizzBuzzBuild.ToString();
    //}

    public static string FizzBuzz(int input)
    {
        StringBuilder output = new StringBuilder();

        //if (input % 3 == 0) { output.Append("Fizz"); }
        //if (input % 5 == 0) { output.Append("Buzz"); }
        //if (input % 3 != 0 && input % 5 != 0) { output.Append(input); }
        //return output.ToString();
        //on liner using string builder
        return new StringBuilder(input % 15 == 0 ? "FizzBuzz" : input % 5 == 0 ? "Buzz" :
            input % 3 == 0? "Fizz" : input.ToString()).ToString();
    }
}