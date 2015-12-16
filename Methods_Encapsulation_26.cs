using System;

class Student
{
    // marking class fields as public is a bad idea since we will not have control of what gets assigned and returned
    private int _ID;
    private string _name;
    private int _passmark = 35;
    //for languages that do not have properties, getter and setter methods are used- which are used for encapsulation and protect the fields

    // to set the value and read the value, we use methods

    public int getpassmark()
    {
        return this._passmark;
    }
    
    public void setname(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("name is null");
        }
        this._name = Name;
    }
    public string getname()
    {
        if (string.IsNullOrEmpty(this._name))
        {
            return "no name";
        }
        return this._name;
    }

    public void setid(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("ID cannot be negative");
        }
        else
        {
            this._ID = Id;
        }
    }
    public int getid()
    {
        return this._ID;
    }
}

class PropertiesClass
{
    public static void Main()
    {
        Student S = new Student();
        S.setid(100);
        S.getpassmark();
        //S.setname("Geetha");

        Console.WriteLine("ID is {0}", S.getid());
        Console.WriteLine("ID is {0}", S.getname());
        Console.WriteLine("passmark is {0}", S.getpassmark());
        //S.name = null;
        //S.passmark = -35;

        //Console.WriteLine("Wrong ID {0},{1},{2}", S.ID, S.name, S.passmark);

        // all of the conditions are violated here, to avoid make the fields private
    }
}