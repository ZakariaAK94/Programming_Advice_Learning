using System;
using System.Diagnostics;
class Program
{
    public enum enTypeOfEvent { Information =1, Warning =2, Error =3};
    public static void WriteInLogEvents(string sourceName, string logName, string message ,enTypeOfEvent typeofevent)
    {
        // Create the event source if it does not exist
        if (!EventLog.SourceExists(sourceName))
        {
            EventLog.CreateEventSource(sourceName, logName);
            Console.WriteLine("Event source created.");
        }

        switch(typeofevent)
        {
            case enTypeOfEvent.Information:
                // Log an information event
                EventLog.WriteEntry(sourceName, message, EventLogEntryType.Information);
                break;
            case enTypeOfEvent.Warning:
                // Log an warning event
                EventLog.WriteEntry(sourceName, message, EventLogEntryType.Warning);
                break;
            case enTypeOfEvent.Error:
                // Log an error event
                EventLog.WriteEntry(sourceName, message , EventLogEntryType.Error);
                break;
        }   

         Console.WriteLine("Event written to the log.");
    }
    static void Main()
    {
        // Specify the source name for the event log
        string sourceName = "DVLD1";
        string logname = "Application";
        string message1 = "This is an information event.";
        string message2 = "This is an error event.";
        string message3 = "This is an warning event.";

        WriteInLogEvents(sourceName,logname,message1,enTypeOfEvent.Information);
        WriteInLogEvents(sourceName,logname,message2,enTypeOfEvent.Error);
        WriteInLogEvents(sourceName,logname,message3,enTypeOfEvent.Warning);

        Console.ReadLine();
    }
}