# Hospital Management System

## Project Overview
This is a desktop-based **Hospital Management System (HMS)** developed using **C#** with **Windows Forms** for the graphical user interface and **Microsoft SQL Server** for database management. The application is designed to streamline and manage various hospital operations, providing a secure and efficient platform for both administrative staff and receptionists.

---

## Key Features
The system supports two main user roles: **Admin** and **Receptionist**, each with specific functionalities.

### Admin Features
- **Manage Receptionists**: Admins can add, view, edit, and delete receptionist accounts.
- **Manage Facilities**: Admins can manage hospital resources such as departments, doctors, tests, and cabins.
- **Monitor Activity**: Admins can view all registered patients, including historical data, and delete patient records as needed.

### Receptionist Features
- **Patient Management**: Register new patients with general information (name, age, gender, etc.).
- **Billing and Services**: Assign tests, generate invoices, and handle patient billing (subtotal, VAT, discounts, total).
- **Patient Admission/Discharge**: Admit patients by assigning doctors and cabins; discharge patients with final receipts.
- **Appointment Scheduling**: Schedule appointments with doctors, auto-generate serial numbers, and view existing appointments.

---

## Technologies Used
- **Programming Language**: C#
- **User Interface**: Windows Forms
- **Database**: Microsoft SQL Server
- **Database Integration**: ADO.NET (or similar C# database connectivity library)

---

## Database Schema
The database is designed with a normalized schema for data integrity and efficient management. Key tables and their purposes:

- **LoginUsers**: Stores user credentials and roles (Admin, Receptionist).
- **Receptionists**: Contains detailed information about reception staff.
- **Departments**: Manages different hospital departments.
- **Doctors**: Stores information about doctors.
- **Cabins**: Manages cabin details including availability and pricing.
- **Patients**: Holds patient demographic information and admission details.
- **Appointments**: Tracks scheduled appointments for patients with doctors.
- **PatientTests**: Links patients to assigned tests.
- **Tests**: Lists all available tests and their prices.
- **PatientBills**: Stores all billing and invoice information for patients.

---

## Getting Started
To run this project, you will need:
- **Microsoft Visual Studio**
- **Microsoft SQL Server Management Studio**

### Setup Instructions
1. **Clone the repository:**
```bash
git clone https://github.com/dev-mehedi-github/Hospital-management-System.git
```

2. **Restore the Database:**
- Open SQL Server Management Studio.
- Execute the SQL queries provided in the project to create the database schema.

3. **Configure the Connection String:**
- Open the project in Visual Studio.
- Update the database connection string in `App.config` to point to your SQL Server instance.

4. **Run the Application:**
- Build and run the project from Visual Studio.

---

## Credits
This project was developed for the **CSC2210: Object Oriented Programming 2** course at the **American International University-Bangladesh (AIUB)**.

**Supervised by:**
Md. Hasibul Hasan  
Assistant Professor, Department of Computer Science

**Developed by:**
Hasan, Mehedi  
[GitHub Repository](https://github.com/dev-mehedi-github/Hospital-management-System.git)
