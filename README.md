# E-Commerce Full Stack Application

A modern full-stack e-commerce web application built with **ASP.NET Core MVC**, **Entity Framework Core**, **SQLite**, and **Stripe** for secure online payments.

---

# About the Developer

**Sanjay Kumar**

Full-Stack Developer passionate about building scalable, responsive, and user-friendly web applications.

### Skills

* ASP.NET Core MVC
* C#
* Entity Framework Core
* SQL / SQLite
* JavaScript (ES6+)
* React.js
* HTML5 & CSS3
* Bootstrap
* Git & GitHub

---

# Project Features

* User Registration & Login
* Role-Based Authorization
* Product Management
* Category Management
* Shopping Cart
* Wishlist
* Checkout System
* Stripe Payment Integration
* Order Management
* Email Notifications
* Admin Dashboard
* Responsive Design
* Entity Framework Core
* SQLite Database

---

# Tech Stack

### Backend

* ASP.NET Core MVC
* C#
* Entity Framework Core

### Frontend

* HTML5
* CSS3
* Bootstrap
* JavaScript

### Database

* SQLite

### Authentication

* ASP.NET Core Identity

### Payment Gateway

* Stripe

### Email Service

* SMTP (Gmail)

---

# Folder Structure

```text
Controllers/
Models/
Views/
Data/
Services/
Repositories/
wwwroot/
Migrations/
appsettings.json
Program.cs
```

---

# Prerequisites

Before running the project, install:

* .NET SDK 8.0 (or the version used by the project)
* Visual Studio 2022 or Visual Studio Code
* Git

---

# Installation

## 1. Clone the repository

```bash
git clone https://github.com/SnzuGill/ecommerce_fullstack.git
```

## 2. Navigate to the project

```bash
cd ecommerce_fullstack
```

## 3. Restore packages

```bash
dotnet restore
```

## 4. Configure application settings

Open `appsettings.json` and replace the placeholder values with your own credentials.

### Stripe

```json
"StripeSetting": {
  "PublishableKey": "YOUR_STRIPE_PUBLISHABLE_KEY",
  "SecretKey": "YOUR_STRIPE_SECRET_KEY"
}
```

### Gmail SMTP

```json
"EmailSettings": {
  "UsernameEmail": "YOUR_EMAIL@gmail.com",
  "UsernamePassword": "YOUR_GMAIL_APP_PASSWORD"
}
```

---

## 5. Apply database migrations

```bash
dotnet ef database update
```

If the database does not exist, it will be created automatically.

---

## 6. Run the application

```bash
dotnet run
```

or press **F5** in Visual Studio.

The application will be available at:

```
https://localhost:xxxx
```

or

```
http://localhost:xxxx
```

---

# Default Functionality

Users can:

* Register
* Log in
* Browse products
* Add items to cart
* Manage wishlist
* Place orders
* Pay securely using Stripe
* Receive order confirmation emails

Administrators can:

* Manage products
* Manage categories
* View customer orders
* Manage users
* Update order status

---

# Security Notes

For security reasons, never commit:

* Stripe Secret Keys
* Gmail App Passwords
* API Keys
* Database passwords
* Any sensitive credentials

Store sensitive values using **ASP.NET Core User Secrets**, environment variables, or your deployment platform's secret management.

---

# Future Improvements

* Product Reviews & Ratings
* Coupons & Discount Codes
* Inventory Management
* Product Search & Filters
* Order Tracking
* Dashboard Analytics
* REST API
* JWT Authentication
* Docker Support
* Cloud Deployment

---

# License

This project is intended for educational and portfolio purposes.

---

# Contact

**Sanjay Kumar**

GitHub: https://github.com/SnzuGill

Feel free to explore the project, report issues, or suggest improvements.
