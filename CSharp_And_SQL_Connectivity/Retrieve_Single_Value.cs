using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

public class Program
{
    static string ConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING_ContactsDB");

    static string GetFirstName(int ID)
    {
        string FirstName = "";
        SqlConnection connection = new SqlConnection(ConnectionString);
        string query = "select FirstName from Contacts where ContactID =@ContactID";
        SqlCommand command = new SqlCommand(query,connection);
        command.Parameters.AddWithValue("@ContactID", ID);

        try
        {
            connection.Open();
            object result = command.ExecuteScalar();

            if(result != null)
            {
                FirstName = result.ToString();
            }
            else
            {
                FirstName = "";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " +ex.Message);
        }

        connection.Close();

        return FirstName;
    }





    static void Main(string[] args)
    {
        Console.WriteLine(GetFirstName(1));

        Console.ReadKey();
    }
}

