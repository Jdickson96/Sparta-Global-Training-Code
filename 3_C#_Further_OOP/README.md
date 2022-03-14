


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
