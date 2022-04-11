## Web development - HTML and CSS

### What are the new features of HTML5?

* New video and audio tags to embed these into pages
* Nav element used for the part of an internet site that links to different pages at the website
* Header element can be used to institution collectively introductory factors on a website
* Canvas is a tag of HTML used to draw the images on the fly
* Footer is a tag used to define the footer of a document or section
* New types for input tags
  * ContentEditable: An attributee used to permit the user to edit the content
  * Progress: Used to check the progress of a task
  * Section: Used to divide a document or in parts or sections
  * Main: a tag used to contain the main content of the page
* Figure and Figcaption: This allows you to insert an image in a page with its caption
* Placeholders: This gives a hint to what is to be iinserted in a particular field of the form
* Required Attribute: Used for mandatory info in a form
* Preload Videos: This is good for uploading videos
* Display Control: Helps in specifying ther behaviour of the elements
* Regular Expressions: Can add a particular pattern as an input 
* Accessability: Adds features for disabled users
* Inline Elements
* Dynamic Page Support
* Email Attribute
* Cryptographic Nonces
* Reverse Links
* Zero Width Images 

### What is the difference between the '<head>' and '<header>' tags?
  
The head tag is used for holding Meta information, title, links, etc. and is not displayed on the page. The header tag is used within the body of the website and can be used multiple times if required, e.g. to determine the top of an article.

### What is a '<nav>' element?
  
The '<nav>' tag defines a set of navigation links.
  
### What does CSS stand for?
  
Cascading Style Sheets 
  
### What does Cascading mean in this context?

"Cascading" means that styles can fall (or cascade) from one style sheet to another, enabling multiple style sheets to be used on one HTML document.
Even the simplest HTML document may have three or more style sheets associated with it including:
* The browser's style sheet
* The user's style sheet
* The author's style sheet
  
### Give some examples of CSS selectors

