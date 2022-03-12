using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == null || numbers.Length == 0) //If input is null or empty
                return 0;

            char delimiter = ',';
            string multiCharDelimeter = "";
            string newNumbers = numbers.Trim('/');

            if (!char.IsDigit(newNumbers[0]) && newNumbers[0] != '[')   //Sets single char delimiters
                delimiter = newNumbers[0];

            int indexEnd;
            StringBuilder sb = new();
            while (newNumbers.Contains('['))             //Sets string and multiple delimiters
            {
                indexEnd = newNumbers.IndexOf(']') - 1;
                multiCharDelimeter = newNumbers.Substring(1, indexEnd);
                
                sb.Append(newNumbers);
                sb.Replace(multiCharDelimeter, ",");
                newNumbers = sb.Remove(0, 3).ToString(); //Removes Bracketed delimiter
                sb.Clear();
            }

            string[] nums = newNumbers.Split('\n', delimiter);

            int sum = 0;
            StringBuilder negatives = new();
            foreach (string num in nums)
            {
                bool isDigit = int.TryParse(num, out int digit);
                if (isDigit)
                {
                    if(digit<0) 
                        negatives.Append($"{digit} ");
                    if (digit<=1000) 
                        sum += digit;
                }
                else if (num.Contains("--"))
                {
                    string newNum = num.Trim('-');
                    if (int.TryParse(newNum, out int doubleNegative) && doubleNegative < 1000)  
                        sum += doubleNegative;
                }
            }
            if(negatives.Length > 0)
                throw new ArgumentOutOfRangeException(($"negatives not allowed : {negatives}").Trim());
          
            return sum;
        }
    }
}
