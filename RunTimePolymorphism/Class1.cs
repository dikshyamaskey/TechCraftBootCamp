using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Techcraft
{
   
    public  class Customer1 : ParentCustomer
    {
        public override void AddCustomer()
        {
            Console.WriteLine($" Customer Type :{customerType}");

            Console.WriteLine($" Name :{fullName} Address: {address} MobNum: {mobNumber}");
        }
    }
    public class Customer2 : ParentCustomer
    {

        public override void AddCustomer()
        {
           
            if (string.IsNullOrEmpty(billNumber) || string.IsNullOrEmpty(billAmt))
            {
                if (string.IsNullOrEmpty(billNumber))
                {
                    Console.WriteLine("Bill Number Cannot be empty");
                }
                if (string.IsNullOrEmpty(billAmt))
                {
                    Console.WriteLine("Bill Amount Cannot be empty");

                }
                Console.ReadKey();
                return;
            }
            Console.WriteLine($" Customer Type :{customerType}");
            Console.WriteLine($" Name :{fullName} Address {address} MobNum: {mobNumber} BillNum: {billNumber} BillAmount: {billAmt}");

        }


    }

    public class ParentCustomer
    {
       public int customerType;
     public   string fullName, address, mobNumber;
     public   string billNumber, billAmt;


        public virtual void AddCustomer() { }
        
    }

 
}

