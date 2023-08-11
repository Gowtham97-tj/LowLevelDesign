using BuildingBlocks.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BuildingBlocks.DataAccess
{
    public class Repository<T> : IRepository<T>
    {
        private readonly IConnectionFactory _connectionFactory;

        protected Repository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        private IDbConnection DbConnection
        {
            get
            {
                return _connectionFactory.DbConnection;
            }
        }
    }
}
