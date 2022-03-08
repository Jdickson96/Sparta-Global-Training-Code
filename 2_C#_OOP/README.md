# Object-Oriented Programming
Code and notes created during the OOP section of the Sparta Global Training Course.
> **OOP Sections**
> * [Introduction](#Introduction)
> * [Safari Park System](#Safari-Park-System)
> * [Derived Classes](#Derived-Classes)

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

#### Abstraction
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

#### Encapsulation
Encapsulation is the process of hiding the detail of how the system works in order to make it easier to use. This provides a simple, consistent interface to use the system where each class has a well defined responsibility. The user only gets a set of simple controls to operate the system.

This makes use of the `private` keyword in order to hide values from the user (with the variables named in the `_variable` notation).

```csharp
public string FirstName { get => _firstName; set => _firstName = value; } // this is encapsulation

cust.LastName = "Ghosh"; //this will assign this string value to a property
```

#### Inheritance

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

#### Polymorphism

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
This means that the superclasses methods can be reassigned by a subclass. However, this can only be done if the base class methods are assigned as `virtual` and is achieved by using the `override` identifier.

```csharp
public override string ToString()
{
return $"{base.ToString()} Name: {FullName} Age: {Age}"; //The base.ToString() method calls the method in the superclass of this class
}
```

### Virtual Methods

This means the method can be overwritten in derived classes with each of these methods providing a default implementation. These methods can be called in derived classes but overwritten with `override`

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
