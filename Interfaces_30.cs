using System;

// interface can contail everything a clas contain but only declaration but not implementation. they are implemented in class by inheritance
// not even console.writeline in interface. Interface cannot have fields.
// interface memebers are public by default and we cannot have explicit access modifier. 
// classes allow multiple interface implementation
// interface cannot inherit from abstract class
// multiple class inheritance can be achieved using interfaces. Implementing 2 interfaces in 2 classes and third class inheriting 2 interfaces
interface ICustomer
{
    void print();
}
interface ICustomer2 : ICustomer
    // interface inheritance is possible but the class that is implementing Icustomer2 must implement all members of Icustomer also
{
    void anotherprint();
}

public class Customer : ICustomer,ICustomer2
{
    public void anotherprint()
    {
        Console.WriteLine("I2 implementation");
    }

    public void print()
    {
        // signature should be same as in the interface
        Console.WriteLine("Interfece implementation");
    }
}



public class InterfaceClass
{
    public static void Main()
    {
        Customer C = new Customer();
        C.print();
        C.anotherprint();

        ICustomer IC = new Customer();
        // IC can be used only for print method not to anotherprint method

        // we cannot create instance of an interface,(since they are incomplete) but the reference variable can be pointed to the derived object 
    }
}