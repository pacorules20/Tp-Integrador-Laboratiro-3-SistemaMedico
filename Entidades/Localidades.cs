using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidades
    {
        private int id_Localidades_LO;
        private int id_Provincias_LO;
        private string descripcion_LO;

        public Localidades(int id_Localidades_LO, int id_Provincias_LO, string descripcion_LO)
        {
            this.id_Localidades_LO = id_Localidades_LO;
            this.id_Provincias_LO = id_Provincias_LO;
            this.descripcion_LO = descripcion_LO;
        }

        public int Id_Localidades_LO { get => id_Localidades_LO; set => id_Localidades_LO = value; }
        public int Id_Provincias_LO { get => id_Provincias_LO; set => id_Provincias_LO = value; }
        public string Descripcion_LO { get => descripcion_LO; set => descripcion_LO = value; }
    }
}
