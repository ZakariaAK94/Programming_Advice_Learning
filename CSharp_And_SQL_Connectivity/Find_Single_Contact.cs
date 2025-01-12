using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

public class Program
{
    static string ConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING_ContactsDB");

    public struct stContact
    {
        public int ContactID;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Phone;
        public string Address;
        public int CountryID;
    }

    static bool FindContact(int ContactID, ref stContact ContactInfo)
    {
        bool isFind = false;
        SqlConnection connection = new SqlConnection(ConnectionString);
        string query = "select * from Contacts where ContactID = @ContactID";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@ContactID",ContactID);
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                ContactInfo.ContactID = (int)reader["ContactID"];
                ContactInfo.FirstName = (string)reader["FirstName"];
                ContactInfo.LastName = (string)reader["LastName"];
                ContactInfo.Email = (string)reader["Email"];
                ContactInfo.Phone = (string)reader["Phone"];
                ContactInfo.Address = (string)reader["Address"];
                ContactInfo.CountryID = (int)reader["CountryID"];
                isFind = true;
            }
            else
                isFind = false;
            connection.Close();
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error:"+ex.Message);
        }

        return isFind;
    }

    static void Main(string[] args)
    {
        stContact contactInfo = new stContact();

        if(FindContact(3,ref contactInfo))
        {
            Console.WriteLine($"\nContactID: {contactInfo.ContactID} ");
            Console.WriteLine($"Name: {contactInfo.FirstName}{contactInfo.LastName}");
            Console.WriteLine($"Email: {contactInfo.Email} ");
            Console.WriteLine($"Phone: {contactInfo.Phone} ");
            Console.WriteLine($"Address: {contactInfo.Address} ");
            Console.WriteLine($"CountryID: {contactInfo.CountryID} ");
        }
       
        Console.ReadKey();
    }
}

