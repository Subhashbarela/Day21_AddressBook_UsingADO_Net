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
        public void DisplayDataFromDatabase()
        {
            CustomerClass customer = new CustomerClass();
            try
            {
                string searchQuery = @"Select * from Customer";
                SqlCommand cmd = new SqlCommand(searchQuery, sqlConnection);
                sqlConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                   // Console.WriteLine("Id CustomerName Address Country Salary Pincode ");
                    Console.WriteLine(".......................................................");
                    while (dr.Read())
                    {
                        customer.C_Id = dr.GetInt32(0);
                        customer.Customer_Name = dr.GetString(1);
                        customer.PhoneNumber = dr.GetInt64(2);
                        customer.Address = dr.GetString(3);
                        customer.Country = dr.GetString(4);
                        customer.Salary = dr.GetInt32(5);
                        customer.Pincode = dr.GetInt32(6);                        
                        Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}", customer.C_Id, customer.Customer_Name, customer.PhoneNumber, customer.Address, customer.Country, customer.Salary, customer.Pincode);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Data not found");
                }
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteDataFromDatabase()
        {
            try
            {
                sqlConnection.Open();
                Console.WriteLine("insert the id that row wanto to delete");
                int id = int.Parse(Console.ReadLine());
                string deleteQuery = @"delete from Customer where CustomerId='" + id + "'";
                SqlCommand cmd = new SqlCommand(deleteQuery, sqlConnection);
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    Console.WriteLine($"{result} row(s)is deleted..");
                }
                else
                {
                    Console.WriteLine("Erroe while deleting data");
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
