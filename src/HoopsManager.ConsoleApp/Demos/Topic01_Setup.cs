namespace HoopsManager.ConsoleApp.Demos;

// Topic 1 demo: the "Hello, World" of HoopsManager — proves the solution builds
// and runs, and confirms the .NET runtime we're on. This is our setup checkpoint.
public static class Topic01_Setup
{
    public static void Run()
    {
        WriteLine("── Topic 1: Setup ──");
        WriteLine("Solution built and running.");
        WriteLine($"Runtime: .NET {Environment.Version}");         // e.g. 10.0.7
        WriteLine($"Machine: {Environment.MachineName}");
        WriteLine("Court is ready, Coach. Tip-off! 🏀");
    }
}
