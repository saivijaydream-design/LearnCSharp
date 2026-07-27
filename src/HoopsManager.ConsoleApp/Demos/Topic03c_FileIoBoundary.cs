namespace HoopsManager.ConsoleApp.Demos;

// Does "saving a file" = unmanaged code? No — YOUR code is MANAGED, but it delegates
// to the unmanaged OS underneath. This demo shows both layers.
public static class Topic03c_FileIoBoundary
{
    public static void Run()
    {
        WriteLine("── Topic 3 extra: file I/O and the managed/unmanaged boundary ──");

        string path = Path.Combine(Path.GetTempPath(), "hoops_roster.txt");

        // (1) MANAGED code: you call a .NET BCL method. No pointers, no manual memory,
        //     the GC manages the string buffer. From YOUR side this is fully managed.
        File.WriteAllText(path, "Sai, Coach, Rocky");
        WriteLine($"[managed]   Wrote file via File.WriteAllText → {path}");

        // (2) Under the hood, only the OS KERNEL can touch the disk. So the BCL P/Invokes
        //     into unmanaged OS functions (CreateFile/WriteFile on Windows). The proof:
        //     a FileStream holds a SafeFileHandle — a managed wrapper around an UNMANAGED
        //     OS file handle (a raw resource the GC alone cannot release).
        using (FileStream fs = File.OpenRead(path))
        {
            IntPtr rawOsHandle = fs.SafeFileHandle.DangerousGetHandle();
            WriteLine($"[boundary]  FileStream holds an UNMANAGED OS file handle = {rawOsHandle}");
            WriteLine($"[managed]   Read back: \"{new StreamReader(fs).ReadToEnd()}\"");
        } // <- `using` disposes the FileStream, which RELEASES the unmanaged handle (Topic 41)

        File.Delete(path);
        WriteLine("[managed]   Cleaned up the temp file.");
    }
}
