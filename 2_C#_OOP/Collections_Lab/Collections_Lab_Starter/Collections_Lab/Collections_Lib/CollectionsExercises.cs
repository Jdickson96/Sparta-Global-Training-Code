using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            if (queue.Count < num)
            {
                num = queue.Count;
            }
       
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < num; i++)
            {
                if (i == 0)
                {
                 result.Append(queue.Dequeue());
                }
                else
                {
                 result.Append($", {queue.Dequeue()}");
                }
            }
            return result.ToString();
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            Stack<int> numberStack = new Stack<int>();

            foreach(int number in original)
            {
                numberStack.Push(number);
            }

            return numberStack.ToArray();
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> counter = new Dictionary<char, int>();

            foreach(char character in input)
            {  
                    if (counter.ContainsKey(character))
                    {
                        counter[character]++;
                    }
                    else if (Char.IsNumber(character))
                    {
                        counter.Add(character, 1);
                    }
            }
            StringBuilder result = new StringBuilder();

            foreach (KeyValuePair<char, int> keyValuePair in counter)
            {
                result = result.Append(keyValuePair); //.Key or .Value can be added to access a single part of the pair
            }

            return result.ToString();
        }
    }
}
