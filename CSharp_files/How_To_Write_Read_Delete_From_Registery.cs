using System;
using System.IO;
using Microsoft.Win32;

namespace HowToWriteInRegistry
{
    public class Program
    {
        public static void WriteToRegistry(string KeyPath,string ValueName,string ValueData)
        {
            try
            {
                //write the value to registry
                Registry.SetValue(KeyPath, ValueName, ValueData, RegistryValueKind.String);
                Console.WriteLine($"Value {ValueName} is successfully saved in registry");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }
        }

        public static void ReadFromRegistry(string KeyPath, string ValueName )
        {
            string ValueData;
            try
            {
                //read the value from registry
                ValueData = Registry.GetValue(KeyPath, ValueName,null) as string;
                if(ValueData != null) 
                {
                    Console.WriteLine($"The value of {ValueName} in registry is {ValueData}."); 
                }
                else
                {
                    Console.WriteLine($"The {ValueName} in registry doesn't exist.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }
        }

        public static void DeleteFromRegistry(string KeyPath, string ValueName)
        {
            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(KeyPath, true))
                    {
                        if (key != null)
                        {
                            // Delete the specified value
                            key.DeleteValue(ValueName);


                            Console.WriteLine($"Successfully deleted value '{ValueName}' from registry key '{KeyPath}'");
                        }
                        else
                        {
                            Console.WriteLine($"Registry key '{KeyPath}' not found");
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        static void Main(string[] args)
        {

            // Specify the registry key and path
            //string KeyPath2 = @"HKEY_Local_Machine\SOFTWARE\YourSoftware";
            //need permission so :
            //you can run VS as administrative
            //or add file app.manifist * Open your project properties in Visual Studio.
            //  Go to the "Application" tab /  Set "Manifest" to the path of your app.manifest file.
            string KeyPath2 = @"HKEY_Current_User\SOFTWARE\YourSoftware";
            string ValueName = "YourValueName";
            string ValueData = "YourValueData";           

            // the second example with DVLD to write in registry
            string KeyPath1 = @"HKEY_Current_User\SOFTWARE\DVLD1";
            string ValueNameUserName = "UserName";
            string ValueDataUserName = "Msaqer77";            
            string ValueNamePassword = "Password";
            string ValueDataPassword = "1234";

            // store data in registry
            // WriteToRegistry(KeyPath2, ValueName, ValueData);
             //WriteToRegistry(KeyPath1, ValueNameUserName, ValueDataUserName);
             //WriteToRegistry(KeyPath1, ValueNamePassword, ValueDataPassword);

            //retrieve Data from Registry
            // ReadFromRegistry(KeyPath2, ValueName);
            //ReadFromRegistry(KeyPath1, ValueNameUserName);
            //ReadFromRegistry(KeyPath1, ValueNamePassword);

            // Specify the registry key path and value name
            string keyPath = @"SOFTWARE\DVLD1";
            string valueName1 = "UserName";
            string valueName2 = "Password";
            //delete Data from Registry
            DeleteFromRegistry(keyPath, valueName1);
            DeleteFromRegistry(keyPath, valueName2);


            Console.ReadLine();

        }
    }
}
