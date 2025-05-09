using System;

namespace Day1___Boolean_Expressions;

public static class Expressions
{
    /// <summary>
    /// Outputs
    /// True
    /// False
    /// False
    /// True
    /// </summary>
    public static void CheckEqualityOperator()
    {
        string value1 = "a";
        string value2 = "a ";

        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
        // Console.WriteLine("a" == "a");
        // Console.WriteLine("a" == "A");
        // Console.WriteLine(1 == 2);

        // string myValue = "a";
        // Console.WriteLine(myValue == "a");
    }

    /// <summary>
    /// Outputs
    /// False
    /// True
    /// True
    /// False
    /// </summary>
    public static void CheckInEqualityOperator()
    {
        Console.WriteLine("a" != "a");
        Console.WriteLine("a" != "A");
        Console.WriteLine(1 != 2);

        string myValue = "a";
        Console.WriteLine(myValue != "a");
    }

    /// <summary>
    /// Outputs
    /// False
    /// True
    /// True
    /// True
    /// </summary>
    public static void CheckComparisonOperator()
    {
        Console.WriteLine(1 > 2);
        Console.WriteLine(1 < 2);
        Console.WriteLine(1 >= 1);
        Console.WriteLine(1 <= 1);
    }

    /// <summary>
    /// Check if method contains a substring
    /// </summary>
    public static void CheckBooleanMethods()
    {
        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));
    }
}