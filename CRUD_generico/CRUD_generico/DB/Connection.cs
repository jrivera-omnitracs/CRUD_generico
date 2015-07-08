using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CRUD_generico.DB
{
    class Connection
    {
        public static SqlConnection GetDBConnection()
        { 
            SqlConnection conn = new SqlConnection(Contract.DB_CONN_STRING);

            try
            {
                conn.Open();
                //Console.WriteLine("Connected");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Not connected : " + e.ToString());
                Console.ReadLine();
            }
            finally
            {
                //Console.WriteLine("You're connected..");
            }
            return conn;
        }
    }
}
