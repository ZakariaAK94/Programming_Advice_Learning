using System;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using static LoggingService;

public class LoggingService
{
    private ILogService _logService;
    public LoggingService(ILogService logService)
    {
        _logService = logService;
    }

    public void Log(string message) => _logService.Log(message);
    
}
   
public interface ILogService
{
    public void Log(string message);
}
public class LoggingToEventLogService : ILogService
    {
        public void Log(string message)
        {
            // Create the event source if it does not exist
            if (!EventLog.SourceExists("DVLD"))
            {
                EventLog.CreateEventSource("DVLD", "Application");
                Console.WriteLine("Event source created.");
            }

            EventLog.WriteEntry("DVLD", "Application", EventLogEntryType.Information);


            Console.WriteLine("Event written to the log.");
        }
    }
    

public class LoggingToDBService : ILogService
    {
        public void Log(string message)
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
    }
    

public class LoggingToFileService : ILogService
    {
        public void Log(string message)
        {

            string filePath = "C:\\Users\\AKILZA\\source\\repos\\Github folders\\Programming_Advice_Learning\\SOLID_Principales\\Open_Closed_Principale\\Loggin_Service\\log.txt";

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
        string message1 = "This is an example of using SRP and OCP";
        // Create an instance of the LoggingService
        LoggingService LoggingService = new LoggingService(new LoggingToDBService());

        // Log to Database 
        LoggingService.Log(message1);

        LoggingService = new LoggingService(new LoggingToFileService());

        // Log to File 
        LoggingService.Log(message1);

        LoggingService = new LoggingService(new LoggingToEventLogService());

        // Log to Event Log
        LoggingService.Log(message1);

        Console.ReadKey();

    }
}
