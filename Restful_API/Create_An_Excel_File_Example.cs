using Microsoft.Office.Interop.Excel;
using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelSheetCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Application excelApp = new Excel.Application();
            try
            {
                if (excelApp == null)
                {
                    Console.WriteLine("Excel is not properly installed!!");
                    return;
                }

                excelApp.Visible = false;  // Set to false to run Excel in the background

                // Create a new, empty workbook and add a worksheet
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
                worksheet.Name = "MySheet";

                // Populate the worksheet with numbers 1 to 10
                int i = 1;
                int k = 1;
                while(i <= 10)
                {
                    worksheet.Cells[k, 1] = $"Table i={i}";
                    for (int j =1; j <= 10; j++)
                    {
                        worksheet.Cells[k, 2] = $"{i}";
                        worksheet.Cells[k, 3] = $"{j}";
                        worksheet.Cells[k, 4] = $"{i*j}";
                        k++;
                    }
                    i++;
                }

                // Save the workbook
                string filepath = @"C:\Temp\MyExcel.xlsx";  // Change the path as needed
                workbook.SaveAs(filepath);
                workbook.Close(true);
                Console.WriteLine("Excel file created successfully at: " + filepath);
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                excelApp.Quit();  // Close Excel application
            }

            Console.ReadKey();  // Keeps the console window open
        }
    }
}
