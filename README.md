# Garage 3.0

A web-based parking management system built with C# and ASP.NET Core MVC. The application supports parking operations for members and administrative management, with authentication, role-based access, parking history, receipts, and statistics.

## Features

- User registration and login with ASP.NET Core Identity
- Member and Admin roles with role-based authorization
- Register and manage vehicles
- Search vehicles by registration number
- Manage vehicle types and parking spots
- Start and finish parking sessions
- Calculate parking duration and price
- View parking history and receipts
- Search and filter active parking sessions
- View garage statistics
- Validate ownership and business rules

## Tech Stack

| Area | Technologies |
| --- | --- |
| Language | C# |
| Framework | .NET 10, ASP.NET Core MVC |
| Data access | Entity Framework Core, LINQ |
| Database | SQL Server, LocalDB |
| Authentication | ASP.NET Core Identity |
| Frontend | Razor Views, HTML, CSS, Bootstrap, JavaScript |

## Architecture

The application follows the ASP.NET Core MVC pattern and separates HTTP handling, business logic, data access, and presentation.

```text
Browser
   |
   v
Razor Views <-> Controllers
                    |
                    v
                 Services
                    |
                    v
          Entity Framework Core
                    |
                    v
                SQL Server
```

### Main responsibilities

- **Controllers** handle incoming HTTP requests.
- **Services** contain reusable business logic.
- **Models and ViewModels** represent domain data and view-specific data.
- **Views** render the user interface with Razor.
- **Data** contains the database context and related configuration.
- **Migrations** track database schema changes.

### Main domain entities

- `ApplicationUser`
- `Vehicle`
- `VehicleTypeEntity`
- `ParkingSpot`
- `ParkingSession`
- `ParkingAllocation`

## Authorization

The application distinguishes between two main roles:

- **Member:** manages their own vehicles and parking activity.
- **Admin:** manages users, vehicle types, parking spots, active parking sessions, and statistics.

Role-based authorization is combined with ownership checks for user-specific operations.

## Run Locally

### Prerequisites

- .NET 10 SDK
- SQL Server or SQL Server LocalDB
- EF Core CLI tools if you need to manage migrations

Clone the repository:

```bash
git clone https://github.com/Zabi-Sideqi/Garage.3.0.git
cd Garage.3.0
```

Restore dependencies and build:

```bash
dotnet restore
dotnet build
```

Configure the database connection string for your local environment. Do not commit passwords or other secrets. Apply migrations if needed:

```bash
dotnet ef database update
```

Run the application:

```bash
dotnet run
```

Open the local URL printed by the application.

To create a new migration after changing the data model:

```bash
dotnet ef migrations add <MigrationName>
dotnet ef database update
```

## What This Project Demonstrates

- MVC application structure in ASP.NET Core
- Relational database access with EF Core
- Authentication and role-based authorization
- Ownership checks and business-rule validation
- CRUD workflows and search/filter functionality
- Database migrations and separation of responsibilities

## Source Code

[View Garage 3.0 on GitHub](https://github.com/Zabi-Sideqi/Garage.3.0)
