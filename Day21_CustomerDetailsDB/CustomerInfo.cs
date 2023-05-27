using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_CustomerDetailsDB
{
    public class CustomerInfo
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=CustomerDetails";
        SqlConnection sqlConnection = new SqlConnection(connectionString);        
        public void InsertDataFromCustomerClass(CustomerClass customer)
        {           
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SPCustomer", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Customer_Name", customer.Customer_Name);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                sqlCommand.Parameters.AddWithValue("@Address", customer.Address);
                sqlCommand.Parameters.AddWithValue("@Country", customer.Country);
                sqlCommand.Parameters.AddWithValue("@Salary", customer.Salary);
                sqlCommand.Parameters.AddWithValue("@Pincode", customer.Pincode);
                int result = sqlCommand.ExecuteNonQuery();

                if (result >= 0)
                {
                    Console.WriteLine($"{result} Row(s) is inserted succesfully...!");
                    result++;
                }
                else
                {
                    Console.WriteLine("Error While Created ..");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }           

    }
}
