````markdown
# 🚗 Garage 3.0

> A web-based parking management system developed as a school project at **Lexicon**.

Garage 3.0 is an ASP.NET Core MVC application for managing users, registered vehicles, parking spots and parking sessions. The system includes authentication, role-based authorization, parking management, administration and statistics.

---

## ✨ Features

### 👤 User Management
- User registration and login
- ASP.NET Core Identity authentication
- Role-based authorization
- Admin and Member roles
- User administration for administrators

### 🚘 Vehicle Management
- Register vehicles
- Edit registered vehicles
- Delete vehicles when allowed
- Search vehicles by registration number
- Vehicle type management
- Ownership validation
- Unique registration numbers

### 🅿️ Parking Management
- Park registered vehicles
- Check out vehicles
- Calculate parking duration and price
- Prevent multiple active parkings for the same vehicle
- Prevent parking in an occupied parking spot
- Parking history
- Parking receipts

### 🔎 Active Parking Overview

Administrators can:

- View all currently active parkings
- Search by registration number
- Filter by vehicle type
- View vehicle owner
- View vehicle type
- View registration number
- View parking spot
- View location
- View check-in time
- View parking duration

### 📊 Statistics

The application provides statistics related to parking activity and garage usage.

### ⚙️ Administration

Administrators can manage:

- Users
- Vehicles
- Vehicle types
- Parking spots
- Active parkings
- Statistics

---

## 🛠️ Technologies

| Technology | Purpose |
|---|---|
| **C#** | Programming language |
| **.NET 10** | Application framework |
| **ASP.NET Core MVC** | Web application framework |
| **Entity Framework Core** | Database access and ORM |
| **ASP.NET Core Identity** | Authentication and authorization |
| **SQL Server / LocalDB** | Database |
| **Razor Views** | User interface |
| **Bootstrap** | Styling and responsive UI |
| **LINQ** | Data querying |
| **Async/Await** | Asynchronous operations |

---

## 🏗️ Architecture

Garage 3.0 follows the **ASP.NET Core MVC architecture** with separation between controllers, services, models, view models and data access.

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
└── *.csproj
````

### Main domain entities

* `ApplicationUser`
* `Vehicle`
* `VehicleTypeEntity`
* `ParkingSpot`
* `ParkingSession`
* `ParkingAllocation`

---

## 🔐 Authorization

The application uses role-based authorization together with ownership checks.

### Member

Members can:

* Manage their own vehicles
* Park their own registered vehicles
* Check out their own vehicles
* Access their own relevant parking information

Members cannot manage another member's vehicles or access administrator-only functionality.

### Admin

Administrators can:

* Manage users
* Manage vehicles
* Manage vehicle types
* Manage parking spots
* View active parkings
* Access statistics
* Perform administrative parking operations

Authorization and ownership rules are enforced on the server side.

---

## ✅ Validation & Business Rules

The application implements important validation and parking rules, including:

* Registration numbers must be unique.
* Registration numbers are normalized.
* Vehicles must be registered before they can be parked.
* Members can only park their own vehicles.
* A vehicle cannot have more than one active parking session.
* A parking spot cannot be occupied by multiple active parkings.
* Vehicles with parking history are protected from accidental deletion.
* Historical parking data is protected from accidental cascade deletion.
* Administrative operations require the appropriate authorization.

---

## 🗄️ Database

Garage 3.0 uses **Entity Framework Core** with SQL Server / LocalDB.

Database changes are managed through Entity Framework Core migrations.

### Apply migrations

```bash
dotnet ef database update
```

### Create a new migration

```bash
dotnet ef migrations add <MigrationName>
```

### Apply the migration

```bash
dotnet ef database update
```

---

## 🚀 Getting Started

### Prerequisites

Make sure you have installed:

* .NET 10 SDK
* Visual Studio 2022 or later
* SQL Server LocalDB
* Entity Framework Core tools

### 1. Clone the repository

```bash
git clone <repository-url>
cd Garage.3.0
```

### 2. Configure the database

Check the connection string in:

```text
appsettings.json
```

The application is configured to use SQL Server LocalDB for development.

### 3. Apply database migrations

```bash
dotnet ef database update
```

### 4. Run the application

```bash
dotnet run
```

Or open the solution in Visual Studio and run the project.

---

## 🔄 CI/CD

Garage 3.0 is being prepared for **Continuous Integration and Continuous Delivery (CI/CD)**.

The goal is to automatically build, validate and deploy the application when changes are pushed to the repository.

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

The CI/CD workflow helps ensure that new changes are built and validated automatically before deployment.

---

## 🧪 Testing

Important scenarios for the application include:

* User registration
* Login
* Role authorization
* Vehicle registration
* Vehicle ownership
* Vehicle search
* Parking a vehicle
* Preventing duplicate active parking
* Preventing parking in an occupied spot
* Vehicle checkout
* Parking history
* Receipt generation
* Admin functionality
* Active parking search and filtering
* Statistics

---

## 💡 Development Practices

The project uses:

* ASP.NET Core MVC
* Dependency Injection
* Entity Framework Core
* LINQ
* Asynchronous database operations
* ViewModels
* Server-side validation
* Role-based authorization
* Ownership checks
* Entity Framework migrations
* Separation of business logic into services
* Avoidance of unnecessary database calls
* Avoidance of N+1 query patterns where possible

---

## 📌 Project Status

**Garage 3.0 is an ongoing school project developed as part of the Lexicon .NET development program.**

The project focuses on developing a complete parking management system while applying modern development practices such as:

* ASP.NET Core MVC
* Entity Framework Core
* Relational database design
* Authentication and authorization
* LINQ
* Business rules
* Service-based architecture
* CI/CD
* Azure deployment

---

## 👨‍💻 Project

**Garage 3.0**
Developed as part of the **Lexicon .NET development program**.

---

```

