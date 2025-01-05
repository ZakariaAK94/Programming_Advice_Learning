using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Server=.;DataBase=ContactsDB;User Id=sa;Password =sa123456;";

    static void PrintAllContacts()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        string query = "select * from Contacts";
        SqlCommand command = new SqlCommand(query,connection);

        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(); 
            while(reader.Read())
            {
                 
                int ID = (int)reader ["ContactID"]    ;
                string FirstName = (string)reader ["FirstName"];
                string LastName = (string)reader ["LastName"];
                string Email = (string)reader ["Email"];
                string Phone = (string)reader ["Phone"];
                string Address = (string)reader ["Address"];
                int CountryID = (int)reader["CountryID"];

                Console.WriteLine($"ID:{ID}");
                Console.WriteLine($"FirstName:{FirstName}");
                Console.WriteLine($"LastName:{LastName}");
                Console.WriteLine($"Email:{Email}");
                Console.WriteLine($"Phone:{Phone}");
                Console.WriteLine($"CountryID:{CountryID}");
            }

            reader.Close();
            connection.Close();
        }
        catch (Exception ex)
        { 
            Console.WriteLine("Error :"+ex.Message);
        }

    }
    static void PrintAllContactsWithFirstName(string FirstName)
    {
        SqlConnection connection = new SqlConnection(connectionString);

        string query = "Select *from Contacts where firstName = @FirstName";

        SqlCommand command = new SqlCommand(query,connection);

        command.Parameters.AddWithValue("@FirstName", FirstName);

        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(); 
            while (reader.Read())
            {
               
                int contactID = (int)reader["contactID"];
                string firstName = (string)reader["FirstName"];
                string lastName = (string)reader["LastName"];
                string email = (string)reader["Email"];
                string phone = (string)reader["Phone"];
                string address = (string)reader["Address"];
                int countryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID: {contactID}");
                Console.WriteLine($"FirstName: {firstName}");
                Console.WriteLine($"LastName: { lastName}");
                Console.WriteLine($"email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"CountryID: {countryID}");
                Console.WriteLine("---------------------------------------");

            }
            reader.Close();
            connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error:"+ ex.Message);
        }

    }

    static void Main(string[] args)
    {
        PrintAllContacts();
        //PrintAllContactsWithFirstName("Jane");

        Console.ReadKey();
    }
}

