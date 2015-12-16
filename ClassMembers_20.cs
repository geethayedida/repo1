using System;

public class Circle
{
    public static float _pi;
    int _radius;

    // without static keyword fields, constructors, events, delegates, properties, or any class members become instance members
    // each object will have their own set of instance fields
    // it makes sence to make pi value static since that wont change which will be shared by all objects
    // similarly methods can be made reusable with marking them static
    // static values are called even before we use it in the program

    static Circle()
    {
        // to initializw static fields, we can use static Constructor
        // static constructor cannot have access modifier
        // static constructor comes before instance constructor
        // static constructions are called only once irrespecting of how many times we use it
        Circle._pi = 3.141F;
    }
    
    public Circle(int Radius)
    {
        // when the access modifier of a class is removed, it becomes private
        this._radius = Radius;
    }

    // state of the class is represented by the fields 
    // behavior of the method is represented by the method of the clas

    public static void PrintMethod()
    {
        // to call instance methid, we need object to be created, use the name of the class
    }

	public float CalculateArea()
	{
        return _pi * this._radius * this._radius;
        // this keyword will not change with the instance so, it doesnt make scence to use this keyword
        // tis keyword cannot be used with static members
	}
}

class mainprogram
{
    public static void Main()
    {
        Circle c1 = new Circle(9);
        float Area1 = c1.CalculateArea();
        Console.WriteLine("Area is {0}", Area1);

        Circle c2 = new Circle(6);
        float Area2 = c2.CalculateArea();
        Console.WriteLine("Area is {0}", Area2);
        // static method called with class.method name
        Circle.PrintMethod();

    }
}
