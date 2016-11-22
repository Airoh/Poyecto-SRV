using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using System.Data;

namespace SRV.Componentes.Acceso
{
    public class ManejadorDB
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        // PostgeSQL-style connection string
        private string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", 5432, "postgres", "123", "SRV");
        public ManejadorDB()
        {

        }
        /*Retorno de tablas*/
        public DataTable EjecutarEscalar(string sql)
        {
            try
            {
                // Conexion
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                // Abrir Conexion
                conn.Open();
                // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                //limpieza de ds
                ds.Reset();
                // Llenado de dataset
                da.Fill(ds);
                // Llenado de dataTable
                dt = ds.Tables[0];
                // Cerrar Conexion
                conn.Close();
                // Retorno de tabla
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /*Ejecucion de SQL*/
        public Boolean EjecutarSQL(string sql)
        {
            try
            {
                // Conexion
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                // Abrir Conexion
                conn.Open();
                // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                // Cerrar Conexion
                conn.Close();
                // Retorno de respuesta
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        /*Ejecucion de Escalar*/
        public string EjecutarNoEscalar(string sql)
        {
            try
            {
                // Conexion
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                // Abrir Conexion
                conn.Open();
                // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                //limpieza de ds
                ds.Reset();
                // Llenado de dataset
                da.Fill(ds);
                // Llenado de dataTable
                dt = ds.Tables[0];
                // Cerrar Conexion
                conn.Close();
                // Retorno de tabla
                return Convert.ToString(dt.Rows[0].ItemArray[0].ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }


    }
}