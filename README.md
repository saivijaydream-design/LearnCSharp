# 🏀 HoopsManager

A basketball league management system — built topic-by-topic while learning **C# / .NET 10** in detail, from console fundamentals to a full **ASP.NET Core Web API + EF Core** backend.

Part of the C# Academy learning series. Roadmap: `C:\Users\HP\CSharpAcademy\ROADMAP.md`.

## Solution layout
```
LearnCSharp.slnx
  src/HoopsManager.ConsoleApp   # C# language, OOP, LINQ, async (Quarters 1–3)
  src/HoopsManager.Core         # domain models + services (class library)
  src/HoopsManager.Data         # EF Core DbContext + migrations (Quarter 4)
  src/HoopsManager.Api          # ASP.NET Core Web API (Quarter 4)
  tests/HoopsManager.Tests      # xUnit
```

## Run
```bash
dotnet build LearnCSharp.slnx
dotnet run --project src/HoopsManager.ConsoleApp
```

## Requirements
- .NET SDK 10.x
