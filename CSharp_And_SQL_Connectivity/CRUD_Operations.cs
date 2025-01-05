using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

public class Program
{
    static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password =sa123456;";

    public struct stContact
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
        public int ContactID { get; set; }

    }

    static void AddNewContact(stContact NewContactInfo)
    {
        SqlConnection connection = new SqlConnection(ConnectionString);
        string query = @"insert into Contacts(FirstName,LastName,Email,Phone,Address,CountryID) 
               values(@FirstName,@LastName,@Email,@Phone,@Address,@CountryID)";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@FirstName", NewContactInfo.FirstName);
        command.Parameters.AddWithValue("@LastName", NewContactInfo.LastName);
        command.Parameters.AddWithValue("@Email", NewContactInfo.Email);
        command.Parameters.AddWithValue("@Phone", NewContactInfo.Phone);
        command.Parameters.AddWithValue("@Address", NewContactInfo.Address);
        command.Parameters.AddWithValue("@CountryID", NewContactInfo.CountryID);
        try
        {
            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Record inserted successfully.");

            }
            else
            {
                Console.WriteLine("Record insertion failed.");

            }
            connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }

    static void AddNewContactAndReturnLastID(stContact NewContactInfo)
    {
        SqlConnection connection = new SqlConnection(ConnectionString);
        string query = @"insert into Contacts(FirstName,LastName,Email,Phone,Address,CountryID) 
               values(@FirstName,@LastName,@Email,@Phone,@Address,@CountryID);
                select SCOPE_IDENTITY();";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@FirstName", NewContactInfo.FirstName);
        command.Parameters.AddWithValue("@LastName", NewContactInfo.LastName);
        command.Parameters.AddWithValue("@Email", NewContactInfo.Email);
        command.Parameters.AddWithValue("@Phone", NewContactInfo.Phone);
        command.Parameters.AddWithValue("@Address", NewContactInfo.Address);
        command.Parameters.AddWithValue("@CountryID", NewContactInfo.CountryID);
        try
        {
            connection.Open();

            //int rowsAffected = command.ExecuteNonQuery();
            object result = command.ExecuteScalar();

            if (result!=null && int.TryParse(result.ToString(),out int LastID))
            {
                Console.WriteLine("Record inserted successfully.");
                Console.WriteLine($"ID of the last record is {LastID}.");

            }
            else
            {
                Console.WriteLine("Record insertion failed.");

            }
            connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }

    static void UpdateContact(int ID,stContact UpdateContactInfo)
    {
        SqlConnection connection = new SqlConnection(ConnectionString);
        string query = @"UPDATE Contacts SET FirstName = @FirstName,LastName= @LastName,Email = @Email,Phone = @Phone,
                       Address = @Address,CountryID =@CountryID WHERE ContactID = @ID ";
          SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@FirstName", UpdateContactInfo.FirstName);
        command.Parameters.AddWithValue("@LastName", UpdateContactInfo.LastName);
        command.Parameters.AddWithValue("@Email", UpdateContactInfo.Email);
        command.Parameters.AddWithValue("@Phone", UpdateContactInfo.Phone);
        command.Parameters.AddWithValue("@Address", UpdateContactInfo.Address);
        command.Parameters.AddWithValue("@CountryID", UpdateContactInfo.CountryID);
        command.Parameters.AddWithValue("@ID", ID);
        try
        {
            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Record inserted successfully.");

            }
            else
            {
                Console.WriteLine("Record insertion failed.");

            }
            connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }

    static void DeleteContact(string FirstName)
    {
        SqlConnection connection = new SqlConnection(ConnectionString);
        string query1 = "Delete from Contacts where FirstName = @FirstName";
        SqlCommand command = new SqlCommand(query1, connection);     
        command.Parameters.AddWithValue("@FirstName", FirstName);
        try
        {
            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Record deleted successfully.");
            }
            else
            {
                Console.WriteLine("Record deleted failed.");
            }
            connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }

    static void Main(string[] args)
    {
        stContact NewContactInfo = new stContact
        {
            FirstName = "AMAL",
            LastName = "Karim",
            Email = "MILOCAT@zio.com",
            Phone = "216209914879",
            Address = "Massira4",
            CountryID = 1
        };

        //AddNewContact(NewContactInfo);

        //DeleteContact("Zakaria");

        //UpdateContact(1, UpdateContactInfo);

        AddNewContactAndReturnLastID(NewContactInfo);

        Console.ReadLine();
        
    }
}

