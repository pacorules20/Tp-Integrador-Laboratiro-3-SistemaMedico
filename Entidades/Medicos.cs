using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medicos
    {
        private int Legajo_ME;
        private string Nombre_ME;
        private string Apellido_ME;
        private string Dni_ME;
        private string Sexo_ME;
        private string Nacionalidad_ME;
        private DateTime Fecha_de_Nacimiento_ME;
        private string Direccion_ME;
        private int Id_Localidades_ME;
        private int Id_Provincias_ME;
        private string Correo_Electronico_ME;
        private string Telefono_ME;
        private int Especialidad_ME;
        private string Dias_y_Horarios_ME;
        private bool Activos_ME;

        public Medicos()
        {
        }

        public int Legajo_ME1 { get => Legajo_ME; set => Legajo_ME = value; }
        public string Nombre_ME1 { get => Nombre_ME; set => Nombre_ME = value; }
        public string Apellido_ME1 { get => Apellido_ME; set => Apellido_ME = value; }
        public string Dni_ME1 { get => Dni_ME; set => Dni_ME = value; }
        public string Sexo_ME1 { get => Sexo_ME; set => Sexo_ME = value; }
        public string Nacionalidad_ME1 { get => Nacionalidad_ME; set => Nacionalidad_ME = value; }
        public DateTime Fecha_de_Nacimiento_ME1 { get => Fecha_de_Nacimiento_ME; set => Fecha_de_Nacimiento_ME = value; }
        public string Direccion_ME1 { get => Direccion_ME; set => Direccion_ME = value; }
        public int Id_Localidades_ME1 { get => Id_Localidades_ME; set => Id_Localidades_ME = value; }
        public int Id_Provincias_ME1 { get => Id_Provincias_ME; set => Id_Provincias_ME = value; }
        public string Correo_Electronico_ME1 { get => Correo_Electronico_ME; set => Correo_Electronico_ME = value; }
        public string Telefono_ME1 { get => Telefono_ME; set => Telefono_ME = value; }
        public int Especialidad_ME1 { get => Especialidad_ME; set => Especialidad_ME = value; }
        public string Dias_y_Horarios_ME1 { get => Dias_y_Horarios_ME; set => Dias_y_Horarios_ME = value; }
        public bool Activos_ME1 { get => Activos_ME; set => Activos_ME = value; }
    }
}
