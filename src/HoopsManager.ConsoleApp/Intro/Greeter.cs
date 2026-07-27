// File-scoped namespace (C# 10+): declares ONE namespace for the whole file with a
// semicolon — no extra braces or indentation. Namespaces organize types and prevent
// name clashes (two libraries can each have a `Greeter` in different namespaces).
namespace HoopsManager.ConsoleApp.Intro;

// This class is referenced from Program.cs via `using HoopsManager.ConsoleApp.Intro;`.
public static class Greeter
{
    // Expression-bodied method (=>): a concise form for a one-line method body.
    public static string Welcome(string coachName) =>
        $"Tip-off! Coach {coachName} is on the court. 🏀";
}
