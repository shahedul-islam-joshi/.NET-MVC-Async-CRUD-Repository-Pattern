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
├── Controllers/
│   ├── AdminStudentController.cs    # Logic for student CRUD operations
│   └── HomeController.cs            # Home and Privacy page logic
├── Data/
│   └── AppsDbContext.cs             # Entity Framework Core database context
├── Migrations/                      # Database schema migration history
├── Models/
│   ├── DomainModel/
│   │   └── StudentClass.cs          # Database entity model
│   ├── ViewModel/
│   │   ├── AddStudentRequest.cs     # Model for creating students
│   │   └── EditStudentRequest.cs    # Model for updating students
│   └── ErrorViewModel.cs            # Application error handling model
├── Repository/                      # Repository Pattern implementation
│   ├── IStudentRepo.cs              # Interface for student operations
│   └── StudentRepo.cs               # Concrete implementation (Async)
├── Views/
│   ├── AdminStudent/                # Management views
│   │   ├── Add.cshtml
│   │   ├── Edit.cshtml
│   │   └── List.cshtml
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Shared/                      # Layout and partial views
│   │   ├── _ViewImports.cshtml
│   │   └── _ViewStart.cshtml
├── wwwroot/                         # Static files (CSS, JS, Libs)
├── .gitignore                       # Git exclusion rules
├── appsettings.json                 # Connection strings and config
├── Dockerfile                       # Containerization setup
├── Program.cs                       # App entry point and DI container
└── README.md                        # Documentation
