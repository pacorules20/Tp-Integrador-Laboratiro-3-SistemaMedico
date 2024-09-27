using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administradores
    {
        private int legajo_ADM;
        private string nombre_ADM;
        private string apellido_ADM;
        private string dni_ADM;
        private string sexo_ADM;
        private string nacionalidad_ADM;
        private TimeSpan fecha_de_Nacimiento_ADM;
        private string direccion_ADM;
        private int id_Localidades_ADM;
        private int id_Provincias_ADM;
        private string correo_Electronico_ADM;
        private string telefono_ADM;
        private bool Activos_ADM;

        public Administradores()
        { }

        public int Legajo_ADM { get => legajo_ADM; set => legajo_ADM = value; }
        public string Nombre_ADM { get => nombre_ADM; set => nombre_ADM = value; }
        public string Apellido_ADM { get => apellido_ADM; set => apellido_ADM = value; }
        public string Dni_ADM { get => dni_ADM; set => dni_ADM = value; }
        public string Sexo_ADM { get => sexo_ADM; set => sexo_ADM = value; }
        public string Nacionalidad_ADM { get => nacionalidad_ADM; set => nacionalidad_ADM = value; }
        public TimeSpan Fecha_de_Nacimiento_ADM { get => fecha_de_Nacimiento_ADM; set => fecha_de_Nacimiento_ADM = value; }
        public string Direccion_ADM { get => direccion_ADM; set => direccion_ADM = value; }
        public int Id_Localidades_ADM { get => id_Localidades_ADM; set => id_Localidades_ADM = value; }
        public int Id_Provincias_ADM { get => id_Provincias_ADM; set => id_Provincias_ADM = value; }
        public string Correo_Electronico_ADM { get => correo_Electronico_ADM; set => correo_Electronico_ADM = value; }
        public string Telefono_ADM { get => telefono_ADM; set => telefono_ADM = value; }
        public bool Activos_ADM1 { get => Activos_ADM; set => Activos_ADM = value; }
    }
}
