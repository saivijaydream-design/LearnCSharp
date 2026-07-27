using HoopsManager.ConsoleApp.Intro;   // `using` DIRECTIVE: bring the Intro namespace into scope

namespace HoopsManager.ConsoleApp.Demos;

public static class Topic02_ProgramAnatomy
{
    // `args` is handed in from Program.cs — the entry point (the hidden Main).
    public static void Run(string[] args)
    {
        WriteLine("── Topic 2: Program Anatomy ──");

        // Greeter lives in namespace HoopsManager.ConsoleApp.Intro (see Intro/Greeter.cs).
        // We can call it by short name because of the `using` directive above.
        WriteLine(Greeter.Welcome("Sai"));

        // Command-line arguments flow from top-level statements' hidden Main(string[] args).
        WriteLine($"Command-line args received: {args.Length}");
        for (int i = 0; i < args.Length; i++)
            WriteLine($"  args[{i}] = {args[i]}");

        // `WriteLine` (not Console.WriteLine) works thanks to `global using static System.Console;`
        WriteLine("Note: 'WriteLine' has no 'Console.' prefix — a global using static (GlobalUsings.cs).");
    }
}
