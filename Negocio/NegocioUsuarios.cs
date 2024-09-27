using Datos;
using Entidades;
using System;
using System.Data;

namespace Negocio
{
    public class NegocioUsuarios
    {
        // Método para obtener la lista de usuarios desde la capa de datos.

        public DataTable ObtenerUsuarios()
        {
            DatosUsuarios dao = new DatosUsuarios();
            return dao.ObtenerTablaUsuarios();
        }

        // Método para obtener la lista de usuarios desde la capa de datos por ID.

        public DataTable ObtenerUsuariosxId(string id)
        {
            DatosUsuarios dao = new DatosUsuarios();
            return dao.ObtenerTablaUsuariosxId(id);
        }

        // Método para modificar un usuario.

        public bool Modificar_Usuarios(int id, string usuario, string contra)
        {
            Usuarios Usu = new Usuarios();
            Usu.Id_Usuario_Medico_US1 = id;
            Usu.NombreUsuario_US1 = usuario;
            Usu.Contraseña_US1 = contra;

            DatosUsuarios datMedicModf = new DatosUsuarios();
            int FilasAfectadas = datMedicModf.EditarUsuarios(Usu);
            return FilasAfectadas == 1; // Retorna true si se modificó correctamente, de lo contrario false.
        }

        // Método para eliminar un usuario por su ID.

        public bool Eliminar_Usuarios(int id)
        {
            Usuarios us = new Usuarios();
            us.Id_Usuarios_US1 = id;

            DatosUsuarios dao = new DatosUsuarios();
            if (dao.existeUsuarioPorIdUsuario(us)) // Verifica si el usuario existe antes de intentar eliminarlo.
            {
                int cantFilas = dao.eliminarUsuario(us);
                return cantFilas == 1; // Retorna true si se eliminó correctamente, de lo contrario false.
            }
            else
            {
                return false; // Retorna false si el usuario no existe.
            }
        }

        // Método para verificar si existe una cuenta de usuario asociada a un legajo específico.

        public bool ExisteCuentaPorLegajo(string legajo)
        {
            DatosUsuarios dat = new DatosUsuarios();
            Usuarios us = new Usuarios();
            int leg = Convert.ToInt32(legajo);
            us.Id_Usuario_Medico_US1 = leg;
            return dat.existeUsuarioDeEsteMedico(us); // Retorna true si existe una cuenta para el legajo especificado, de lo contrario false.
        }

        // Método para agregar un nuevo usuario.

        public bool AgregarUsuario(string legajo, string usuario, string contraseña)
        {
            DatosUsuarios dat = new DatosUsuarios();
            Usuarios us = new Usuarios();
            int leg = Convert.ToInt32(legajo);
            us.Id_Usuario_Medico_US1 = leg;
            us.Contraseña_US1 = contraseña;
            us.NombreUsuario_US1 = usuario;

            return dat.AgregarUsuario(us) == 1; // Retorna true si se agregó correctamente el usuario, de lo contrario false.
        }
    }
}

