# Sparta Global: Training Code
Code Created During The Sparta Global Training Program

## Hello World
This was a Hello world at one point but I have changed it because I don't think a Hello World file is worth saving. It is currently a piece of code that I am working on in my free time to practice C#. I will add further details when I add more to the code.

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

### Check input for "password"
The code below converts the string into completely lower case in order to remove any issues with uppercase characters not being recognised.
```csharp
   if(input.ToLower() == "password") { return true; }
                                else { return false; }
```

### Return the sum of all of the items in a list
The code below uses two main methods in order to reduce complexity. The foreach function is used in place of a for loop as well as using the += command to add a custom ammount on each iteration.
```csharp
   int sumOfList = 0;
   foreach (int number in list){   sumOfList += number; }
   return sumOfList;
```
