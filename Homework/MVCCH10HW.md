#### Roxanna Barahona
#### April 8, 2020
#### Homework: MVC
#### MVC Ch 10



1. What are services? What are services commonly used for? Generally, how are services implemented?
You don’t need to go into a lot of detail.

2. What does the AddScoped<T>() method do? Where do you call the method?
- Scoped objects are the same within a request, but different across different requests.Scoped lifetime services are created once per request within the scope in MVC it creates 1 instance per each http request but uses the same instance in the other calls within the same web request.

3. What does the AddSingleton<T>() method do? Where do you call the method?
- Singleton objects are the same for every object and every request (regardless of whether an instance is provided in ConfigureServices)

4. (Not in book) In the cotext of software design patterns, the term singleton has a specific meaning.
What is the singleton pattern used for?

5. Microsoft has removed support for Bower from Visual Studio. How do you install the Font Awesome
package without using Bower?

6. In building a shopping cart summary functionality, the author creates a view component that takes
advantage of a service. Describe how a view component can take advantage of a service.

7. What does the [BindNever] attribute do? Why do we need it?

8. What does the HTML <label> element do? How does the author use it in build the HTML order
checkout form?

9. What do the following two commands do?
dotnet ef database drop --force
dotnet ef database update

10. What do the following two LINQ methods do?
.Include()
.ThenInclude()

11. What is the difference between Http GET and Http POST?

12. What is the difference between server-side validation and client-side validation? Do we need both? If
so, why do we need both?
