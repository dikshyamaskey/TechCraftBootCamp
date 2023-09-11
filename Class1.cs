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

    }
    public class Customer2 : ParentCustomer
    {

        string _billNumber, _billAmt;
        public Customer2( string billNumber, string billAmt)
        {
            _billNumber = billNumber;
            _billAmt = billAmt;

        }

        public override void AddCostumer()
        {
            Console.WriteLine($" Customer Type :{customerType}");
            Console.WriteLine($"Name :{fullName} Address {address} MobNum {mobNumber} BillNum {_billNumber} BillAmount {_billAmt}");

        }


    }

    public class ParentCustomer
    {
       public int customerType;
     public   string fullName, address, mobNumber;

        public virtual void AddCostumer()
        {
            Console.WriteLine($" Customer Type :{customerType}");

            Console.WriteLine($"Name :{fullName} Address {address} MobNum {mobNumber}");
        }
    }

 
}

