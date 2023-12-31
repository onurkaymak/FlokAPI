<br>
  <h1 align="center">Flok API</h1>

<p align="center">
  
   <br>
    <a href="https://github.com/onurkaymak/FlokAPI" style="display:flex;justify-content:center;">
        <img src="https://i.ibb.co/nfMH2jN/flok2.png" style="width:450px;height:100px;">
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href=https://onurkaymak.com/">
            <strong>By Onur Kaymak</strong>
        </a>
    </p>
    <!-- Project Shields -->
    <p align="center">
        <a href="https://github.com/onurkaymak/FlokAPI/graphs/contributors">
            <img src="https://img.shields.io/github/contributors/onurkaymak/ParksLookupAPI.svg?style=plastic">
        </a>
        &nbsp;
        <a href="https://github.com/onurkaymak/FlokAPI/stargazers">
            <img src="https://img.shields.io/github/stars/onurkaymak/ParksLookupAPI.svg?color=yellow&style=plastic">
        </a>
        &nbsp;
        <a href="https://github.com/onurkaymak/FlokAPI/issues">
            <img src="https://img.shields.io/github/issues/onurkaymak/ParksLookupAPI?style=plastic">
        </a>
        &nbsp;
        <a href="https://github.com/jfpalchak/FlokAPI/blob/main/LICENSE.txt">
            <img src="https://img.shields.io/github/license/jfpalchak/MessageBoardAPI?color=orange&style=plastic">
        </a>
    </p>    
</p>

<p align="center">
  <small>Initiated December 01th, 2023.</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/onurkaymak/FlokAPI.git"><big>Project Docs</big></a> ·
    <a href="https://github.com/onurkaymak/FlokAPI/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/onurkaymak/FlokAPI/issues"><big>Request Feature</big></a>
</p>

------------------------------
<u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🛠-built-with">Built With</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
------------------------------

## 🌐 About the Project

### 📖 Description

*Flok* is a fleet management tool that is made for car rental companies. It allows users to create/track vehicles in the inventory, track production status, current detailing numbers, and information about current reservations. 

All the features work based on authentication and authorization, different employee roles have different access levels in the app. These roles are "Auto Detailer", "Customer Service Agent", and "Manager".

It's a full-stack application that is built on React with Redux & ASP.NET Web API with MySQL. While Flok works as a front-end that allows a dynamic and better user experience, Flok API (this repo) allows this tool to expand on mobile development with React Native (WIP).

### 🔗 Flok repository Link

