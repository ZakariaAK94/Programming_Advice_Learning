using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;


public class Logger
{
    public delegate void LogAction(string message);

    private LogAction _logAction;

    public Logger(LogAction logAction)
    {
        _logAction = logAction;
    }

    public void Log(string message)
    {
        _logAction(message);
    }

}

public class Program
{
    // method to display message in the console
    public static void logToScreen(string message)
    {
        Console.WriteLine($"{DateTime.Now}: {message}");
    }
    // log to DataBase
    public static void logToDataBase(string message)
    {
            
          string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING_C21_DB1");

        SqlConnection connection = new SqlConnection(connectionString);

        string procedureName = "Add_Test_Types_Log";

            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TestTypeDescription",message);
            command.Parameters.AddWithValue("@DateOfLogging",DateTime.Now);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }
        
    }
    // log to file
    public static void logTofile(string message)
    {

        string filePath = "log.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
            Console.WriteLine("Log written successfully.");
        }
        catch (IOException ioEx)
        {
            Console.WriteLine($"IO error occurred: {ioEx.Message}");
        }
        catch (UnauthorizedAccessException uaEx)
        {
            Console.WriteLine($"Access denied: {uaEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }


    }
    static void Main()
    {
        Logger logger1 = new Logger(logToScreen);
        Logger logger2 = new Logger(logToDataBase);
        Logger logger3 = new Logger(logTofile);
        string message = "I will become a good programmer.";
        logger1.Log(message);
        logger2.Log(message);
        logger3.Log(message);

        Console.ReadLine();
    }
}
