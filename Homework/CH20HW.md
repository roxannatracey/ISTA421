#### Roxanna Barahona
#### Homework: ISTA 421 ch 20
#### March 23, 2020


1. What is a delegate? Explain delegates in terms of pointers and reference types.
-  A delegate is a reference to a method. A delegate is a reference to a method. A delegate is an object that refers to  method

2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
- the statement that assigns the method reference to the delegate does not run the method at that point; there are no parentheses after the method name, and you do not specify any parameters (if the method takes them). This is just an assignment statement.
- TYPES/return values/names/parameters:
- The parameter taken by the Average, Max, Count, and other methods of the List<T> class is actually a generic Func<T, TResult> delegate; the type parameters refer to the type of the parameter passed to the delegate and the type of the return value. For the Average, Max, and
Count methods of the List<Person> class shown in the text, the fi rst type parameter T is the type of data in the list (the Person struct), whereas the TResult type parameter is determined by the context in which the delegate is used. In the following example, the type of TResult is int because the value returned by the Count method should be an integer:

3. How do you create instances of delegates and assign values to the instance? What are the values?
- void methodName();
- delegate void stopMachineryDelegate();

4. How do you invoke a method that has been added to a delegate?
- You use the delegate keyword.
- You specify the return type (void in this example), a name for the delegate
(stopMachineryDelegate), and any parameters (there are none in this case).
- After you have declared the delegate, you can create an instance and make it refer to a matching method by using the += compound assignment operator. You can do this in the constructor of the controller class like this:
- You use the same syntax to invoke a delegate as you use to call a method
- You can call the method by invoking the delegate, like this:
public void ShutDown()
{
this.stopMachinery();
...
}
- You can remove a method from a delegate by using the –= compound assignment operator,

5. What is an event? Why do we have events?
- events, can be used to define and trap significant actions and arrange for a delegate to be called to handle the situation

6. How do you declare events?
- You declare an event in a class intended to act as an event source. An event source is usually a class that
monitors its environment and raises an event when something significant happens.
- You declare an event similarly to how you declare a field. you must prefix the declaration with the event keyword. Use the following syntax to declare an event: event delegateTypeName eventName

7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
- You subscribe to an event by using this += operator.
- You subscribe to an event by using this += operator.

8. How do you raise an event? How do you declare code that raises an event?
- You can raise an event by calling it like a method. When you raise an event, all the attached delegates
are called in sequence.

9. Explain with specificity what happens when an event fires and that event has been attached to a
delegate.
-
