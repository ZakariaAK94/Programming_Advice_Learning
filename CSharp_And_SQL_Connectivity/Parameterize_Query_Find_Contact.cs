using System;
using System.Data.SqlClient;

public class Program
{

    static string ConnectionString = "Server =.;Database=ContactsDB;User Id=sa; Password=sa123456;";

    static void SearchContactWithChoice(string StartsWith, int Choice)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);


        string query ="";

        switch (Choice)
        {
            case 1:
                query = "select *from Contacts where firstName LIKE '' + @StartWith +'%'";
                break;
            case 2:
                query = "select *from Contacts where firstName LIKE '%' + @StartWith +''";
                break;
            case 3:
                query = "select *from Contacts where firstName LIKE '%' + @StartWith +'%'";
                break;
        }

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@StartWith", StartsWith);

        try 
        { 
            Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int ID = (int)reader["ContactID"];
                string firstName = (string)reader["FirstName"];
                string lastName = (string)reader["LastName"];
                string Email = (string)reader["Email"];
                string Phone = (string)reader["Phone"];
                string Address = (string)reader["Address"];
                int CountryID = (int)reader["CountryID"];

                Console.WriteLine($"ContactID :{ID}");
                Console.WriteLine($"firstName :{firstName}");
                Console.WriteLine($"lastName :{lastName}");
                Console.WriteLine($"Email :{Email}");
                Console.WriteLine($"Phone :{Phone}");
                Console.WriteLine($"Adress :{Address}");
                Console.WriteLine($"CountryID :{CountryID}");
            }
            reader.Close();
            Connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error:"+ex.Message);
        }
    }


    static void Main(string[] args)
    {
        SearchContactWithChoice("d",3);
        Console.ReadKey();
    }
}

