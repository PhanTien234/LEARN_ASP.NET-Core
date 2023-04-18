using System.Runtime.InteropServices;
using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace adodotnet{
    class Program{
        static void Main(string[] args){
            var sqlStringBuilder = new MySqlConnectionStringBuilder();  //SqlConnectionStringBuilder();
            sqlStringBuilder["Server"] = "localhost";
            sqlStringBuilder["Database"] = "new_schema";
            sqlStringBuilder["UID"] = "root";
            sqlStringBuilder["PWD"] = "abc123";
            sqlStringBuilder["Port"] = "3307";

            var sqlStringConnection = sqlStringBuilder.ToString();
            Console.WriteLine(sqlStringConnection);
            // string sqlStringConnection = "Data Source = localhost,1433;Initial Catalog=xtlab;User ID=sa;Password=Password123";
            using var connection = new MySqlConnection(sqlStringConnection);//SqlConnection(sqlStringConnection);
            connection.Open();
            Console.WriteLine(connection.State);
             //..truy van
            using DbCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Sanpham Limit 0,10";

            var datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                Console.WriteLine($"{datareader["TenSanpham"], 10} Gia {datareader["Gia"], 8}");
            }
            connection.Close();
        }
    }
}