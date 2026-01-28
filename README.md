# Todo Backend API

**Task Management System (.NET Core, CQRS, GraphQL)**

## Description
Backend API for a Todo app built with **.NET Core**.  
Implements **CQRS** and **GraphQL** for clean, scalable architecture. Swagger is included for API testing.

## Features
- Query and manage tasks via **GraphQL**
- GraphQL endpoint: `/graphql`  
- **Swagger UI** for easy API exploration
- - Swagger UI: `/swagger`  
- Clean architecture, SOLID principles
- CQRS pattern with MediatR  
- Clean, scalable, and maintainable architecture    

## Running Locally
```bash
# Clone the repo
git clone https://github.com/USERNAME/todo-backend.git
cd todo-backend

# Restore dependencies
dotnet restore

# Run the backend
dotnet run