|Selector |	Example |	Example description|
|-----------------|------------|------------- | 
|`.class`            |	  `.intro`                |	Selects all elements with class="intro"|
|`.class1.class2`    |	  `.name1.name2`          |	Selects all elements with both name1 and name2 set within its class attribute|
|`.class1 .class2`   |	  `.name1 .name2`         |	Selects all elements with name2 that is a descendant of an element with name1|
|`#id`	              |   `#firstname`            |	Selects the element with id="firstname"|
|`*`                 |	  `*`	                    | Selects all elements|
|`element`           |	  `p`                     | Selects all `<p>` elements|
|`element.class`     |	  `p.intro`               |	Selects all `<p>` elements with class="intro"|
|`element,element`	  |   `div, p`                |	Selects all `<div>` elements and all `<p>` elements|
|`element element`	  |   `div p`	                | Selects all `<p>` elements inside `<div>` elements|
|`element>element`	  |   `div > p`               |	Selects all `<p>` elements where the parent is a `<div>` element|
|`element+element`	  |   `div + p`               |	Selects the first `<p>` element that is placed immediately after `<div>` elements|
|`element1~element2`	|   `p ~ ul`                |	Selects every `<ul>` element that is preceded by a `<p>` element|
|`[attribute]`	      |   `[target]`              |	Selects all elements with a target attribute|
|`[attribute=value]`	|   `[target=_blank]`       | Selects all elements with target="_blank"|
|`[attribute~=value]`|	  `[title~=flower]`       |	Selects all elements with a title attribute containing the word "flower"|
|`[attribute/=value]`|	  `[lang/=en]`            |	Selects all elements with a lang attribute value equal to "en" or starting with "en-"|
|`[attribute^=value]`|	  `a[href^="https"]`      |	Selects every `<a>` element whose href attribute value begins with "https"|
|`[attribute$=value]`|	  `a[href$=".pdf"]`       |	Selects every `<a>` element whose href attribute value ends with ".pdf"|
|`[attribute*=value]`|	  `a[href*="w3schools"]`  |	Selects every `<a>` element whose href attribute value contains the substring "w3schools"|
|`:active`           | 	 `a:active`              |	Selects the active link|
|`::after`           |	  `p::after`              | Insert something after the content of each `<p>` element|
|`::before`          |	  `p::before`	            | Insert something before the content of each `<p>` element|
|`:checked`          |	  `input:checked`         |	Selects every checked `<input>` element|
|`:default`          |	  `input:default`         |	Selects the default `<input>` element|
|`:disabled`         |	  `input:disabled`        |	Selects every disabled `<input>` element|
|`:empty`            |	  `p:empty`               |	Selects every `<p>` element that has no children (including text nodes)|
|`:enabled`          |	  `input:enabled`         |	Selects every enabled `<input>` element|
|`:first-child`      |	  `p:first-child`         |	Selects every `<p>` element that is the first child of its parent|
|`::first-letter`    |  	`p::first-letter`       |	Selects the first letter of every `<p>` element|
|`::first-line`	    |   `p::first-line`	        | Selects the first line of every `<p>` element|
|`:first-of-type`	  |   `p:first-of-type`       |	Selects every `<p>` element that is the first `<p>` element of its parent|
|`:focus`	          |   `input:focus`	          | Selects the input element which has focus|
|`:fullscreen`	      |   `:fullscreen`           |	Selects the element that is in full-screen mode|
|`:hover`            |	  `a:hover`               |	Selects links on mouse over|
|`:in-range`         |	  `input:in-range`        |	Selects input elements with a value within a specified range|
|`:indeterminate`    |	  `input:indeterminate`   |	Selects input elements that are in an indeterminate state|
|`:invalid`	        |   `input:invalid`         |	Selects all input elements with an invalid value|
|`:lang(language)`	  |   `p:lang(it)`            |	Selects every `<p>` element with a lang attribute equal to "it" (Italian)|
|`:last-child`	      |   `p:last-child`          |	Selects every `<p>` element that is the last child of its parent|
|`:last-of-type`	    |   `p:last-of-type`        |	Selects every `<p>` element that is the last `<p>` element of its parent|
|`:link`	            |   `a:link`                |	Selects all unvisited links|
|'::marker`	        |   `::marker`              |	Selects the markers of list items|
|`:not(selector)`	  |   `:not(p)`               | Selects every element that is not a `<p>` element|
|`:nth-child(n)`     |   `p:nth-child(2)`        |	Selects every `<p>` element that is the second child of its parent|
|`:nth-last-child(n)`|	  `p:nth-last-child(2)`   |	Selects every `<p>` element that is the second child of its parent, counting from the last child|
|`:nth-last-of-type(n)`|	`p:nth-last-of-type(2)` |	Selects every `<p>` element that is the second `<p>` element of its parent, counting from the last child|
|`:nth-of-type(n)`	  |   `p:nth-of-type(2)`      |	Selects every `<p>` element that is the second `<p>` element of its parent|
|`:only-of-type`	    |   `p:only-of-type`        |	Selects every `<p>` element that is the only `<p>` element of its parent|
|`:only-child`	      |   `p:only-child`          |	Selects every `<p>` element that is the only child of its parent|
|`:optional`	        |   `input:optional`        |	Selects input elements with no "required" attribute|
|`:out-of-range`	    |   `input:out-of-range`    |	Selects input elements with a value outside a specified range|
|`::placeholder` |	`input::placeholder`          |	Selects input elements with the "placeholder" attribute specified|
|`:read-only`    |	`input:read-only`             |	Selects input elements with the "readonly" attribute specified|
|`:read-write`   |	`input:read-write`            |	Selects input elements with the "readonly" attribute NOT specified|
|`:required`	    |`input:required`               |	Selects input elements with the "required" attribute specified|
|`:root`	        |`:root`                        |	Selects the document's root element|
|`::selection`   |	`::selection`	                | Selects the portion of an element that is selected by a user|
|`:target`       |	`#news:target`                |	Selects the current active #news element (clicked on a URL containing that anchor name)|
|`:valid`        |	`input:valid`	                | Selects all input elements with a valid value|
|`:visited`      |	`a:visited`                   |	Selects all visited links|
  
### What is the difference between an id and a class?

The difference between an ID and a class is that an ID is only used to identify one single element in our HTML. IDs are only used when one element on the page should have a particular style applied to it. However, a class can be used to identify more than one HTML element.
 
### What is the prefix for an id?  

They have a pound sign before them 
 
### A Class?

They have a period before them
 
### What is the CSS box model?

The CSS box model is essentially a box that wraps around every HTML element. It consists of: margins, borders, padding, and the actual content. The image below illustrates the box model:
 
### Why are inline styles not a good idea?

 Inline styles, while they have a purpose, generally are not the best way to maintain your website. They go against every one of the best practices:

