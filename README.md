# YallaDigital - User & Blog Management System

YallaDigital is a role-based ASP.NET Core MVC web application that supports user registration, login, and blog management. Admins can manage both users and blogs, while normal users can manage their own blog posts and comments.

## 🚀 Features

- 🔐 Authentication with ASP.NET Identity
- 🧑‍💼 Role-based access control (Admin/User)
- 📝 Blog creation, editing, deletion
- 💬 Commenting on blog posts
- 🧮 Admin dashboard with user & blog management
- 🌐 Razor Pages for frontend

---

## 📁 Project Structure

```
YallaDigital/
│
├── Controllers/
├── Models/
├── Views/
│   ├── Account/
│   ├── Blog/
│   └── Shared/
│
├── DTO/
├── wwwroot/
│   └── img/
├── screenshots/
│   ├── usecase-diagram.png
│   ├── class-diagram.png
│   └── auth-sequence-diagram.png
└── README.md
```

---

## 📊 Diagrams

### ✅ Use Case Diagram

![Use Case Diagram](screenshots/usecase.png)

### ✅ Class Diagram

![Class Diagram](screenshots/classdiagram.png)

### ✅ Authentication Sequence Diagram

![Authentication Sequence Diagram](screenshots/sequencediagram.png)

---

## 🛠️ Tech Stack

- **ASP.NET Core MVC**
- **Entity Framework Core**
- **Microsoft Identity**
- **Razor Views**
- **Bootstrap 5**

---

## 🧪 How to Run

1. Clone the repo:
   ```bash
   git clone https://github.com/louayamor/YallaDigital.git
   ```

2. Update the database:
   ```bash
   dotnet ef database update
   ```

3. Run the app:
   ```bash
   dotnet run
   ```

---

## 👤 Roles

| Role  | Capabilities                 |
|-------|------------------------------|
| Admin | Manage users and blogs       |
| User  | Manage their own blogs only  |

---

## ✍️ Author

- [@louayamor](https://github.com/louayamor)

---

## 📄 License

This project is licensed under the MIT License.
