# EvolentExercise
Implement ContactManagement using Asp.net MVC, Entity Framwork code first.
Use Niject as IoC for Dependency injection, AutoMapper to map entities between layers.

## About the Project
Project Description:

Design and implement a production ready application for maintaining contact information. Please

choose the frameworks, packages and/or technologies that best suit the requirements.

Expected functionality:

- add a contact

- list contacts

- edit contact

- delete contact

Required Contact model:

- First Name

- Last Name

- Email

- Phone Number

- Status (Possible values: Active/Inactive)

## Getting Started
You need to change connection string in .config files to connect to your database
1. Change the connection string in ~\ContactManagement\Data\App.config
2. Change connection string in ~\ContactManagement\ContactManagement\Web.config
```xml
  <connectionStrings>
    <add name="ContactContext" connectionString="Data Source=(localdb)\MyInstance;Initial Catalog=Evolent;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework" providerName="System.Data.SqlClient" />
  </connectionStrings>
```
This project is using Entity Framework 6 code first, so it will create a table dbo.Contact to the database you assigned in the Connection String 

## Thank you 
