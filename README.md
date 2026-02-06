# ASP.NET Core MVC – Async Repository Pattern CRUD

This project is a **Student Management CRUD application** built with **ASP.NET Core MVC**.  
It demonstrates **asynchronous programming**, **Repository Pattern**, and **interface-based abstraction** using **Entity Framework Core**.

---

##  Features

-  ASP.NET Core MVC architecture
-  CRUD operations (Create, Read, Update, Delete)
-  Asynchronous programming (`async` / `await`)
-  Repository Pattern
-  Interface-based abstraction
-  Entity Framework Core
-  SQL Server database
-  Clean separation of concerns
-  Dependency Injection

---




##  Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- C#
- Razor Views
- Bootstrap

---


##  How to Run
1. Clone the repo: `git clone https://github.com/shahedul-islam-joshi/.NET-MVC-Async-CRUD-Repository-Pattern.git`
2. Update the Connection String in `appsettings.json`.
3. Run migrations: `Update-Database` in Package Manager Console.
4. Press `F5` or run `dotnet run`.
## Project Structure

```text
test_apps-3/
├── Connected Services/
├── Dependencies/
├── Properties/
├── wwwroot/
├── Controllers/
│   ├── AdminStudentController.cs
│   └── HomeController.cs
├── Data/
│   └── AppsDbContext.cs
├── Migrations/
├── Models/
│   ├── DomainModel/
│   │   └── StudentClass.cs
│   ├── ViewModel/
│   │   ├── AddStudentRequest.cs
│   │   └── EditStudentRequest.cs
│   └── ErrorViewModel.cs
├── Repository/
│   ├── IStudentRepo.cs
│   └── StudentRepo.cs
├── Views/
│   ├── AdminStudent/
│   │   ├── Add.cshtml
│   │   ├── Edit.cshtml
│   │   └── List.cshtml
│   ├── Home/
│   ├── Shared/
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── .gitignore
├── appsettings.json
└── Dockerfile