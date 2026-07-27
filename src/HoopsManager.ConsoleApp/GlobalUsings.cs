// A `global using` applies to EVERY file in this project — no need to repeat it
// per file. `using static` imports a type's STATIC members so you can call them
// unqualified. Combined here so `WriteLine(...)` works without the `Console.` prefix.
global using static System.Console;

// (The project also has <ImplicitUsings>enable</ImplicitUsings> in the .csproj,
//  which auto-adds global usings for System, System.Collections.Generic, System.Linq, etc.)
