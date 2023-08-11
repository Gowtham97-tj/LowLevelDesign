using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BuildingBlocks.DataAccess.Interface
{
    public interface IConnectionFactory
    {
        IDbConnection DbConnection { get; }
    }   
}
