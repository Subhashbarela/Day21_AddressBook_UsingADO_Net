using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_CustomerDetailsDB
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerClass customer = new CustomerClass();
            customer.Customer_Name = "Rajvir";
            customer.PhoneNumber = 8654357756;
            customer.Address = "Rajstan";
            customer.Country = "India";
            customer.Salary = 4535353;
            customer.Pincode = 543435;

            CustomerInfo info = new CustomerInfo();
            info.InsertDataFromCustomerClass(customer);
        }
    }
}
