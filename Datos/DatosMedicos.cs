using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosMedicos
    {
        Conexiones ds = new Conexiones();

        // Método para realizar el login de un médico.

        public String LoginMedico(string userName, string PWD)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosLoginMedico(ref comando, userName, PWD);
            return ds.ConseguirDatoSingularProcedimientoAlmacenado(comando, "SpBuscarLoginMedico");
        }

        // Método para realizar el login de un administrador.

        public String LoginAdmin(string userName, string PWD)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosLoginAdmin(ref comando, userName, PWD);
            return ds.ConseguirDatoSingularProcedimientoAlmacenado(comando, "SpBuscarLoginAdmin");
        }

        // Método privado para armar los parámetros necesarios para el login de un médico.

        private void ArmarParametrosLoginMedico(ref SqlCommand Comando, string userName, string PWD)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreUsuario_ME", SqlDbType.VarChar);
            SqlParametros.Value = userName;
            SqlParametros = Comando.Parameters.Add("@Contraseña_ME", SqlDbType.VarChar);
            SqlParametros.Value = PWD;
        }

        // Método privado para armar los parámetros necesarios para el login de un administrador.

        private void ArmarParametrosLoginAdmin(ref SqlCommand Comando, string userName, string PWD)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreUsuario_ADM", SqlDbType.VarChar);
            SqlParametros.Value = userName;
            SqlParametros = Comando.Parameters.Add("@Contraseña_ADM", SqlDbType.VarChar);
            SqlParametros.Value = PWD;
        }

        // Método para verificar si un médico existe en la base de datos usando su DNI y si está activo.

        public Boolean existeMedico(Medicos med)
        {
            String consulta = "Select * from Medicos where Dni_ME = " + med.Dni_ME1 + " AND Activos_ME = 1";
            return ds.existe(consulta);
        }


        // Método para verificar si un medico existe en la base de datos usando su telefono y si está activo.


        public Boolean existeMedicoporTelefono(string telefono)
        {
            String consulta = "Select * from Medicos where Telefono_ME = '" + telefono + "' AND Activos_ME = 1";
            return ds.existe(consulta);
        }


        // Método para verificar si un médico existe en la base de datos usando su correo y si está activo.


        public Boolean existeMedicoporCorreo(string correo)
        {
            String consulta = "Select * from Medicos where Correo_Electronico_ME = '" + correo + "' AND Activos_ME = 1";
            return ds.existe(consulta);
        }


        // Método para verificar si un médico existe en la base de datos usando su legajo y si está activo.

        public Boolean existeMedicoPorLegajo(Medicos med)
        {
            String consulta = "Select * from Medicos where Legajo_ME = " + med.Legajo_ME1 + " AND Activos_ME = 1";
            return ds.existe(consulta);
        }

        // Metodos para verificar existencias de mas de un telefono, telefono o DNI

        public int existeMedicoporMasDeUnTelefono(string telefono)
        {
            String consulta = "Select  COUNT(*) AS TotalCount  from Medicos where Telefono_ME = '" + telefono + "' AND Activos_ME = 1";
            return ds.Obtenercontador(consulta);
        }

        public int existeMedicoporMasDeUnCorreo(string correo)
        {
            String consulta = "Select COUNT(*) AS TotalCount from Medicos where Correo_Electronico_ME = '" + correo + "' AND Activos_ME = 1";
            return ds.Obtenercontador(consulta);
        }

        public int existeMedicoporMasDeUnDni(string dni)
        {
            String consulta = "Select COUNT(*) AS TotalCount from Medicos where Dni_ME = '" + dni + "' AND Activos_ME = 1";
            return ds.Obtenercontador(consulta);
        }

        // Método privado para armar los parámetros necesarios para agregar un médico.

        public void ArmarParametrosMedicosAgregar(ref SqlCommand Comando, Medicos med)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Nombre_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Nombre_ME1;
            SqlParametros = Comando.Parameters.Add("@Apellido_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Apellido_ME1;
            SqlParametros = Comando.Parameters.Add("@Dni_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Dni_ME1;
            SqlParametros = Comando.Parameters.Add("@Sexo_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Sexo_ME1;
            SqlParametros = Comando.Parameters.Add("@Nacionalidad_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Nacionalidad_ME1;
            SqlParametros = Comando.Parameters.Add("@Fecha_De_Nacimiento_ME", SqlDbType.Date);
            SqlParametros.Value = med.Fecha_de_Nacimiento_ME1;
            SqlParametros = Comando.Parameters.Add("@Direccion_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Direccion_ME1;
            SqlParametros = Comando.Parameters.Add("@Id_Localidades_ME", SqlDbType.Int);
            SqlParametros.Value = med.Id_Localidades_ME1;
            SqlParametros = Comando.Parameters.Add("@Id_Provincias_ME", SqlDbType.Int);
            SqlParametros.Value = med.Id_Provincias_ME1;
            SqlParametros = Comando.Parameters.Add("@Correo_Electronico_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Correo_Electronico_ME1;
            SqlParametros = Comando.Parameters.Add("@Telefono_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Telefono_ME1;
            SqlParametros = Comando.Parameters.Add("@Especialidad_ME", SqlDbType.Int);
            SqlParametros.Value = med.Especialidad_ME1;
            SqlParametros = Comando.Parameters.Add("@Dias_y_Horarios_ME", SqlDbType.Int);
            SqlParametros.Value = med.Dias_y_Horarios_ME1;
        }

        // Método privado para armar los parámetros necesarios para modificar un médico.

        public void ArmarParametrosMedicoModificar(ref SqlCommand Comando, Medicos med)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@legajo_ME", SqlDbType.Int);
            SqlParametros.Value = med.Legajo_ME1;
            SqlParametros = Comando.Parameters.Add("@Nombre_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Nombre_ME1;
            SqlParametros = Comando.Parameters.Add("@Apellido_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Apellido_ME1;
            SqlParametros = Comando.Parameters.Add("@Dni_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Dni_ME1;
            SqlParametros = Comando.Parameters.Add("@Sexo_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Sexo_ME1;
            SqlParametros = Comando.Parameters.Add("@Nacionalidad_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Nacionalidad_ME1;
            SqlParametros = Comando.Parameters.Add("@Fecha_De_Nacimiento_ME", SqlDbType.Date);
            SqlParametros.Value = med.Fecha_de_Nacimiento_ME1;
            SqlParametros = Comando.Parameters.Add("@Direccion_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Direccion_ME1;
            SqlParametros = Comando.Parameters.Add("@Id_Localidades_ME", SqlDbType.Int);
            SqlParametros.Value = med.Id_Localidades_ME1;
            SqlParametros = Comando.Parameters.Add("@Id_Provincias_ME", SqlDbType.Int);
            SqlParametros.Value = med.Id_Provincias_ME1;
            SqlParametros = Comando.Parameters.Add("@Correo_Electronico_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Correo_Electronico_ME1;
            SqlParametros = Comando.Parameters.Add("@Telefono_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Telefono_ME1;
            SqlParametros = Comando.Parameters.Add("@Especialidad_ME", SqlDbType.Int);
            SqlParametros.Value = med.Especialidad_ME1;
            SqlParametros = Comando.Parameters.Add("@Dias_y_Horarios_ME", SqlDbType.VarChar);
            SqlParametros.Value = med.Dias_y_Horarios_ME1;
        }

        // Método privado para armar los parámetros necesarios para eliminar un médico.

        public void ArmarParametrosMedicosEliminar(ref SqlCommand Comando, Medicos med)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Legajo_ME", SqlDbType.Int);
            SqlParametros.Value = med.Legajo_ME1;
        }

        // Método para agregar un nuevo médico a la base de datos.

        public int agregarMedicos(Medicos med)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMedicosAgregar(ref comando, med);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarMedico");
        }

        // Método para eliminar un médico de la base de datos.

        public int eliminarMedicos(Medicos med)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMedicosEliminar(ref comando, med);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpEliminaMedico");
        }

        // Método para editar la información de un médico existente en la base de datos.

        public int EditarMedicos(Medicos med)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMedicoModificar(ref comando, med);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spActualizarMedico");
        }

        // Método para obtener la tabla de médicos activos.

        public DataTable ObtenerTablaMedicos()
        {
            DataTable Tabla = ds.ObtenerTabla("Medicos", "Select Legajo_ME AS Legajo, Nombre_ME AS Nombre, Apellido_ME AS Apellido," +
                " Dni_ME AS Dni, Sexo_Me AS Sexo, Nacionalidad_ME AS Nacionalidad, Fecha_de_Nacimiento_ME AS [Fecha de Nacimiento], Direccion_ME AS Direccion," +
                " Id_Localidades_ME AS Localidad, Id_Provincias_ME AS Provincia, Correo_Electronico_ME AS [Correo Electronico], Telefono_ME AS Telefono," +
                " Especialidad_ME AS Especialidad, Dias_y_Horarios_ME AS [Dias y Horarios] from Medicos WHERE Activos_ME = 1");
            return Tabla;
        }

        // Método para obtener la tabla de médicos activos por legajo

        public DataTable ObtenerTablaMedicosXlegajo(string legajo)
        {
            DataTable Tabla = ds.ObtenerTabla("Medicos", "Select Legajo_ME AS Legajo, Nombre_ME AS Nombre, Apellido_ME AS Apellido," +
                " Dni_ME AS Dni, Sexo_Me AS Sexo, Nacionalidad_ME AS Nacionalidad, Fecha_de_Nacimiento_ME AS [Fecha de Nacimiento], Direccion_ME AS Direccion," +
                " Id_Localidades_ME AS Localidad, Id_Provincias_ME AS Provincia, Correo_Electronico_ME AS [Correo Electronico], Telefono_ME AS Telefono," +
                " Especialidad_ME AS Especialidad, Dias_y_Horarios_ME AS [Dias y Horarios] from Medicos WHERE Activos_ME = 1 AND Legajo_ME = '" + legajo + "'");
            return Tabla;
        }

        // Método para cargar una lista desplegable con datos de médicos según su especialidad.

        public List<Tuple<string, string>> DropDownListcargardatos(int i)
        {
            List<Tuple<string, string>> Medicos = new List<Tuple<string, string>>();

            string consultaSQLProvincias = "select * from Medicos WHERE Especialidad_ME = '" + i + "' AND Activos_ME = '1'";
            DataTable tabla = ds.ObtenerTabla("Medicos", consultaSQLProvincias);

            foreach (DataRow row in tabla.Rows)
            {
                string DatosMedicostablaNombre = row["Nombre_ME"].ToString(); // Asumiendo que hay una columna "Nombre"
                string DatosMedicostablaID = row["Legajo_ME"].ToString(); // Asumiendo que hay una columna "Id"

                Medicos.Add(new Tuple<string, string>(DatosMedicostablaNombre, DatosMedicostablaID));
            }

            return Medicos;
        }
        // Método para obtener la cuenta total de turnos presentes en un rango de fechas específicas.

        public int ObtenerCuentaTotalEspecialidadx(string especialidad)
        {
            string consulta = "SELECT COUNT(*) AS TotalCount FROM Medicos WHERE Medicos.Especialidad_ME = '" + especialidad + "' AND Activos_ME = '1'";
            return ds.Obtenercontador(consulta);
        }

        // Método para obtener la cuenta total de turnos ausentes en un rango de fechas específicas.

        public int ObtenerCuentaTotalMedicos()
        {
            string consulta = "SELECT COUNT(*) AS TotalCount FROM Medicos WHERE Activos_ME = '1'";
            return ds.Obtenercontador(consulta);
        }

        // Método para cargar una lista desplegable con datos de médicos según su especialidad.

        public DataTable ObtenerTablaMedicosXEspecialidad(string especialidad)
        {
            DataTable Tabla = ds.ObtenerTabla("Medicos", "Select Legajo_ME AS Legajo, Nombre_ME AS Nombre, Apellido_ME AS Apellido," +
                " Dni_ME AS Dni, Sexo_Me AS Sexo, Nacionalidad_ME AS Nacionalidad, Fecha_de_Nacimiento_ME AS [Fecha de Nacimiento], Direccion_ME AS Direccion," +
                " Id_Localidades_ME AS Localidad, Id_Provincias_ME AS Provincia, Correo_Electronico_ME AS [Correo Electronico], Telefono_ME AS Telefono," +
                " Especialidad_ME AS Especialidad, Dias_y_Horarios_ME AS [Dias y Horarios] from Medicos WHERE Activos_ME = 1 AND Especialidad_ME = '" + especialidad + "'");
            return Tabla;
        }

    }
}
