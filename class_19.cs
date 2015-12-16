using System;

class CustomerClass
{
    String _firstname;
    String _lastname;

    public CustomerClass() : this("no name", "nothing") { }

    // to initialize fields in a class we need a constructor
    // constructor has same name as class name
    // constructor doesnot return a value
    // constructor can take parameters

    public CustomerClass(string firstname, string lastname)
    {
        _firstname = firstname;
        _lastname = lastname;
    }

    public void CustomerClassMethod()
    {
        Console.WriteLine("Firstname is {0} ", this._firstname + " " + this._lastname);

        // this keyword refers to an object of this class
    }
}
class Program
{
    public static void Main()
    {
        CustomerClass c1 = new CustomerClass("Geetha", "Yedida");
        c1.CustomerClassMethod();

        // a default constructor can be created with no parameters being passed

        CustomerClass c2 = new CustomerClass();
        c2.CustomerClassMethod();

        // this is called constructor overloading with varying parameters or type of fields passing 
    }

}