
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Options;
using UMISModuleAPI.Configuration;
using UMISModuleAPI.Entities;

namespace UMISModuleAPI.Services
{
    public class dapperQuery
    {
        public static IEnumerable<T> Qry<T>(string sql, IOptions<conStr> conStr)
        {
            using (IDbConnection con = new SqlConnection(conStr.Value.dbCon))
            {
                return con.Query<T>(sql);
            }
        }
        public static IEnumerable<string> SPReturn<T>(string procName, T model, IOptions<conStr> conStr)
        {
            using (IDbConnection con = new SqlConnection(conStr.Value.dbCon))
            {
                var row = con.Query<string>(procName, model, commandType: CommandType.StoredProcedure);

                return row;
            }
        }
    }
}