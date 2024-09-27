using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Especialidades
    {
        private int Id_Especialidad_ES;
        private string DescripcionEspecialidad_ES;

        public Especialidades(int id_Especialidad, string descripcionEspecialidad)
        {
            Id_Especialidad_ES1 = id_Especialidad;
            DescripcionEspecialidad_ES1 = descripcionEspecialidad;
        }

        public int Id_Especialidad_ES1 { get => Id_Especialidad_ES; set => Id_Especialidad_ES = value; }
        public string DescripcionEspecialidad_ES1 { get => DescripcionEspecialidad_ES; set => DescripcionEspecialidad_ES = value; }
    }
}
