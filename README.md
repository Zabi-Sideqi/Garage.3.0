````markdown
# Garage 3.0

Garage 3.0 is a web-based parking management system developed as a school project at Lexicon.

The purpose of the application is to manage a garage where users can register their vehicles, park vehicles, check out, and view parking history. Administrators can manage users, vehicles, vehicle types, parking spots, active parkings and statistics.

## How the Application Is Built

The application is built using **ASP.NET Core MVC** with **C# and .NET 10**.

The project uses:

- **ASP.NET Core MVC** – application structure and web interface
- **Entity Framework Core** – database access and relational data
- **ASP.NET Core Identity** – user registration, login and roles
- **SQL Server / LocalDB** – database
- **Razor Views** – user interface
- **Bootstrap** – styling and responsive design
- **LINQ** – database queries

The application is divided into different layers:

```text
Controllers
    ↓
Services
    ↓
Entity Framework Core
    ↓
SQL Server
````

### Main Parts

* **Models** – represent the application's data and database entities.
* **Controllers** – handle requests and coordinate the application.
* **Services** – contain business logic and reusable functionality.
* **ViewModels** – transfer the required data between controllers and views.
* **Views** – provide the user interface.
* **Data** – contains the database context, configuration and seed data.
* **Migrations** – manage changes to the database structure.

The main entities are:

* `ApplicationUser`
* `Vehicle`
* `VehicleTypeEntity`
* `ParkingSpot`
* `ParkingSession`
* `ParkingAllocation`

The system also uses **role-based authorization** with `Admin` and `Member` roles and applies ownership checks for user-specific vehicle and parking operations.

## Project Status

Garage 3.0 is a school project developed as part of the **Lexicon .NET development program**, with a focus on ASP.NET Core, Entity Framework Core, relational databases, authentication, authorization and modern application development practices.

```
```
