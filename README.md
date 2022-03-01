# Sparta Global: Training Code
Code Created During The Sparta Global Training Program
> #### Index
> 1) Time Of Day NUnit Testing
> 2) Test First Programming Excersize
> 3) Film Classification Coding and Testing Task
> 4) Operators
> 5) Control Flow
> 6) Operators and Control Flow
> 7) Exceptions
> 8) Datatypes

## 1) Time Of Day NUnit Testing
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

## 2) Test First Programming Excersize
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

## 3) Film Classification Coding and Testing Task
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

## 4) Operators

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

## 5) Control Flow

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

## 6) Operators and Control Flow

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

## 7) Exceptions
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

## 8) Datatypes

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

### Floating Point
This is a numeric data type which is used to store data that requires precision as it accurately stores decimal places:
* `float`   	~6-9 digits   (4 bytes)
* `double`  	~15-17 digits (8 bytes)
* `decimal`     28-29 digits (16 bytes)

This is useful in scenarios where a high level of precision is required (for example during distance calculations for moving a robot). Banks use Decimals to represent money rather than a float or a double due to the small rounding error that occurs in binary which will lead to noticable errors if done on a large enough scale.

### Datatype Casting
Datatypes can be changed by being acted on by differing operators.For example:
```csharp
var x = 5.50 / 5;
```
This converts the double data type on the right into the var datatype on the left. This can be done easily if the number being cast is of a smaller datatype than that which it is being cast to. However, when going from a larger datatype to a smaller datatype, explicit casting must be used due to the danger of data loss.

The following diagram shows the order of  which data can be **Implicitly Cast**
> `char`->`int`->`long`->`float`->`double`

Along with data which mus be **Explicitly cast**(or manually cast)
> `double` -> `float` -> `long` -> `int` -> `char`
