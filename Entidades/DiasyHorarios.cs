using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DiasyHorarios
    {
        private int Id_DiasyHorarios;
        private int Id_Horarios;
        private int Id_Dias;

        public DiasyHorarios(int id_DiasyHorarios, int id_Horarios, int id_Dias)
        {
            Id_DiasyHorarios1 = id_DiasyHorarios;
            Id_Horarios1 = id_Horarios;
            Id_Dias1 = id_Dias;
        }

        public int Id_DiasyHorarios1 { get => Id_DiasyHorarios; set => Id_DiasyHorarios = value; }
        public int Id_Horarios1 { get => Id_Horarios; set => Id_Horarios = value; }
        public int Id_Dias1 { get => Id_Dias; set => Id_Dias = value; }
    }
}
