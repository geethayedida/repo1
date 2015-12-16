using System;

public class StudentClass
{
    private int _ID;
    private int _passmark= 35;
    private string _city;
    
    public string Email
    {
        get;
        set;
    }
    // this is a lot of code to write. so in 3.0 there are properties for auto-implementation
    // the compiler creates the private fields for us if there is no additional logic
    public string City
    {
        get
        {
            return this._city;
        }
        set
        {
            this._city = value;
        }
    }

    public int passmark
    {
        get
        {
            return this._passmark;
        }
    }

    public int id
    {
        set
        {
            if (value <= 0)
                // the value keyword stores id value in it
            {
                throw new Exception("ID cannot be negative");
            }
            else
            {
                this._ID = value;
            }
        }
        get
        {
            return this._ID;
        }
    }
}
class Properties
{
    public static void Main()
    {
        StudentClass S = new StudentClass();
        S.id = 10;
        Console.WriteLine("id is {0}", S.id);
        Console.WriteLine(S.passmark);

        // here ID is a read/write property. passmark is a read only property
        // advantages of properties over get and set methods is we can access them as if they were public fields

    }
}