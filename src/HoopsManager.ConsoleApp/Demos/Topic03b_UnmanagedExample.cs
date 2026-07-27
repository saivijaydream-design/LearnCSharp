using System.Runtime.InteropServices;

namespace HoopsManager.ConsoleApp.Demos;

// Two concrete ways managed C# reaches into UNMANAGED (non-CLR) code.
public static class Topic03b_UnmanagedExample
{
    // (1) P/Invoke: declare a NATIVE function that lives in the Windows OS library
    // kernel32.dll. This code is UNMANAGED — it runs directly on the OS, not the CLR.
    // The CLR "marshals" the call across the managed/unmanaged boundary for us.
    [DllImport("kernel32.dll")]
    private static extern uint GetTickCount();

    public static void Run()
    {
        WriteLine("── Topic 3 extra: unmanaged code ──");

        // Call the unmanaged OS function from managed C#:
        uint ms = GetTickCount();
        WriteLine($"[P/Invoke] kernel32!GetTickCount() = {ms} ms since the machine booted");

        // (2) Allocate UNMANAGED memory on the native heap. The Garbage Collector does
        // NOT know about or free this — YOU must free it manually (like C/C++ malloc/free).
        IntPtr ptr = Marshal.AllocHGlobal(64);                 // 64 bytes of unmanaged memory
        WriteLine($"[Marshal]  Allocated 64 unmanaged bytes at address {ptr}");

        Marshal.WriteInt32(ptr, 0, 99);                        // write directly to that address
        int value = Marshal.ReadInt32(ptr, 0);                 // read it back
        WriteLine($"[Marshal]  Wrote & read back the value {value}");

        Marshal.FreeHGlobal(ptr);                              // MUST free — no GC out here!
        WriteLine("[Marshal]  Freed it manually. (Managed C# objects never need this — the GC does it.)");
    }
}
