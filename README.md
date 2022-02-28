# Sparta Global: Training Code
Code Created During The Sparta Global Training Program
>               #### Index
> 1) Time Of Day NUnit Testing
> 2) Test First Programming Excersize
> 3) Film Classification Coding and Testing Task
> 4) Operators
> 5) Control Flow Application
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

