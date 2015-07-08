﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CRUD_generico.DB;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_generico
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProceduresHelper ph = new ProceduresHelper();
            ProceduresHelper.execSPCreate(Contract.Usuarios.PROCEDURE_CREATE + " 'nombre', 'aParterno', 'aMaterno', 'usuario', 'contrasena'");
            ProceduresHelper.execSPUpdate(Contract.Usuarios.PROCEDURE_UPDATE + " 'usuario', 'constrasena', 'password'");
            ProceduresHelper.execSPDelete(Contract.Usuarios.PROCEDURE_DELETE + " 1");
            bool login = ProceduresHelper.execSPLogin(Contract.Usuarios.PROCEDURE_LOGIN + " 'usuario', 'password'");
            //DataSet ds = ProceduresHelper.execSPRead(Contract.Usuarios.PROCEDURE_READ);
            
            
            //DataRow usuarios = ProceduresHelper.execSPRead(Contract.Usuarios.PROCEDURE_READ).Tables[0].Rows[0];

            //Console.WriteLine("First Name: {0}", (String)usuarios["nombre"]);
            //Console.WriteLine("Last Name:  {0}", (String)usuarios["usuario"]);

            Console.Read();
        }
    }
}
