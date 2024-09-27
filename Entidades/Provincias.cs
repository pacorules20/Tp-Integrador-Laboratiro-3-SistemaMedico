using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincias
    {
        private int Id_Provincia_PRO;
        private string DescripcionProvincia_PRO;

        public Provincias(int id_Provincia, string descripcionProvincia)
        {
            Id_Provincia_PRO1 = id_Provincia;
            DescripcionProvincia_PRO1 = descripcionProvincia;
        }

        public int Id_Provincia_PRO1 { get => Id_Provincia_PRO; set => Id_Provincia_PRO = value; }
        public string DescripcionProvincia_PRO1 { get => DescripcionProvincia_PRO; set => DescripcionProvincia_PRO = value; }
    }
}
