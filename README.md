## Research & Planning Log

## Fri, 12/01/2023
```
* 08:00 AM - Initialize the project repo.
* 08:30 AM - WIP capstone proposal.
* 09:00 AM - Working on back end API structure, using a Miro board. (https://miro.com)
* 09:13 AM - Working on database schema, using SQL designer. (https://sql.toad.cz/)
* 09:32 AM - Created the database schema, pushing the schema on repo.
* 09:54 AM - Creating API endpoints on Miro.
* 10:17 AM - Creating ASP.NET Web API project. 
* 10:45 AM - WIP building the initial project files.
* 10:55 AM - Starting to work on first Models, taking advantage of thinking / working on project in Thanksgiving break!
* 11:21 AM - Creating DbContext for EF Core.
* 11:29 AM - Thinking about how to test this API for account creation, how to use JWT.
* 11:35 AM - Creating Register class as data transfer object (DTO).
* 11:45 AM - Lunch Break
* 01:00 PM - Brainstorming about controllers structure.
* 01:30 PM - Created first controller (Accounts Controller).
* 01:50 PM - Working on a method that checks existings roles.
* 02:05 PM - Creating the first route in the controller.
* 02:33 PM - WIP Register route, debugging a role issue on account creation.
* 02:45 PM - WIP Register route, working in MySQL Workbench to test Register route. Trying to see if the method creates an account with a defined role, it creates the user but cannot see the defined role in the table.
* 02:57 PM - WIP Register route, checking documentations to have better understand of IdentityUser class. 
 (https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.entityframeworkcore.identityuser?view=aspnetcore-1.1&viewFallbackFrom=aspnetcore-6.0)
* 03:09 PM - Fixed the bug, Register route successfully creates an account with defined Identity role.
* 03:26 PM - Working on migrations to initialize the database.
* 03:54 PM - Initialized the database successfully, application creates an account with defines Identity role.
* 04:05 PM - Brainstorming about a route that allows registered accounts to sign in.
* 04:35 PM - Checking Microsoft's documentation about SignInManger, I already work with this class but I want to make sure before use it.
```

## Tue, 12/05/2023
```
* 05:40 AM - Create CreateToken method, this method is used in SignIn route, it creates JSON Web Tokens to send to the user in response.
* 06:03 AM - Searching about JWT, trying to decide what data needs to be in response tokens to use for future requests.
* 06:07 AM - Using JWT Debugger tool to read successfully created tokens as part of SignIn route response, it works as expected (https://jwt.io/).
* 06:28 AM - Testing the successfully created accounts on MySQL workbench.
* 09:58 PM - Created a Vehicle entity.
* 10:11 PM - Added a new migration (Vehicle).
* 10:15 PM - WIP new controller.
* 10:27 PM - Searching about boolean data types in MySQL, found really interesting answers on Stack Overflow and decided to go with "TINYINT".
(https://stackoverflow.com/questions/289727/which-mysql-data-type-to-use-for-storing-boolean-values)
* 10:36 PM - Created a fleet controller.
```

## Wed, 12/06/2023
```
* 05:50 AM - Working on Vehicle entity, adding new properties.
* 06:17 AM - Added a new migration (new vehicle properties).
* 06:23 AM - Created a POST route in fleet controller, this route adds vehicle into the database.
```

## Fri, 12/08/2023
```
* 08:00 AM - Continuing to work on Fleet Controller.
* 08:07 AM - Trying to set authorization for the POST route in the controller.
* 08:16 AM - Reading ASP.NET documentation about role based authorization.
* 08:27 AM - Still working on role based authorization.
* 08:44 AM - Reading ASP.NET documentation "How to use Identity to secure a Web API backend for SPAs".
(https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-6.0)
* 08:56 AM - Watching a video about roled based auth on Youtube.
(https://www.youtube.com/watch?v=KRVjIgr-WOU)
* 09:18 AM - WIP role based auth, still trying to make this work.
* 09:41 AM - Debugging role based auth, having really hard time with this. Everything works good without roles but when I try to reach to auth protected routes, I got 403 Forbidden error. When I read the decoded token, I can see the user role in the token but route doesn't accept this.
* 10:00 AM - Searching on internet about this role based auth problem.
* 10:39 AM - Finally I found the problem, It took good amount of time. I could just pass this bug and focus on controller and routes but role based auth is an important feature for my application so I wanted fix this before go further. Still need refactor my Account Controller because routes work with hard coded roles at the moment.
* 02:59 PM - I've realized I need three different user model for this application, we work with ApplicationUser class that extends from IdentityUser in the classes but I'm planning to add two more user model.
* 03:02 PM - Started to search about this three different user models idea, found some interesting content on Stackoverflow.
(https://stackoverflow.com/questions/64370175/how-to-add-multiple-identity-and-multiple-role-in-asp-net-core/64421573#64421573)
* 03:12 PM - WIP multiple users in IdentityUser.
(https://learn.microsoft.com/en-us/answers/questions/1266674/how-can-i-have-multiple-identity-user-types-when-u)
* 4:18 PM - Trying to find a solution without multiple user class, maybe a simple join table can solve my problem?
(https://stackoverflow.com/questions/28667360/how-to-create-a-new-user-when-inheriting-from-identityuser)
* 8:05 PM - Working on a Join Entity, basically this join entity is going to be a record of the detailed fleet vehicles.
```

## Fri, 12/15/2023

```
* 08:20 AM - Working on CORS errors, trying to make test Http request from front-end (React) to back-end (ASP.NET) while serving both application on local.
* 09:09 AM - Fixed CORS errors, I was able make a Http POST request from frontend to backend and created an account.
```