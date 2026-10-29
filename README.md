# StaySpace — Hostel Management System (ASP.NET Core MVC)

A simple student mini-project for Visual Studio using ASP.NET Core MVC and .NET 8. No database or external NuGet packages are required.

## Features
- Dashboard with live student count, room count, occupied rooms, available beds and recent students.
- Add, edit, search and delete student records.
- Room directory with capacity, occupancy status and monthly fee.
- Basic validation, duplicate enrollment check and room-capacity checks.
- Responsive sidebar layout and dashboard styling.
- In-memory storage: data is retained only while the app is running and resets after restart.

## Run in Visual Studio
1. Extract the ZIP file.
2. Open `HostelManagementMVC.csproj` in Visual Studio 2022 (with the ASP.NET and web development workload) or a compatible Visual Studio version.
3. Ensure the .NET 8 SDK is installed.
4. Press **F5** or **Ctrl+F5**.

Alternatively, from this folder run:
```bash
dotnet restore
dotnet run
```
Open the localhost URL shown in the terminal.

## Project structure
- `Controllers/` — Dashboard, Students and Rooms controllers
- `Models/` — Student and Room models
- `Services/HostelStore.cs` — in-memory data store
- `Views/` — Razor pages
- `wwwroot/css/site.css` — UI styling

This is a learning/demo project, not a production-ready system. For persistent storage, connect a database and add authentication/authorization before real use.
