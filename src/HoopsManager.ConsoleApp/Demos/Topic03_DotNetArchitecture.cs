using System.Reflection;
using System.Runtime.InteropServices;

namespace HoopsManager.ConsoleApp.Demos;

// Topic 3 demo: inspect the .NET machinery that is running THIS program.
public static class Topic03_DotNetArchitecture
{
    public static void Run()
    {
        WriteLine("── Topic 3: .NET Architecture ──");

        // The RUNTIME (CLR) currently executing our managed code:
        WriteLine($"Runtime (CLR)   : {RuntimeInformation.FrameworkDescription}");   // e.g. ".NET 10.0.x"
        WriteLine($"OS              : {RuntimeInformation.OSDescription}");
        WriteLine($"CPU architecture: {RuntimeInformation.ProcessArchitecture}");     // e.g. X64 / Arm64

        // Our compiled program is an ASSEMBLY — the unit of deployment (.dll/.exe)
        // that contains IL + metadata. The CLR loads and runs it.
        Assembly asm = Assembly.GetExecutingAssembly();
        AssemblyName name = asm.GetName();
        WriteLine($"This assembly   : {name.Name}  v{name.Version}");
        WriteLine($"On disk at      : {asm.Location}");

        // Types live inside the assembly's metadata; the CLR loads them on demand.
        WriteLine($"Types compiled in this assembly: {asm.GetTypes().Length}");
    }
}
