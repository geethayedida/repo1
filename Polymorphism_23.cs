using System;

public class ClassEmp
{
    public string _firstname = "FN";
    public string _lastname = "LN";

    public virtual void printfullname()
    {
        Console.WriteLine("Fullname is {0}", _firstname + _lastname);
    }

}

public class PartTime : ClassEmp
{
    public override void printfullname()
    {
        Console.WriteLine("Fullname is {0}", _firstname + _lastname + "part time");
    }
}

public class FullTime : ClassEmp
{
    public override void printfullname()
    {
        Console.WriteLine("Fullname is {0}", _firstname + _lastname + "full time");
    }
}

public class TempTime : ClassEmp
{
    public override void printfullname()
    {
        Console.WriteLine("Fullname is {0}", _firstname + _lastname + "temp time");
    }
}

public class Implementation
{
    public static void Main()
    {
        ClassEmp[] employee = new ClassEmp[4];
        employee[0] = new ClassEmp();
        employee[1] = new PartTime();
        employee[2] = new FullTime();
        employee[3] = new TempTime();

        //created an array of base class and to each element we assigned a different type of base class object 

        // now create an array to loop through each base class object

        // since we have a base class reference variable referenceing to child classses, though we have the method in child overriding parent class
        //the base class method is called 

        // the new keyword is used to hide the base class but our intension is to override the definition provided by base class, use override
        // for this mark the parent method virtual
        // this indicated the child class that it can override the parent class if it wishes to do so 

        //though the ref variable is of type parent, the runtime checks the type of object, then it invokes the overriden method in the child class
        // this is called polymorphism

        // Polymorphism enables us to invoke the derived class methods using base class reference variables at run time

        // if the child class do not have any implementation overriding the parent class, then the parent class method is executed
         
        foreach(ClassEmp E in employee)
        {
            E.printfullname();
        }


    }
}