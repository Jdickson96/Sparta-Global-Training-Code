## Week 5/6 Data & APIs

### Serialisation

#### What is serialisation?

Serialization is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database, or a file. Its main purpose is to save the state of an object in order to be able to recreate it when needed.

#### What are the advantages and disadvantages of using binary object serialisation? JSON Serialisation? / XML Serialisation?



### LINQ and Lambda

#### LINQ uses two syntaxes - Name and describe them

#### When is a LINQ query executed?

#### What is a Lambda expression?  Why is it used in LINQ queries?

#### What does x => x * x mean?

#### What is an anonymous method?

#### What is Expression body syntax?

### Entity Framework

#### NorthwindContext had DbSet (of Customer objects) - what did it do?

#### What is LINQ?

#### What are the advantages of using EF over raw SQL?

#### What is a connection string used for – what information does it contain?

#### In the context of Entity Framework, what does scaffolding mean?

#### When a class is generated from a database, what does it contain?

#### What does the DbContext class contain?

#### How are 1 to many relationships represented in the code model?

#### What is the using keyword used for?

#### What is meant by a partial class and why is it useful?

#### What do we mean by the term model first approach to EF?

#### What are EF Migrations?

#### Using EF, how do you update an object’s data in the database?

#### When loading an object from the database, why aren’t all its associated objects loaded by default?

#### What is the difference between the OO and Relational Approach?

#### How do you load associated objects in a query?

#### Why isn’t eager loading enabled by default?

### Asynchronous Programming

#### Why do we need to use asynchronous methods?

#### What keywords should an asynchronous method use (and where?)

#### What return types are allowed for asynchronous methods?

#### What effect does the await keyword have?

#### What is the naming convention for asynchronous methods?

### APIs

#### What does API stand for?

#### What are the HTTP verbs and what are their CRUD equivalents?

#### What is the structure of an HTTP request?  An HTTP response?

#### What are the categories of HTTP response status code?

#### What does REST stand for in the context of RESTful APIs?

#### What are the characteristics of a REST API?

#### For the endpoint myapi.com/api/customers what would you expect a GET request to do?  A POST request?  PUT? DELETE?

#### What does REST stand for?

#### What do we mean by caching?

#### What is the structure of an HTTP Request?

#### What is the structure of an HTTP Response?

#### What should the RESTful endpoint myresource.io/Employees/6/Order/2 GET?

#### Give some examples of header elements that can be used to control caching?

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

### Test Doubles using Fakes and Moq

#### Why should you use an in-memory database for testing?

#### Why should you use the Moq framework for testing?

#### Why did we refactor our WPF-EF system to use a Service class?

#### How does Dependency injection aid unit testing?

#### How can we use a Moq to check if a method is called with the correct parameters?

#### What is the difference between strict and loose mocking behaviour?
