using System;
using System.Text;

namespace FizzBuzzApp;

public class Program
{
    public static void Main(string[] args)
    {
        // div by 3 - fizz
        // div by 5 - buzz
        // div by 3 and 5 - fizzbuzz

        int max = 30;

        for (int i = 1; i <= max; i ++)
        {
            Console.WriteLine(FizzBuzz);
        }
    }

    public static string FizzBuzz(int input)
    {
        //    StringBuilder output = new StringBuilder();

        //   if (input % 3 == 0) { output.Append("fizz"); }
        //   if (input % 5 == 0) { output.Append("buzz"); }
        //   if (input % 3 != 0 && input % 5 != 0) { output.Append(input); }
        //   return output.ToString();

        return input % 15 == 0 ? "FizzBuzz" : input % 5 == 0 ? "Buzz" : input % 3 == 0 ? "Fizz" : "";
    }

    public int Add(string numbers)
    {
        return 0;
    }
}
