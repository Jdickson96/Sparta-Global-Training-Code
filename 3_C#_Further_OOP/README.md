


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

#### WHERE Wildcards

**_**



**%**



**[ABC]**


