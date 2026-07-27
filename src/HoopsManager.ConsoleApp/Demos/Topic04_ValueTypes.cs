namespace HoopsManager.ConsoleApp.Demos;

// Topic 4: the built-in value types and the LITERALS used to write them.
public static class Topic04_ValueTypes
{
    public static void Run()
    {
        WriteLine("── Topic 4: Value Types & Literals ──");

        // ── Integer family (whole numbers) — differ by size (bits) and sign ──
        byte jersey        = 23;                 //  8-bit unsigned: 0..255
        short seasonWins    = 1_200;             // 16-bit: '_' is just a digit separator for readability
        int pointsScored    = 2_000_000;         // 32-bit: the DEFAULT integer type
        long franchiseValue = 5_000_000_000L;    // 64-bit: 'L' suffix marks a long literal

        WriteLine($"byte  jersey         = {jersey}   (range {byte.MinValue}..{byte.MaxValue})");
        WriteLine($"short seasonWins     = {seasonWins}   (range {short.MinValue}..{short.MaxValue})");
        WriteLine($"int   pointsScored   = {pointsScored:N0}   (int max {int.MaxValue:N0})");
        WriteLine($"long  franchiseValue = {franchiseValue:N0}");

        // ── Floating-point family (fractional numbers) ──
        float freeThrowPct = 0.885f;   // 'f' suffix = float  (~7 significant digits)
        double avgPoints   = 27.35;    // no suffix on a decimal literal = double (~15-16 digits)
        WriteLine($"float  freeThrowPct  = {freeThrowPct}");
        WriteLine($"double avgPoints     = {avgPoints}");

        // ── THE classic interview trap: double is BINARY floating point ──
        double d = 0.1 + 0.2;
        WriteLine($"double 0.1 + 0.2     = {d}   <-- NOT exactly 0.3 (binary rounding error!)");

        // decimal is BASE-10 floating point → exact for money. 'm' suffix (m = money/decimal).
        decimal money  = 0.1m + 0.2m;
        decimal salary = 45_000_000.50m;
        WriteLine($"decimal 0.1 + 0.2    = {money}   <-- exact");
        WriteLine($"decimal salary       = {salary:C}");

        // ── bool: true/false ONLY (no implicit 0/1 like C/C++) ──
        bool isChampion = true;
        WriteLine($"bool  isChampion     = {isChampion}");

        // ── char: a SINGLE 16-bit Unicode character in single quotes (a number underneath) ──
        char position = 'G';
        WriteLine($"char  position       = '{position}'  (Unicode code point = {(int)position})");

        // ── Other literal forms ──
        int hex = 0xFF;        // hexadecimal literal  = 255
        int bin = 0b1010;      // binary literal       = 10
        WriteLine($"literals: 0xFF = {hex}, 0b1010 = {bin}");
    }
}
