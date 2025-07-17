# 🛍️ Brands Shop - Blazor WebAssembly + .NET API + MySQL

A fully functional online shop demo built using **Blazor WebAssembly** and **.NET 8 Web API**, connected to a **MySQL database**, featuring real-time product browsing by brand, detailed product view, a persistent shopping cart, and a filterable orders page.

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
- View a table of orders with:
  - Order ID
  - Customer Name
  - Order Date
  - Total Amount
- **Filter orders by date range** using date pickers
- **Search orders** by customer name
- **Sort orders** by columns (e.g., date, amount)
- **Pagination** support for large datasets
- Data is fetched dynamically from the API

---

## 🧱 Technologies Used

- 🌐 **Blazor WebAssembly** for the frontend SPA
- ⚙️ **ASP.NET Core Web API** (NET 8)
- 🗄️ **MySQL** database with **Entity Framework Core**
- 🎨 Bootstrap for responsive UI styling
- 🔌 HTTP Client for API communication

---

## 📁 Project Structure

- `BrandsShope/` – Blazor WebAssembly frontend
- `BrandsShops.Api/` – ASP.NET Core backend with EF Core
- `MySQL` – for storing products, brands, cart items, and orders

---

## 🔧 Setup Instructions

1. **Clone the repo**
2. Update `appsettings.json` with your MySQL connection string
3. Run migrations:
   ```bash
   dotnet ef database update
