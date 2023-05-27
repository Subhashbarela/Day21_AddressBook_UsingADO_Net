using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_CustomerDetailsDB
{
   // Country varchar(30),Salary varchar(30),Pincode int;
    public class CustomerClass
    {
        public int C_Id { get; set; }
        public int CustomerId { get; set; }
        public string Customer_Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public int Salary { get; set; }
        public int Pincode{ get; set; }
    }
}
