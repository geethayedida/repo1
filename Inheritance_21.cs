using System;

public class Employee
{
    public string firstname;
    // making fields public is not at all suggested in real time instead use properties with private access modifier
    public string _lastname;
    public string _email;

    public void PrintFullName()
    {
        Console.WriteLine("{0},{1}", firstname, _lastname);
    }
}

public class FullTimeEmployee : Employee
{
    // inheritance allows code reuse-- primary pilar of oops
    // child clas is the specialization of parent class
    // use sealed keyword to prevent a class from being inherited by another class
    public float YearlySalary;
}

public class A: FullTimeEmployee
{
    // multi level inheritance is possible , but multiple class inheritance is not possible
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

class EmployeeClass
{
    public static void Main()
    {
        // whenever we creare an instance of a child class, we automatically create an instance of the base class
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.firstname = "Geetha";
        FTE._lastname = "Yedida";
        FTE.PrintFullName();
        FTE.YearlySalary = 15000F;

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.firstname = "Gee";
        PTE._lastname = "Yed";
        PTE.HourlyRate = 13;
        PTE.PrintFullName();

        A A1 = new A();
        A1.YearlySalary = 1200;
        A1.PrintFullName();

        // it is also possible for the derived class constructor to control which of the constructors in the parent class is called. if the parent
        // class has more than one constructor.
    }
}
