// ── Topic 2: Program anatomy ─────────────────────────────────────────────────
// These lines are TOP-LEVEL STATEMENTS. The C# compiler secretly wraps them into
// a hidden `Program` class with a `static Main(string[] args)` method — the real
// entry point every C# program has. Inside top-level statements you get `args`
// (command-line arguments) and can even use `await` for free.

using HoopsManager.ConsoleApp.Intro;   // a `using` DIRECTIVE: bring a namespace into scope

WriteLine("🏀 Welcome to HoopsManager!");      // WriteLine, not Console.WriteLine — see GlobalUsings.cs
WriteLine(Greeter.Welcome("Coach"));           // Greeter lives in the Intro namespace imported above

WriteLine($"Command-line arguments received: {args.Length}");
