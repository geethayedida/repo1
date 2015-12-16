using System;

class MethodOverloading
{
    public static void Main()
    {
        MethodOverloading.add(10,20);
        MethodOverloading.add(10, 20, 30);
    }

    public static void add(int FN, int SN)
    {
        Console.WriteLine("Sum is {0}", FN + SN);
    }
    // Function overloading or method overloading are used interchangebly. A class with multiple method names with same name and different signature
    // name + type of parameter + number of parameters + kind of Parameters = signature
    // signature does not include return type and params keyword

    // methods can also be overloaded based on the TYPES of parameters
    public static void add(float FN, int SN)
    {
        Console.WriteLine("Sum is {0}", FN + SN);

    }

    // we can overload a function based on the NUMBER of paramenters 
    public static void add(int FN, int SN, int TN)
    {
        Console.WriteLine("Sum is {0}", FN + SN + TN);

    }

    // methods can also be overloaded based on the KINDS of parameters
    public static void add(int FN, int SN, out int TN)
    {
        Console.WriteLine("Sum is {0}", FN + SN );
        TN = FN + SN; 
    }
}