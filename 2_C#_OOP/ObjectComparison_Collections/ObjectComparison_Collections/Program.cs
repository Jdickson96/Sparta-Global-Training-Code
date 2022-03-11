using System;

namespace ObjectComparison_Collections;

public class Program
{

    public static void Main(string[] args)
    {
        #region Equals and Compare
        /*
        var bobOne = new Person("Bob", "Builder") { Age = 25 };
        var bobTwo = bobOne;
        var areSame = bobOne.Equals(bobTwo);
        var bobThree = new Person("Bob", "Builder") { Age = 25 };
        var areSameOneThree = bobOne.Equals(bobThree);

        List<Person> personList = new List<Person>
        {
            new Person("Cath","Cookson"),
            new Person("Bob","Builder"),
            new Person("Dan","Dare"),
            new Person("Amy","Andrews") {Age = 32},
        };

        personList.ForEach(x => Console.WriteLine(x));

        Console.WriteLine();

        var hasBob = personList.Contains(bobOne);

        personList.Sort();
        //personList.ForEach(x => Console.WriteLine(x));

        personList.OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine(x));
    */
        #endregion

        #region Collections
        
        var helen = new Person("Helen", "Troy") { Age = 22 };
        var will = new Person("William", "Shakespear") { Age = 457 };
        /*
                List<Person> thePeople = new List<Person> { helen, will };
                thePeople.Add(new Person("Nish", "Mandal"));
                thePeople.Count();  //This iterates through the list when it counts

                Person[] arr = thePeople.ToArray();
        */

        /*
                    //LIST 
         
                var numList = new List<int> { 5, 4, 3, 9, 0 };

                //Add 8 to the list
                numList.Add(8);
                //Sort the list Ascending
                numList.Sort();
                //Remove 2 Digits starting at position 1
                numList.RemoveRange(1, 2);
                //insert the number 1 at position 2
                numList.Insert(2, 1);
                //reverse the list
                numList.Reverse();
                //remove the number 9
                numList.Remove(9);
                //Write the list to the console on one line
                numList.ForEach(x => Console.Write(x));
        */

        /*
                //LINKEDLIST 
         
        LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
        thePeopleLinked.AddFirst(helen);
        thePeopleLinked.AddFirst(will);
        thePeopleLinked.AddLast(new Person("Nish", "Mandal"));

        foreach (var person in thePeopleLinked)
        {
            Console.WriteLine(person);
        }
        */

        /*
                //QUEUES
         
        var myQueue = new Queue<Person>();
        myQueue.Enqueue(helen);
        myQueue.Enqueue(will);
        myQueue.Enqueue(new Person("Nish", "Mandal"));

        foreach(var item in myQueue)
        {
            Console.WriteLine(item);
        }

        var first = myQueue.Peek();     //This looks at who is at the front of the queue
        var serve = myQueue.Dequeue();  //This removes the person at the front of the queue

        Console.WriteLine();
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }
        */

        /*
                //STACKS

        int[] original = new int[] { 1, 2, 3, 4, 5 };
        int[] reversed = new int[original.Length];
        var stack = new Stack<int>();

        foreach (var n in original)
        {
            stack.Push(n);
        }

        //pop off the stack, which will be 5 and continue until our array is full
        for(int i = 0; i < original.Length; i++)
        {
            reversed[i] = stack.Pop();
        }
        */

        /*
          
         //HashSet

        var peopleSet = new HashSet<Person>
        {
            helen, new Person("Jasmin","Mandal"), new Person("Andrei","Aggassi") //internally methods are ordered by their hashcode
        };

        var successMartin = peopleSet.Add(new Person("Martin","Beard"));
        var successHelen = peopleSet.Add(new Person("Helen", "Troy") {Age = 22});

        var morePeople = new HashSet<Person> { new Person("Cathy", "French"), new Person("Jasmin", "Mandal") };
        peopleSet.IntersectWith(morePeople);    //this is an AND statement between the two datasets so if a person exists in both they are left in peopleSet

        foreach (var person in peopleSet)
        {
            Console.WriteLine(person);
        }
        */
        /*
        //DICTIONARY

        var personDictionary = new Dictionary<string, Person>
        {
            {"helen", helen },
            {"Sherlock", new Person("Sherlock", "Holmes") {Age = 40} }
        };

        Person p = personDictionary["Sherlock"]; //This uses the Sherlock key string to access the data


        string input = "The cat in the hat comes back";
        input.Trim().ToLower();
        var countDict = new Dictionary<char, int>();
        foreach(char character in input)
        {
            if (countDict.ContainsKey(character))
            {
               countDict[character]++;
            }
            else
            {
                countDict.Add(character, 1);
            }
        }

        Console.WriteLine("Dictionary Problem");

        foreach(KeyValuePair<char,int> keyValuePair in countDict)
        {
            Console.WriteLine(keyValuePair); //.Key or .Value can be added to access a single part of the pair
        }
        */

        var theBeatles = new Dictionary<int, string>() { { 1, "John" }, { 2, "Paul" }, { 3, "Ringo" }, { 4, "George" } };
        var isAdded = theBeatles.TryAdd(3, "Nish");
        var beatlesList = theBeatles.Values.ToList();   //This converts the dictionary to a list
        var c = theBeatles.Remove(1);
        var d = theBeatles.Keys.Where(x => x % 2 == 0).Sum();
        #endregion
    }
}