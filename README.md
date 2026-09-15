

````markdown
# Garage 3.0

A web-based parking management system developed as a school project at Lexicon.

Garage 3.0 is designed to manage users, registered vehicles, parking spots and parking sessions. The application also provides administration features, parking history and statistics.

## Features

- User registration and login
- Authentication with ASP.NET Core Identity
- Admin and Member roles
- Role-based authorization
- Register and manage vehicles
- Search vehicles by registration number
- Manage vehicle types
- Manage parking spots
- Park registered vehicles
- Check out vehicles
- Automatic parking duration and price calculation
- Parking history and receipts
- Active parking overview
- Search and filter active parkings
- Garage statistics
- Ownership and business rule validation

## Technologies

### Backend

- C#
- .NET 10
- ASP.NET Core MVC
- Entity Framework Core
- ASP.NET Core Identity
- LINQ

### Database

- SQL Server
- SQL Server LocalDB
- Entity Framework Core Migrations

### Frontend

- Razor Views
- HTML
- CSS
- Bootstrap
- JavaScript

## Architecture

The application follows the **ASP.NET Core MVC architecture** and separates responsibilities between controllers, services, models, view models and data access.

```text
Controllers
     ↓
Services
     ↓
Entity Framework Core
     ↓
SQL Server
````

### Main Components

* **Models** – Represent the application's data and database entities.
* **Controllers** – Handle HTTP requests and coordinate application logic.
* **Services** – Contain business logic and reusable functionality.
* **ViewModels** – Transfer the required data between controllers and views.
* **Views** – Provide the user interface using Razor.
* **Data** – Contains the database context, configuration and seed data.
* **Migrations** – Manage changes to the database structure.

### Main Entities

* `ApplicationUser`
* `Vehicle`
* `VehicleTypeEntity`
* `ParkingSpot`
* `ParkingSession`
* `ParkingAllocation`

## Authorization

The application uses role-based authorization with two main roles:

### Member

Members can manage their own vehicles, park their own vehicles and check out their own vehicles.

### Admin

Administrators can manage users, vehicles, vehicle types, parking spots, active parkings and statistics.

Ownership checks are used together with role-based authorization to protect user-specific operations.

## Database

Entity Framework Core is used as the ORM for communication with SQL Server.

Database changes are handled using EF Core migrations.

```bash
dotnet ef migrations add <MigrationName>
dotnet ef database update
```

## CI/CD

The project is being prepared for Continuous Integration and Continuous Delivery.

The planned workflow is:

```text
Git Push
   ↓
Build
   ↓
Test
   ↓
Publish
   ↓
Deploy
   ↓
Azure
```

## Project Status

Garage 3.0 is a school project developed as part of the **Lexicon .NET development program**.

The project focuses on ASP.NET Core MVC, Entity Framework Core, relational database design, authentication, authorization, business logic and CI/CD.

```

**Den här versionen är mycket närmare exakt den stil du visade på bilden.** Den kommer att renderas med stor titel, tydliga rubriker, punktlistor och snygga kodblock på GitHub.
```
