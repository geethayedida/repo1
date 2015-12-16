using System;
interface INewInterface1
{
    void InterfaceMethod();
  
}
interface INewInterface2
{
    void InterfaceMethod();

}
public class InterfaceImplement : INewInterface1, INewInterface2
{
    // to make this the default access modifier
    public void InterfaceMethod()
    {
        Console.WriteLine("Interface1 method");
    }
    // access modifier is not allowed in explicit interface implementation
    void INewInterface2.InterfaceMethod()
    {
        Console.WriteLine("Interface2 method");
    }
    public static void Main()
    {
        InterfaceImplement ip = new InterfaceImplement();
        ip.InterfaceMethod();
        ((INewInterface2)ip).InterfaceMethod();

        // if a class is inheriting 2 interfaces which have same method names, then we sue explicit interface . so know which method we are calling
        // typecast
        // during explicit implementation, we cannot implement with classname.methodname(); it shouldbe ((interfacename).classname).methodname();

        INewInterface1 i1 = new InterfaceImplement();
        INewInterface2 i2 = new InterfaceImplement();

        i1.InterfaceMethod();
        i2.InterfaceMethod();
    }

}