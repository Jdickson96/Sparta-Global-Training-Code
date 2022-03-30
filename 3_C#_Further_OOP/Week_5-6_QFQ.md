## Week 5/6 Data & APIs

### Serialisation

#### What is Serialisation?

Serialization is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database, or a file. Its main purpose is to save the state of an object in order to be able to recreate it when needed.

#### What are the advantages and disadvantages of using binary object serialisation? JSON Serialisation? / XML Serialisation?

**Binary Object Serialisation**
Advantages:
* Preserves type fidelity
* Stores all detail

Disadvantages:
* Dangerous as deserializing the data is never safe when used with an untrusted input

**JSON (JavaScript Object Notation) Serialisation**
Advantages:
* Open Standard
* Popular for sharing data over the web

Disadvantages:
* Only serialises public properties
* Does not preserve type fidelity

**XML (Extensible Markup Language) Serialisation**
Advantages:
* Open standard so popular for sharing data over the web
* Only public properties and fields

Disadvantages:
* Does not preserve type fidelity

### LINQ and Lambda

#### LINQ uses two syntaxes - Name and describe them

The two syntaxes are Method and Query Syntax:

**Method Syntax**

 Method syntax uses extension methods included in the Enumerable or Queryable static classes and comprises of extension methods and Lambda expression.

**Query Syntax**

Query syntax starts with from keyword and ends with select keyword, it looks like SQL.

#### When is a LINQ query executed?

A LINQ Query is executed when the data is iterated over.

#### What is a Lambda expression?  Why is it used in LINQ queries?

Lambda expressions are anonymous functions that contain expressions or sequence of operators. All lambda expressions use the lambda operator =>, that can be read as “goes to” or “becomes”. The left side of the lambda operator specifies the input parameters and the right side holds an expression or a code block that works with the entry parameters. Usually lambda expressions are used as predicates or instead of delegates (a type that references a method).

#### What does x => x * x mean?

Every value in the list being iterated through is squared.

#### What is an anonymous method?

As the name suggests, an anonymous method is a method without a name. Anonymous methods in C# can be defined using the delegate keyword and can be assigned to a variable of delegate type.

#### What is Expression body syntax?

Expression body definitions let you provide a member's implementation in a very concise, readable form. You can use an expression body definition whenever the logic for any supported member, such as a method or property, consists of a single expression. An expression body definition has the following general syntax:

```csharp
public override string ToString() => $"{fname} {lname}".Trim();
```

### Entity Framework

#### NorthwindContext had DbSet (of Customer objects) - what did it do?

A DbSet represents the collection of all entities in the context, or that can be queried from the database, of a given type.

#### What is LINQ?

Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language.

#### What are the advantages of using EF over raw SQL?

* It gives developers the ability to write SQL "like" syntax within a C# or other .NET environment, but it has the same efficiency of executing SQL through the SQL libraries that already exist in .NET.
* Entity Framework helps to reduce development time and development cost.
* It provides auto-generated code and allows developers to visually design models and mapping of databases.
* It allows easy mapping of Business Objects.
* It helps to perform fast CRUD operations in .NET Applications.

#### What is a connection string used for – what information does it contain?

 The connection string contains the information that the provider need to know to be able to establish a connection to the database or the data file.

#### In the context of Entity Framework, what does scaffolding mean?

Frameworks are designed to simplify the programmer's work as much as possible, and in particular, reduce the amount of code they need to write. Although they are doing well, there are still situations where a certain amount of stereotypical code is necessary and there's no way the framework could change this.

#### When a class is generated from a database, what does it contain?

contains the model definition and mapping information

#### What does the DbContext class contain?

A DbContext instance represents a combination of the Unit Of Work and Repository patterns such that it can be used to query from a database and group together changes that will then be written back to the store as a unit. DbContext is conceptually similar to ObjectContext.

#### How are 1 to many relationships represented in the code model?

You can establish a one-to-many relationship by using any of the following code first conventions.

```csharp
public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
}

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public Author Author { get; set; }
}
```

#### What is the using keyword used for?

The using keyword has two major uses:

* The using statement defines a scope at the end of which an object will be disposed.
* The using directive creates an alias for a namespace or imports types defined in other namespaces.

#### What is meant by a partial class and why is it useful?

you can split the implementation of a class, a struct, a method, or an interface in multiple .cs files using the partial keyword. The compiler will combine all the implementation from multiple .cs files when the program is compiled.
There are several situations when splitting a class definition is desirable:

* When working on large projects, spreading a class over separate files enables multiple programmers to work on it at the same time.
* When working with automatically generated source, code can be added to the class without having to recreate the source file. Visual Studio uses this approach when it creates Windows Forms, Web service wrapper code, and so on. You can create code that uses these classes without having to modify the file created by Visual Studio.
* When using source generators to generate additional functionality in a class.

#### What do we mean by the term model first approach to EF?

In the Model-First approach, you create the entities, relationships, and inheritance hierarchies directly on the design surface and then generate the database from your model.

#### What are EF Migrations?

Migration is a way to keep the database schema in sync with the EF Core model by preserving data.

#### Using EF, how do you update an object’s data in the database?

