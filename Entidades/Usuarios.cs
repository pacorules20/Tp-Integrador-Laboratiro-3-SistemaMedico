using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        private int Id_Usuarios_US;
        private string NombreUsuario_US;
        private string Contraseña_US;
        private int? Id_Usuario_Admin_US;
        private int? Id_Usuario_Medico_US;
        private bool Activos_US;

        public Usuarios()
        {

        }

        public int Id_Usuarios_US1 { get => Id_Usuarios_US; set => Id_Usuarios_US = value; }
        public string NombreUsuario_US1 { get => NombreUsuario_US; set => NombreUsuario_US = value; }
        public string Contraseña_US1 { get => Contraseña_US; set => Contraseña_US = value; }
        public int? Id_Usuario_Admin_US1 { get => Id_Usuario_Admin_US; set => Id_Usuario_Admin_US = value; }
        public int? Id_Usuario_Medico_US1 { get => Id_Usuario_Medico_US; set => Id_Usuario_Medico_US = value; }
        public bool Activos_US1 { get => Activos_US; set => Activos_US = value; }
    }
}
