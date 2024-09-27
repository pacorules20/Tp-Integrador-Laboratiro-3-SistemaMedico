using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pacientes
    {
        private int Legajo_PA;
        private string nombre_PA;
        private string apellido_PA;
        private string dni_PA;
        private string sexo_PA;
        private string nacionalidad_PA;
        private DateTime fecha_de_nacimiento_PA;
        private string direccion_PA;
        private int id_localidades_PA;
        private int id_provincias_PA;
        private string correo_electronico_PA;
        private string telefono_PA;
        private bool Activos_PA;

        public Pacientes()
        {
        }

        public int Legajo_PA1 { get => Legajo_PA; set => Legajo_PA = value; }
        public string Nombre_PA { get => nombre_PA; set => nombre_PA = value; }
        public string Apellido_PA { get => apellido_PA; set => apellido_PA = value; }
        public string Dni_PA { get => dni_PA; set => dni_PA = value; }
        public string Sexo_PA { get => sexo_PA; set => sexo_PA = value; }
        public string Nacionalidad_PA { get => nacionalidad_PA; set => nacionalidad_PA = value; }
        public DateTime Fecha_de_nacimiento_PA { get => fecha_de_nacimiento_PA; set => fecha_de_nacimiento_PA = value; }
        public string Direccion_PA { get => direccion_PA; set => direccion_PA = value; }
        public int Id_localidades_PA { get => id_localidades_PA; set => id_localidades_PA = value; }
        public int Id_provincias_PA { get => id_provincias_PA; set => id_provincias_PA = value; }
        public string Correo_electronico_PA { get => correo_electronico_PA; set => correo_electronico_PA = value; }
        public string Telefono_PA { get => telefono_PA; set => telefono_PA = value; }
        public bool AActivos_PA1 { get => Activos_PA; set => Activos_PA = value; }
    }
}