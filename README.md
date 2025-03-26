# Human Resource Management System for ZapLink

**C# WinForms-based desktop application** for managing employee records, attendance, leaves, and reporting. Designed specifically for small-sized companies to streamline and digitalize HR tasks.

---

## 📌 Project Goals

-  Provide a user-friendly desktop UI for HR operations
-  Implement a layered architecture for scalability and maintainability
-  Connect with a local or remote SQL database for persistent data
-  Enable features like employee management, attendance tracking, and leave processing

---



## 📁 Project Structure

```plaintext
HRMSApp/
├──  Forms/
│    (Login)
│      ↓
│    DashboardForm (Main Menu)             # Each Form or Page
│       ├── EmployeeListForm.cs
│       ├── AddEmployeeForm.cs
│       ├── AttendanceForm.cs
│       ├── LeaveForm.cs
│       └── ReportsForm.cs
│
├── Models/               # C# classes for database
│   ├── Employee.cs
│   ├── User.cs
│   ├── Leave.cs
│   └── Attendance.cs
│
├── DataAccess/           # DB context and repositories
│   ├── HRMSDbContext.cs
│   └── Repositories/
│       ├── EmployeeRepo.cs
│       ├── LeaveRepo.cs
│       └── AttendanceRepo.cs
│
├── Services/             # Business logic layer
│   ├── EmployeeService.cs
│   ├── LeaveService.cs
│   └── AuthService.cs
│
├── Resources/            # Images, logos, etc.
├── Utils/                # Helper classes, constants, validators
├── App.config            # DB connection
└── Program.cs
```


## 🧩 Key Features

- 🔐 **Login Authentication**  
- 👨‍💼 **Employee Management** (Add, List, Update, Delete)
- 📅 **Attendance Tracking**
- 📝 **Leave Management**
- 📊 **Reports Generation**


---