* Inline styles don't separate content from design: Inline styles are exactly the same as embedded font and other clunky design tags that modern developers rail against. The styles affect only the particular, individual elements to which they're applied; while that approach might give you more granular control, it also makes other aspects of design and development—such as consistency—more difficult.

* Inline styles cause maintenance headaches: When you're working with stylesheets, figuring out where a style is being set can be difficult. When you're dealing with a mixture of inline, embedded and external styles, you have many locations to check. If you work on a web design team or have to redesign or maintain a site built by someone else, then you're going to have even more trouble. Once you find the style and change it, you'll have to do so on every element on every page where it's been placed. That increases time and work budgets astronomically.

* Inline styles are not as accessible: While a modern screen reader or another assistive device may be able to handle inline attributes and tags effectively, some older devices can't, which can result in some strangely displayed web pages. Extra characters and text can affect how your page is viewed by a search engine robot, too, so your page doesn't do as well in terms of search engine optimization.

* Inline styles make your pages bigger: If you'd like every paragraph on your site to appear a certain way, you can do it once with six lines or so of code in an external stylesheet. If you do it with inline styles, however, you have to add those styles to every paragraph of your site. If you have five lines of CSS, that's five lines multiplied by every paragraph on your site. That bandwidth and load time can add up in a hurry.
 
## Javascript

### Is Javascript statically or dynamically typed?  What does that mean?

Javascript is dynamically typed, so the interpreter assigns variables a type at runtime based on the variable's value at the time.
 
### How do you tell if you have made a javascript error?

Open up the browsers console and check in there
 
### What are some examples of events that javascript can respond to?


| Event|	Description|
 |-------------|-------------|
|onchange	|An HTML element has been changed|
|onclick	|The user clicks an HTML element|
|onmouseover|	The user moves the mouse over an HTML element|
|onmouseout	|The user moves the mouse away from an HTML element|
|onkeydown	|The user pushes a keyboard key|
|onload	|The browser has finished loading the page|
 
### Where is the best place to put your javascript and why?

In HTML, JavaScript code is inserted between <script> and </script> tags.
 
### What is the difference between a javascript and a c# class declaration?
 
Javascript functions are declared with the keyword function before the function name. C# Method declarations just use the return type, and the method name. The return type is often "void" for common Unity events. Javascript functions are public by default, and you can specify them as private if required.

### What is the DOM?

 When a web page is loaded, the browser creates a Document Object Model of the page. The HTML DOM model is constructed as a tree of Objects:
 
### What is Bootstrap?

Bootstrap is the most popular HTML, CSS, and JavaScript framework for developing responsive, mobile-first websites.
 
### What is JQuery?

jQuery is a fast, small, and feature-rich JavaScript library.
 
### How can DOM elements be accessed?

The easiest way to find an HTML element in the DOM, is by using the element id. 
> This example finds the element with id="intro":
> Example
> const element = document.getElementById("intro");
 
## ASP.NET Razor Pages

### What do ASP.NET API and ASP.NET Razor pages apps have in common?  What are the differences?

ASP.NET Web API is a framework for building HTTP services that can be accessed from any client including browsers and mobile devices. 
 
Razor Pages is a newer, simplified web application programming model. It removes much of the ceremony of ASP.NET MVC by adopting a file-based routing approach. Each Razor Pages file found under the Pages directory equates to an endpoint. Razor Pages have an associated C# objected called the page model, which holds each page's behavior. Additionally, each page works on the limited semantics of HTML, only supporting GET and POST methods.
 
### Where does dependency injection take place in a Razor Pages application?  Where is the database context registered with the Dependency Injection container?

You can do constructor injection in your page model class. Dependency injection is also possible in the pages by using the `inject` directive. The database context is registered with the Dependency Injection container in Program.cs. It uses the Builder.Services
 
 ```csharp
 builder.Services.AddDbContext<RazorPagesMovieContext>(options => 
       options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesMovieContext")));
 ```
 
### What are the advantages/disadvantages of adding a service to the DI container with Singleton lifetime?

Singletons are created only once and not destroyed until the end of the Application. Any memory leaks in these services will build up over time. Hence watch out for the memory leaks. Singletons are also memory efficient as they are created once reused everywhere.

Use Singletons where you need to maintain application wide state. Application configuration or parameters, Logging Service, caching of data is some of the examples where you can use singletons.
 
