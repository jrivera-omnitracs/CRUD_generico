using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD_generico.DB
{
    class Contract
    {
        public static readonly string DB_NAME = "db_gmodelo";
        public static readonly string DB_USER = "abdupiicsa";
        public static readonly string DB_PASS = "base";
        public static readonly string DB_CONN_STRING = @"Data Source=EDWIN-PC\SQLEXPRESS;Initial Catalog=" + DB_NAME + ";User ID=" + DB_USER + ";Password=" + DB_PASS + "";

        public static class Usuarios
        {
            public static readonly string TABLE_NAME = "usuarios";
            public static readonly string COLUMN_NAME_ID = "id"; 
            public static readonly string COLUMN_NAME_NOMBRE = "name";
            public static readonly string COLUMN_NAME_APATERNO = "aPaterno";
            public static readonly string COLUMN_NAME_AMATERNO = "aMaterno";
            public static readonly string COLUMN_NAME_USUARIO = "usuario";
            public static readonly string COLUMN_NAME_PASSWORD = "contrasena";

            public static readonly string PROCEDURE_CREATE = "proc_Create_Usuarios";
            public static readonly string PROCEDURE_UPDATE = "proc_Update_Usuarios";
            public static readonly string PROCEDURE_DELETE = "proc_Delete_Usuarios";
            public static readonly string PROCEDURE_LOGIN = "proc_Login_Usuarios";
            public static readonly string PROCEDURE_READ = "proc_Select_Usuarios";

        }
    }
}
