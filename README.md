````markdown
# Garage 3.0

Garage 3.0 is a web-based parking management system developed as a school project at Lexicon.

The application manages users, registered vehicles, parking spots and parking sessions. It also provides administration features for managing the garage and viewing statistics.

## Features

### User Management

- User registration and login
- Authentication with ASP.NET Core Identity
- Role-based authorization
- Admin and Member roles
- User administration for administrators

### Vehicle Management

- Register vehicles
- Edit registered vehicles
- Delete vehicles when allowed
- Search vehicles by registration number
- Vehicle type management
- Ownership validation
- Unique registration numbers

### Parking Management

- Park registered vehicles
- Check out vehicles
- Calculate parking duration and price
- Prevent multiple active parkings for the same vehicle
- Prevent parking in an occupied parking spot
- Parking history
- Parking receipts

### Active Parking Overview

Administrators can:

- View currently active parkings
- Search by registration number
- Filter by vehicle type
- View vehicle owner
- View vehicle type
- View registration number
- View parking spot
- View location
- View check-in time
- View parking duration

### Statistics

The application provides statistics related to parking activity and the garage.

### Administration

Administrators can manage:

- Users
- Vehicles
- Vehicle types
- Parking spots
- Active parkings
- Statistics

## Technologies

- C#
- .NET 10
- ASP.NET Core MVC
- Entity Framework Core
- ASP.NET Core Identity
- SQL Server / LocalDB
- Razor Views
- Bootstrap
- LINQ
- Async/Await

## Architecture

The application follows the ASP.NET Core MVC architecture.

```text
Garage.3.0
│
├── Areas/
│   └── Identity/
│
├── Controllers/
│
├── Data/
│
├── Helpers/
│
├── Models/
│
├── Services/
│   └── Interfaces/
│
├── ViewModels/
│
├── Views/
│
├── Migrations/
│
├── wwwroot/
│
├── Program.cs
├── appsettings.json
└── GarageV3.csproj
````

The application separates responsibilities between controllers, services, data access, models and view models.

## Database

Entity Framework Core is used for database access.

The main domain entities include:

* `ApplicationUser`
* `Vehicle`
* `VehicleTypeEntity`
* `ParkingSpot`
* `ParkingSession`
* `ParkingAllocation`

Database changes are managed using Entity Framework Core migrations.

## Requirements

Before running the project, make sure you have:

* .NET 10 SDK
* Visual Studio 2022 or later
* SQL Server LocalDB
* Entity Framework Core tools

## Getting Started

### 1. Clone the repository

```bash
git clone <repository-url>
```

### 2. Open the project

Open the solution in Visual Studio.

### 3. Configure the database

Check the connection string in:

```text
appsettings.json
```

The project is configured to use SQL Server LocalDB during development.

### 4. Apply database migrations

```bash
dotnet ef database update
```

### 5. Run the application

From Visual Studio or by using:

```bash
dotnet run
```

The application will start on the configured local development URL.

## Roles and Authorization

Garage 3.0 uses role-based authorization.

### Member

Members can:

* Manage their own vehicles
* Park their own registered vehicles
* Check out their own vehicles
* View their own relevant parking information

Members cannot manage other users' vehicles or access administrator-only functionality.

### Admin

Administrators have access to:

* User management
* Vehicle management
* Vehicle type management
* Parking spot management
* Active parking overview
* Statistics
* Administrative parking operations

Authorization is enforced on the server side using ASP.NET Core authorization and ownership checks.

## Validation and Business Rules

The application contains validation and business rules for important operations.

Examples include:

* Registration numbers are normalized and must be unique.
* A vehicle must be registered before it can be parked.
* A member can only park their own vehicle.
* A vehicle cannot have more than one active parking session.
* A parking spot cannot be occupied by two active parking sessions.
* Vehicles with parking history are protected from accidental deletion.
* Historical parking data is protected from accidental cascade deletion.
* Administrative operations require the appropriate role.

## CI/CD

The project is prepared for Continuous Integration and Continuous Delivery.

The intended pipeline consists of:

```text
Git Push
   │
   ▼
Restore
   │
   ▼
Build
   │
   ▼
Test
   │
   ▼
Publish
   │
   ▼
Deploy
   │
   ▼
Azure
```

CI/CD allows the application to be automatically built and validated when changes are pushed to the repository and supports deployment to Azure.

## Development Practices

The project follows several development practices:

* ASP.NET Core MVC architecture
* Dependency Injection
* Entity Framework Core
* LINQ queries
* Asynchronous database operations
* ViewModels for transferring data to views
* Server-side validation
* Role-based authorization
* Ownership checks
* Database migrations
* Avoiding unnecessary database calls
* Avoiding N+1 query patterns where possible

## Project Structure

### Controllers

Controllers handle HTTP requests and coordinate application logic.

Examples include:

* `ParkingController`
* `AdminParkingController`
* `MyVehiclesController`
* `AdminVehiclesController`
* `AdminParkingSpotsController`
* `AdminVehicleTypesController`
* `UserManagementController`

### Services

Services contain reusable business logic and separate application logic from controllers.

Interfaces are used where appropriate to make the application easier to maintain and test.

### ViewModels

ViewModels are used to control which data is sent between controllers and views instead of exposing database entities directly.

### Data

The `Data` folder contains:

* `ApplicationDbContext`
* Database initialization
* Entity Framework Core configuration
* Seed data

## Database Migrations

After changing the database model, create a migration with:

```bash
dotnet ef migrations add <MigrationName>
```

Then apply it with:

```bash
dotnet ef database update
```

## Testing

Important scenarios to verify include:

* User registration
* Login
* Role authorization
* Vehicle registration
* Vehicle ownership
* Vehicle search
* Parking a vehicle
* Preventing duplicate active parking
* Preventing parking in an occupied spot
* Checkout
* Parking history
* Receipt generation
* Admin functionality
* Active parking search and filtering
* Statistics

## Future Improvements

Possible future improvements include:

* More automated tests
* Improved CI/CD deployment configuration
* Additional parking statistics
* Extended garage functionality
* Additional user account features
* Further UI and accessibility improvements

## Project Status

Garage 3.0 is a school project developed as part of the Lexicon .NET development program.

The project focuses on:

* ASP.NET Core MVC
* Entity Framework Core
* Relational database design
* Authentication and authorization
* LINQ
* Business rules
* Clean separation of responsibilities
* CI/CD
* Azure deployment

```
```
