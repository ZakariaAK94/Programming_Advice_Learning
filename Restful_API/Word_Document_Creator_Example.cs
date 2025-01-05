﻿using System;
using Word = Microsoft.Office.Interop.Word;
///
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WordDocumentCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message = "Hi, My Name is Zakaria AKIL";            
            string Path = @"C:\Temp\MyDocument.docx";

            CreatAWordDocument(Message, Path);
            Console.ReadKey();  
        }
         
        public static void CreatAWordDocument(string Message,string Path)
        {
            Word.Application wordApp = new Word.Application();
            try
            {
                wordApp.Visible = false;  // Set to true if you want to see Word while the document is being created

                Word.Document doc = wordApp.Documents.Add();  // Create a new document
                Word.Paragraph para = doc.Paragraphs.Add();   // Add a paragraph
                para.Range.Text = Message;  

                // Save the document
                string filepath = Path;  // Change the path as needed
                doc.SaveAs2(filepath);
                doc.Close();

                Console.WriteLine("Document created successfully at: " + filepath);
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                wordApp.Quit();  // Close Word application
            }

        }
    }

}
