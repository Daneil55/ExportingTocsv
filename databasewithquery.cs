using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SQLite;

namespace ExportingTocsv
{
    internal class databasewithquer
    {
        public static string databasewithqures()
        {

         //   string connectionString = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DaaaSourcedatabase.db");
         //   System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection(connectionString);
         ////  connection.Open();


           
            // Create a connection to the SQLite database
            //  string connectionString = "Data Source=database.db";
        //    var connections = new System.Data.SQLite.SQLiteConnection(connectionString);

        //    // Open the database connection
        //    //  connection.Open();
        //  //  connections.Open();
        //        // Create a table
        //        using (var command = connection.CreateCommand())
        //        {
        //            command.CommandText = @"
        //    CREATE TABLE IF NOT EXISTS Person (
        //        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        //        FirstName TEXT NOT NULL,
        //        LastName TEXT NOT NULL
        //    );
        //";
        //            command.ExecuteNonQuery();
        //        }
            return "the table have been created succefully";
        }


           
        }

    }

