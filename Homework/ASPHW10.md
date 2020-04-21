#### Roxanna Barahona
#### April 15, 2020
#### Homework: MVC
#### MVC Ch 10


1. What are services? What are services commonly used for? Generally, how are services implemented?
You don’t need to go into a lot of detail.
- Services are most commonly used to hide details of how interfaces are implemented from the components that depend on them.

2. What does the AddScoped<T>() method do? Where do you call the method?
- Scoped objects are the same within a request, but different across different requests. Scoped lifetime services are created once per request within the scope in MVC it creates 1 instance per each http request but uses the same instance in the other calls within the same web request.
- The AddScoped method specifies that the same object should be used to satisfy related requests for Cart instances.

3. What does the AddSingleton<T>() method do? Where do you call the method?
- Singleton objects are the same for every object and every request (regardless of whether an instance is provided in ConfigureServices) / specifies that the same object should always be used.

4. (Not in book) In the cotext of software design patterns, the term singleton has a specific meaning.
What is the singleton pattern used for?
- Singleton pattern is using when you need a class that has only one instance, and you need to provide a global point of access to the instance.

5. Microsoft has removed support for Bower from Visual Studio. How do you install the Font Awesome
package without using Bower?
- you go to the solution explorer, right click on the project name, click add client side libraries and search for the package you want to install

6. In building a shopping cart summary functionality, the author creates a view component that takes
advantage of a service. Describe how a view component can take advantage of a service.
- The result is a simple view component class that passes on the Cart object to the View method in order to generate the fragment of HTML that will be included in the layout.

7. What does the [BindNever] attribute do? Why do we need it?
- The BindNever attribute prevents the user from supplying values for these properties in an HTTP request. This is a feature of the model binding system, which I describe in Chapter 26; it stops MVC using values from the HTTP request to populate sensitive or important model properties.

8. What does the HTML <label> element do? How does the author use it in build the HTML order
checkout form?
- create a label element and an input element to capture the user input, formatted with Bootstrap. The asp-for attribute on the input elements is handled by a built-in tag helper that generates the type, id, name, and value attributes based on the specified model property.

9. What do the following two commands do?
a. dotnet ef database drop --force
b. dotnet ef database update

- delete the database/reset the database so that it accurately reflects your model and allow you to return to developing your application.

10. What do the following two LINQ methods do?
.Include()
.ThenInclude()
- these methods specify that when an Order object is read from the database, the collection associated with the Lines property should also be loaded along with each Product object associated with each collection object.

11. What is the difference between Http GET and Http POST?
- GET method sends the information by appending them to the page request while POST method sends information via HTTP header.

12. What is the difference between server-side validation and client-side validation? Do we need both? If
so, why do we need both?
- The data submitted by the user is sent to the server before it is validated, which is known as server-side validation, client-side validation, where JavaScript is used to check the values that the user has entered before the form data is sent to the server.
