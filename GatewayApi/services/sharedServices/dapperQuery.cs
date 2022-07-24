
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace gatewayapi.Services
{
    public class dapperQuery
    {

        public static IEnumerable<T> Qry<T>(string sql, string conStr)
        {

            using (IDbConnection con = new SqlConnection(conStr))
            {
                return con.Query<T>(sql).ToList();
            }
        }
    }
}