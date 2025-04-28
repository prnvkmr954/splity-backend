# 📄 Splity Backend

Splity is a Splitwise-inspired expense-sharing app backend, built with modern software practices:  
- .NET 8  
- Clean Architecture  
- CQRS Pattern  
- MediatR for In-Process Messaging  
- ASP.NET Core Identity for User Management  
- JWT Authentication  
- PostgreSQL as Database

## 🏗️ Project Structure


✅ Separation of Concerns  
✅ Scalable and Testable  
✅ Dependency Injection across all layers

## 🚀 Tech Stack

| Tech | Usage |
|:---|:---|
| .NET 8 | Core Framework |
| ASP.NET Core Identity | User Authentication and Authorization |
| Entity Framework Core | ORM |
| PostgreSQL | Relational Database |
| MediatR | CQRS + Clean Messaging |
| JWT Bearer Tokens | Secure Authentication |
| FluentValidation | Request Validation |
| AutoMapper | DTO Mapping |

## 🛠️ Features Implemented

- [x] User Registration (using Identity)
- [x] User Authentication (JWT)
- [x] Secure Password Hashing
- [x] Create and Join Groups
- [x] Add Expenses inside Groups
- [x] Settle Expenses (Settlement entity)
- [x] Notifications (basic structure ready)

🚧 (More features like Group balances, expense summaries coming soon.)

## 🔥 How to Run Locally

### 1. Clone the Repository
```bash
git clone https://github.com/your-username/splity-backend.git
cd splity-backend
