using System;
public abstract class CustomerAbstract
{
    public void print1()
    {
        Console.WriteLine("print");
    }
    public abstract void print();
    
    public int j;
}
// we cannot create instance of abstract class since we cannot use them without any implementation can only be used as base class
// provide implementation for the abstract methods or make the class abstract
// use override keyword to provide implementation
// abstract class cannt be sealed
// abstract class can have all members implemented
// abstract class member is private by default
// it can inherit from another abstract class or interface
public class CustClass:CustomerAbstract
{
    public override void print()
    {
        Console.WriteLine("print {0)",j);
    }
    public static void Main()
    {
        // 2 methods to call this meethos. 1. create instance of main class. 2. create instance of abstract clas referencing to main class
        CustClass CC = new CustClass();
        CC.print();

        CustomerAbstract CA = new CustClass();
        CA.print();
    }
}