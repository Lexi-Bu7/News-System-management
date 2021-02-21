using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Text;
using System.Data.SqlClient;

namespace lexiUtiliy.MsSqlHelper
{
    public class YFMsSqlHelper
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["lexi"].ConnectionString;

        #region 
        public static int ExecuteSql(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString,connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (SqlException E)
                    {
                        connection.Close();
                        throw new Exception(E.Message);
                    }
                }
            }
        }
        #endregion


    }
}
