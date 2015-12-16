using System;

public class BaseEmployee
{
    public string _lastname;
    public string _firstname;

    public void FullName()
    {
        Console.WriteLine("Fullname is {0} ", this._lastname + " "+ this._firstname);
    }
}

public class PartTimeEmp: BaseEmployee
{
    // if you want to hide the base contractor- use new keyword

    public new void FullName()
    {
        Console.WriteLine("Fullname is {0} ", this._lastname + " " + this._firstname + "-contractor");
        // but if we want to use the base class constructor, use base keyword

        base.FullName();
    }
}

public class FullTimeEmp : BaseEmployee
{

}


public class MethodHiding
{
    public static void Main()
    {
        FullTimeEmp FT = new FullTimeEmp();
        FT._firstname = "Geetha";
        FT._lastname = "Yedida";
        FT.FullName();

        PartTimeEmp PT = new PartTimeEmp();
        PT._firstname = "Geetha";
        PT._lastname = "Yedida";
        PT.FullName();

        // base class can be also invoked from the child class like this
        //Employee PT =  PartTimeEmp();
        //PT._firstname = "Geetha";
        //PT._lastname = "Yedida";
        //PT.FullName();
    }
}