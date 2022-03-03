using System;
using System.Text;

namespace Methods;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        //seeding with current time in ticks
        var rng = new Random();
        var rngSeeded = new Random(42);
        var between1And10 = rngSeeded.Next(1,11);
        Console.WriteLine(between1And10);
        */

        // var result = DoThis(10, "Sad");

        /*
        Console.WriteLine("Please enter Pizza Number from selection below: \n" +
                          "");
        string myPizza = OrderPizza(anchovies: true, pineapple: false);
        Console.WriteLine(myPizza);
   */
        int y = 10;
        int z = 10;
        Add(y);
        Console.WriteLine(y);
        Add(ref z);
        Console.WriteLine(z);
    }

    public static void Add(int num)
    {
        num++;
    }

    public static void Add(ref int num)
    {
        num++;
    }

    public static string OrderPizza(bool pineapple, bool anchovies, bool mushrooms = false)
    {
        StringBuilder sb = new StringBuilder();

        if (pineapple) sb.Append("pineapple"); 
        if (anchovies) sb.Append("anchovies"); 
        if (mushrooms) sb.Append("mushrooms"); 

        return $"Pizza with a base of cheese and tomato with {sb}";
    }
    public static int DoThis(int x, string y)
    {
        Console.WriteLine($"I am feeling {y}");
        return x;
    }
}