using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosTurnos
    {
        // Instancia de la clase Conexiones para manejar la conexión a la base de datos.

        Conexiones ds = new Conexiones();

        // Método para armar los parámetros necesarios para agregar un turno a la base de datos.

        public void ArmarParametrosTurnosAgregar(ref SqlCommand Comando, Turnos Tur)
        {
            SqlParameter SqlParametros = new SqlParameter();

            // Agrega y asigna el parámetro de días y horarios.
            SqlParametros = Comando.Parameters.Add("@Dias_y_Horarios_TU", SqlDbType.VarChar);
            SqlParametros.Value = Tur.Dias_y_Horarios_TU;

            // Agrega y asigna el parámetro del legajo del paciente.
            SqlParametros = Comando.Parameters.Add("@Legajo_Pac_TU", SqlDbType.Int);
            SqlParametros.Value = Tur.Legajo_Pac_TU1;

            // Agrega y asigna el parámetro del legajo del médico.
            SqlParametros = Comando.Parameters.Add("@Legajo_Med_TU", SqlDbType.Int);
            SqlParametros.Value = Tur.Legajo_Med_TU;

            // Agrega y asigna el parámetro de la fecha del turno.
            SqlParametros = Comando.Parameters.Add("@Fecha_TU", SqlDbType.Date);
            SqlParametros.Value = Tur.Fecha_TU1;
        }

        // Método para armar los parámetros necesarios para eliminar un turno de la base de datos.

        public void ArmarParametrosTurnoEliminar(ref SqlCommand Comando, Turnos tur)
        {
            SqlParameter SqlParametros = new SqlParameter();
            // Agrega y asigna el parámetro del ID del turno.
            SqlParametros = Comando.Parameters.Add("@Id_Turnos_TU", SqlDbType.Int);
            SqlParametros.Value = tur.Id_Turnos_TU;
        }

        // Método para armar los parámetros necesarios para modificar un turno en la base de datos.

        public void ArmarParametrosTurnosModificar(ref SqlCommand Comando, Turnos tur)
        {
            SqlParameter SqlParametros = new SqlParameter();

            // Agrega y asigna el parámetro del ID del turno.
            SqlParametros = Comando.Parameters.Add("@Id_Turnos_TU", SqlDbType.Int);
            SqlParametros.Value = tur.Id_Turnos_TU;

            // Agrega y asigna el parámetro de la observación del turno.
            SqlParametros = Comando.Parameters.Add("@Observacion_TU", SqlDbType.VarChar);
            SqlParametros.Value = tur.Observacion_TU;

            // Agrega y asigna el parámetro de la asistencia del turno.
            SqlParametros = Comando.Parameters.Add("@Asistencia_TU", SqlDbType.Bit);
            SqlParametros.Value = tur.Asistencia_TU;
        }

        // Método para eliminar un turno de la base de datos.

        public int eliminarTurno(Turnos Tur)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosTurnoEliminar(ref comando, Tur);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpEliminaTurnos");
        }

        // Método para agregar un turno a la base de datos.

        public int agregarTruno(Turnos Tur)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosTurnosAgregar(ref comando, Tur);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarTurno");
        }

        // Método para verificar si un turno existe en la base de datos.

        public Boolean existeTurno(Turnos tur)
        {
            String consulta = "Select * from Turnos where Id_Turnos_TU ='" + tur.Id_Turnos_TU + "' AND Activos_TU = '1' ";
            return ds.existe(consulta);
        }

        // Método para modificar un turno en la base de datos.

        public int EditarTurno(Turnos tur)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosTurnosModificar(ref comando, tur);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpActualizarTurnosxMedico");
        }

        // Método para obtener una tabla de turnos filtrada por nombre y apellido del médico.

        public DataTable ObtenerTablaturnosxMedico(string nombre, string apellido)
        {
            DataTable Tabla = ds.ObtenerTabla("Turnos", "Select * from Turnos INNER JOIN Medicos ON Turnos.Legajo_Med_TU = Medicos.Legajo_ME WHERE Medicos.Nombre_ME = '" + nombre + "' AND Medicos.Apellido_ME = '" + apellido + "' AND Turnos.Activos_TU = '1'");
            return Tabla;
        }

        // Método para obtener una tabla de todos los turnos activos.

        public DataTable ObtenerTablaturnos()
        {
            DataTable Tabla = ds.ObtenerTabla("Turnos", "Select Id_Turnos_TU AS [Id Turno], Dias_y_Horarios_TU AS [Dias y Horarios], Fecha_TU AS Fecha," +
                " Legajo_Pac_TU AS [Legajo Paciente], Legajo_Med_TU AS [Legajo Medico], Observacion_TU AS Observaciones, Asistencia_TU AS [El paciente asistio?]" +
                " from Turnos WHERE Turnos.Activos_TU = '1'");
            return Tabla;
        }

        // Método para obtener una tabla de todos los turnos activos por ID.

        public DataTable ObtenerTablaTurnosXLeg(string legajo)
        {
            DataTable Tabla = ds.ObtenerTabla("Turnos", "Select Id_Turnos_TU AS [Id Turno], Dias_y_Horarios_TU AS [Dias y Horarios], Fecha_TU AS Fecha," +
                " Legajo_Pac_TU AS [Legajo Paciente], Legajo_Med_TU AS [Legajo Medico], Observacion_TU AS Observaciones, Asistencia_TU AS [El paciente asistio?]" +
                " from Turnos WHERE Turnos.Activos_TU = '1' AND Id_Turnos_TU = '" + legajo + "'");
            return Tabla;
        }

        // Método para obtener una tabla de turnos en un rango de fechas específicas.

        public DataTable ObtenerTablaturnosInformes1(string fechaInicio, string fechaFinal)
        {
            DataTable Tabla = ds.ObtenerTabla("Turnos", "SELECT * FROM Turnos WHERE Turnos.Fecha_TU BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' AND (Turnos.Asistencia_TU = '1' OR Turnos.Asistencia_TU = '0') AND Turnos.Activos_TU = '1'");
            return Tabla;
        }

        // Método para obtener la cuenta total de turnos presentes en un rango de fechas específicas.

        public int ObtenerCuentaTotalTurnosPresentes(string fechaInicio, string fechaFinal)
        {
            string consulta = "SELECT COUNT(*) AS TotalCount FROM Turnos WHERE Turnos.Fecha_TU BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' AND Turnos.Asistencia_TU = '1' AND Turnos.Activos_TU = '1'";
            return ds.Obtenercontador(consulta);
        }

        // Método para obtener la cuenta total de turnos ausentes en un rango de fechas específicas.

        public int ObtenerCuentaTotalTurnosAusentes(string fechaInicio, string fechaFinal)
        {
            string consulta = "SELECT COUNT(*) AS TotalCount FROM Turnos WHERE Turnos.Fecha_TU BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' AND Turnos.Asistencia_TU = '0' AND Turnos.Activos_TU = '1'";
            return ds.Obtenercontador(consulta);
        }

        // Método para filtrar turnos por legajo del turno.

        public DataTable FiltrarTurnosPorLegajo(string nombre, string apellido, int legajo)
        {
            DataTable Tabla = ds.ObtenerTabla("Turnos", "Select * from Turnos INNER JOIN Medicos ON Turnos.Legajo_Med_TU = Medicos.Legajo_ME WHERE Medicos.Nombre_ME = '" + nombre + "' AND Medicos.Apellido_ME = '" + apellido + "' AND Turnos.Activos_TU = '1' AND Turnos.Id_Turnos_TU = '" + legajo + "'");
            return Tabla;
        }

        // Método para filtrar turnos por id del turno.

        public DataTable FiltrarTurnosPorid(string nombre, string apellido, int id)
        {
            DataTable Tabla = ds.ObtenerTabla("Turnos", "Select * from Turnos INNER JOIN Medicos ON Turnos.Legajo_Med_TU = Medicos.Legajo_ME WHERE Medicos.Nombre_ME = '" + nombre + "' AND Medicos.Apellido_ME = '" + apellido + "' AND Turnos.Activos_TU = '1' AND Turnos.Legajo_Pac_TU = '" + id + "'");
            return Tabla;
        }

        // Método para filtrar turnos por fecha del turno.

        public DataTable FiltrarTurnosPorFechaBusqueda(string nombre, string apellido, string fecha)
        {
            DataTable Tabla = ds.ObtenerTabla("Turnos", "Select * from Turnos INNER JOIN Medicos ON Turnos.Legajo_Med_TU = Medicos.Legajo_ME WHERE Medicos.Nombre_ME = '" + nombre + "' AND Medicos.Apellido_ME = '" + apellido + "' AND Turnos.Activos_TU = '1' AND Turnos.Fecha_TU = '" + fecha + "'");
            return Tabla;
        }

        // Método para filtrar turnos por día/horario del turno.

        public DataTable FiltrarTurnosPorDiaYHorario(string nombre, string apellido, string DiaHorario)
        {
            DataTable Tabla = ds.ObtenerTabla("Turnos", "Select * from Turnos INNER JOIN Medicos ON Turnos.Legajo_Med_TU = Medicos.Legajo_ME WHERE Medicos.Nombre_ME = '" + nombre + "' AND Medicos.Apellido_ME = '" + apellido + "' AND Turnos.Activos_TU = '1' AND Turnos.Dias_y_Horarios_TU LIKE '%" + DiaHorario + "%'");
            return Tabla;
        }
    }
}
