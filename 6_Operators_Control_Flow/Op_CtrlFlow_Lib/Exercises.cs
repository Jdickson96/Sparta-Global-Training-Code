using System;
using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;   //false if same number else true if num1 is divisible by num2
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {   
            double numsSum = 0;   int listLength = nums.Count;
            if (listLength != 0)
            {
                foreach (int num in nums)
                {
                    numsSum += num;
                }
                return numsSum / listLength;
            }
            else
            {
                return 0;
            }
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;
            if (age >= 60)
            {
              ticketType = "OAP";
            }
            else if(age >= 18 && age <= 59)
            {
                ticketType = "Standard";
            }
            else if (age >= 13 && age <= 17)
            {
                ticketType = "Student";
            }
            else if (age >= 5 && age <= 12)
            {
                ticketType = "Child";
            }
            else if (age < 5)
            {
                ticketType = "Free";
            }
                return ticketType;
        }

        /*
                switch (age)
                {
                    case >= 60:
                        ticketType = "OAP";
                        break;
                    case >= 18:
                        ticketType = "Standard";
                        break;
                    case >= 13:
                        ticketType = "Student";
                        break;
                    case >= 5:
                        ticketType = "Child";
                        break;
                    case < 5:
                        ticketType = "Free";
                        break;
                    default:
                        ticketType = "Error";
                        break;
         */

        public static string Grade(int mark)
        {
            var grade = "";
           if(mark <= 100)
            {
                if(mark < 75)
                {
                    if(mark < 60)
                    {
                        if(mark < 40)
                        {
                            grade = "Fail";
                        }
                        else
                        {
                            grade = "Pass";
                        }
                    }
                    else
                    {
                        grade = "Pass with Merit";
                    }
                }
                else
                {
                    grade = "Pass with Distinction";
                }
            }
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            switch(covidLevel)
            {
                case 0:
                    return 200;
                case 1:
                    return 100;
                case 2:  
                case 3: 
                    return 50;   
                case 4:
                    return 20;
                default:
                    return -1;
            }
        }
    }
}
