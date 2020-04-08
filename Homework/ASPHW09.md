#### Roxanna Barahona
#### April 8, 2020
#### Homework: MVC
#### MVC Ch 9


1. In the Configure() method of the Startup.cs file, note the four map routes defined in the book.
(1)What is the difference in the definitions of the four routes defined?
 the system.web.httpModules section,
 the system.web.httpHandlers section,
 the system.webserver.modules section,
 and the system.webserver.handlers section.
(2) How are the routes ordered?  - see above (1)
(3)Why does it matter that the routes are ordered this way?
- without these sections routing will no longer work.

2. When you define tag helpers, you can specify a prefix for the attribute name.
(1) What happens when you define several attributes with the same prefix?
- Example: If a Tag Helper prefix is set to th:, only those elements using the prefix th: support Tag Helpers (Tag Helper-enabled elements have a distinctive font). The <label> and <input> elements have the Tag Helper prefix and are Tag Helper-enabled, while the <span> element doesn't.
(2) What is the benefit of doing this?
- The @tagHelperPrefix directive allows you to specify a tag prefix string to enable Tag Helper support and to make Tag Helper usage explicit
- Tag Helpers enable server-side code to participate in creating and rendering HTML elements in Razor files
-

3. How does using the attribute page-url-category benefit the application? Be specific with your answer
and give an example.
- you can filter products by category and tag


4. What is a view component and what purpose do view components have in building a web application?
- View components are classes that provide action-style logic to support partial views, which means complex content can be embedded in views while allowing the C# code that supports it to be easily maintained and unit tested.
- Without view components, it is hard to create embedded functionality such as shopping baskets or login panels in a way
that is easy to maintain and unit test.

5. The book notes that you can build a list of categories programmatically or use the “more expressive
Razor syntax” to render the HTML. What do you think that this means?
- i think it means that the code is more clean and easier to read.

6. What does @await Component.InvokeAsync("InformationSidebar") do?
- This is a view component which:
- Renders a chunk rather than a whole response.
- Includes the same separation-of-concerns and testability benefits found between a controller and view.
- Can have parameters and business logic.
- Is typically invoked from a layout page.

7. Describe the functionality of the RouteData property of the ViewComponent class, and give a concrete
example of that functionality.
- provides information about how the request URL was handled by the routing system.

8. What is the purpose of session state, and how does the Sports Store application use session state?
- "I am going to store details of a user’s cart using session state, which is data that is stored at the server
and associated with a series of requests made by a user. ASP.NET provides a range of different ways to
store session state, including storing it in memory, which is the approach that I am going to use. This has
the advantage of simplicity, but it means that the session data is lost when the application is stopped or
restarted. Enabling sessions requires adding services and middleware in the Startup class, as shown in
Listing 9-17." pg 263

9. Describe model binding and give a specific example. Explain how model binding relates form elements,
HTTP query requests, variables, and properties.
- Model binding is a mechanism ASP.NET MVC uses to create parameter objects defined in controller action methods.
- The parameters can be of any type, from simple to complex ones.

- Properties: Controllers and Razor pages work with data that comes from HTTP requests. For example, route data may provide a record key, and posted form fields may provide values for the properties of the model. It can update properties and complex types

10. What does the RedirectToAction() method do?
- This method is used to redirect to specified action instead of rendering the HTML. In this case, the browser receives the redirect notification and make a new request for the specified action.
