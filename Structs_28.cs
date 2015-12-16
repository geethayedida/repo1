using System;

// just like classes, struct can have private fields, public properties, constructors, methods

public struct Structure
{
    private int _id;
    private string _name;

    public int ID
    {
        get
        {
            return this._id;   
        }
        set
        {
            this._id = value;
        }
    }
    // refactoring in c# can be used to create a property for the name field rt clcik on the field and select refactor, encapsulate field, name
    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }
    // simillar to class, structure can also have constructor to initialize the fields

    public Structure(int ID, string Name)
    {
        this._id = ID;
        this._name = Name;
    }

    public void printdetails()
    {
        Console.WriteLine("ID and Name : {0}, {1}", this._id, this._name);
    }
}

public class StructsClass1
{
    public static void Main()
    {
        Structure S1 = new Structure(101,"Geetha");
        S1.printdetails();

        // we can also use the default constructor,
        Structure S2 = new Structure();
        S2.ID = 102;
        S2.Name = "Yedida";
        S2.printdetails();

        // we can use the object initializer introduced in c# 3.0. this can be used to classes as well
        Structure S3 = new Structure
        {
            ID = 103, Name = "Yahoo"
        };
        S3.printdetails();
    }
}