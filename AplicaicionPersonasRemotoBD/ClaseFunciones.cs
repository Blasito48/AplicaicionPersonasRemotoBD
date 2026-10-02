using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicaicionPersonasRemotoBD
{
    public class ClaseFunciones
    {
        public static string cadena = "workstation id=BDPersona.mssql.somee.com;packet size=4096;user id=Blasito48_SQLLogin_1;pwd=ucnakrf5vu;data source=BDPersona.mssql.somee.com;persist security info=False;initial catalog=BDPersona;TrustServerCertificate=True";
        public static string excepcion = "";
        //Funcion Conectar
        public static bool Func_Conectar()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                cnn.Open();
                cnn.Close();
                return true;

            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return false;
            }
        }
    }
}
