


## Refactoring and Code Smells

**Refactoring means improving the structure of existing code (not fixing bugs or changing or extending functionality).**

If code is not refactored then it can lead to code rot where the code loses functionality and clarity.

### Before Refactoring

1) Cover your code with unit tests
2) Make sure they all pass
3) Commit your code (ad a label or new branch)
4) Now you can cofidently change code with a previous version as a safety net

#### When to refactor

**Rule of 3 (Don Roberts)**
* The first time you do something, just do it
* Second time you do something similar, you wince at the duplication, but do the seperate thing anyway.
* The third time you do something similar, you refactor

Some reasons to refactor are:
* When a program is hard to read
* When duplication exists
* Before adding new functionality - refactor the existing code first
* When adding new behaviour is not possible without making major changes to the existing code
* On code reviews
* When your code smells

#### When not to refactor

* Close to deadline (unfinished refactoring can be an issue)
* Need a complete rewrite (code should work before refactoring, and sometimes its better to throw the code out and restart)

### Code Smells

This refers to recognisable code issues.

#### Innapropriate Names

* Method names should say what the method does
* field, property, paramater and variable names should be meaningful as well as class names
* your code will be easier to understand and require less commenting
* comments need to be maintained along with code otherwise they are useless and missleading

#### Dead Code

This is code that cannot be reached or is unused in the current version of the solution. Removing this increases the clarity of the overall method.

#### Duplicate Code

**This is the most important code smell to attend to**

This is the same code in multiple places and these should be unified. If you have the same code in multiple places, can you extract a superclass? Duplicate code on the whole is easy to write but hard to maintain.

#### Long Methods

* Favour shorter methods (4 lines, not 40) and split up methods that perform multiple tasks.
* Use meaningful method names
* Less need for comments if method-names are self explanatory

#### Data Clumps

* When the same group of methods keep appearing together
* Make a class to encapsulate them
* For example: `_houseno`, `_street`, `_town` in `Person`
* Make an Address Class

## Using GitHub Collaberatively

The Git strategy for Sparta Group work is:
* Have a Dev branch from the main branch
* Both the Dev and Main Branch are protected
* With all work done being in braches off of the Dev branch
* Once features that have been worked on are completed,they are merged with the dev branch
* Other features being worked on then pull the latest dev branch

## Design Patterns

These are based on architecture patterns, and are solutions to commonly encountered problems.

### Singleton

Ensures a class only has one instance while providing global access to that instance.

Problem:
* Application needs to have **Only one instance** of a particular class
* But **Many** classes need to be able to access it
* Potential for a lot of coupling
  * lots of objects referencing the same object

An example would be a logging system

### Factory Pattern

### MVC

### Strategy

### Decorator

## Big-O Notation (Algorithmic Complexity)



## Recursion


## XML and JSON

Json is Java Script Object Notation and XML is the precursor for HTML. Both XML and JSON are used for storing and transfering data. They are both human readable, easily parsed and hierarchal.

### XML

XML means Extensible Markup Language.
* **Extensible** - can add or remove data
* **Markup** - provides definition to text and symbols
* **Language** - present info based on certain rules

It is important in every web application as it has Schema definitions, config files and document mapping

### JSON



## SQL

