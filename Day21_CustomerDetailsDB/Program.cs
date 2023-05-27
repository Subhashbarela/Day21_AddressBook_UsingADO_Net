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
            string ans = "";
            do
            {
                Console.WriteLine("1: Insert the data \n2: display the data\n3: Delete record");
                Console.WriteLine("Select One from above List");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        info.InsertDataFromCustomerClass(customer);
                        break;
                    case 2:
                        info.DisplayDataFromDatabase();
                        break;
                    case 3:
                        info.DeleteDataFromDatabase();
                        break;
                }
                Console.WriteLine("Do you want to continue ?");
                ans = Console.ReadLine();
            } while (ans == "yes" || ans == "y");
            Console.ReadLine();
        }
        
    }
}
