using System;
using System.Collections.Generic;

public class DelegateUsage1
{
    // use delegates if you want to pass a method as a parameter to another method, use delegates
    // to make your methods and code reusable, use delegates
    public static void Main()
    {
        List<EmployeeDel> emplist = new List<EmployeeDel>();
        emplist.Add(new EmployeeDel()
        {
            ID = 100,
            Ename = "Geetha",
            Experience = 5,
            Salary = 23000
        });
        emplist.Add(new EmployeeDel()
        {
            ID = 101,
            Ename = "Yedida",
            Experience = 2,
            Salary = 2343242
        });
        emplist.Add(new EmployeeDel()
        {
            ID = 102,
            Ename = "Ye",
            Experience = 7,
            Salary = 23643
        });
        ISPromotable prom = new ISPromotable(promote);

        EmployeeDel.PromoteEmployee(emplist, prom);
    }

     static bool promote(EmployeeDel employ)
    {
        if
            (employ.Experience >= 5)
        {
            return true;
        }
        else { return false; }
    }
}

 delegate bool ISPromotable(EmployeeDel empl);

class EmployeeDel
{
    public int ID
    {
        get
        {
            return ID;
        }

        set
        {
            ID = value;
        }
    }
    public string Ename { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<EmployeeDel> employeelist, ISPromotable IsEligibleToPromote)
    {
        foreach (EmployeeDel emp in employeelist)
        {
            if (IsEligibleToPromote(emp))
            {
                Console.WriteLine(emp.Ename, "promoted");
            }
                    
        }
        }
    }