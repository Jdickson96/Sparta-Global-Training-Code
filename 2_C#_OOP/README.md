# Object-Oriented Programming
Code and notes created during the OOP section of the Sparta Global Training Course.
> **OOP Sections**
> * [Introduction](#Introduction)
> * 

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

### UML Class Diagrams

A way of representing classes and the relationships between them can be shown at varying levels of detail.

