namespace HoopsManager.ConsoleApp.Demos;

public static class Topic05_StackHeap
{
    // A STRUCT is a VALUE type — copied by value.
    struct ScoreValue { public int Points; }

    // A CLASS is a REFERENCE type — the variable holds a reference (pointer) to a heap object.
    class ScoreRef { public int Points; }

    public static void Run()
    {
        WriteLine("── Topic 5: Stack vs Heap, Value vs Reference, Boxing ──");

        // ── Value type: assignment COPIES the whole value ──
        ScoreValue a = new() { Points = 10 };
        ScoreValue b = a;            // b is a FULL COPY of a
        b.Points = 99;
        WriteLine($"[value] a.Points={a.Points}, b.Points={b.Points}  → a unchanged (independent copy)");

        // ── Reference type: assignment COPIES THE REFERENCE (both point to the SAME object) ──
        ScoreRef x = new() { Points = 10 };
        ScoreRef y = x;              // y refers to the SAME heap object as x
        y.Points = 99;
        WriteLine($"[ref]   x.Points={x.Points}, y.Points={y.Points}  → both changed (shared object)");

        // ── Same story for method parameters ──
        var v = new ScoreValue { Points = 5 };
        MutateValue(v);              // receives a COPY
        WriteLine($"[param value] after call: {v.Points}  (unchanged)");

        var r = new ScoreRef { Points = 5 };
        MutateRef(r);                // receives the reference to the same object
        WriteLine($"[param ref]   after call: {r.Points}  (changed)");

        // ── BOXING: putting a value type into an `object` copies it onto the HEAP ──
        int number = 42;             // lives on the stack (a local value type)
        object boxed = number;       // BOXING → allocates a heap object holding a copy of 42
        WriteLine($"[boxing]   boxed = {boxed}  (the int was copied onto the heap)");

        // ── UNBOXING: pulling the value type back out (must cast to the EXACT type) ──
        int unboxed = (int)boxed;    // UNBOXING
        WriteLine($"[unboxing] unboxed = {unboxed}");

        // The boxed copy is independent of the original:
        number = 100;
        WriteLine($"[boxing]   original now {number}, boxed still {boxed}  (separate copy)");
    }

    static void MutateValue(ScoreValue s) => s.Points = 999;  // mutates a COPY → caller unaffected
    static void MutateRef(ScoreRef s) => s.Points = 999;      // mutates the shared object → caller sees it
}
