# Sparta Global: Training Code
Code Created During The Sparta Global Training Program as well as notes from the coding lessons taught during the course.
> #### Index
> 1) [Time Of Day NUnit Testing](#Time-Of-Day-NUnit-Testing)
> 2) [Test First Programming Excersize](#Test-First-Programming-Excersize)
> 3) [Film Classification Coding and Testing Task](#Film-Classification-Coding-and-Testing-Task)
> 4) [Operators](#Operators)
> 5) [Control Flow](#Control-Flow)
> 6) [Operators and Control Flow](#Operators-and-Control-Flow)
> 7) [Exceptions](#Exceptions)
> 8) [Datatypes](#Datatypes)
> 9) [More Datatypes](#More-Datatypes)
> 10) [Methods](#Methods)

## Time Of Day NUnit Testing
The code below takes an int that represents the current time and based on its value returns a message in the console. This code doesn't account for any value out of the 0-24 number range, including negative values. With the way the code is written, there are multiple different edge conditions (dealt with here via the use of a sequence of operators as well as a catch all else condition.

```csharp
string greeting;
        if (timeOfDay >= 5 && timeOfDay <= 12)
        {
            greeting = "Good morning!";
        }
        else if (timeOfDay > 12 && timeOfDay <= 18)
        {
            greeting = "Good afternoon!";
        }
        else
        {
            greeting = "Good evening!";
        }
        return greeting;
```

The NUit testing code I used is shown below. I decided to break down the testing conditions into during each time frame as well as every edge case. I did not take into account any out of range errors, and if I were to redo the code I would do this simply by having values such as 50 and -1 input.

```csharp
[TestCase(6)]
        [TestCase(8)]
        [Category("Morning during")]
        public void GivenAtimeBetween5and12Inclusive_Greeting_ReturnsGoodEvening(int time)
        {
            Assert.That("Good morning!", Is.EqualTo(Program.Greeting(time)));
        }

        [TestCase(13)]
        [TestCase(16)]
        [Category("Afternoon during")]
        public void GivenAtimeBetween12and18Inclusive_Greeting_ReturnsGoodAfternoon(int time)
        {
            Assert.That("Good afternoon!", Is.EqualTo(Program.Greeting(time)));
        }

        [TestCase(3)]
        [TestCase(20)]
        [Category("Evening during")]
        public void GivenAtimeBetween18and5Inclusive_Greeting_ReturnsGoodEvening(int time)
        {
            Assert.That("Good evening!", Is.EqualTo(Program.Greeting(time)));
        }

        [Category("Edge case")]
        [TestCase(5, "Good morning!")]
        [TestCase(12, "Good morning!")]
        [TestCase(18, "Good afternoon!")]
        public void GivenATime_Greeting_ReturnsCorrectMessage(int time, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));
        }
```

## Test First Programming Excersize
This code was a list of short coding tests:
* Greater than or equal to code
* BODMAS Test (number treated with a series of maths operators)
* Return true when an input number is even
* Sum all even numbers and multiples of 5 up to a number n
* Return true if input is "password"
* Return Sum of all numbers in a list

### Greater than or Equal to
Its just:
```csharp
if (x >= y)  { return true; }
        else { return false;}
```
This can be simplified down to a single statement as it returns boolean.
```csharp
return x>= y;
```

### BODMAS
This section of code is purely about the use of brackets within the equation in order to apply the calculations within the order specified by the task.
```csharp
double calculatedNumber = Convert.ToDouble(inputNumber);
       calculatedNumber = Math.Round(((((calculatedNumber * calculatedNumber) + 101) / 7) - 4),3);
return calculatedNumber;
```

### Even Checker
The simplest way to complete this task is by the use of a modulus 2 operator (checking if the remainder by dividing by 2 is 0, and the number is therefor a factor)
```csharp
    if(num % 2 == 0) { return true; }
                else { return false;}
```

This can be simplified down to a single statement as it returns boolean.
```csharp
return num % 2 == 0
```

### Sum of Even numbers and Multiples of 5 up to a number
The main issue with this task is the overlap of every second multiple of 5 and even numbers which could lead to the value being added to the sum twice. In order to counteract this a boolean flag has been added to check if a number has been added already on this iteration of the for loop.
```csharp
    int sum = 0; bool addedFlag = false;
            for (int i = 1; i <= max; i++)
            {
                addedFlag = false;
                if(i % 2 == 0 && addedFlag == false)
                {
                    sum += i;
                    addedFlag = true;
                }
                if(i % 5 == 0 && addedFlag == false)
                {
                    sum += i;
                    addedFlag = true;
                }
            }
            return sum;
```
This code has been changed based upon training session feedback. It has now been simplified down to a single statement with an OR operator with the flag removed.
```csharp
int sum = 0;
if (max == 0) { return 0; }
else{
     for (int i = 1; i <= max; i++)
        {
        if (i % 2 == 0 || i % 5 == 0)
          {
           sum += i;
          }
        }
     return sum;
    }
```

### Check input for "password"
The code below converts the string into completely lower case in order to remove any issues with uppercase characters not being recognised.
```csharp
   if(input.ToLower() == "password") { return true; }
                                else { return false; }
```

This can be simplified down to a single statement as it returns boolean.
```csharp
return input.ToLower() == "password"
```

### Return the sum of all of the items in a list
The code below uses two main methods in order to reduce complexity. The foreach function is used in place of a for loop as well as using the += command to add a custom ammount on each iteration.
```csharp
   int sumOfList = 0;
   foreach (int number in list){   sumOfList += number; }
   return sumOfList;
```

## Film Classification Coding and Testing Task
This task required the changing of some provided code in order to meet the following initial conditions
> 1. If someone is **Under 12** - U, PG and 12 films are available
> 2. If someone is **Under 15** - U, PG and 15 Films are available
> 3. **Over 18** - All films are available

By changing and testing the below provided code
```csharp
public static string AvailableClassifications(int ageOfViewer)
{
    string result;
    if (ageOfViewer < 12)
    {
        result = "U, PG & 12 films are available.";
    }
    else if (ageOfViewer < 15)
    {
        result = "U, PG, 12 & 15 films are available.";
    }
    else
    {
        result = "All films are available.";
    }
    return result;
}
```

This has issues however with edge cases but more importantly there are issues with the requirements currently in place. This is because the British Board of Film Classification (found at [BBFC](https://www.bbfc.co.uk/)) does not have age classifications as laid out in the current requirements. This means the requirements should change to be:
> 1. If someone is **Under 12** - U and PG films are available
> 2. If someone is **Over 12 and Under 15** - U, PG and 12 Films are available
> 3. If someone is **Over 15 and Under 18** - U, PG, 12 and 15 Films are available
> 4. **Over 18** - All films are available

This was then tested by the use of tests on each Edge Case as well as two tests within each age range mentioned above.
```csharp
    public class Tests
    {
        [Category("In Range cases")]
        [TestCase(7, "U, PG films are available.")]
        [TestCase(10, "U, PG films are available.")]
        [TestCase(13, "U, PG & 12 films are available.")]
        [TestCase(14, "U, PG & 12 films are available.")]
        [TestCase(16, "U, PG, 12 & 15 films are available.")]
        [TestCase(17, "U, PG, 12 & 15 films are available.")]
        [TestCase(20, "All films are available.")]
        [TestCase(34, "All films are available.")]
        public void GivenAnInRangeAge_Rating_ReturnsCorrectMessage(int ageOfViewer, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.AvailableClassifications(ageOfViewer)));
        }


        [Category("Edge cases")]
        [TestCase(12, "U, PG & 12 films are available.")]
        [TestCase(15, "U, PG, 12 & 15 films are available.")]
        [TestCase(18, "All films are available.")]
        public void GivenAnEdgeAge_Rating_ReturnsCorrectMessage(int ageOfViewer, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.AvailableClassifications(ageOfViewer)));
        }
    }
```

## Operators

This task was a lot of explanations of the operators used in coding.

### Iteration Operators
Iterating a number in code by one can be done in two ways.
```csharp
a = x++;
b = ++y;
```
Having the operator after the value means that the addition is done at the end of the line, whereas having the operator before the value means that the addition is performed before other operations involving the value.

### Operations assigning types to values
The value of an equations output is dependent on the data types of those being acted on in the equation. If the numbers have an int datatype then the outputted data will be a whole number. However, if a double is divided by an int then the output will act as a double.
```csharp
var c = 5 / 2;          //c is an int as both equation variables are ints 
var d = 5.0 / 2;        //d is an double as the number being divided is a double 
var e = 5 / 3;          //e is an int as both equation variables are ints 
double f = 5 / 2;       //f is a whole number as both equation variables are ints 
```

### Modulus Operator Use
A modulus operator is used to find the remainder from a division, meaning that it can be used to see if a number is a factor of another (most commonly to find if a number is odd or even).
```csharp
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
```

The below code is used to move through a sequence of animations. The modulus operator is used here to move along the row with the divide operator being used to move up and down the column. This means that a single value can be used to reference a position in 2 dimensions.
```csharp
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
```

### Pounds to Stones and Pounds
This code has to break a total number of pounds down into a X Stones, Y Pounds value. This makes use of 1 Stone being the equivalent of 14 Pounds, which means that when the total number of pounds is divided by 14, if this value is rounded down then this is the number of Stone needed. The Pounds remainder is then found by using the modulus operator.

```csharp
public static int GetStones(int totalPounds)
        {
            return totalPounds / 14;
        }

public static int GetPounds(int totalPounds)
        {
            return totalPounds % 14;
        }
```

### Shortcircuiting Operators
Below is a shortcircuiting and (the && operator) as if the left side of the statement is false then the right side is not called. A single and (&) evaluates both arguements but two and operators (&&) looks at them in order from left to right. Which means that the code below will not call the JumpOutOfAirplane function if there is && but it will be called if there is a single & function.

```csharp
bool isWearingParachute = false;

if (isWearingParachute && JumpOutOfAirplane()) //rather than: if (isWearingParachute && JumpOutOfAirplane()) 
  {
   Console.WriteLine("Congrats, you have made a successful jump!");
  }
```

### Exclusive OR (XOR) Operator
The XOR operator is used when you want to find a situation where only one of the arguments within the function is true, it's the same as a regular OR but with the both true situation removed. XOR is represented in C# with the ^ symbol.
```csharp
int num1 = 5;
int num2 = 10;

if (num1 == 5 ^ num2 ==120)  //XOR operator
  {
   Console.WriteLine("Exclusive or satisfied");
  }
```

## Control Flow

There are multiple different ways to both organise the overall setup of your system as well as methods that can be used to structure your code more effectively.

### Loop Types
There are multiple different types of loops that can be used in C#. These are:
#### For Loop
This is the most simple loop format, with the for statement taking the structure of:
> for(initialising iterator; max iterator value; iteration)
As shown in the code below:
```csharp
int highestNo = nums[0];
if (nums.Count > 1)
{
        for (int i = 1; i < nums.Count; i++)
        {
                if (nums[i] > highestNo)
                {
                 highestNo = nums[i];
                }
        }
}
return highestNo;
```

#### For Each Loop
This is a C# loop format not available in C, with the for each statement taking the structure of:
> foreach(datatype value in list)
As shown in the code below:
```csharp
int highestNo = nums[0];
foreach(int i in nums)
{
        if (i > highestNo)
        {
         highestNo = i;
        }
}
return highestNo;
```

#### While Loop
This is the main C# loop format, with the while statement taking the structure of:
> initialize iterator outside of loop
> while(iterator < max value)
> in loop have iterator++ code
As shown in the code below:
```csharp
int highestNo = nums[0];
int iterator = 0;
if (nums.Count > 1)
{
        while (iterator < nums.Count)
        {
                if (nums[iterator] > highestNo)
                {
                 highestNo = nums[iterator];
                }
         iterator++;
        }
}
return highestNo;
```

#### Do While Loop
This is an alternate while loop used to initialize systems within the repeated code, with the do while statement taking the structure of:
> initialize iterator outside of loop
> in loop have iterator++ code
> > while(iterator < max value)
```csharp
int highestNo = int.MinValue;
int iterator = 0;
if (nums.Count > 1)
{
        do
        {
                if (nums[iterator] > highestNo)
                {
                 highestNo = nums[iterator];
                }
         iterator++;
        } while (iterator < nums.Count);
}
return highestNo;
```

### Switch Statements
A switch statement is a system for using a single value select between multiple options. This has an advantage over if statements as it doesn't check every single option, it instead moves directly to the matching option. The code below also has empty cases which if they are selected simply drop down to the next section of code within a case.
```csharp
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
```

Switch statements can also select cases by the use of comparison operators with this working by breaking down sections by having a case selected if it is the only case that matches that value or if it is the first case in the order to. The default statement is a catch-all (the same as a pure else on an if statement).
```csharp
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
```

### Ternary Operators
A ternary operator uses a question mark to create an argument in order to put a simple if onto a single line.
> ## Example
> argument ? (Output if True) : (Output if False)
This can be shown with actual code below:
```csharp
mark >= 65 ? "Pass" : "Fail"; 
```

## Operators and Control Flow

### What does the MyMethod Function do?
The MyMethod function checks if num1 is equal to num2 and then if this is true it returns false. However, if the two numbers are not equal then it is checked if num1 is divisable by num2 and returns true if this is true.
```csharp
num1 == num2 ? false : (num1 % num2) == 0; 
```

This hypothesis is then tested by using the testing code below:
```csharp
[Test]
[TestCase(10,10, false)]
[TestCase(15, 15, false)]
[TestCase(20, 20, false)]
[Category("Both Numbers are Equal")]
public void WhenNumbersTheSame_MyMethod_ReturnsFalse(int num1, int num2, bool expected)
{
 Assert.That(Exercises.MyMethod(num1,num2), Is.EqualTo(expected));
}

[Test]
[TestCase(20, 10, true)]
[TestCase(15, 5, true)]
[TestCase(200, 20, true)]
[Category("Number 1 is Divisible by Number 2")]
public void WhenNum1Divisible_MyMethod_ReturnsTrue(int num1, int num2, bool expected)
{
 Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expected));
}

[Test]
[TestCase(10, 20, false)]
[TestCase(5, 15, false)]
[TestCase(7, 2, false)]
[Category("Failure Tests")]
public void WhenNum1IsNotDivisible_MyMethod_ReturnsFalse(int num1, int num2, bool expected)
{
 Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expected));
}
```

### Average List Value and Tests
The average value from a list can be calculated by using a variety of different methods. The method below uses a foreach loop to go through each different item in the list, adding them together and then dividing them by the total number of items in the list to get the mean list value.
```csharp 
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
```

The code below tests the function using a test list as well as an empty list to check the results from this input.
```csharp
[Test]
public void Average_ReturnsCorrectAverage()
{
 var myList = new List<int>() { 3, 8, 1, 7, 3 };
 Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
}

[Test]
public void WhenListIsEmpty_Average_ReturnsZero()
{
 var myList = new List<int>() {};
 Assert.That(Exercises.Average(myList), Is.EqualTo(0));
}
```

### Ticket Type Code
The Ticket Type code should fit the following requirements
> "Standard" if they are between 18 and 59 inclusive
> "OAP" if they are 60 or over
> "Student" if they are 13-17 inclusive
> "Child" if they are 5-12
> "Free" if they are under 5

The code that meets these requirements is shown below:
```csharp
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
```

### Grade Calculator
The code below shows grade calculations performed by using a nested if statement (an if statement within an if statement system).
```csharp
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
```

With this code then tested by using these unit Tests:
```csharp
[Test]
[TestCase(0,  "Fail")]
[TestCase(39, "Fail")]
[TestCase(40, "Pass")]
[TestCase(59, "Pass")]
[TestCase(60, "Pass with Merit")]
[TestCase(74, "Pass with Merit")]
[TestCase(75, "Pass with Distinction")]
[TestCase(100, "Pass with Distinction")]
[Category("Edge Cases")]
public void WhenScoreIsEdgeCase_Grade_ReturnsCorrect(int score, string expected)
{
 Assert.That(Exercises.Grade(score), Is.EqualTo(expected));
}
```

### Maximum Number of Scottish Covid Wedding Attendees
The code must meet the requirements in the table below:
| **Level** | **Max Attendees** |
|-------|---------------|
| 4     | 20            |
| 3     | 50            |
| 2     | 50            |
| 1     | 100           |
| 0     | 200           |

This is broken down in a simple switch statement below:
```csharp
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
```

### Static Keyword
Static means that the item using the keyword doesn't need to be instanced. Along with this Static classes can only contain static members.

## Exceptions
Exceptions are objects which are thrown when an issue occurs at runtime. 
There are differences between
* Syntax Error (Won't compile due to spelling or written issue)
* Logic Errors (Code will compile but there is an issue with the operators)
* Exceptions (Code will compile but returns unexpected output)

Exceptions are used in order to locate where the issue occurs within the code and remove the need for a root cause analysis. The C# librarys exceptions are all subclasses of `SystemException`, which is a subclass of `Exception`

### Try-Catch Method
This is a method to catch exceptions at runtime and then run a piece of code in response. The code example below shows an example where strings are printed to the console when an exception is caused. With the finally keyword used to always run a piece of code regardless of exceptions hit.
```csharp
string text;
string fileName = "HelloWorld.txt";

try 
 { 
  text = File.ReadAllText(fileName); 
  Console.WriteLine(text);
 }
catch (FileNotFoundException ex)        //Exception stored in variable ex
 {
  Console.WriteLine("Sorry I can't find: " + fileName);
 }
catch (ArgumentException ex)            //Exception where no fileName entered
 {
  Console.WriteLine("You Gave Me an Empty fileName");
 }
finally
 {
  Console.WriteLine("Always Run No Matter What Happens");
 }
```

Exceptions can also be used in the code to trigger when the code has an error caused by an exception to its inputs:

```csharp
throw new ArgumentOutOfRangeException("Mark: " + mark + " Allowed Range: 0-100");
```

This provides information about the issue that is causing the code to fail while also allowing the code to respond to common errors.

#### Exception Testing
In NUint testing you can test if a piece of code has thrown the desired error in certain situations by using this code:

```csharp
public class GradeTests
{
    [TestCase(-34)]
    [TestCase(-1)]
    [Category("Less Than Zero")]
    public void WhenMarkLessThanZero_Grade_ThrowsArgumentOutOfRangeException(int mark)
    {
     Assert.That(() => Program.Grade(mark), Throws.TypeOf<GradeException>()
           .With.Message.Contain("Allowed range 0-100"));
    }
}
```

#### Exception Definition
In certain scenarios it may be beneficial to create your own exceptions in order to more accurately outline an issue. In these cases you can define a new exception name using  the class code below:

```csharp
public class GradeException : ArgumentOutOfRangeException
{
 public GradeException(string message) : base(message) { }
}
```

## Datatypes

C# is strongly and statically typed (so type is known at compile time), so data must have its type declared when it is initialized. The language is also typesafe, where as datas types are defined before use they cannot change type and cause errors (~~Excluding using Dynamic type~~). C# is also memory safe as areas of memory are predefined for data. 

### Var
`var x = "Ghost";`    The var keyword can be used to declare variable if it's type can be determined at compile time.
However it poses issues as it's not clear what datatype it is acting as, it also assigns memory not based on the data being held and so may lead to wasted memory space.

If `var` is passed a digit it assigns it the data value of `int` by default with the type chosen for numbers too large for this being the smallest that will allow the number to fit.

### Int
There are multiple different versions of an int (with the default `int` refering to `int32` specifically) with these types and the number ranges they can store being shown below:
* `sbyte`  -128 to 127
* `byte`   0 to 255 (the byte type is unsigned by default)
* `short`  -32,768 to 32,767
* `ushort` 0 to 65,535
* `int`    -2,147,483,648 to 2,147,483,647
* `uint`   0 to 4,294,967,295
* `long`   -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
* `ulong`  0 to 18,446,744,073,709,551,615

Unsigned integers means that the value of the data can only be positive. 

For an unsigned int in binary an all 1's value is the maximum, however on a signed int all 1's in binary is -1.

### Floating Point
This is a numeric data type which is used to store data that requires precision as it accurately stores decimal places:
* `float`   	~6-9 digits   (4 bytes)
* `double`  	~15-17 digits (8 bytes)
* `decimal`     28-29 digits (16 bytes)

This is useful in scenarios where a high level of precision is required (for example during distance calculations for moving a robot). Banks use Decimals to represent money rather than a float or a double due to the small rounding error that occurs in binary which will lead to noticable errors if done on a large enough scale.

This rounding error can also lead to issues in testing as it leads to small indescrepancies between two calculations performed by the same function and so a tolerance may need to be added.

### Datatype Casting
Datatypes can be changed by being acted on by differing operators.For example:
```csharp
var x = 5.50 / 5;
```
This converts the double data type on the right into the var datatype on the left. This can be done easily if the number being cast is of a smaller datatype than that which it is being cast to. However, when going from a larger datatype to a smaller datatype, explicit casting must be used due to the danger of data loss.

The following diagram shows the order of  which data can be **Implicitly Cast**
> `char`->`int`->`long`->`float`->`double`

Along with data which must be manually or **Explicitly cast**
> `double` -> `float` -> `long` -> `int` -> `char`

An example of **Explicit casting** is shown below:
```csharp
double x = 2.0;
int intx = (int)x;
```
#### Convert
This is a method used in order to **Explicitly Cast** a datatype to another, with demonstration code shown below:
```csharp
var theInt = 5;
//No Conversion
var anotherInt = Convert.ToInt32(theInt);
//safe - widening
var myDouble = Convert.ToDouble(theInt);
//unsafe - Narrowing
var myShort = Convert.ToIn16(theInt);
//InvalidCastException
var pi = 3.142;
DateTime piDay = Convert.ToDateTime(pi);
```
Convert class is preferable as it will cause an error if it fails rather than casting directly as this can silently fail leading to increased difficulty debugging.

### Data Under/OverFlow
Data under and overflow happens when a datatype is changed in a way that would cause its value to become out of range for the datatype being used. This then causes the datatype to loop around either to the minimum or maximum value and add or subtract the remainder from the new value.

> This underflow error is most well known for its effect on the Ghandi NPC in the Civilisation series. The character began the game with the lowest possible aggression value > > stored as a value from 0 to 10. The act of trading with the NPC then led to a subtraction of 1 from the aggression stat (as per the games code), with this action causing the > aggression stat to underflow and lead to Ghandi becoming incredibly aggressive towards other factions in the game.

If a number is explicitly cast to a value that cannot fit it in memory, this can lead to under or overflow depending on the value being cast.

#### Under/Overflow protection
Due to the way that the compiler works, it will detect if a value is being assigned to a datatype that is too large however, any values that are acted upon in the code are not checked by default. This means that a value can be iterated above or below its maximum value by mistake, this is to reduce the strain on the compiler checking all operations.

This can be changed by the use of either the checked operator or by right clicking the project -> properties -> search 'Checked' and then turn the option to check for under/overflow on.

The checked operator is used by simply surrounding the code you wish to check with brackets and the `check` operator

```csharp
check{
byte x = 256;
}
```

## More Datatypes

### Strings

Strings are stored in continuous memory blocks (In the same way as arrays) ending with an end of range characters. Strings look like primitive data types which are stored on the stack, but are in fact objects and so are stored in the heap (in the string pool). As a string is an object it has a constructor, they are also immutable and as such redefined data still exists it is just not referenced. 

`string` is an alias for `String` this means that there is a multitude of ways to initialize a string which are all equivalent:

```csharp
String nish = "Nish Kumar";
String nish2 = new String("Nish Kumar");
string nish3 = "Nish Kumar";
```

There are many different operations that can be performed on a string to allow for additional functionality, this includes:

#### Split
This operation is used to split a string into an array of strings and is useful for breaking up lists (such as the comma seperated lists in a csv file) into useable data.

```csharp
string names = "Jab,James,Guarav,Goncalo";
String[] namesToArray = names.Split(',');       //returns {"Jab","James","Guarav","Goncalo"}
```

#### Trim
This operator removes any blank space at the beginning or end of a string in order to clean up any used data:

```csharp
string data = " blank bits gone ";
string trimmedData = data.Trim();       // returns "blank bits gone"
```

#### Letter Case Operations
The case of the letters in a string can be changed simply by either using the ToUpper or ToLower operators:

```csharp
string data = "LoAdS oF dIfFeReNt CaSeS";
string dataLower = data.ToLower();      //returns "loads of different cases"
string dataUpper = data.ToUpper();      //returns "LOADS OF DIFFERENT CASES"
```

#### Replace
This operator works to replace characters in the string with a different selected character

```csharp
string changedData2 = changedData1.Replace('T', '*');   // this will replace any T's in the string with *'s
```

#### IndexOf
By using this operator you get the location of a designated character within a string as the string can be treated as an array of characters:

```csharp
var nPos = changedData2.IndexOf('N');
```

#### Remove
This operator removes a section of the string after a designated character location:

```csharp
data.Remove(location);
```

### StringBuilder Class
This class simply presents a mutable version of strings for manipulation, it does however, have fewer methods. The basic methods that can be used are: update, read, modify and delete. This is used mainly to reduce the amount of memory used by strings in a system but does still require the use of strings for certain operations. The code below show a string based operation along with its stringBuilder equivalent for reference.

```csharp
private string StringVersion(string input)
{
 string trimmedUpperString = input.Trim().ToUpper();
 string changedData1 = trimmedUpperString.Replace('L', '*');
 string changedData2 = changedData1.Replace('T', '*');
 var nPos = changedData2.IndexOf('N');
 return changedData2.Remove(nPos + 1);
}
    
private static string StringBuilderVersion(string input)
{
 var trimmedUpperString = input.Trim().ToUpper();
 var nPos = trimmedUpperString.IndexOf('n');
 StringBuilder sb = new StringBuilder(trimmedUpperString);
 sb.Replace('L', '*').Replace('T','*');
 sb.Remove(nPos + 1, sb.Length - nPos - 1);
 sb.Append(" and is better than c++ and Java");
 return sb.ToString();
}
```
**If a string needs to be changed in a loop, use a StringBuilder class instead to reduce the amount of data being used**
 
 This can be seen in the below example:
 ```csharp
 public static string ManipulateString(string input, int num) //a piece of code to manipulate and return a string
        {
            input = input.ToUpper().Trim();
            StringBuilder sb = new StringBuilder (input);
            for(int i = 0; i < num; i++)
            {
                sb.Append(i);
            }
            return   sb.ToString();
        }
 ```

### String Interpolation
This is a simplified method for combining strings rather than using the Concat function as this simplifies the overall code format. For Example:

```csharp
var spartaString = String.Concat("This", "Is", "Sparta");       //This is the concaternation method

Console.WriteLine("My name is : " + str + " using +");                          //the interpolation method can use the '+' operator
Console.WriteLine($"My name is {str} using interpolation");                     //the interpolation method can also use curled brackets to add data
var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";       // with the ability to perform code within these brackets

var fString2 = $"That will be {num1 / 3.0:C}, please";  //This would output num1/3 in GBP because of the C (culture operator)
                                                        //This can also use N (to give decimal places, 2 by default) and P (to give it as a percentage) 
```

### Parsing Strings
Parsing a string is converting it into a different datatype from its original, and can be done via the use of the Parse or TryParse operator. Below is a demonstration for the TryParse operator, the Parse method works the same way except it does not produce a boolean statement based upon whether the parsing is possible.

```csharp
bool isSuccess = true;
        ConsoleKeyInfo cki;     //stores key press data
        do {
            Console.WriteLine("How Many Apples?");
            string input = Console.ReadLine();          //simply reading the keyboard
            isSuccess = Int32.TryParse(input, out int numApples);       //the method is equal to a boolean statement while the out method produces the output of the Parsing
            Console.WriteLine($"{numApples} apples");                   //by default the output int is 0
            if (!isSuccess)
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine("Continue or Leave? Press Esc to leave");
            cki = Console.ReadKey();    //reading a single keypress
        } while (cki.Key != ConsoleKey.Escape);
```

### Arrays
Arrays are immutable, along with strings and constants. An array of type `var` cannot be directly created, however an array of a know type can be cast to it. For example
```csharp
var traineesArray = new string[]{"David","Marian","Stanni"};
```
Arrays are of a fixed size that is defined when they are created and trying to add past this point will throw a `OutOfRangeException`

**They also have a large amounts of methods that can be applied to them, with some shown here**

#### Reverse
This method simply reverses the order of the elements in the array, so the first index item becomes the last and visa versa.

#### ForEach
This method applies defined code to each part of the array referenced. So for example the code below prints out every item in the array
```csharp
Array.ForEach(myArray, x => Console.WriteLine(x);
```
#### OrderBy
This method is used to organise the data within an array and can be used in the form of `OrderByDescending` to sort integer values by their numerical value.

### Multi-Dimensional Arrays
These are simply arrays but they operate in more than one direction (either 2 or 3 dimensions, with 2 being more prominant). The data within these arrays can be accessed in a similar way to using a graph, so `array[row,column]`. They work in a grid or cube format.

With a 2 dimensional array able to be defined as below:
```csharp
char[,] gridTwo =
{
{'a','b'},
{'c','d'},
{'e','f'},
{'g','h'}
};
```
If a foreach loop is used to iterate through a multidimensional array, it simply flattens it and treats it as a single dimension array.

### Jagged Arrays
These are arrays of arrays (nested arrays), with them able to contain arrays of different lengths (hence the name jagged). So in an example, there is one array where each indexed data point within it is, itself, and array (think of it like a spine and ribs system).

```csharp
int[][] intJArray = new int[2][];
        intJArray[0] = new int[4];
        intJArray[1] = new int[2];

        intJArray[0][2] = 3; //This sets a single cell in the array
```

### Date and Time
This presents an issue due to the presence of leap years, leap seconds as well as other calendar formats. This has led to coding systems having calendar management built into their systems with many different cultures calendars provided for.

In computing the method of ticks is often used, there are 10 million ticks in a second.

The minimum value for datetime in C# is 00:00:00 00/00/0000 with the max value being the end of the year 9999.

The Unix timecode is the start of 1970, and this is the base time for a large amount of computers as they count from this moment. This poses an issue however if a system uses a 32 bit system, as this will overflow in 2038 but can be fixed by switching to a 64 bit number which is magnitudes larger.

To get the time when the code is run:
```csharp
var now = DateTime.Now;

var tomorrow = now.AddDays(1);                  //this calculates tomorrows date (any time segment can be refered to here)
Console.WriteLine(tomorrow.ToString("y-M-d"));  //the ToString Method specifies the format of the date wanted

TimeSpan myAge = DateTime.Now - birthDay;       //Timespan is simply the length of time between 2 dates
```

**.net 6.0 added some new date features**

Such as `DateOnly`, which is shown below, this simply formats dates to a usable format for most cases.
```csharp
var myDate = DateOnly(1989,11,2);
```

### Stopwatch
There is a stopwatch datatype which can be used to record periods of time within the code. This can be used as seen in the code below:

```csharp
var stopwatch = new Stopwatch();
        stopwatch.Start();
        long total = 0;
        for (int i = 0; i < int.MaxValue; i++)
        {
            total += i;
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        Console.WriteLine(stopwatch.ElapsedTicks);
```

### Enums (Enumerators)
This is used to display a fixed constant as it provides type safety. In the example below the enumerated data is the suits in a pack of cards, this is because they are fixed values. These can be best sorted with the use of `switch` cases.

```csharp
public enum suits
{
    HEARTS, CLUBS, DIAMONDS, SPADES     //these can be assigned integer values but by default they start from zero and iterate
}
```

You can cast other types to an enum using the `Parse` operator, if it matches.
```csharp
var anotherSuit = Enum.Parse(typrof(suits), "CLUBS");
```

### Const
This keyword means once the variable has been initialized it cannot be changed. So once it has been assigned a value in the code it cannot be reassigned, meaning that provided it is set correctly you should always know its value.

### Readonly
Readonly is used to make the variables for a class read only (and as such unable to be overwritten by sections of code). This is used for `private member variables` but for `methods` the `sealed` command is used.

```csharp
private readonly string _name;
public Trainee(string name)
{
_name = name;
}
```

**If a value is a private member then the convention is to name it `_variable` with an underscore at the start to show this behaviour.**

### Random
These can be created with or without a seed value (a starting point for random values), as they are psuedo random. If no seed value is provided then the computers time in ticks is used.
```csharp
        var rng = new Random();         //unseeded random
        var rngSeeded = new Random(42); //seeded random
        var between1And10 = rngSeeded.Next(1,11);       // The .Next method provides an upper and lower bound for the random number
        Console.WriteLine(between1And10);
```

## Methods

A method is made up of it's `visibility`, `Return type`, `name`, `parameters` (within the `signature`) and then its `body`

**Method Overloading** is providing a method with too many `parameters`

### Optional Parameters
These are a methods parameters that are not required for the method to run. The code below achieves this via the use of a default value for the input of the variable.

```csharp
public static int DoThis(int x, string y = "Happy") //y is the optional parameter 
{
Console.WriteLine($"I am feeling {y}");
return x * x;
}
```

**The optional parameter must be the last parameter to be entered (furthest right)**

### Method input description
When inputting to a method in c# you can define which inputs you are refering to:
```csharp
var myPizza = OrderPizza(anchovies: true, pineapple: false);
```
This makes the codee far easier to read, especially in longer sections of code.

### Ref Keyword
This is to not pass a copy of a variable but instead send a reference to its location in memory. For example in the method below y is unchanged by the operation on num within the method as its location in memory is not accessed (due to the use of a copy of it's value). However, in the z example no copy is made, with the location of z passed and so it is altered directly rather than having a temporary variable (that exists only in the method) changed.

```csharp
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
```

**The In and Out Keywords are used instead of Ref now in most use cases** 

#### Out keyword
This is a reference keyword that returns another output of a method to from a specific location in memory. It is defined in the signature of the method.

```csharp
public static int DoThis(int x, string y, out bool z)
```

#### In Keyword
The same as a reference but it's read only input reference and so the referenced value being passed cannot have its value in memory changed.

### Tuples
A tuple is a format of multiple datatypes in a single data structure

```csharp
var myTuple = (fName: "Liam", lName: "Gallagher", age: 49);

(string fName, string lName, int age) myTuple2 = ("Noel","Gallagher", 55);      //This is a more typesafe version of the same tuple
```

To have a method return a tuple its datatypes must be defined in the signature of the method
```csharp
public static (int stones, int pounds) ConvertPoundsToStones(int pounds)
```
Then when it is returned it is simply:
```csharp
return (st, lb); //Or it can be stored as a var result = (st, lb); and have this result returned
```
