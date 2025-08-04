# 🎓 University Training Tasks - Brands Shop Project

This repository contains practical training tasks for university coursework, including a full demo project for an online shop built with **Blazor WebAssembly**, **.NET 8 Web API**, and **MySQL**.  
The project demonstrates real-world concepts such as database integration, repository pattern, unit of work, and API development.

---

## 🚀 Features

### ✅ Product & Brand Management
- View all **brands** from the database
- View **products by brand**
- View **product details** in a modal
- Products include images, descriptions, and prices
- Data loaded from a **real MySQL database** via Web API

### 🛒 Shopping Cart (Database-Backed)
- Add products to the cart (saved in MySQL)
- Update product quantity
- Remove products from the cart
- Cart persists across sessions (no authentication required)

### 📦 Orders Page
- View a table of orders with filtering, searching, sorting, and pagination

### 🎓 Student Management (Training Task)
- **Student** entity with properties like FullName, Email, Age, EnrollmentDate, Grade
- Enforced data validation using **Data Annotations**
- Implemented **Repository Pattern** and **Unit of Work** for Student data access
- CRUD operations exposed via Web API endpoints

---

## 🧱 Technologies Used

- 🌐 **Blazor WebAssembly** for frontend SPA
- ⚙️ **ASP.NET Core Web API** (.NET 8) backend
- 🗄️ **MySQL** with **Entity Framework Core** ORM
- 🎨 Bootstrap for responsive UI
- 🔌 HTTP Client for API communication
- 📦 **Repository Pattern** and **Unit of Work** design patterns for clean architecture

---

## 📁 Project Structure

- `BrandsShope/` – Blazor WebAssembly frontend
- `BrandsShops.Api/` – ASP.NET Core Web API backend with EF Core, repositories, and Unit of Work implementation
- `MySQL` – MySQL database storing products, brands, cart items, orders, and students

---

## 🔧 Setup Instructions

1. **Clone the repo**
   git clone https://github.com/yourusername/UniversityTrainingTasks.git

2. Update appsettings.json with your MySQL connection string.

3. Apply migrations to create/update the database schema:
   dotnet ef database update

4. Run the API project and frontend, then navigate to Swagger UI (/swagger) to test API endpoints.

---

## 📬 API Endpoints Highlights

- /api/products – Manage products
- /api/brands – Manage brands
- /api/cart – Shopping cart operations
- /api/orders – Orders retrieval with filtering and sorting
- /api/students – Manage student records with repository pattern

---

This project is part of university practical training tasks demonstrating modern .NET web development.