#### When loading an object from the database, why aren’t all its associated objects loaded by default?

Lazy loading refers to objects are returned from a query without the related objects loaded at first. When the given collection or reference is first accessed on a particular object, an additional SELECT statement is emitted such that the requested collection is loaded.

#### What is the difference between the OO and Relational Approach?

An object-oriented database is a database that represents information in the form of objects as used in object-oriented Programming. An object-relational database, on the other hand, is a database that depends on the relational model and the object-oriented database model. Thus, this is the main difference between object oriented database and object relational database.

#### How do you load associated objects in a query?

Entity Framework supports three ways to load related data - eager loading, lazy loading and explicit loading. 

#### Why isn’t eager loading enabled by default?

Eager loading refers to objects returned from a query with the related collection or scalar reference already loaded up front. The Query achieves this either by augmenting the SELECT statement it would normally emit with a JOIN to load in related rows simultaneously, or by emitting additional SELECT statements after the primary one to load collections or scalar references at once.

### Asynchronous Programming

#### Why do we need to use asynchronous methods?

Asynchronous programming is a form of parallel programming that allows a unit of work to run separately from the primary application thread. When the work is complete, it notifies the main thread (as well as whether the work was completed or failed). 

#### What keywords should an asynchronous method use (and where?)

* Async code uses Task<T> and Task, which are constructs used to model work being done in the background.
* The async keyword turns a method into an async method, which allows you to use the await keyword in its body.
* When the await keyword is applied, it suspends the calling method and yields control back to its caller until the awaited task is complete.
await can only be used inside an async method.

#### What return types are allowed for asynchronous methods?

  Task, Task, and void
 
#### What effect does the await keyword have?

The await operator suspends evaluation of the enclosing async method until the asynchronous operation represented by its operand completes. When the asynchronous operation completes, the await operator returns the result of the operation, if any.
 
#### What is the naming convention for asynchronous methods?

 The name of an async method, by convention, ends with an "Async" suffix.
 
### APIs

#### What does API stand for?

* Application
* Programming
* Interface

#### What are the HTTP verbs and what are their CRUD equivalents?

* POST      - Create
* GET       - Read
* PUT/PATCH - Update
* DELETE    - Delete

#### What is the structure of an HTTP request?  An HTTP response?

HTTP request consists of 4 fundamental elements: A request line, zero or more header (General|Request|Entity) fields followed by CRLF, and a space preceding the CRLF (indicating the end of the header fields) and optionally a message body.
 
 HTTP response status codes indicate whether a specific HTTP request has been successfully completed.
 
#### What are the categories of HTTP response status code?
 
* Informational responses (100–199)
* Successful responses (200–299)
* Redirection messages (300–399)
* Client error responses (400–499)
* Server error responses (500–599)

#### What does REST stand for in the context of RESTful APIs?

REST stands for Representational State Transfer

#### What are the characteristics of a REST API?
 
 1. It is stateless
 2. It supports JSON and XML
 3. It is simple than SOAP
 4. Documentation
 5. Error messages

#### For the endpoint myapi.com/api/customers what would you expect a GET request to do?  A POST request?  PUT? DELETE?

 
 
#### What does REST stand for?

 REST stands for Representational State Transfer
 
#### What do we mean by caching?
 
 A cache is a temporary storage area. For example, the files you automatically request by looking at a Web page are stored on your hard disk in a cache subdirectory under the directory for your browser. 

#### What should the RESTful endpoint myresource.io/Employees/6/Order/2 GET?

#### Give some examples of header elements that can be used to control caching?
 
| Request	| Response |
----------------------
| max-age |	max-age |
| max-stale |	- |
| min-fresh |	- |
| - |	s-maxage |
| no-cache |	no-cache |
| no-store |	no-store |
| no-transform |	no-transform |
| only-if-cached |	- |
| - |	must-revalidate |
| - |	proxy-revalidate |
| - |	must-understand |
| -	| private |
| -	| public |
| -	| immutable |
| -	| stale-while-revalidate |
| stale-if-error |	stale-if-error |

### API Development with ASP.NET

#### What do we mean by scaffolding a Controller?  What files are added to the project?

#### What does ASP stand for and how long has it been around?  What makes it active?

#### How does the structure of an ASP.NET application relate to MVC?

#### What actions happen on startup of an ASP.NET application?

#### What are the responsibilities of a Dependency injection container?

#### What are the 3 classes of Service Lifetimes?  What do they mean?

#### What are the advantages/disadvantages of adding a service to the DI container with Singleton lifetime?

#### What happens in the request pipeline?

#### Name some components of the request pipeline

#### Why is Exception handling normally the outermost layer of the pipeline?

#### Which comes first in the request pipeline - Authorisation or Authentication?



-----------------------------------------------------------------------------------------------------------------------------------------------------------------

### Test Doubles using Fakes and Moq

#### Why should you use an in-memory database for testing?

#### Why should you use the Moq framework for testing?

#### Why did we refactor our WPF-EF system to use a Service class?

#### How does Dependency injection aid unit testing?

#### How can we use a Moq to check if a method is called with the correct parameters?

#### What is the difference between strict and loose mocking behaviour?
