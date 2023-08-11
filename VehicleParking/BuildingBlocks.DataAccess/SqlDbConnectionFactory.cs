using BuildingBlocks.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BuildingBlocks.DataAccess
{
    public class SqlDbConnectionFactory : IConnectionFactory
    {
        private static string _connectionString;

        public IDbConnection DbConnection
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    throw new Exception("Connection String Not Initialized");
                }
                var connection = new SqlConnection(_connectionString);
                return connection;
            }
        }

        public static void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