SQL Stands for **S**tructured **Q**uery **L**anguage. The majority of SQL engines are case insensitive but common practice is that SQL Keywords (like `SELECT` and `FROM` are typed in upper case while names of things are typed in lower case. SQL also does not care about whitespace, but common practice is to have a new line for each clause. Statements should also be finished with a semicolon to aid visability.

### SELECT Statements

These are used to query the database and return any data that matches our specified criteria. For example:

```sql
SELECT column
FROM table;
```
This asks for a single column in a single table in the database, with `column` and `table` replaced with actual names in practice.

Select Statements contain two clauses: `SELECT` and `FROM`

The `AS` keyword assigns column aliases:

```sql
SELECT firstname AS "First Name", lastname AS "Last Name", birth_date AS "Date of Birth"
FROM customer
```

If you want to return all the columns in a table without typing out every column name you can use an astrerisk

```sql
SELECT *
FROM customer
```


#### SELECT Statement sequences

When an SQL query is written the various clauses ust be written in a set order. This is know as the **Logical Sequence** or **Syntax Sequence**

* SELECT
* DISTINCT
* FROM
* WHERE
* GROUP BY
* HAVING
* ORDER BY

The sequence above is not the order in which the clauses are processed by SQL however. This is known as the **Processing Sequence** and is shown below:

* FROM
* WHERE
* GROUP BY
* HAVING
* SELECT
* DISTINCT
* ORDER BY

This has important implications for how we write our SQL queries

### WHERE Statement

This is used to only retrieve specific rows from our tables. The code below will only return products where the name is exactly equal to 'Chromecast'. For this to work you need to use single quotes. 

```sql
SELECT *
FROM product
WHERE name = 'Chromecast'
```

#### WHERE Comparison operators

The WHERE clause can also use other operators than =. These are:
* < Less than
* > More than
* <= Less than or equal to
* >= More than or equal to
* != Not equal to

WHERE clauses can also use AND and OR statements to chain clauses.

```sql
SELECT name, price, available_stock
FROM product
WHERE price < 10 OR available_stock >= 3000
```

#### BETWEEN Operator

Instead of using a
```sql
WHERE price >= 50 AND price <= 100;
```

We can use:

```sql
WHERE price BETWEEN 50 and 100;
```

This increases the clarity of the code. It can also make multiple variable checks easier, for example:

```sql
SELECT name, description, price, available_stock
FROM product
WHERE available_stock BETWEEN 10 and 20 AND price > 100;
```

#### IN Operator

```sql
WHERE firstName = 'James' OR firstName = 'Roger' OR firstName = 'Jean-Claude';
```
This can be simplified by using the IN operator:
```sql
WHERE firstName IN('James','Roger','Jean-Claude');
```

#### NULL Operator

Some of the data in the database shows up as NULL, this is SQL's way of showing there is no data. This can be checked for using the code below:

```sql
SELECT *
FROM customer
WHERE birth_date IS NULL; -- IS NOT NULL can also be used
```

#### WHERE Wildcards

These are used when you are not looking for an exact match but you want to find an item that contains something desired. These use the LIKE keyword, and can be combined.

**_**

This substitutes a single character, for example:

```sql
SELECT *
FROM customer
WHERE firstname LIKE 'Li_a'
```

**%**

This substitutes for zero or more characters, so a single percentage character can be used to search for a string that begins or ends with an entered string. The code below will return all items that begin with J.

```sql
SELECT *
FROM customer
WHERE firstname LIKE 'J%'
```

**[ABC]**

This is used to specify multiple possible characters to match. For example the code below would return the 'Kindle Fire 5','Kindle Fire 6' and 'Kindle Fire 7' if these exist in the database being searched.

```sql
SELECT *
FROM customer
WHERE firstname LIKE 'Kindle Fire [567]'
```

**[^ABC]**

This works similarly to the case above however the ^ works as a NOT Logic operator, and as such the system will return any kindles not including the chars in the square brackets.

```sql
SELECT *
FROM customer
WHERE firstname LIKE 'Kindle Fire [^567]'
```

### TOP

This grabs the top few rows of a table rather than checking the entire table as this can take up time and resources.

```sql
SELECT TOP 5 *
FROM customer;
```

### ORDER BY

This orders the rows of a table by the columns specified as well as either ordering in ascending (ASC) or descending (DESC) order:

```sql
SELECT *
FROM customer
ORDER BY lastname ASC, firstname ASC;
```

### DISTINCT

This keyword works to remove any duplicate rows within a table

```sql
SELECT DISTINCT city
FROM customer;
```

## SQL Data Manipulation

### CONCATENATION

This is combining data in multiple columns to form a single combined column of data

```sql
SELECT firstname + ' ' + lastname AS 'Full Name'
FROM customer;
```

For codingame use:

```sql
SELECT address || ', ' || city AS "Full Address"
FROM customer;
```

## SQL String Functions

**UPPER**(text) returns the content of that text in  UPPERCASE

```sql
SELECT UPPER(firstname)
FROM customer;
```

**LOWER**(text) returns the content of that text in  lowercase

```sql
SELECT LOWER(firstname)
FROM customer;
```

**TRIM**(text) returns the content of that text with whitespace characters at the start and end removed

```sql
SELECT TRIM(firstname)
FROM customer;
```

**LTRIM**(text) returns the content of that text with whitespace characters at the start removed

```sql
SELECT LTRIM(firstname)
FROM customer;
```

**RTRIM**(text) returns the content of that text with whitespace characters at the end removed

```sql
SELECT RTRIM(firstname)
FROM customer;
```

**LENGTH**(text) returns the length of the string

```sql
SELECT LENGTH(firstname)
FROM customer;
```

**LEFT**(text,N) returns the leftmost content of that text up to the Nth char 

```sql
SELECT LEFT(firstname,6)
FROM customer;
```

**RIGHT**(text,N) returns the rightmost content of that text up to the Nth char 

```sql
SELECT RIGHT(firstname,6)
FROM customer;
```

**SUBSTRING**(text,start_index,length) returns a section of the content equal to the length stating at the start_index 

```sql
SELECT SUBSTRING(firstname,6,4)
FROM customer;
```

**POSITION**(substring IN text) returns the position of a substring within the content 

```sql
SELECT POSITION('G' IN firstname)
FROM customer;
```

**The string functions above can also be combined to make more complex operations**

```sql
SELECT LEFT(firstname,1) || '. ' || UPPER(LEFT(lastname,1)) || LOWER(RIGHT(lastname, LENGTH(lastname) - 1)) AS "Name"
FROM customer;

SELECT SUBSTRING(name, 1 , POSITION(':' IN name) - 1) AS "Name", price AS "Price"
FROM product
WHERE name LIKE '%:%';
```

## SQL Arithmetic Operators

The data in the tables can be changed using +, -, *, /, % operators.

```sql
SELECT name AS "Name", price AS "Price", available_stock AS "Available Stock", price * available_stock AS "Total Value"
FROM product;
```

## SQL Date Functions

**GETDATE()** Returns the current date

**DATEADD(unit, N, date)** Adds on to the date provided to a number (N) of the unit specified (DAY, MONTH, YEAR)

```sql
DATEADD(DAY, 5, '1970-01-01')
```

**DATEDIFF(unit, date1, date2)** Returns the difference between two dates

```sql
DATEADD(MONTH, '1970-01-01', '1970-01-01')
```

**YEAR(date)** Extracts the year as an integer from the date

```sql
YEAR('1952-03-11') -- returns: 1952
```

**MONTH(date)** Extracts the month as an integer from the date

```sql
MONTH('1952-03-11') -- returns: 03
```

**DAY(date)** Extracts the day as an integer from the date

```sql
DAY('1952-03-11') -- returns: 11
```

**Code using these date functions can be seen here**

```sql
SELECT UPPER(firstname) AS "First Name", UPPER(lastname) AS "Last Name",DATEADD(MONTH,165,birth_date) AS "Date"
FROM customer
WHERE birth_date IS NOT NULL;
```

## SQL CASE

This is like a case statement in C# it works as below:

```sql
SELECT name, price,
     CASE
         WHEN price < 50 THEN 'Cheap'
         WHEN price > 100 THEN 'Moderately Priced'
         ELSE 'EXPENSIVE'
     END AS 'Price Category'
FROM product;
```

## SQL Aggregation

This is bringing things together into groups such as getting the sum value of a column, this can use any of the operators below:

```sql
SELECT SUM(available_stock) AS "Total Stock",
       AVG(available_stock) AS "Average Stock",
       MIN(available_stock) AS "Minimum Stock",
       MAX(available_stock) AS "Maximum Stock",
       COUNT(available_stock) AS "Number of Products with non null stock",
FROM product;
```
