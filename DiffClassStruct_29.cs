using System;

//Struct is value type, class is refernece type . int float boolean structs enums,- value type.  clases, interfaces, delegates - reference type
//value types are stored on stack. classes on heap. variables, objects in a prog are in mem until prog executes.
// for classes, the object efernce variable is stored in struct whereas the actual object are stored on heap
// reference types are destroyed immediately but value types are destroyed by garbage collector
// copying struct into another struct will not make changes in the original struct. which is unlike in reference type
// when we copy value types, we get 2 copies, wen we copy reference types, we get a copy of eference variable
// structs cant have destructors classes cannot
// class can have explicit parameter less constructor but structures
// structures cannot inherit from classes but from interfaces they are sealed by default
public class SimpleClass
{
    int _id;
    string _name;

    public int Id
    {
        get
        {
            return _id;
        }

        set
        {
            _id = value;
        }
    }

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
}
public class ClassStruct
{
    public static void Main()
    {
        int i = 0; // int is an alias for structure System.int32
        if (i == 10)
        {
            //int j = 20;
            SimpleClass SC = new SimpleClass();
            SC.Id = 101;
            SC.Name = "Geetha";
            // j is destroyed after this loop                    
        }
    }
}