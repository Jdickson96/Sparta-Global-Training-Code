using System;

namespace Operator;

public class Ops
{
    public static void Main(string[] args)
{
        //int x = 5;
        //int y = 5;

        //int a = x++;
        //int b = ++y;

        //for (int i = 1; i<= 5; ++i)
        //{
        //      Console.WriteLine(i);
        //}

        //var c = 5 / 2; 
        //var d = 5.0 / 2;
        //var e = 5 / 3;

        // double f = 5 / 2;

        //Console.WriteLine(FindSumDiv3And5(6));
        /*
        const int NUM_ROWS = 2;
        const int NUM_COLS = 5;
        bool running = true;
        int row = 0;
        int col = 0;
        int spriteNo = -1;
        while(running)
        {
            spriteNo = ++spriteNo % (NUM_COLS * NUM_ROWS);  //This makes the code cycle through 0-9
            row = spriteNo / NUM_COLS;  //This makes the code switch between 0-1
            col = spriteNo % NUM_COLS;  //This makes the code cycle through 0-4
        }
        */
        // int j = 5, k = 3, m = 4;
        // m += +j++ + ++k;            //++int means operation happens first, int++ operation happens last


        // Below is a short circuiting and as if the left side is false the right side is not called
        // Single and evaluates both arguements but two ands looks at them in order
        /*
                bool isWearingParachute = false;

                if (isWearingParachute && JumpOutOfAirplane())
                {
                    Console.WriteLine("Congrats, you have made a successful jump!");
                }
        */

        int num1 = 5;
        int num2 = 10;

        if (num1 == 5 ^ num2 ==120)  //XOR operator
        {
            Console.WriteLine("Exclusive or satisfied")
        }
}

    private static bool JumpOutOfAirplane()
    {
        Console.WriteLine("Jump");
        return true;
    }

    public static bool EvenOdd (int num)
    {
        return num % 2 == 0;
    }

    public static int FindSumDiv3And5 (int n)
    {
        int sum = 0;
        if (n != 0)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        } else
        {
            return 0;
        }
    }
}