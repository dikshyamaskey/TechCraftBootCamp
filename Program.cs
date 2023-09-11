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
        Console.WriteLine("Enter Customer Type  : ");
       int customerType =int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Customer Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Customer Address: ");
        string address = Console.ReadLine();
        Console.WriteLine("Enter Customer Mob: ");
        string mob = Console.ReadLine();
       

        ParentCustomer customer = new ParentCustomer();
        customer.customerType = customerType;
        customer.address = address;
        customer.fullName = name;
        customer.mobNumber = mob;
        if(customerType == 1)
        {
            customer = new Customer1();
            customer.AddCostumer();

        }
        else if (customerType == 2)
        {
            Console.WriteLine("Enter Customer billAdd: ");
            string billNumber = Console.ReadLine();
            Console.WriteLine("Enter billAmt: ");
            string bilAMt = Console.ReadLine();
            if(string.IsNullOrEmpty(billNumber) || string.IsNullOrEmpty(bilAMt)){
                if (string.IsNullOrEmpty(billNumber))
                {
                    Console.WriteLine("Bill Number Cannot be empty");
                }
                if (string.IsNullOrEmpty(bilAMt))
                {
                    Console.WriteLine("Bill Amount Cannot be empty");

                }
                Console.ReadKey();
                return;
            }
           

            customer = new Customer2(billNumber,bilAMt);
            customer.AddCostumer();

        }
        Console.ReadKey();
      

    }
}
