using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosPacientes
    {
        Conexiones ds = new Conexiones();  // Instancia de la clase Conexiones para manejar la conexión a la base de datos.

        // Método para verificar si existe un paciente por DNI.

        public Boolean existePaciente(Pacientes pac)
        {
            String consulta = "Select * from Pacientes where Dni_PA =" + pac.Dni_PA + " AND Activos_PA = 1";
            return ds.existe(consulta);
        }

        // Método para verificar si existe un paciente por legajo.

        public Boolean existePacientePorLegajo(Pacientes pac)
        {
            String consulta = "Select * from Pacientes where Legajo_PA = " + pac.Legajo_PA1 + " AND Activos_PA = 1";
            return ds.existe(consulta);
        }

        // Método para armar los parámetros necesarios para agregar o modificar un paciente.

        public void ArmarParametrosPacientesAgregarModificar(ref SqlCommand Comando, Pacientes pac)
        {
            SqlParameter SqlParametros = new SqlParameter();

            // Agrega y asigna los parámetros para los datos del paciente.
            SqlParametros = Comando.Parameters.Add("@nombre_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Nombre_PA;
            SqlParametros = Comando.Parameters.Add("@apellido_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Apellido_PA;
            SqlParametros = Comando.Parameters.Add("@dni_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Dni_PA;
            SqlParametros = Comando.Parameters.Add("@sexo_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Sexo_PA;
            SqlParametros = Comando.Parameters.Add("@nacionalidad_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Nacionalidad_PA;
            SqlParametros = Comando.Parameters.Add("@fecha_de_nacimiento_PA", SqlDbType.Date);
            SqlParametros.Value = pac.Fecha_de_nacimiento_PA;
            SqlParametros = Comando.Parameters.Add("@direccion_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Direccion_PA;
            SqlParametros = Comando.Parameters.Add("@id_localidades_PA", SqlDbType.Int);
            SqlParametros.Value = pac.Id_localidades_PA;
            SqlParametros = Comando.Parameters.Add("@id_provincias_PA", SqlDbType.Int);
            SqlParametros.Value = pac.Id_provincias_PA;
            SqlParametros = Comando.Parameters.Add("@correo_electronico_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Correo_electronico_PA;
            SqlParametros = Comando.Parameters.Add("@telefono_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Telefono_PA;
        }

        // Método para armar los parámetros necesarios para modificar un paciente.

        public void ArmarParametrosPacientesModificar(ref SqlCommand Comando, Pacientes pac)
        {
            SqlParameter SqlParametros = new SqlParameter();

            // Agrega y asigna los parámetros para los datos del paciente.
            SqlParametros = Comando.Parameters.Add("@legajo_PA", SqlDbType.Int);
            SqlParametros.Value = pac.Legajo_PA1;
            SqlParametros = Comando.Parameters.Add("@nombre_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Nombre_PA;
            SqlParametros = Comando.Parameters.Add("@apellido_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Apellido_PA;
            SqlParametros = Comando.Parameters.Add("@dni_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Dni_PA;
            SqlParametros = Comando.Parameters.Add("@sexo_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Sexo_PA;
            SqlParametros = Comando.Parameters.Add("@nacionalidad_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Nacionalidad_PA;
            SqlParametros = Comando.Parameters.Add("@fecha_de_nacimiento_PA", SqlDbType.Date);
            SqlParametros.Value = pac.Fecha_de_nacimiento_PA;
            SqlParametros = Comando.Parameters.Add("@direccion_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Direccion_PA;
            SqlParametros = Comando.Parameters.Add("@id_localidades_PA", SqlDbType.Int);
            SqlParametros.Value = pac.Id_localidades_PA;
            SqlParametros = Comando.Parameters.Add("@id_provincias_PA", SqlDbType.Int);
            SqlParametros.Value = pac.Id_provincias_PA;
            SqlParametros = Comando.Parameters.Add("@correo_electronico_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Correo_electronico_PA;
            SqlParametros = Comando.Parameters.Add("@telefono_PA", SqlDbType.VarChar);
            SqlParametros.Value = pac.Telefono_PA;
        }

        // Método para agregar un nuevo paciente a la base de datos.

        public int agregarPaciente(Pacientes pac)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPacientesAgregarModificar(ref comando, pac);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarPaciente");
        }

        // Método para obtener una tabla con todos los pacientes activos.

        public DataTable ObtenerTablaPacientes()
        {
            DataTable Tabla = ds.ObtenerTabla("Pacientes", "Select Legajo_PA AS Legajo, Nombre_PA AS Nombre, Apellido_PA AS Apellido, Dni_PA AS Dni," +
                " Sexo_PA AS Sexo, Nacionalidad_PA as Nacionalidad, Fecha_de_Nacimiento_PA AS [Fecha de Nacimiento], Direccion_PA AS Direccion," +
                " Id_Localidades_PA AS Localidad, Id_Provincias_PA AS Provincia, Correo_Electronico_PA AS [Correo Electronico], Telefono_PA AS Telefono from Pacientes" +
                " WHERE Activos_PA = 1");
            return Tabla;
        }


        // Método para obtener una tabla de turnos filtrada por nombre y apellido del médico.

        public DataTable ObtenerTablarPacientesXlegajo(string legajo)
        {
            DataTable Tabla = ds.ObtenerTabla("Pacientes", "Select Legajo_PA AS Legajo, Nombre_PA AS Nombre, Apellido_PA AS Apellido, Dni_PA AS Dni," +
                " Sexo_PA AS Sexo, Nacionalidad_PA as Nacionalidad, Fecha_de_Nacimiento_PA AS [Fecha de Nacimiento], Direccion_PA AS Direccion," +
                " Id_Localidades_PA AS Localidad, Id_Provincias_PA AS Provincia, Correo_Electronico_PA AS [Correo Electronico], Telefono_PA AS Telefono from Pacientes" +
                " WHERE Activos_PA = 1 AND Pacientes.Legajo_PA = '" + legajo + "'");
            return Tabla;
        }

        // Método para obtener el nombre completo separado con coma de un paciente dado su legajo.

        public string ObtenerNombrePaciente(int leg)
        {
            SqlCommand comando = new SqlCommand();
            return ds.EjecutarQueryDevuelveString("SELECT CONCAT (Nombre_PA ,', ',Apellido_PA) from Pacientes WHERE Legajo_PA = " + Convert.ToInt32(leg));
        }

        // Método para eliminar un paciente de la base de datos.

        public int eliminarPacientes(Pacientes Pac)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPacientesEliminar(ref comando, Pac);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpEliminaPaciente");
        }

        // Método para editar un paciente en la base de datos.

        public int EditarPaciente(Pacientes pac)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPacientesModificar(ref comando, pac);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpActualizarPaciente");
        }

        // Método para armar los parámetros necesarios para eliminar un paciente.

        public void ArmarParametrosPacientesEliminar(ref SqlCommand Comando, Pacientes Pac)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Legajo_PA", SqlDbType.Int);
            SqlParametros.Value = Pac.Legajo_PA1;
        }


        //Revisa existencia de paciente usando telefono

        public Boolean existePacienteporTelefono(string telefono)
        {
            String consulta = "Select * from Pacientes where Telefono_PA = '" + telefono + "' AND Activos_PA = 1";
            return ds.existe(consulta);
        }

        //Revisa existencia de paciente usando correo

        public Boolean existePacienteporCorreo(string correo)
        {
            String consulta = "Select * from Pacientes where Correo_Electronico_PA = '" + correo + "' AND Activos_PA = 1";
            return ds.existe(consulta);
        }

        //Cuentan existencias multiples de pacientes por telefono, correo o dni

        public int existePacienteporMasDeUnTelefono(string telefono)
        {
            String consulta = "Select  COUNT(*) AS TotalCount from Pacientes where Telefono_PA = '" + telefono + "' AND Activos_PA = 1";
            return ds.Obtenercontador(consulta);
        }


        public int existePacienteporMasDeUnCorreo(string correo)
        {
            String consulta = "Select COUNT(*) AS TotalCount from Pacientes where Correo_Electronico_PA = '" + correo + "' AND Activos_PA = 1";
            return ds.Obtenercontador(consulta);
        }

        public int existePacienteporMasDeUnDni(string dni)
        {
            String consulta = "Select COUNT(*) AS TotalCount from Pacientes where Dni_PA ='" + dni + "' AND Activos_PA = 1";
            return ds.Obtenercontador(consulta);
        }
    }
}
