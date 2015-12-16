using System;
// structures -value type classes, interfaces - reference types
// type safe funtion pointer -- it points to a function
// it is type safe because the signature in delegate and the method should match

public delegate void HelloDelegate(string Message);
// syntax is similar to method- acess modifier, return type, name of delegate, parameter
// this delegate can point to any funtion that has a void return type and takes in a sring parameter
// to point to a particular method we nned an object of delegate pointing to that method


public class DelegateClass
{
    public static void Main()
    {
        HelloDelegate del = new HelloDelegate(Hello);
        del("Confusing delegate");
    }

    public static void Hello(string fMessage)
    {
        Console.WriteLine(fMessage);
    }
}