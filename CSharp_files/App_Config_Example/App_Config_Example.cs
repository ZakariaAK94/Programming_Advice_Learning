using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


public class Program
{
    public static void PrintConnectionInsideAppSettings(string ConnectionName)
    {
        string connectionString = ConfigurationManager.AppSettings[ConnectionName];
        Console.WriteLine(connectionString);
    }

    public static void PrintConnectionInsideConnectionString(string ConnectionName)
    {
        string connectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        Console.WriteLine(connectionString);
    }
    static void Main(string[] args)
    {
        PrintConnectionInsideAppSettings("ConnectionString");
        PrintConnectionInsideAppSettings("Loglevel");
        PrintConnectionInsideAppSettings("koko");
        PrintConnectionInsideConnectionString("MyDbconnection");  

        Console.ReadLine();

    }
}

