using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    public class MoneyProblem
    {
        public static string BillConverter(double sum)
        {
            int[] bills = new int[] { 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
           // int[] bills = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };    If the requirement was for coins only uncomment this and comment out above value
            StringBuilder billsInSum = new();
            int valueInSum;
            
            sum = Math.Round(sum, 2) * 100;
            foreach (int bill in bills)
            {
                valueInSum = (int)(sum / bill);
                if (valueInSum > 0)
                {
                    sum -= bill * valueInSum;
                    if (bill > 50)  
                        billsInSum.Append($"- {valueInSum} `£{bill / 100}`\n");
                    else 
                        billsInSum.Append($"- {valueInSum} `{bill}p`\n");
                }
            }
            return billsInSum.ToString().Trim('\n');
        }
    }
}
