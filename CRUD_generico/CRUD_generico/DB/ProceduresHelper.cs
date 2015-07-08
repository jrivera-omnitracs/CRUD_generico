using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CRUD_generico.DB;
using System.Data.SqlClient;
using System.Data;

using System.Data;

namespace CRUD_generico.DB
{
    class ProceduresHelper
    {
        public static void execSPCreate(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdCreate = new SqlCommand(sp, conn);
                    cmdCreate.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("El elemento ha sido añadido");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public static DataSet execSPRead(string sp)
        {
            DataSet myDataSet = new DataSet();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();

            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdRead = new SqlCommand(sp, conn);
                    myDataSet.Clear();
                    myDataAdapter.Fill(myDataSet, "usuarios");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            return myDataSet;
        }
        public static void execSPUpdate(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdUpdate = new SqlCommand(sp, conn);
                    cmdUpdate.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("El elemento ha sido modificado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public static void execSPDelete(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdUpdate = new SqlCommand(sp, conn);
                    cmdUpdate.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("El elemento ha sido eliminado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public static bool execSPLogin(string sp)
        {
            bool login = false;
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdLogin = new SqlCommand(sp, conn);
                    SqlDataReader myReader = cmdLogin.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader.GetValue(0).ToString().Equals("1"))
                        {
                            login = true;
                        }
                        break;
                    }
                    conn.Close();
                    if (login)
                    {
                        Console.WriteLine("Bienvenido");
                    }
                    else
                    {
                        Console.WriteLine("Verifica tus datos");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return login;
        }
    }
}
