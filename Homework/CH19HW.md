#### Roxanna Barahona
#### Homework: ISTA 421 Ch 19
#### March 22, 2020

1. What is an enumerable collection?
- An enumerable collection is one that implements the systems.collections.IEnumerable interface

2. What properties and methods does the IEnumerable interface contain?
- the IEnumerable interface contains a single method called GetEnumerator
IEnumerator GetEnumerator();

3. What properties and methods does the IEnumerator interface contain?
object Current { get; }
bool MoveNext();
void Reset();

4. What values does the MoveNext() method return? What does it do?
- you call the MoveNext method to move the pointer down to the next (first) item in
the list; the MoveNext method should return true if there actually is another item and false if there isn’t.

5. What values does the Reset() method return? What does it do?
- you use the Reset method to return the pointer back to before the first item in the list.
- it returns void

6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type
safety?
- IEnumerator interface exhibits non–type-safe behavior in that it returns an object rather than a specific type


7. Why don't recursive methods retain state when used with data structures like binary trees?
- Recursive algorithms, such as those used when walking a binary tree, do not lend themselves to maintaining state information between method calls in an easily accessible manner
- you will first preprocess the data in the binary tree into
a more amenable data structure (a queue) and actually enumerate this data structure instead
- when you call a recursive method a recursive method returns one value and thats all it knows is that one value 

8. How do you define an enumerator?
- Through the interface (IEnumerator interface)
- An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numeric type. To define an enumeration type, use the enum keyword and specify the names of enum members: (via Microsoft Docs)
- Definition: An enumerator helps you enumerate (iterate) over a collection of items

9. What is an iterator?
- An iterator is a block of code that yields an ordered sequence of values. An iterator is not actually
a member of an enumerable class; rather, it specifies the sequence that an enumerator should use
for returning its values
- an iterator is just a description of the enumeration sequence that the C# compiler can use for creating its own enumerator.

10. What does yield do?
- . Using yield to define an iterator removes the need for an explicit extra class (the class that holds the state for an enumeration, see IEnumerator<T> for an example) when you implement the IEnumerable and IEnumerator pattern for a custom collection type. (via Microsoft Docs)
- The yield keyword performs custom and stateful iteration and returns each element of a collection one at a time sans the need of creating temporary collections

#### extra notes:
- All MoveNext does is update the internal state in the enumerator (that is,
the value of the currentItem variable is set to the data item extracted from the queue) for use by
the Current property, returning true if there is a next value and false otherwise.

- The Current property examines the enumData variable to ensure that MoveNext has been
called.

- You should have noticed that the statement that defi nes and initializes the currentItem variable
uses the default keyword:
