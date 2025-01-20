using System;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using static LoggingService;

public class LoggingService
{
    public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

    public void Log(string message, enLoggingType LoggingType)
    {

        if (LoggingType == enLoggingType.ToFile)
        {
            LogToFile(message);
        }
        else if (LoggingType == enLoggingType.ToEventLog)
        {
            LogToEventLog (message);
        }
        else if (LoggingType == enLoggingType.ToDatabase)
        {
            logToDataBase( message);
        }
    }

    // method to log in the Event view
    
    
    private  void LogToEventLog(string message, string sourceName="DVLD", string logName="Application")
    {
        // Create the event source if it does not exist
        if (!EventLog.SourceExists(sourceName))
        {
            EventLog.CreateEventSource(sourceName, logName);
            Console.WriteLine("Event source created.");
        }

        EventLog.WriteEntry(sourceName, message, EventLogEntryType.Information);              
        

        Console.WriteLine("Event written to the log.");
    }

    // log to DataBase
    private void logToDataBase(string message)
    {

        string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING_C21_DB1");

        SqlConnection connection = new SqlConnection(connectionString);

        string procedureName = "Add_Test_Types_Log";

        SqlCommand command = new SqlCommand(procedureName, connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@TestTypeDescription", message);
        command.Parameters.AddWithValue("@DateOfLogging", DateTime.Now);

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
    private void LogToFile(string message)
    {

        string filePath = "C:\\Users\\AKILZA\\source\\repos\\Programming Advice\\Csharp projects\\2_Loggin_Service\\log.txt";

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

}

class Program
{
    static void Main()
    {
        // Create an instance of the LoggingService
        LoggingService LoggingService = new LoggingService();
        string message1 = "This is an information event.";

        // Log to File
        LoggingService.Log(message1, LoggingService.enLoggingType.ToFile);

        // Log to Event Log
        LoggingService.Log(message1, LoggingService.enLoggingType.ToEventLog);

        // Log to Database
        LoggingService.Log(message1, LoggingService.enLoggingType.ToDatabase);

        Console.ReadKey();

    }
}
