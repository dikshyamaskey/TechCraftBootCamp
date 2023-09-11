// See https://aka.ms/new-console-template for more information
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Xml.Linq;
using Techcraft;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Customer Type 1 or 2 : ");
       int customerType =int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Customer Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Customer Address: ");
        string address = Console.ReadLine();
        Console.WriteLine("Enter Customer Mob: ");
        string mob = Console.ReadLine();
        Console.WriteLine("Enter Customer billAdd: ");
        string billNumber = Console.ReadLine();
        Console.WriteLine("Enter billAmt: ");
        string bilAMt = Console.ReadLine();

        var obj = new CustomerObject().CreateCustomerObject(customerType);
        obj.customerType = customerType;
        obj.address = address;
        obj.fullName = name;
        obj.mobNumber = mob;
        obj.billNumber = billNumber;
        obj.billAmt = bilAMt;
        obj.AddCustomer();
        Console.ReadKey();
        }


}
public class CustomerObject
{
    public ParentCustomer CreateCustomerObject(int customerType)
    {
        ParentCustomer customerObj = null;

        if (customerType == 1)
        {
            customerObj = new Customer1();

        }
        else if (customerType == 2)
        {
            customerObj = new Customer2();
        }
        return customerObj;
    }
}