* [Flok](https://github.com/onurkaymak/Flok)

### 🦠 Known Bugs

* If any bugs are discovered, please contact the author(s).

### 🛠 Built With
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core)
* [MySQL 8.0.34](https://dev.mysql.com/)
* [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Entity Framework Core CLI Tools 6.0.0](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
* [Language Integrated Query (LINQ)](https://learn.microsoft.com/en-us/dotnet/csharp/linq/)
* [JWT](https://jwt.io/)
* [Postman](https://www.postman.com/)

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install dotnet-ef
For Entity Framework Core, we'll use a tool called dotnet-ef to reference the project's migrations and update our database accordingly. To install this tool globally, run the following command in your terminal:

```
$ dotnet tool install --global dotnet-ef --version 6.0.0
```

#### Install MySQL Workbench
This project assumes you have MySQL Server and MySQL Workbench installed on your system. If you do not have these tools installed, follow along with the installation steps for the the necessary tools introduced in the series of lessons found here on [LearnHowToProgram](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

[Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need a code editor or text editor. A popular open-source choice for a code editor is VisualStudio Code.

  1) Code Editor Download:
     * [VisualStudio Code](https://code.visualstudio.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)


### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [Flok API repository here](https://github.com/onurkaymak/FlokAPI).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/onurkaymak/FlokAPI.git`
  5) Run the command `cd FlokAPI.Solution/FlokAPI` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `code .` to open the project in VisualStudio Code for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [Flok API repository here](https://github.com/onurkaymak/FlokAPI).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and extract.
  4) Open by double clicking on any of the files to open in a text editor.


 #### AppSettings

  1) Create a new file in the FlokAPI directory named `appsettings.json`
  2) Add in the following code snippet to the new `appsettings.json` file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    },
    "JWT": {
        "ValidAudience": "example-audience",
        "ValidIssuer": "example-issuer",
        "Secret": "[YOUR-SECRET-HERE]"
  }
}
  ```

  3) Change the server, port, and user id as necessary. Replace `[YOUR-USERNAME-HERE]`, `[YOUR-PASSWORD-HERE]` and `[DATABASE-NAME-HERE]` with your personal MySQL username, password (set at installation of MySQL) and your choice of database name. 
  4) To properly implement JSON Web Tokens for API authorization, replace `[YOUR-SECRET-HERE]` with your own personalized string.
     1) NOTE: The `Secret` is a special string that will be used to encode our JWTs, to make them unique to our application. Depending on what type of algorithm being used, the Secret string will need to be a certain length. **In this case, it needs to be at least 16 characters long**.
  

  #### Database
  1) Navigate to FlokAPI.Solution/FlokAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/FlokAPI.Solution/FlokAPI`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. 
  4) After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to ParksLookupAPI.Solution/ParksLookupAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/FlokAPI.Solution/FlokAPI`).
  2) Run the command `dotnet run` to have access to the API.

## 🛰️ API Documentation

Explore the API endpoints in Postman. Please note that, you will not be able to utilize authentication in a browser.

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.

---

### Note on CORS
CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS. For more information or to see how CORS functions, see the Microsoft documentation. 

⭐ Please note that, this API allows CORS for development, you can run this API on your computer and make HTTP requests to this API.

---

### Database Diagram

<a href="https://ibb.co/SdB1KwL"><img src="https://i.ibb.co/LJ1qCdG/Database-Diagram.png" alt="Database-Diagram" border="0"></a>

⭐ This application uses EF Core Entity features to create migrations and update the database tables includes join tables.

---

### API Endpoints 

| Controller  | Type | Endpoint | 
| :---: | :---: | :---: | 
| Accounts | POST | /accounts/register |
| Accounts | POST | /accounts/signIn |
| Fleet | GET | /api/fleet |
| Fleet | POST | /api/fleet |
| Fleet | POST | /api/fleet/AddDetailingService |
| Fleet | PUT | /api/fleet/{id} |
| Fleet | DELETE | /api/fleet/{id} |
| Fleet | DELETE | /api/fleet/DeleteDetailingService |
| Production | GET | /api/production/{id} |
| Production | GET | /api/production/GetTotal/{id} |
| Rental | GET | /api/rental |
| Rental | POST | /api/rental |
| Rental | PUT | /api/rental/{rentalServiceId} |
| Rental | DELETE | /api/rental/DeleteRentalService/{rentalServiceId} |

---

### Accounts Controller


`POST` /accounts/register

We'll be using Postman for this example. Let's setup a POST request to the accounts/register endpoint. Select the 'Body' tab, choose the 'raw' radio button, and select 'JSON' from the dropdown selection.

In the Body of the Post request, use the following format:
```
{
    "email": "test@test.com",
    "userName": "TestUser",
    "password": "@Test123",
    "employeeRole": "Manager"
}
```
---

`POST` /accounts/signIn

To sign in, select the 'Body' tab, choose the 'raw' radio button, and select 'JSON' from the dropdown selection.

In the Body of the Post request, use the following format:
```
{
    "email": "test@test.com",
    "password": "@Test123",
}
```
Sample JSON Response
{
    "status": "success",
    "message": "test@test.com signed in.",
    "token": "xxxx.xxxx.xxxx"
}

<a href="https://ibb.co/4tP1HRT"><img src="https://gcdnb.pbrd.co/images/svw60XgYuJfQ.png?o=1" alt="SignIn" border="0" style="height:450px;width:700px;"/></a>

⭐ Using the JSON Web Token

Now let's copy that token from the response, and add it as an authorization header to our next request. Copy the token from the body, and click on the Authorization tab in Postman. On the 'Type', make sure that is set to 'Bearer Token', and then paste in the token in the field on the right.

Until the Token expires, you should now have access to all endpoints requiring user authorization!

<a href="https://ibb.co/gSqykJ9"><img src="https://i.ibb.co/c6fJ4Q3/Screenshot-2023-12-22-at-7-24-48-PM.png" alt="SignIn" border="0" style="height:350px;width:700px;"></a>



### Fleet Controller

⭐ Please note that, all the fleet routes are only accessible to "Manager" accounts, you need to use your token to access these routes.

`GET` /api/fleet

You can get all the vehicles in the Vehicles tables in the database, optionally you can use add queries to filter your search result.

Queries

| Query  | Required | 
| :---: | :---: | 
| VIN | No |
| isRented | No |
| inProduction | No |


Example Query
```
https://localhost:5000/api/fleet?vin=12345678
```

---

`POST` /api/fleet

You can add a new vehicle into Vehicles table in the database.

Sample JSON Request Body

```
{
    "VIN": "12345678",
    "detailerId": "8aa4b789-904a-4218-83d4-c5e4ab060fc1"
}
```

---

`POST` api/fleet/AddDetailingService

You can add a new DetailingService in the database, new DetailingService is a record of the detailed vehicles with the detailer information.

Sample JSON Request Body

```
{
    "vin": "12345678",
    "make": "Toyota",
    "model": "Camry",
    "color": "Red",
    "mileage": "678",
    "class": "Full Size",
    "classCode": "FCAR",
    "state": "OR",
    "licensePlate": "OR123",
    "isRented": false,
    "inProduction": false
}
```

---

`PUT` api/fleet/{id}

You can update an existing vehicle in the database.

Sample JSON Request Body
```
{
      "vehicleId": 17,
      "vin": "abcdefgh",
      "make": "BMW",
      "model": "X5",
      "color": "White",
      "mileage": 123,
      "class": "Small Pickup",
      "classCode": "SPAR",
      "state": "CA",
      "licensePlate": "WA123",
      "isRented": false,
      "inProduction": false
}
```

---

`DELETE` api/fleet/{id}

You can delete an existing vehicle in the database.

Example Request
```
https://localhost:5000/api/fleet/17
```

---

### Production Controller

`GET` api/production/{id}

You can get pending detailing information about the detailer with the provided detailer id.

Example
```
https://localhost:5000/api/production/8aa4b789-904a-4218-83d4-c5e4ab060fc1
```

---

`GET` api/production/GetTotal/{id}

You can get all the detailing records about the detailer with the provided detailer id.

Example Request
```
https://localhost:5000/api/production/GetTotal/8aa4b789-904a-4218-83d4-c5e4ab060fc1
```

---

### Rental Controller


`GET` api/rental

You can check all the booked vehicles from this route, optionally you can use queries to filter your search results.

Queries

| Query  | Required | 
| :---: | :---: | 
| rentalServiceId | No |
| customerEmail | No |
| customerPhoneNum | No |


Example Query
```
https://localhost:5000/api/fleet?customerEmail=test@test.com
```

---

`POST` api/rental

You can book a vehicle with these route, this route uses a join table to join customer and vehicle tables with provided information.

Sample JSON Request Body

```
{
    "VIN": "12345678",
    "customerEmail": "carlajohns@gmail.com",
    "serviceAgentId": "8aa4b789-904a-4218-83d4-c5e4ab060fc1",
    "reservationStart": "12/14/2023 8:30:00 AM",
    "reservationEnd": "12/18/2023 10:30:00 PM"
}
```

---

`PUT` /api/rental/{rentalServiceId}

You can update an existing reservation in the database.

Sample JSON Request Body
```
{
    "rentalServiceId": 3,
    "vehicleid": 1,
    "customerId": 3,
    "ServiceAgentId": "436c0226-8889-4ebf-bf5d-7c2401ac79c2",
    "reservationStart": "12/13/2023 10:30:00 AM",
    "reservationEnd": "12/17/2023 19:30:00 PM"
}
```

---

`DELETE` /api/rental/DeleteRentalService/{rentalServiceId}

You can delete an existing rentalService in the database. This is basically simulate an action for a returned rental vehicle. 

Example Request
```
https://localhost:5000/api/rental/15
```

---

## Research & Planning Log

### Fri, 12/01/2023
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

### Tue, 12/05/2023
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

### Wed, 12/06/2023
```
* 05:50 AM - Working on Vehicle entity, adding new properties.
* 06:17 AM - Added a new migration (new vehicle properties).
* 06:23 AM - Created a POST route in fleet controller, this route adds vehicle into the database.
```

### Fri, 12/08/2023
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

### Fri, 12/15/2023

```
* 08:20 AM - Working on CORS errors, trying to test Http request from front-end (React) to back-end (ASP.NET) while serving both application on local.
* 09:09 AM - Fixed CORS errors, I was able make a Http POST request from frontend to backend and created an account.
* 09:30 AM - Working on Account controller, trying to implement a feature that allows users auto sign in after created an account.
```
------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact one of the contributors.

<p>
    <a href="https://github.com/onurkaymak/FlokAPI/issues">Report Bug</a> ·
    <a href="https://github.com/onurkaymak/FlokAPI/issues">Request Feature</a>
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2023 Onur Kaymak. All Rights Reserved.

```
MIT License

Copyright (c) 2023 Onur Kaymak.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```
<center><a href="#">Return to Top</a></center>