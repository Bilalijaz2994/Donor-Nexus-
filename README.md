# 🩸 Donor Nexus

A Blood Donation Management System developed in **C# Windows Forms**, **ADO.NET**, and **SQL Server** following the **N-Tier Architecture** and Object-Oriented Programming (OOP) principles.

## 📌 Project Overview

Donor Nexus is designed to simplify blood donation management by connecting blood donors, hospitals, and administrators through a centralized desktop application.

The system manages:

* Donor Registration
* Donor Search
* Hospital Search
* Blood Inventory Management
* Donation Recording
* Contact & Support Messages
* Donor Availability Tracking

---

## 🚀 Features

### 👤 Public Users

* Register as a blood donor
* Search available donors
* Search hospitals by blood group and location
* Contact system administrators

### 🩸 Donors

* Secure login
* View donation history
* Manage availability status
* Update donation participation

### 🏥 Administrators

* Manage donor records
* Manage hospitals
* Manage blood inventory
* Record blood donations
* View contact messages
* Monitor overall system activity

---

## 🛠️ Technology Stack

| Technology           | Usage                   |
| -------------------- | ----------------------- |
| C#                   | Application Development |
| Windows Forms        | User Interface          |
| .NET Framework 4.7.2 | Application Framework   |
| SQL Server Express   | Database                |
| ADO.NET              | Database Connectivity   |
| Visual Studio        | Development Environment |

---

## 🏗️ Architecture

The project follows a **3-Layer (N-Tier) Architecture**:

### 1. User Interface (UI) Layer

Handles all Windows Forms and user interactions.

### 2. Models Layer

Contains business entities and validation logic.

### 3. Data Access Layer (DAL)

Handles all SQL Server communication using parameterized queries.

---

## 📂 Project Structure

```text
DonorNexus
│
├── Models
│   ├── Person.cs
│   ├── Donor.cs
│   ├── Admin.cs
│   ├── Hospital.cs
│   ├── BloodInventory.cs
│   └── DonationRecord.cs
│
├── DAL
│   ├── DatabaseHelper.cs
│   ├── AuthDAL.cs
│   ├── DonorDAL.cs
│   ├── HospitalDAL.cs
│   ├── InventoryDAL.cs
│   ├── DonationDAL.cs
│   └── ContactDAL.cs
│
├── UI
│   ├── HomePageForm.cs
│   ├── LoginForm.cs
│   ├── RegisterDonorForm.cs
│   ├── SearchDonorForm.cs
│   ├── HospitalSearchForm.cs
│   ├── AdminDashboardForm.cs
│   └── DonorDashboardForm.cs
│
└── Database
    └── DonorNexusDB.sql
```

---

## 🗄️ Database Design

### Main Tables

* Donors
* Admins
* UserAccounts
* Hospitals
* BloodInventory
* DonationRecords
* ContactMessages

### Database Objects

#### Stored Procedure

* SearchDonors

#### Trigger

* trg_UpdateTotalDonations

#### Function

* GetTotalBloodUnits()

---

## 🎯 OOP Concepts Implemented

### Encapsulation

Validation through private fields and public properties.

### Inheritance

`Donor` inherits from the abstract `Person` class.

### Abstraction

`Person` defines abstract methods implemented by child classes.

### Polymorphism

Virtual and overridden methods across multiple model classes.

### Composition

UI forms interact with DAL and Model classes.

---

## 🔒 Security Features

* Parameterized SQL Queries
* Input Validation
* Role-Based Authentication
* SQL Injection Protection
* Database Constraint Enforcement

---

## 📸 Application Screenshots

### Home Page

![Home Page](Screenshots/homepage.png)

### Donor Registration

![Donor Registration](Screenshots/registerdonor.png)

### Login Form

![Login Form](Screenshots/login.png)

### Search Donor

![Search Donor](Screenshots/searchdonor.png)

### Hospital Search

![Hospital Search](Screenshots/hospitalsearch.png)

### Admin Dashboard

![Admin Dashboard](Screenshots/admindashboard.png)

### Donor Dashboard

![Donor Dashboard](Screenshots/donordashboard.png)

---

## ⚙️ Installation

### Clone Repository

```bash
git clone https://github.com/yourusername/DonorNexus.git
```

### Database Setup

1. Open SQL Server Management Studio.
2. Create a database named `DonorNexusDB`.
3. Execute the provided SQL script.
4. Verify all tables, procedures, functions, and triggers are created.

### Application Setup

1. Open the solution in Visual Studio.
2. Update the SQL Server connection string in `DatabaseHelper.cs`.
3. Build and run the project.

---

## 🎓 Academic Project

Developed as an Object-Oriented Programming (OOP) semester project for the Institute of Data Science, University of Engineering and Technology (UET), Lahore.

---

## 👨‍💻 Team Members

* Muhammad Abdullah Shahid
* Muhammad Bilal Ijaz
* Ayman

### Supervisor

Ms. Sapna

---

## 📜 License

This project is developed for educational and academic purposes.
