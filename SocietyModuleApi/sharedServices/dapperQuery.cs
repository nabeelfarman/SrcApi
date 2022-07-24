
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using SocietyModuleAPI.Configuration;
using Microsoft.Extensions.Options;
using System.IO;

namespace SocietyModuleAPI.Services
{
    public class dapperQuery
    {


        public static IEnumerable<T> Qry<T>(string sql, IOptions<conStr> conStr)
        {

            using (IDbConnection con = new SqlConnection(conStr.Value.dbCon))
            {

                IEnumerable<T> result;

                // check connection state
                if (con.State == ConnectionState.Closed)
                    con.Open();

                result = con.Query<T>(sql).ToList();

                // colose connection
                if (con.State == ConnectionState.Open)
                    con.Close();

                return result;
            }
        }

        public static IEnumerable<string> SPReturn<T>(string proceedure, T p, IOptions<conStr> conStr)
        {
            using (IDbConnection con = new SqlConnection(conStr.Value.dbCon))
            {                // var result = new List<T1>();
                string[] response = new string[2];
                // check connection state
                if (con.State == ConnectionState.Closed)
                    con.Open();

                var row = con.Query<string>(proceedure, p, commandType: CommandType.StoredProcedure);

                // response[0] = p.Get<string>("@response");
                // response[1] = p.Get<string>("@seq");

                // colose connection
                if (con.State == ConnectionState.Open)
                    con.Close();

                return row;
            }
        }

        public static string saveImageFile(string regPath, string name, string binData, string ext)
        {
            String path = regPath; //Path
            //Check if directory exist
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path); //Create directory if it doesn't exist
            }

            string imageName = name + "." + ext;

            //set the image path
            string imgPath = Path.Combine(path, imageName);

            byte[] imageBytes = Convert.FromBase64String(binData);

            System.IO.File.WriteAllBytes(imgPath, imageBytes);

            return "Ok";
        }

        public static string SP<T>(string spName, T model, string conStr)
        {

            using (IDbConnection con = new SqlConnection(conStr))
            {                // var result = new List<T1>();
                List<DBResponse> dbResponse;
                string response;
                try
                {
                    // check connection state
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    dbResponse = con.Query<DBResponse>(spName, model, commandType: CommandType.StoredProcedure).ToList();
                    response = dbResponse[0].response;

                }
                catch (Exception ex)
                {
                    response = ex.Message;
                }
                finally
                {
                    // colose connection
                    if (con.State == ConnectionState.Open)
                        con.Close();

                }
                return response;
            }
        }
    }
}