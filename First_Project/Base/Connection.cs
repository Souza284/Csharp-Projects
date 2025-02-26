using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Project.Models;
using Microsoft.Data.SqlClient;

namespace First_Project.Base
{
    internal class Connection
    {
        private string connectionString = @"data source=DESKTOP-P3RKM7N\SQLEXPRESS;initial catalog=ScreenSound;trusted_connection=true";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public IEnumerable<Artist> _ToList()
        {
            var list = new List<Artist>();

            using var connection = GetConnection();
            connection.Open();

            string sql = "SELECT * FROM Artists";

            
        }
    }
}