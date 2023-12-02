### Research & Planning Log

```
Friday, 12/01/2023

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
```
