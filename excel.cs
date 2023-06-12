using Microsoft.Office.Interop.Excel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Syncfusion.XlsIO;
using System.Xml.Linq;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;

using Microsoft.Office.Interop.Word;
using Application = Microsoft.Maui.Controls.Application;
using Microsoft.Maui.Controls;

namespace ExportingTocsv
{
    internal class excel
    {

        static string db = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "localsDataBase.db");
        public static SQLiteAsyncConnection connection = new SQLiteAsyncConnection(db);



        static string name;
        static string date;
        static string time;
        public static string imagepath;
        public static string imagepaths;
        public static string imagename;
        static PickOptions options;
      

    
        public static async void openfiles() 
        {
            //name = "Daniel";
            //date = "7/7/3882";
            //time = "34:46";
            //excelstream = @"C:\Users\HP\Downloads\houe.doc";
            //MainPage main = new MainPage();
            var result = await FilePicker.Default.PickAsync(options);
            if (result != null)
            {
                if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                    result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                {
                    using var stream = await result.OpenReadAsync();
                    var image = ImageSource.FromStream(() => stream);
                    imagepath = result.FullPath;
                   // return result.FullPath;
                    imagename=result.FileName;

                }
            }
           // return imagepath;
        }
    
            
           public static string excelstream;
        public static string csvcreation()

        {
        
            var query = connection.Table<OrdersTB>().ToListAsync();
            string csvPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"C:\Users\HP\Downloads\houe.csv");
            using (var writer = new StreamWriter(csvPath))
            {
                var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(query.Result);
            }

            return excelstream;
        }




        // -----------------------------------------------------------------------------image treatment lines-------------------------------------------------------------------------------------


        public static string createtable(string name, string image )
        {
            connection.CreateTableAsync<OrdersTB>();
            var tablevalues = new OrdersTB
            {
               
                image = ImageToBinary(imagepath),
                name = string.Empty,
                date = date,
                time = time

        };
            connection.InsertAsync(tablevalues);

            return "complitly saved";
        }
        public static void listPTB(string name, string presence){ 
        connection.CreateTableAsync<List_of_PTB>();
            var presence_list = new List_of_PTB()
            {   
                name = name,
                presence = presence
                
                
            };       
        connection.InsertAsync(presence_list);
        }
        public static Task<List<List_of_PTB>> attendenceReader() 
        {
          return connection.Table<List_of_PTB>().ToListAsync();
        }

        public static void listPTB1(string image, string name, string secName)
        {
            connection.CreateTableAsync<List_of_PTB1>();
            var presence_list = new List_of_PTB1()
            {
                image = ImageToBinary(image),
                name = name,
                secName= secName
            };
            connection.InsertAsync(presence_list);
            
        }
        static public Task<List<List_of_PTB1>> attendenceReader12()
        {
            return connection.Table<List_of_PTB1>().ToListAsync();
        }

        static public Task<List<OrdersTB>> reader()
        {

             return connection.QueryAsync<OrdersTB>("SELECT * FROM [OrdersTB] WHERE [image] != null");

           // return connection.Table<OrdersTB>().ToListAsync();



        }


        public static byte[] ImageToBinary(string imagePath)
        {
            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, (int)fileStream.Length);
            fileStream.Close();
            return buffer;
        }

    
   }
 }

