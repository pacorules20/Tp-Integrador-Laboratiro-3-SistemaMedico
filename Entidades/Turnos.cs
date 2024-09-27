using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnos
    {
        private int id_Turnos_TU;
        private string dias_y_Horarios_TU;
        private int Legajo_Pac_TU;
        private int legajo_Med_TU;
        private string observacion_TU;
        private bool asistencia_TU;
        private bool Activos_TU;
        private DateTime Fecha_TU;
        public Turnos()
        {
       
        }

        public int Id_Turnos_TU { get => id_Turnos_TU; set => id_Turnos_TU = value; }
        public string Dias_y_Horarios_TU { get => dias_y_Horarios_TU; set => dias_y_Horarios_TU = value; }
        public int Legajo_Pac_TU1 { get => Legajo_Pac_TU; set => Legajo_Pac_TU = value; }
        public int Legajo_Med_TU { get => legajo_Med_TU; set => legajo_Med_TU = value; }
        public string Observacion_TU { get => observacion_TU; set => observacion_TU = value; }
        public bool Asistencia_TU { get => asistencia_TU; set => asistencia_TU = value; }
        public bool Activos_TU1 { get => Activos_TU; set => Activos_TU = value; }
        public DateTime Fecha_TU1 { get => Fecha_TU; set => Fecha_TU = value; }
    }
}
