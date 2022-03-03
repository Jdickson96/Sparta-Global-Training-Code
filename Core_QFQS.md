## C# Core Quickfire Questions and Answers 

These are the quickfire questions that can be asked any day on the course and learning the answers to each of them would be beneficial for the completion of the course

#### What's compile time and run time?

Compile time is at the point that the compiler puts the code together to form a package whereas runtime is when this package of data itself is used.

#### What is meant by a "Strongly Typed Language"?

#### Why is C# described as memory safe?

#### What is .NET?

#### What is the difference between .NET Framework, NET Core, and .NET5/.NET6?

#### What is a conditional breakpoint?

#### What is the difference between compiling to debug and release formats?

#### What is a git-ignore file and why is it important?

A git ignore file is a file used on the PC uploading to github within the repository to create a blacklist of files to not be uploaded to the git hub site. This is used to prevent sensitive or security data being uploaded onto a public platform causing a security risk.

#### What does the using keyword do?

#### Give an example of a ternary operator

#### What does the modulus operator do?

The modulus operator `%` outputs the remainder of the division between the two numbers in the function. So the number left after as many of the whole integer has been removed as possible.

#### How would you calculate the number of weeks and days represents by 34 days?

This would be done by calculating the number of weeks with a division and the days remaining with the use of a modulo operator.

#### What is the difference between a postfix and a prefix increment operator?

A postfix operator (for example `x++`) occurs at the end of the line, whereas a prefix operator (for example `++x`) occurs at the start.

#### What is the difference between a unary and binary operator?

#### Which types of operator have the lowest priority?

#### What is the difference between an if-else block and a switch-case block?  Give an example of when you would use each.

#### What is the difference between a for- loop and a foreach- loop?  Give an example of when you would use each.

#### What is the difference between a while- loop and a do while- loop?  Give an example of when you would use each.

#### What is an exception?

#### In handling exceptions, when is the finally block run?

#### What happens if you add 3 to the largest int?  To the largest unsigned int?

#### What is the smallest floating point number type?  How many bytes?

#### What data types can int be safely converted to?

#### How would you find out the largest value an Int32 value type can be?

#### What is casting?

#### How can you prevent silent overflow of integers?

#### What is StringBuilder and why is it used?

#### What is the difference between an array and a List?  What are the advantages and disadvantages of each?

#### What is the difference between a multidimensional array and a jagged array?

#### Why is representing Dates and Times complicated?

#### What is string parsing?

#### What is an enum and why would you use it?

#### What makes up a method signature?

#### What is a method body?

#### In a method signature, what does the void keyword mean?

#### What is method overloading?

#### What is an out parameter?

#### What are named parameters and why are they useful?
 
#### What is a tuple, and why is it useful?

A tuple is a grouping of different datatypes in a similar way to an array and can be used as an output from a method if more than a single output is produced.

#### What is a stack, what is a heap?

The stack is organised memory used for smaller primative types (such as `ints`) or pointers to data in the heap. With the heap being the larger memory store used for more complex data types, as well as being managed by the garbage collector.

#### What is the difference between passing method parameters by value and by reference?

Passing a method parameter by value means that the item has been copied with the copy being used and altered by the method. Using data by reference however means that the data is not copied and is instead altered directly by the use of a pointer to its location in memory. 

#### What types are normally passed by value?  By reference?

Smaller primative types (for example `int`) are passed by value as the space required to reference them is similar to the space needed for the data itself. Whereas data is referenced when it is larger and more complicated (for example `strings`) , meaning space can be saved by just referencing it.

#### When does the .NET garbage collector run? What does it do?

A garbage collector runs periodically or when the limit of the heaps memory is being reached. It has 3 main functions:
* Find (find dead data)
* Free (free up this space in memory)
* Combine (move used memory together to reduce gaps and free up space)
