# EF6-Data-Validation
In depth tutorial on data validation with EF 6

# What we will Cover
In the context of this tutorial we will have a look at how to implement data validation using Entity framework core 6 (EF 6). 
For the purpose of this tutorial, I would love to build with you a simple Cheap Phone listing platform and the technologies will be:

## 1. Asp.Net 6 Web API
This tutorial will start off as an Asp.Net 6 Web API project but in later section we will migrate to MVC when the need arise.
## 2. EF In memory database
For this purpose of this tutorial, we will focus more on validation which means we will not be connecting to any database but use EF Core In memory database. You can build upon the project by integrating with any database of your choice.
## 3. Swagger
Starting off the project, swagger will play a key role for testing purposes. Before looking at the Magic of EF validation API at the client side, we will start off from server side validation and so swagger could be helpful here but you can also use any testing framework of your choice eg: Postman.
## 4. Razor pages
We will have a look at how easy EF makes validation on the client side especially for MVC projects. For this tutorial, we will be using Razor pages for our client side.

# EF6 Validation
1. Data Annotations
2. Fluent API
3. IValidatableObject
4. DbContext.ValidateEntity