### What other lifetimes are available?  What is the default lifetime for a database context class?

Transient, Scoped and Singleton. With the default life time for DbContext is scoped.
 
### What is in the Web folder of an ASP.NET application?

As the name suggests, the App_WebReference folder contain references to any web services. If we added any web services with our web application, they go automatically into the App_WebReference folder, in the same way as in windows applications, if we added any DLLs, they would go under the Reference folder.
 
### What actions happen on startup of an ASP.NET application?

The Startup class is the entry point to the application, setting up configuration and wiring up services the application will use. Developers configure a request pipeline in the Startup class that is used to handle all requests made to the application.
 
### Where does data validation take place in Web application?
 
 Data validation is the process of ensuring your web application operates on clean, correct and useful data. The more data you can validate in the browser as the site visitor enters it, the better the chance you have of receiving valid data in the first place.

### What happens to data validation if javascript is disabled on the client browser?

The Server side should still validate the data. 
 
### How are the default web pages structured?

They are named _index
 
### How are requests routed to the correct page and method?

Routing is the system that matches URLs to Razor pages. Like most page-centric frameworks, the primary routing system in ASP.NET Razor Pages is based on matching URLs to file paths, starting from the root Razor Pages folder, which is named Pages by default.
 
### How and why do the PageModel classes use asychronous methods?

If you’re building web applications with ASP.NET Core you’re likely to be looking for ways to make them performant as they scale. Using the asynchronous features of C#, ASP.NET Core, and Entity Framework Core is a good way to do this. Making hot code paths asynchronous is one of Microsoft’s ASP.NET Core Performance Best Practices. A hot code path is one that is “...frequently called and where much of the execution time occurs.”
 
1) Razor Pages controller actions – the entire call stack is asynchronous, so you can benefit from that by making your controller actions asynchronous.
2) Data access actions – Entity Framework Core includes asynchronous features to improve the performance of code that relies on calls to a persistent data store.
 
### Why would we want to seed the database?

Database seeding is a simple way to add data into your database. It is especially useful during development where you need to populate the database with sample data that you can develop against, but it is not limited to that. 
 
## More about Web Frameworks

### What do Razor Pages, MVC and API applications have in common? 

 Razor Pages follows a much more compact programming model than MVC does. In Razor Pages, each request gets routed directly to a page. This routing paradigm is different in MVC, where requests get routed to a controller who generates a model for a view to data bind.
 
Just like MVC, Razor Pages uses Razor as it’s templating engine. Razor is shared by several .NET Core web application frameworks and focuses solely on generating HTML markup and rendering data objects.
 
Unlike MVC, which breaks into three separate components, a Razor page is made up of two pieces, a Razor markup file and a C# code file. The Razor markup looks similar to an MVC view; however, there is a unique @page directive placed at the top of the file to give it the features of a Razor Page.
 
### What is model binding?

Model Binding in Razor Pages is the process that takes values from HTTP requests and maps them to handler method parameters or PageModel properties. Model binding reduces the need for the developer to manually extract values from the request and then assign them, one by one, to variables or properties for later processing.
 
One key difference between Razor Pages and MVC is how data gets bound to the Razor markup. With Razor Pages, the page model not only handles requests, but it is also bound directly to the page markup. You can almost think of it like a model and controller combined. Properties exposed in the page model can be accessed directly in the page markup using the @Model syntax.
 
### What is the difference between Razor Pages and MVC Web applications?

 The key difference between Razor Pages implementation of the MVC pattern and ASP.NET Core MVC is that Razor Pages uses the Page Controller pattern instead of the Front Controller pattern.
 
### What is Razor markup?

Razor is a markup syntax that lets you embed server-based code (Visual Basic and C#) into web pages.
 
### Where/when is the C# code in a Razor page executed?
 
This is done server side

### Where/when is the Javascript code in a Razor page executed?

This is done client side
 
### How is C# code indicated in Razor pages?
 
 C# files have the extension .cshtml

## Authorisation and Authentication

### What is the difference between Authorisation and Authentication?
 
Authentication is figuring out who the user is, Authorisation is seeing what they have the right to do.

### Where do they sit in the Request pipeline and why?

 They are at the end of the pipeline before it moves back down through its self for the returned response.

 ### What are Roles?

 
 
### Can a User have more than one Role?

 Yes
 
### Can an anonymous user have a role?

 yes
 
