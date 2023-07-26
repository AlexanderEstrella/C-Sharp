
using System;

class Program
{
    static void Main()
    {
        // Variables for primitive data types
        int myInteger = 42;
        double myDouble = 3.14;
        float myFloat = 2.718f;
        bool myBoolean = true;
        char myCharacter = 'A';
        string myString1 = "I control text";
        string myString2 = "32"; // A whole number as a string

        // Convert myString2 to an integer using int.Parse()
        int myIntegerFromString = int.Parse(myString2);

        // Output for each variable
        Console.WriteLine("myInteger: " + myInteger);
        Console.WriteLine("myDouble: " + myDouble);
        Console.WriteLine("myFloat: " + myFloat);
        Console.WriteLine("myBoolean: " + myBoolean);
        Console.WriteLine("myCharacter: " + myCharacter);
        Console.WriteLine("myString1: " + myString1);
        Console.WriteLine("myString2: " + myString2);
        Console.WriteLine("myIntegerFromString: " + myIntegerFromString);
    }
}
