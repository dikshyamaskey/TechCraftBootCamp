
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
        string bilAmt = Console.ReadLine();

        var obj = new CustomerObject().GetCustomerObject(customerType);
        obj.customerType = customerType;
        obj.address = address;
        obj.fullName = name;
        obj.mobNumber = mob;
        obj.billNumber = billNumber;
        obj.billAmt = bilAmt;
        obj.AddCustomer();
        Console.ReadKey();
    }

}
public class CustomerObject
{
    private Dictionary<int, Func<ParentCustomer>> CreateCustomerObject = new Dictionary<int, Func<ParentCustomer>>
                                                                        {
                                                                           { 1, () => new Customer1() },
                                                                           { 2, () => new Customer2()},
    };
    public ParentCustomer GetCustomerObject(int customerType)
    {
       return  CreateCustomerObject[customerType]();
    }
}
