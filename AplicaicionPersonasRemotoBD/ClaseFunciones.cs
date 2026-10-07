using Microsoft.Data.SqlClient;
using System.Data;

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
        public static DataTable Func_TraerDatos()
        {
            DataTable dt= new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                //adpatador necesita una consulta sql y una conexion
                string consulta = "Select * From Tbl_Persona";
                SqlDataAdapter adap = new SqlDataAdapter(consulta,cnn);
                //ejecuto el adaptador para que llene los datos en una tabla
                adap.Fill(dt);
                return dt;

            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return dt;
            }
        }
        public static bool Func_Insertar(long id, string name,string tel)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                //adpatador necesita una consulta sql y una conexion
                string consulta = "Insert Into Tbl_Persona Values (" + id + ",'" + name + "','" + tel +"')";
                SqlDataAdapter adap = new SqlDataAdapter(consulta, cnn);
                //ejecuto el adaptador para que llene los datos en una tabla
                adap.Fill(dt);
                return true;

            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return false;
            }
        }
        //FUNCION ELIMINAR

        public static bool Func_Eliminar(long id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                //adpatador necesita una consulta sql y una conexion
                string consulta = "Delete From Tbl_Persona Where ID=" + id ;
                SqlDataAdapter adap = new SqlDataAdapter(consulta, cnn);
                //ejecuto el adaptador para que llene los datos en una tabla
                adap.Fill(dt);
                return true;

            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return false;
            }
        }
        //FUNCION EDITAR
        public static bool Func_Editar(long id, string name, string tel)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                //adpatador necesita una consulta sql y una conexion
                string consulta = "Update Tbl_Persona Set Nombre='" + name + "', Telefono='" + tel + "' Where ID="+id;
                SqlDataAdapter adap = new SqlDataAdapter(consulta, cnn);
                //ejecuto el adaptador para que llene los datos en una tabla
                adap.Fill(dt);
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
