using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ctrlArchivos.Modelo
{
    public class Conectasql
    {

        //NOTA LA RUTA DE CONEXION AL FINAL DEL PROYECTO SE PUEDE COLOCAR COMO ESTATICA Y SE MANIPULA DESDE LAS PROPIEDADES DEL PROGRAMA

        //RUTA QUE GUARDA LOS PARAMETROS DE CONEXION 
        public String connectionRoute { set; get; }

        //CONSTRUCTORES QUE INICIALIZAN LA CADENA DE CONEXION
        public Conectasql() { }

        public Conectasql(String c)
        {
            connectionRoute = c;
        }

        //METODO DE CONEXION APLICA PARA TRABAJAR EN ENTORNO DESCONECTADO 
        public SqlConnection Mconect(ref String m)
        {
            connectionRoute = "Data Source=.; Initial Catalog=insunipue; Integrated Security=SSPI;";
            SqlConnection Useconec = new SqlConnection();
            Useconec.ConnectionString = connectionRoute;
            try
            {
                Useconec.Open();
                m = "Conexion establecida";
            }
            catch (Exception d)
            {
                m = "Error de conexion" + d.Message;
                Useconec = null;
            }
            return Useconec;
        }

        //METODO QUE RETORNA UNA CONSULTA DE LECTURA, REQUIERE DE TRES PARAMETROS QUE SON: LA CONEXION ABIERTA, CONSULTA, UNA VARIABLE CADENA DONDE RETORNAMOS ALGUNA EXCEPCION O MENSAJE
        public SqlDataReader Queryreader(SqlConnection Cabierta, String query, ref String m)
        {
            SqlDataReader Resquery = null;
            SqlCommand Comand = new SqlCommand();

            if (Cabierta != null)
            {
                Comand.Connection = Cabierta;
                Comand.CommandText = query;
                try
                {
                    Resquery = Comand.ExecuteReader();
                    m = "Consulta correcta";
                }
                catch (Exception d)
                {
                    m = "Error " + d;
                    Resquery = null;
                }
            }
            else
            {
                m = "Error de conexion ";
            }
            return Resquery;
        }

        //METODO QUE RETORNA UNA CONSULTA Y ES USADA EN UN DATA SET, REQUIERE DE TRES PARAMETROS QUE SON: LA CONEXION ABIERTA, CONSULTA, UNA VARIABLE CADENA DONDE RETORNAMOS ALGUNA EXCEPCION O MENSAJE
        public DataSet consultaset(SqlConnection Copen, String query, ref String m)
        {
            DataSet res = new DataSet();
            res = null;
            SqlCommand Comand = new SqlCommand();
            SqlDataAdapter MoreComand = new SqlDataAdapter();
            if (Copen != null)
            {
                Comand.Connection = Copen;
                Comand.CommandText = query;
                MoreComand.SelectCommand = Comand;
                try
                {
                    MoreComand.Fill(res);
                    m = "Consulta correcta";
                }
                catch (Exception d)
                {
                    m = "Error " + d;
                    res = null;
                }
                Copen.Close();
                Copen.Dispose();
            }
            else
            {
                m = "Error de conexion";
            }
            return res;
        }

        //METODO QUE GENERA UN DATA SET EN REFERENCIA PARA TENER MAS LIBERTAD DE MANIPULAR LA INFORMACION, REQUIERE COM PARAMETROS: 
        //DATA SET POR REFERENCIA, CONEXION ABIERTA, QUERY, VARIABLE DONDE SE GUARDA EL MENSAJE, UN ALIAS PARA LA TABLA 
        public void querysetrefer(ref DataSet myset, SqlConnection Copen, String query, ref String m, String alias)
        {
            SqlCommand Comand = new SqlCommand();
            SqlDataAdapter Morecomand = new SqlDataAdapter();

            if (Copen != null)
            {
                Comand.Connection = Copen;
                Comand.CommandText = query;
                Morecomand.SelectCommand = Comand;
                try
                {
                    Morecomand.Fill(myset, alias);
                    m = "Consulta correcta";
                }
                catch (Exception d)
                {
                    m = "Error " + d;
                    myset = null;
                }
                Copen.Close();
                Copen.Dispose();
            }
            else
            {
                m = "Error de conexion";
            }
        }

        //METODO GENERICO PARA REALIZAR UNA INSERCCION, ACTUALIZACION, ELIMINACION A LA BASE DE DATOS, REQUIERE COMO PARAMETROS UNA CONEXION ABIERTA, QUERY, VARIABLE DONDE SE ETORNA UN MENSAJE
        public void executequery(SqlConnection Copen, String query, ref String m)
        {
            String showquery = "";
            showquery = query.Substring(0, 3);

            SqlCommand Comand = new SqlCommand();
            if (Copen != null)
            {
                Comand.Connection = Copen;
                Comand.CommandText = query;
                try
                {
                    Comand.ExecuteNonQuery();
                    if (showquery == "Ins")
                    {
                        m = "Inserccion Correcta";
                    }
                    if (showquery == "Del")
                    {
                        m = "Eliminación Correcta";
                    }
                    if (showquery == "Upd")
                    {
                        m = "Actualización Correcta";
                    }
                }
                catch (Exception d)
                {
                    m = "Error " + d;
                }
            }
            else
            {
                m = "Error de conexion ";
            }
        }









    }
}