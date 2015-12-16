using System;
public class PrintNumbers
{
    public static void Main()
    {
        int i;
        for(i = 0; i <= 100; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
// string s = null;
// int n = 7;
// var v = s ?? n.ToString()

    // what is var

    // int? what does it do

    // what are delegates

    // diff between abs class and interfaces

    // fully defined names
