# Different Types Of ActionResult In MVC5

## Introduction
ASP.NET MVC has different types of Action Results. Each action result returns a different format of the output. As a programmer, we need to use different action results to get the expected output.

## What are Actions in MVC? 

Actions are the methods in controller class which is responsible for returning the view or json data. Action will mainly have return type “ActionResult” and it will be invoked from method InvokeAction () called by controller. 

mvcaction4 and tab shortcut for MVC ActionResult

## What is the Action Method in ASP.NET MVC?

All the public methods inside a controller which response to the URL is known as Action Method. When creating an Action Method we must follow these rules.

1.	Action method must be public.
2.	It cannot be overloaded
3.	It cannot be a static method
4.	ActionResult is a base class of all the result type action methods.

## What is the Action Result in MVC?

Action Result is a result of action methods or return types of action methods. Action result is an abstract class. It is the base class for all type of action results. 

## Types of Action Results

ActionResult is the base class of all the result type action method. Following are the Result types that an action method can return in MVC.

1.	ViewResult – Represents HTML and mark-up.
2.	EmptyResult – Represents no result.
3.	RedirectResult – Represents a redirection to a new URL.
4.	JsonResult – Represents a JavaScript Object Notation result that can be used in an AJAX application.
5.	JavaScriptResult – Represents a JavaScript script.
6.	ContentResult – Represents a text result.
7.	FileContentResult – Represents a downloadable file (with the binary content).
8.	FilePathResult – Represents a downloadable file (with a path).
9.	FileStreamResult – Represents a downloadable file (with a file stream).

**These results are categorized into three sections:** 

1.	Content-returning
2.	Redirection
3.	Status.

Content-returning: These ActionResults are responsible for returning content to the browser or calling script. The examples are as follows

1.	ViewResult
2.	PartialViewResult
3.	FileResult
4.	ContentResult
5.	EmptyResult
6.	JsonResult
7.	JavaScriptResult

**Redirection**: These ActionResults are responsible for redirecting to other URLs or actions. The examples are as follows

1.	RedirectResult
2.	RedirectToRouteResult
3.	RedirectToActionResult

**Status**: These ActionResults are responsible for returning status codes to the browser for it to use. The examples are as follows

1.	HttpStatusCodeResult
2.	HttpUnauthorizedResult
3.	HttpNotFoundResult

##What is the difference between ActionResult and ViewResult? 
|ActionResult|ViewResult|
|---|---|	
|ActionResult is an abstract class|ViewResult derives from the ActionResult class|
|ActionResult has several derived classes like ViewResult, JsonResult, FileStreamResult etc|ActionResult can be used to exploit polymorphism and dynamism. So if you are returning different types of views dynamically, ActionResult is the best thing.|
|ActionResult can return many type of Results|ViewResult can return Only View result type|
|It is an abstract class|It is a concrete class|
|When action method may have different behavior, like either render a view or perform a redirection. We can use the more general base class ActionResult as the return type.|We can use ViewResult when action method return some view|

## What are Action Selectors in ASP.NET MVC?

The Actions are the public methods of a controller in ASP.NET MVC Application that responds to incoming HTTP Requests. The Action Selectors in ASP.NET MVC are the attributes that can be applied to action methods and are used to influence or control which action method gets invoked in response to a request. That means Action Selectors in MVC help the routing engine to select the correct action method to handle a particular request.

## Types of Action Selectors in ASP.NET MVC.

The ASP.NET MVC Framework provides the following three action selector attributes:

1.	ActionName
2.	ActionVerbs (HttpGet, HttpPost, HttpPut, HttpDelete)
3.	NonAction

For more information please visit below article
https://www.c-sharpcorner.com/article/different-types-of-actionresult-in-mvc/
