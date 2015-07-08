using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CRUD_generico.DB
{
    /**
     * TODO: ESTE PATRON DE DISEÑO PERMITE UNA Y SOLO UNA CONEXIÓN A LA VES AL SERVIDOR DE BASES DE DATOS
     **/
    class ConnSingleton
    {
        private static ConnSingleton dbInstance;
        private readonly SqlConnection conn = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=Potosinos;User ID=supervisor;Password=sqlServer1");

        private ConnSingleton()
        {
        }

        public static ConnSingleton getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new ConnSingleton();
            }
            return dbInstance;
        }

        public SqlConnection GetDBConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connected");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Not connected : " + e.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("End..");
                // Console.WriteLine("Not connected : " + e.ToString());
                Console.ReadLine();
            }
            Console.ReadLine();
            return conn;
        }

    }
}
