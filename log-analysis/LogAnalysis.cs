using System.Runtime.InteropServices;
using Microsoft.Win32;


public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string delimiter) =>
        str[(str.IndexOf(delimiter) + 1)..].Trim();

    public static string SubstringBetween(this string str, string delimiter1, string delimiter2) =>
        str[(str.IndexOf(delimiter1) + 1)..str.IndexOf(delimiter2)];

    public static string Message(this string str) => str.SubstringAfter(":");
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}
//Remember: Extension method's first parameter is the object to extend. It is not a typical parameter. 
//What makes a method an extension method is the "this" keyword in the first parameter
//and followed by the type of the object to extend
//and object parameter."