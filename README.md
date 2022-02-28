# Sparta Global: Training Code
Code Created During The Sparta Global Training Program
> #### Index
> 1) Time Of Day NUnit Testing
> 2) Test First Programming Excersize
> 3) Film Classification Coding and Testing Task
> 4) Operators
> 5) Control Flow
> 6) Operators Control Flow

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

#### Iteration Operators
Iterating a number in code by one can be done in two ways.
```csharp
a = x++;
b = ++y;
```
Having the operator after the value means that the addition is done at the end of the line, whereas having the operator before the value means that the addition is performed before other operations involving the value.

#### Operations assigning types to values
The value of an equations output is dependent on the data types of those being acted on in the equation. If the numbers have an int datatype then the outputted data will be a whole number. However, if a double is divided by an int then the output will act as a double.
```csharp
var c = 5 / 2;          //c is an int as both equation variables are ints 
var d = 5.0 / 2;        //d is an double as the number being divided is a double 
var e = 5 / 3;          //e is an int as both equation variables are ints 
double f = 5 / 2;       //f is a whole number as both equation variables are ints 
```

#### Modulus Operator Use
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

#### Pounds to Stones and Pounds
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

#### Shortcircuiting Operators
Below is a shortcircuiting and (the && operator) as if the left side of the statement is false then the right side is not called. A single and (&) evaluates both arguements but two and operators (&&) looks at them in order from left to right. Which means that the code below will not call the JumpOutOfAirplane function if there is && but it will be called if there is a single & function.

```csharp
bool isWearingParachute = false;

if (isWearingParachute && JumpOutOfAirplane()) //rather than: if (isWearingParachute && JumpOutOfAirplane()) 
  {
   Console.WriteLine("Congrats, you have made a successful jump!");
  }
```

#### Exclusive OR (XOR) Operator
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

