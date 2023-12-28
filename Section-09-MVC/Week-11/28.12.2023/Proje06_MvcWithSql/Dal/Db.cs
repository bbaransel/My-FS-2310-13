using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
/*
        private static SqlConnection CreateConnection(){
            string connectionString = @"Server=DESKTOP-LHV5FJ2\SQLEXPRESS;Database=Northwind;user=enginniyazi;password=432Er58;TrustServerSertificate=true";
        }
*/


namespace Proje06_MvcWithSql.Dal
{
    public static class Db
    {
        private static SqlConnection connection = CreateConnection();
        private static SqlConnection CreateConnection()
        {
            string connectionString = @"Server=DESKTOP-LHV5FJ2\SQLEXPRESS;Database=Northwind;user=sa;password=1234;TrustServerCertificate=true";
            return new SqlConnection(connectionString);
        }
        public static void OpenCn()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                Console.WriteLine("Bağlantı başarı ile kuruldu...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CloseCn()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                Console.WriteLine("Bağlantı kaldırıldı...");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}