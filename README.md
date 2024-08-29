# TranslationProjectManagement

# Project Management Web API

This is a .NET 8 Web API for managing projects and tasks. It allows project managers to create and manage projects, add tasks, assign them to team members, and track project statuses.
 Prerequisites
Before you begin, ensure you have met the following requirements:

- **.NET SDK 8.0**: Install the .NET 8.0 SDK from the official [.NET downloads page](https://dotnet.microsoft.com/download/dotnet/8.0).
- **Entity Framework Core**: Used for database interactions.
- **SQL Server or SQLite**: Depending on your preference, ensure you have an instance of SQL Server or SQLite running.
- **Visual Studio 2022 or VS Code**: (Optional) For development and debugging purposes.

## Getting Started

### Clone the Repository

To get a local copy of the repository, run the following command:

```bash
git clone https://github.com/your-username/project-management-api.git
cd project-management-api

Database Setup: Update the appsettings.json file with your SQL Server connection string:
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server;Database=ProjectManagementDb;User Id=your_user;Password=your_password;"
}
Run the Entity Framework migrations to create the database schema:
dotnet ef database update

Run the application in your local. Following end point you will be able to view:
API Endpoints
The API provides the following endpoints:
•	Projects
o	GET /api/projects: Retrieve all projects.
o	GET /api/projects/{id}: Retrieve a specific project by ID.
o	POST /api/projects: Create a new project.
o	PUT /api/projects/{id}: Update an existing project.
o	DELETE /api/projects/{id}: Delete a project.
•	Tasks
o	GET /api/projects/{projectId}/tasks: Retrieve all tasks for a specific project.
o	POST /api/projects/{projectId}/tasks: Create a new task under a specific project.
o	PUT /api/tasks/{id}: Update a specific task.
o	DELETE /api/tasks/{id}: Delete a specific task.


