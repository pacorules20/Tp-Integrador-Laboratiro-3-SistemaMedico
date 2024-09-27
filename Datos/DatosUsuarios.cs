using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosUsuarios
    {
        Conexiones ds = new Conexiones();

        // Método para obtener una tabla con la información de los usuarios activos que están asociados a un médico.
        public DataTable ObtenerTablaUsuarios()
        {
            DataTable Tabla = ds.ObtenerTabla("Usuarios", "Select Id_Usuarios_US AS [Id Usuario], NombreUsuario_US AS [Nombre de usuario], Contraseña_US AS Contraseña," +
                " Id_Usuario_Medico_US AS [Pertenece al medico] from Usuarios WHERE Activos_US = '1' AND Id_Usuario_Medico_US Is not NULL ");
            return Tabla;
        }

        // Método para obtener una tabla con la información de los usuarios activos que están asociados a un médico, de un usuario particular.

        public DataTable ObtenerTablaUsuariosxId(string id)
        {
            DataTable Tabla = ds.ObtenerTabla("Usuarios", "Select Id_Usuarios_US AS [Id Usuario], NombreUsuario_US AS [Nombre de usuario], Contraseña_US AS Contraseña," +
                " Id_Usuario_Medico_US AS [Pertenece al medico] from Usuarios WHERE Activos_US = '1' AND Id_Usuario_Medico_US Is not NULL AND  Id_Usuarios_US = '" + id + "'");
            return Tabla;
        }

        // Método privado para armar los parámetros necesarios para eliminar un usuario.

        public void ArmarParametrosUsuariosEliminar(ref SqlCommand Comando, Usuarios Usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Id_Usuarios", SqlDbType.Int);
            SqlParametros.Value = Usu.Id_Usuarios_US1;
        }

        // Método privado para armar los parámetros necesarios para modificar un usuario.

        public void ArmarParametrosUsuariosModificar(ref SqlCommand Comando, Usuarios Usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@legajo_ME", SqlDbType.Int);
            SqlParametros.Value = Usu.Id_Usuario_Medico_US1;
            SqlParametros = Comando.Parameters.Add("@Contraseña_US", SqlDbType.VarChar);
            SqlParametros.Value = Usu.Contraseña_US1;
            SqlParametros = Comando.Parameters.Add("NombreUsuario_US", SqlDbType.VarChar);
            SqlParametros.Value = Usu.NombreUsuario_US1;
        }

        // Método privado para armar los parámetros necesarios para agregar un usuario.

        public void ArmarParametrosUsuariosAgregar(ref SqlCommand Comando, Usuarios Usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@legajo_ME", SqlDbType.Int);
            SqlParametros.Value = Usu.Id_Usuario_Medico_US1;
            SqlParametros = Comando.Parameters.Add("@Contraseña_US", SqlDbType.VarChar);
            SqlParametros.Value = Usu.Contraseña_US1;
            SqlParametros = Comando.Parameters.Add("NombreUsuario_US", SqlDbType.VarChar);
            SqlParametros.Value = Usu.NombreUsuario_US1;
        }

        // Método para modificar un usuario en la base de datos.

        public int EditarUsuarios(Usuarios Usu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuariosModificar(ref comando, Usu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpActualizarContraseña");
        }

        // Método para verificar si un usuario existe en la base de datos usando su ID y si está activo.

        public Boolean existeUsuarioPorIdUsuario(Usuarios us)
        {
            String consulta = "Select * from Usuarios where Id_Usuarios_US = " + us.Id_Usuarios_US1 + " AND Activos_US = '1' AND Id_Usuario_Admin_US IS NULL";
            return ds.existe(consulta);
        }

        // Método para verificar si existe un usuario asociado a un médico específico y si está activo.

        public Boolean existeUsuarioDeEsteMedico(Usuarios us)
        {
            String consulta = "Select * from Usuarios where Id_Usuario_Medico_US = " + us.Id_Usuario_Medico_US1 + " AND Activos_US = '1' AND Id_Usuario_Admin_US IS NULL";
            return ds.existe(consulta);
        }

        // Método para agregar un nuevo usuario a la base de datos.

        public int AgregarUsuario(Usuarios Usu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuariosAgregar(ref comando, Usu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpAgregarUsuario");
        }

        // Método para eliminar un usuario de la base de datos.

        public int eliminarUsuario(Usuarios us)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuariosEliminar(ref comando, us);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SP_EliminarUsuario");
        }
    }
}
