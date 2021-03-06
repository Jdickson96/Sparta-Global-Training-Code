# Object-Oriented Programming
Code and notes created during the OOP section of the Sparta Global Training Course.
> **OOP Sections**
> * [Introduction](#Introduction)
> * [Safari Park System](#Safari-Park-System)
> * [Derived Classes](#Derived-Classes)
> * [Polymorphism](#Polymorphism)
> * [SOLID Principles](#SOLID-Principles)
> * [Collections](#Collections)

## Introduction
Object Oriented Programming was developed to replace the previous procedural programming structure that had been in place. This is due to weaknesses in this coding setup steming from the practice of having code and data in seperate locations within the program. By having these seperate, it leads to several key issues:

* Lacking Modularity
* High Levels of coupling between values and its code counterpart
* Re-using code is difficult
* It doesn't model real world systems

Instead of this procedural method OOP systems combine the data with the code acting upon it in units called `classes`. OOP as a format now dominates the prominant coding languages used today (with 4/5 of the main languages being OOP in design). This is due to its key benefits:

* It's Data and Functions are combined
* Better Modularity
* Low levels of Coupling
* Re-Use of code is much easier
* It Models the real world

### 4 Principles of OOP
> These key principles which define if a language can be called an OOP language or not are:
> 
> * Abstraction
> * Encapsulation
> * Inheritance
> * Polymorphism

#### 1) Abstraction
Abstraction is the process of defining an item by a name, its key attributes and operation. For example a car can be broken down into its constituent physical parts as well as its use (drive, open door, etc). The unit of abstraction is the `class` - `blueprint`

The `class` identifier represents abstraction with instances of a class being objects. These instances then can interact with each other via the use of methods and can be combined to make more things.

```csharp
public class Customer
{
public string FirstName;
public string LastName;

  public Customer(string fName, string lName)
  {
    FirstName = fName;
    LastName = lName;
  }
  
  public Print()  //This method can be used by calling cust.Print();
  {
  Console.WriteLine("fName + " " + lName);
  }
}
```

#### 2) Encapsulation
Encapsulation is the process of hiding the detail of how the system works in order to make it easier to use. This provides a simple, consistent interface to use the system where each class has a well defined responsibility. The user only gets a set of simple controls to operate the system.

This makes use of the `private` keyword in order to hide values from the user (with the variables named in the `_variable` notation).

```csharp
public string FirstName { get => _firstName; set => _firstName = value; } // this is encapsulation

cust.LastName = "Ghosh"; //this will assign this string value to a property
```

#### 3) Inheritance

We can chose to create various different versions of an overall type, with these being specialized. For example a car is a specialized type of vehicle with a sports car being a specialized type of car. This means we can create hierarchies of types within a system.

These relationships are often described as an item higher up the hierarchy would be a `superclass` or `base class` of a `subclass` or `derived class` item beneath it with this referred to as an `inheritance hierarchy`. The subclass has code specialized to that use case.

This avoids repeating code to describe the same thing and has a buisness value as it reduces the amount of time spent on a project. 

The relationship between a class and an inherited class is a **B extends A** relationship. 

```csharp
class Customer : Person //this is defined in the subclass to show it belongs to a superclass
  public Customer(string FName, string LName) : base(Fname,Lname) //superclass constructor is called after the colons

public class Person
{
}
```

#### 4) Polymorphism

This is the requirement to perform an action when it recieves a message, so while many different objects may recieve the same message, they each respond differently. 

If the superclass has a function also used by its subclasses, in order to avoid this being called the superclass version has the `virtual` keyword while the subclasses function have the `override` keyword applied.

```csharp
//Same Command, Different Result
cust.Print();
emp.Print();
```

## Safari Park System

This is a demonstration project for OOP programming

### UML Class Diagrams

A way of representing classes and the relationships between them can be shown at varying levels of detail. Their main benefit is the ability to use them to explain code to non-specialists. They break a class code block down into its simple constituent parts: 
* `Fields`
* `Properties`
* `Methods`

### Basic Class Setup

The simple makeup of a class is: `Fields`, `Properties` and `Methods`.

In the main method of a system the class is instanced using the following code: 

```csharp
public static void Main()
    {
        Person james = new Person("James", "Dickson", 26);  //new generates a new instance of an object by calling constructor
        Console.WriteLine(james.GetFullName());
        james.Age = 1;  //calls Setter
        var jamesAge = james.Age; //calls getter
    }
```

Which refers to the following code in a class file:

```csharp
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        public int Age { get; set; }  //The get set setup
        public Person(string firstName, string lastName, int age = 0) //Default age is 0 if unspecified
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }
        
        public Person(string firstName) //this is a constructor
        {
            _firstName = firstName;
        }

        public string GetFullName() //This is a simple method
        {
            return $"{_firstName} {_lastName}";
        }
    }
```

Due to polymorphism the constructor in the code above is selected by the amount of input arguments, however while more constructors can be added as needed it is best practice to reduce the number of these. This is because it reduces the repetition of code and reduces the chance of syntax or input errors. 

**The constructor must have the same name as the class it is constructing and it does not have a return type (Including Void)**

**If a constructor with parameter is used then a parameterless constructor must be written if needed as the compiler will no longer create one for you**

For example, in the code below, without the parameterless constructor the code assumes the only constructor we want is the one we have supplied:

```csharp
public Vehicle() { }

        public Vehicle(int numPassengers, int speed = 10)
        {
            NumPassengers = numPassengers;
            Speed = Math.Abs(speed);    
        }
```

> A `get set` system can be easily created in code by typing "prop" 'tab' 'tab' while the constructor can be easily created using ptor 'tab' 'tab'. 

The `get set` system can be expanded to look like this, with checks in place to ensure only valid inputs are taken:

```csharp
 public int Age {
            get { return _age; }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Age must be 0 or greater");
                }
                else
                {
                    _age = value; //value is the input to the getter-setter function
                }
            } 
        }
```

The GetFullName method can be simplified down to a property (without a set as it has no directly corresponding field):
```csharp
public string GetFullName => $"{_firstName} {_lastName}";
```

### Object Initializers

These have been used previously in the course when an array of data is initialized and are used to set the values for each of the inputs in a single command. 

**The default values for unfilled reference types is 0 with 'bool' being false by default.**

#### Init only setters

These are used in place of set boilerplate code in order to reduce the length of code for each readonly class being initialized. The code below demonstrates this method, with this variable only being able to be read after initialization.

```csharp
public int Age { get; init; }

public int Age { get; init; } = 10; //this sets the default value of age to 10
```

### Structs

These are similar to classes (but `structs` are value types and `classes` are reference types, they can be declared without the `new` keyword (for example `DateTime` is a `struct`. 

They combine multiple pieces of data into a single unit, for example 3 axis coordinates can go into a single Coordinate `struct` value. It is unlikely that these will be used by a developer due to the presence of `classes` (Excluding premade `structs` such as `DateTime`)

## Derived Classes

When the derived class constructor is called, it immediately calls the base class constructor and then once this has completed the body of the derived class constructor runs.

The derived class can access public fields, 

The base class has no knowledge of its derived classes.

```csharp
var fullname = $"{base._firstName} {base._lastName}";
```

### Overriding Methods
This means that the superclasses methods can be reassigned by a subclass. However, this can only be done if the base class methods are assigned as `virtual` and is achieved by using the `override` identifier. The `ToString()` method can be overwritten in each class written in order to provide more useful information.

```csharp
public override string ToString()
{
return $"{base.ToString()} Name: {FullName} Age: {Age}"; //The base.ToString() method calls the method in the superclass of this class
}
```

### Virtual Methods

This means the method can be overwritten in derived classes with each of these methods providing a default implementation. These methods can be called in derived classes but overwritten with `override`. Some example implementation is:

```csharp
public virtual bool Equals(object obj)
public virtual int GetHashCode()
public virtual string ToString()
```

With each of these implementations providing a default implementation. We can call the implementation of the base class method in the body of the derived class.

### Abstract Methods and Abstract Classes

Somethimes, there is no sensible implementation of a base class method, so there is no point in providing a method body so we want derived classes to provide their own. A good example of this is the `CalculateArea` method in a `shape` class. In this case the `abstract` keyword is used.

**If a class has one or more `abstract` methods then it must also be declared as `abstract`**

Both abstract classes can have a mix of both concrete and abstract methods but concrete classes cannot have abstract methods. But abstract methods **MUST** be implemented in their derived classes.

An abstract method has a method signature but **NO** method body.

#### Abstract and Sealed Methods

These keywords can be applied to either individual methods, or whole classes.
* **Abstract Method** - Not Implemented here, must be overwritten in a derived class
* **Abstract Class**  - Can't be instantiated
  * A Class Can be abstract even if it doesn't include any Abstract methods
 
* **Sealed Method** - Prevents a method that overrides a base class virtual or abstract method from being overwritten in a derived class
* **Sealed class**  - prevents the entire class being derived from (no children allowed)

## Polymorphism

Many forms of the same thing, but they need a way to flexibly interact. 

### ToString()

All classes derive from the `Object` Class which defines a `virtual` ToString() Method. In the code below because the ToString() method is overwritten within the Person class, the system choses at runtime to use this definition rather than the global definition of the phrase.

```csharp
 { //Main  
        Person yolanda = new Person("Yolanda", "Young");
        SpartaWrite(yolanda);
    }

    public static void SpartaWrite(Object obj)
    {
        Console.WriteLine(obj.ToString());  //This is runtime Polymorphism (the commonly understood form of Polymorphism)
    }
```

**Method overloading is a type of compile time polymorphism**

### Casting

When casting a class, you cannot cast from a base class to a derived class but you can cast from a derived class to a base class (imagine a family tree, you can work up but not down easily)

The code below shows how items can be cast:
```csharp
var a = new Person("Nish", "Mandal") { Age = 32 };
        var b = new Hunter("Hunter", "McHunty", "Pentax");

        SpartaWrite(a);
        var c = (Person)b;  //Treat b as though its a person even though its a hunter
        SpartaWrite(c);

        var d = a as Hunter;    //This will not cast to a hunter as you cannot cast from a base class to a subclass (cannot downcast)
        SpartaWrite(d);
```

Code to check if an object has been properly cast:
```csharp
 public static void SpartaWrite(Object obj)
    {
        Console.WriteLine(obj.ToString());  //This is runtime Polymorphism (the commonly understood form of Polymorphism)
        if (obj is Hunter)  //The is keyword is used to check if two objects are the same type
        {
            var hunterObj = (Hunter)obj;
            Console.WriteLine(hunterObj.Shoot);
        }
    }
```

### Interface

> * Interfaces are not inherited, they are implemented using the `interface` keyword.
> * They begin with a capital I by convention
> * All members are public by default (they can't use access modifiers)
> * All methods are Abstract (signature only)
> * Can't include constants, fields or constructors
> * Can't include property declarations, but they must be implemented in the implementing class

```csharp
public interface IMovable
{
  string Move();
  string Move(int times);
}
```

## SOLID Principles

> **The Solid Principles are as follows:**
> * Single Responsibility (SRP)
> * Open Closed (OCP)
> * Liskov Substituion (LSP)
> * Interface segregation (ISP)
> * Dependency Inversion (DIP)

### Single Responsibility

* A software module (usually `class`) should **represent just one thing**.
* The class members (fields, properties, and methods) should be cohesive:
  * The fields and properties should hold info about the thing
  * The methods should manipulate or return this information
* The class should have only one reason to change

In the safari park code the movement of the camera from within the hunter class to its own individual class was changing the hunter from multiple responsibility to a single responsibility class. This led to both classes becoming more cohesive as they both only have a single reason to change.
* The hunther changes to add more hunting functionality
* The camera changes if we want to change how it works (for example change focus, add a filter, etc..)

**This makes it easier for other devs to read and debug**

### Open Closed

* Software entities (methods and classes) should be open for extension but closed for modification
* The `weapon` class is abstract and once defined should not be changed
  * It may already be changed

Exception classes and their subclasses in the system namespace are part of the C# library so we can't change it, however we can customise an existing exception instance by providing a meaningful method in its constructor. For more functionality we can also subclass an existing exception.

**As a lot of devs may be using your base class, keeping the software extended reather than edited reduces conflicts**

### Liskov Substitution

* Subtypes must be substitutable for their base types without breaking the application.
```csharp
public interface IMovable
{
  string Move();
  string Move(int times);
}
```
* We expect any class implemented in this interface to implement these methods
* We can use them anywhere an IMoveable Object is expected
* This is the escence of polymorphism

This principle is the concept that all items within the same class should respond in a similar way for a given method. None of their results should be unexcepted, they should work consistently.

### Interface segregation

Many small, specific interfaces are better than one large, general purpose one. `interface` in this context means the public methods and properties of a code module. In the safari park example we considered whether to implement a general-purpose interface or many smaller ones for specific use.

Having small interfaces that only allow one type of behaviour helps enforce the Liskov Substitution principle as the functionality of the system is better defined. 

**Many client-specific interfaces are better than one general-purpose interface**

### Dependency Inversion

* Depends on abstractions rather than concrete instances
* High level modules should not depend on low-level modules
  * Both should depend on abstractions
* High Level
  * Business rules, processes, guts of the application
  * Calculator class, Radio class 
* Low Level 
  * Plumbing code, particularly for IO
  * Interaction with GUI, files, database, API calls 

In the safari code, we intially defined that a hunter has a camera but we could have done this by having the hunter constructor run a camera constructor within its code. However, this would cause a high level of coupling and violate the SRP and DIP, SOLID Principles. This makes it harder to test the Hunter and Camera separately.

But instead, we used **dependency injection**. Where the dependency is injected in the constructor, and so the IShootable interface was placed in the constructor. This allows flexibility as any IShootable object can be called.

#### DIP Example

* The GUI code-behind classes are low-level
  * Handle user interactions with the GUI
  * Depends on the Calculator class
  * Ideally we would refactor this so it depends on an ICalculator interface

* The Calculator class is high-level
  * knows nothing about the GUI 

**This increases the codes maintainability and usability. With TRANSPARENT DEPENDENCY**

### SOLID Relationships

**Single Responsibility** and **Interface Segregation** encourage small, cohesive types, which can then be extended using **Open/Closed**. **Interface Segregation** aids **Liskov Substitution** and **Dependency Inversion**. With **Dependency Inversion** enablinng **Open/Closed** as you can change behaviour using ddependency injection.

### Pain Driven Development

Don't go wild with using all the SOLID principles and design patterns, just use simple techniques until they start to cause pain. Then refactor to solve the problem (which is safe if you already have tests to check the code function).

## Object Equality and Comparison

By default the `object` equality operators compare the positions of the compared classes in memory rather than the data they contain. This means that by default these operators only check if the data is referencing the same position in memory.

This can be changed however, with the use of an override of the Equals and comparison operators within the class.

The comparison code used in our example was:

```csharp
public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (this._lastName != other._lastName) return this._lastName.CompareTo(other._lastName);
            else if (this._firstName != other._firstName) return this._firstName.CompareTo(other._firstName);
            else return this._age.CompareTo(other._age);
        }
```

With reference after the signatures of:

```csharp
 IEquatable<Person?>, IComparable<Person> 
```

With the Equals code being changed to be:

```csharp
public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other != null &&
                   _firstName == other._firstName &&
                   _lastName == other._lastName &&
                   _age == other._age;
        }
```

And finally the GetHshCode() function was changed to reference the data contained rather than a data address:

```csharp
public override int GetHashCode()   //by default this uses the memory address but here it is the data
        {
            return HashCode.Combine(_firstName, _lastName, _age);
        }
```

### GetHashCode()

* A hachcode is a number used to identify an object in a hash-based collection such as a `Dictionary<TKey, TValue>`
* Two equal objects should have the same hashcode
* However, it is possible (but not desirable) for two unequal objects to have the same hashcode by coincidence (for example: James Lewis and Lewis James)
* The default object implementation of GetHashCode() returns the hashcode of the object reference.

** If you override Equals(), you should also override GetHashCode() **

## Collections

Lists and Arrays have a lot of similarities:
* Both can be iterated through
* Both can be indexed
* Both are typed

However they have some key differences:
* Arrays are of a fixed size and Lists can change size

Some list operations are shown in the code below:

```csharp
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
```

### Linked Lists

These lists are not organised by their position in memory, rather by a pointer from each element to the nexts location in memory.

They do not have the IList interface, and so you cannot access specific indexes. This means that a list must be iterated through rather than directly accessing data. You can still access the first and last data but any other must be iterated to.

The benefits of linked lists are that they are more memory efficient, they are also better to have memory added and removed from the list. This is due to linked lists being very flexible in memory. However, lists are much faster at accessing individual sections of data as they are indexed.

```csharp
        LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
        thePeopleLinked.AddFirst(helen);
        thePeopleLinked.AddFirst(will);
        thePeopleLinked.AddLast(new Person("Nish", "Mandal"));

        foreach (var person in thePeopleLinked)
        {
            Console.WriteLine(person);
        }
```

### Queues

These are fast to access and they can add and remove elements. They are **First In First Out**, and an example is the things sent to a printer to print.This functions similar to how a queue in real life works.

```csharp
        var myQueue = new Queue<Person>();
        myQueue.Enqueue(helen);   //This adds to the end of the queue
        myQueue.Enqueue(will);
        myQueue.Enqueue(new Person("Nish", "Mandal"));

        foreach(var item in myQueue)
        {
            Console.WriteLine(item);
        }

        var first = myQueue.Peek();     //This looks at who is at the front of the queue
        var serve = myQueue.Dequeue();  //This removes the person at the front of the queue
```

### Stacks

This is a **First in, Last Out** data model. An example usage of it is the undo function in word.

```csharp
        int[] original = new int[] { 1, 2, 3, 4, 5 };
        int[] reversed = new int[original.Length];
        var stack = new Stack<int>();

        foreach (var n in original) //This puts the data onto the stack
        {
            stack.Push(n);
        }

        //pop off the stack, which will be 5 and continue until our array is full
        for(int i = 0; i < original.Length; i++)
        {
            reversed[i] = stack.Pop();  //the data comes off the stack in reverse
        }
```

### HashSet

No duplicate elements are allowed (eg no two of the same number in an int HashSet). This method uses the hashcodes of the data within it to order them, this leads to a very high speed search.

```csharp
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
```

## Dictionaries

A group of key-value sets, where the values can be indexed by their keys. An example of a `dictionary` is shown below: 

```csharp
var personDictionary = new Dictionary<string, Person>
        {
            {"helen", helen },
            {"Sherlock", new Person("Sherlock", "Holmes") {Age = 40} }
        };
        
        Person p = personDictionary["Sherlock"];  //The data is accessed using this
        
        string input = "The cat in the hat comes back";
        input.Trim().ToLower();
        var countDict = new Dictionary<char, int>();
        foreach(char character in input)
        {
            if (countDict.ContainsKey(character))
            {
               countDict[character]++;    //This adds to the value stored in a dictionary pair
            }
            else
            {
                countDict.Add(character, 1);  //This creates a new dictionary entry
            }
        }

        foreach(KeyValuePair<char,int> keyValuePair in countDict)
        {
            Console.WriteLine(keyValuePair); //.Key or .Value can be added to access a single part of the pair
        }
```

## Advanced NUnit Testing

NUnit tests work using a model based on:
* Arrange
* Act
* Assert

There are two main models for NUnit testing, the Classic model (still supported, but not developed past NUnit 2.0) and the constraint model. With the constraint model being the current model in development and use.

There are many different operators that can be used in NUnit testing

### The characteristics of a good NUnit Test

> * **F**ast (Tests should take milliseconds to run)
> * **I**solated (They should be standalone and not rely on outside factors)
> * **R**epeatable (Test Results should be consistent)
> * **S**elf-Checking (Should be able to check if passed or failed without human interaction)
> * **T**imely (Shouldn't take a long time to write compared to code tested)

A Test class should be cohesive, so it should test the same type of output across the class. 

The name of tests should consist of:
* The method
* The scenario
* The expected output

## Test Driven Development

This is the process of:
* Write a failing test
* Make the test pass
* Refactor the code

Developers on average create 70 bugs per thousand lines of code. TDD encourages good coding practices as the developer only writes code to fit the test. This means the code is increased in cohesion as well as more focused. 

> **Retesting** - Found issue, issue has been fixed. The rest is then re-run to ensure fix has worked.
> 
> **Regression Testing** - Checks if any changes to the system has damaged any pre-existing functionality (checks for side-effects of code changes)

For testing 70% of effort should be on Unit Testing, as it is cheapest and easiest to implement. 

Unit tests should be part of the definition of done for a user story within any feature. If given code without tests, write these before making changes or adding further code to ensure original code functionality is not lost.
