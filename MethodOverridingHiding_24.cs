using System;


public class BaseClass
{
    public virtual void Message()
    {
        Console.WriteLine("User base output");
    }
}

public class DerivedClass : BaseClass
{
    public new void Message()
    {
        Console.WriteLine("User Derived output");
    }
}

public class MethodHidingOverloading
{
    public static void Main()
    {
        BaseClass BC = new DerivedClass();
        //the base class referencing variable is pointing to a chld class object. so, at run time the base class reference variable will figure 
        //out what type of object is there and if that object has overriden the virtual method, then the overriden method is called

        BC.Message();

        // this is called method overriding, a base class pointing to child class will invoke child class

        // method hiding is done using new keyword, where derived class is hiding the base class

        // when new keyword is used, the hidden method in base class is called. When override is used, the overridden method in child class is called

        DerivedClass D = new DerivedClass();
        D.Message();

        // this calls the child class method when new keyword is used

    }
}