you're#### Programming Notes



*USER* -accesses-> *CONTROLLER* -accesses->
the *MODEL*(C# class: methods, controllers, builds)
the *MODEL* then --changes/runs logic--> and comes back to the *CONTROLLER*
*CONTROLLER* --updates in HTML--> the *VIEW* -takes the output--> returns to *USER*


. = access the properties and methods of an object

3 overloads of 'this': used for instance, value types, extension methods
overloads of '?'': null-coalescing, nullable types,
overloads of 'use' and 'using directive':
overloads of '=>': expression bodied method, lambda function

what is a method: A name block of code
Variable : name location in the memory


March 12, 2020
- interface separates the what from the how
- the purpose of the start up class
- default route is home/index
- name of the file that returns html. index.csh.html


#### Chapter 4
- Recursion
 - Recursion is a general problem solving strategy.
 - what is recursion? its a method that calls itself
  - physically and figuratively it, recursion is a deep topic
  - what is a recursive method? a method that calls itself
  - 2 steps to recursion
  -- 1. find/decide the stopping point
  -- 2. decide what to do if you have
- for loop
- 3 components
#### Chapter 7, Chapter 8
- the new keyword goes to the heap and allocates sufficient amount of memory to hold an object of that type and return a memory address to the stack
- how does 'new' know how much memory to allocate? Because it calls the constructor and its the constructor that tells new how much space is needed and what the properties and methods are.
- what is the difference between class and object. A class is abstract while an instance is a concrete materialization of an object of that type
- syntax for a constructor: a construct's class name must match the class and cannot have a return time.
-- Example: PUBLIC CAR();
{
}
- the constructor actually constructs the object on the heap
- fields and properties are variables. you can think of them both doing something. what is an instance field or method? every object of that type you create has an independent copy of that field or method
what is a class field or method? each instance does not have an independent copy but all instances share that one class or method
example: you have a class MATH t

#### Chapter 8
- Variable : name location in the memory
- there are two ways you can pass methods to an argument:
-- 1. by value : a copy is made
-- 2. or by parameter
-- a static method is a class method and you can access(call it) it by calling the name of the class dot name of the method
-- how do you call an instance method? you have to instantiate an instance first then you call it instance dot method name

####SQL CH 7
- a set operator manipulates sets
- grouping sets: are the sets of expressions that you group the data by
- using an OVER clause with empty parentheses exposes a window of all rows from the underlying
query’s result set to the function

1 riddle
and one coding problem

#### More notes for C
-- This is the type of code you would write to connect to a server name
//pseudo code
conn = connect(servername, username, password);
query = makeQuery(...);
runQuery(Query);
result[] = getResult();
// Process the result set
---------------------------------------------------------------------------
 -'N is a unicode
- an interface is an abstraction
- class tells you what something does and how it does it

#### March 30 2020 : chapter 20 delegates and events
- a delegate is a reference type of variable
- references store a memory address/block of memory on the heap
- points to another function which means you can create a variable that does not contain data but rather a function/method
- why do we call a variable a variable - because it varies
- how do we create types in c# - we create a new class
- a delegate is a class -> we can create objects from them
- if a delegate is a type what do you think you do with delegate types ? --> you can create instances or instantiate an object
-- ex: if I have a dog class, I can instantiate breeds or names
- if need a bunch of hammers I would make a hammer factory?
- delegates and events
- this is an expression bodied method: public void PrintFirstName(President p) => Console.WriteLine(p.FirstName); // in other words
you can change it to look like
public void PrintFirstName(President p)
{
  console.WriteLine(p.FirstName);
}

- return type: void
- parenthesis () is a method
- no parenthesis is a property
- value is you can change the function and change where it points , delegating it to a different area in the memory address
- a method with a delegate doesn't have parenthesis because you're not executing it, youre just assigning it.
- what is THIS? it's an instance

- public delegate void CheckoutDelegate(Order order); --> *** creates the delegate type***
--- return type is void, it takes one parameter which is an order and its type is order, and name is CheckoutDelegate,  
---- this line of code creates a delegate type
1. create delegate type
2. instantiate delegate object
3. assign a method to the delegate
### C design patterns
- a design pattern is a blueprint for a solution
- PROS: helps produce high-level solutions, maintainability
- the gange of 4
creational patterns
structure   
behavioral  

<> brackets means its generic
property can havea getter but no setter

- what does an action method look for in a controller? it looks for a view file with the same name / cshtml extension

- ORM: object relational mapper - can map classes to tables and objects to rows in tables in the database

- setting a number to a variable is called a symbolic constant
- optional parameters
-- LIST(2) - set page to 2

#### April 6, 2020

- LINQ:

- If the data structures change, you might need to make a signifi cant number of changes to the code that handles the data. The designers of the Microsoft .NET Framework thought long and hard about these issues and decided to make the life of an application developer easier by providing features that abstract the mechanism that an application uses to query data from application code itself. These features are called Language-Integrated Query, or LINQ.
- what is an extension method: Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. Extension methods are static methods, but they're called as if they were instance methods on the extended type.
- we use extension methods because linq is a layer that sits on top so you can extend the classe


### April 8, 2020

- What is a variable? - a name location in memory that contains a value 
