using System;
public class CustomerEnum
{
    public string CustomerName { get; set; }
    public Gender Gender { get; set; }
         
}
public enum Gender
{
    unknown, male, female
}
public class Enum
{
    public static void Main()
    {
        CustomerEnum[] CE = new CustomerEnum[3];
        CE[0] = new CustomerEnum
        {
            CustomerName = "Mark",
            Gender = Gender.male,
        };
        CE[0] = new CustomerEnum
        {
            CustomerName = "Mary",
            Gender = Gender.female,
        };
        CE[0] = new CustomerEnum
        {
            CustomerName = "Sam",
            Gender = Gender.unknown,
        };
        foreach (CustomerEnum ce in CE)
        {
            Console.WriteLine("Name is {0) and gender is {1}", ce.CustomerName, GetGender(ce.Gender));
        }
    }
        public static string GetGender(Gender Gender)
    {
        switch (Gender)
        {
            case Gender.unknown:
                return "Unknown";
            case Gender.male:
                return "Male";
            case Gender.female:
                return "Invalid data";
            default:
                return "invalid";
        }
    }
}