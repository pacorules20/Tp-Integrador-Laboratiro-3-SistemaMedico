using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexiones
    {
        static string RutaSQL = "Data Source=localhost\\sqlexpress; Initial Catalog=DB_tpintegradosProg3_grupo2;Integrated Security=True";

        SqlConnection cn = new SqlConnection(RutaSQL);

        // Método privado para obtener una nueva conexión a la base de datos.

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(RutaSQL);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // Método para ejecutar una consulta que devuelve un único valor string.

        public string EjecutarQueryDevuelveString(string query)
        {
            string valor = "";
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(query, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                valor = Convert.ToString(datos[0]);
                return valor;
            }
            Conexion.Close();
            return null;
        }


        // Método privado para obtener un adaptador de datos.

        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // Método para obtener una tabla de la base de datos.

        public DataTable ObtenerTabla(String NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }

        // Método para ejecutar un procedimiento almacenado que modifica datos en la base de datos.

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }

        // Método para obtener un dato singular de un procedimiento almacenado.

        public string ConseguirDatoSingularProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            string valor = "";
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                valor = Convert.ToString(datos[0]);
                return valor;
            }
            return null;
        }

        // Método para verificar si existe algún resultado para una consulta dada.

        public Boolean existe(String consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }

        // Método para obtener un contador (valor numérico) de una consulta.

        public int Obtenercontador(String consulta)
        {
            int contador = 0;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            contador = (int)cmd.ExecuteScalar();
            return contador;
        }
    }
}
