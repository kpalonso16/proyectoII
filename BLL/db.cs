using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class db
    {
        public SqlConnection conexion = new SqlConnection();

        public SqlConnection ObtenerConexion()
        {
            conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL_AUT"].ToString());


            try
            {
                if (conexion != null && conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                return conexion;
            }

            catch (Exception ex)
            {
                conexion.Close();
                throw ex;
            }
        }

        public bool DescargarConexion()
        {
            conexion.Close();
            return true;
        }
    }
}
