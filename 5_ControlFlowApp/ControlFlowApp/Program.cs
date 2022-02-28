using System;

namespace ControlFlowApp;

public class Program
{

    public static void Main(string[] args)
    {   /*
        int mark = 82;                              //This is a ternary operator example
        var grade = GetGrade(mark);
        Console.WriteLine(grade);
        */

        //Console.WriteLine(Priority(0));

        //Console.WriteLine(DrivingLaw(2));

        var nums = new List<int> { 10, 6, 22, -7, 3 };
        Console.WriteLine("Highest forEach: "   + LoopTypes.HighestForEachLoop(nums));
        Console.WriteLine("Highest for: "       + LoopTypes.HighestForLoop(nums));
        Console.WriteLine("Highest while: "     + LoopTypes.HighestWhileLoop(nums));
        Console.WriteLine("Highest do while: "  + LoopTypes.HighestDoWhileLoop(nums));
    }

    public static string Priority(int level)
    { string priority = "Code ";
        switch (level)
        {
            case 3:
                return priority + "Red";
            case 2:
            case 1:
                return priority + "Amber";
            case 0:
                return priority + "Green";
            default:
                return priority + "Error";
        }
    }

    public static string DrivingLaw(int age)
    {
        string law = "";
        switch (age)
        {
            case < 18:
                law = "Cannot Legally Drive";
                break;
            case < 23:
                law = "Can legally drive but cannot hire a car";
                break;
            default:
                law = "Can legally drive and rent a car";
                break;
        }
        return law;
    }

    public static string GetGrade(int mark)
    {
        //This is a ternary operator example
        return mark >= 65 ? "Pass" : "Fail";   //Checks statement left of "?" and if true left is used, if false right is [these statements can be nested]
    }
}