using Microsoft.Win32;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str)
    {
        return str[(str.IndexOf(":") + 1)..].Trim();
    }

    
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    
    // TODO: define the 'Message()' extension method on the `string` type

    // TODO: define the 'LogLevel()' extension method on the `string` type
}