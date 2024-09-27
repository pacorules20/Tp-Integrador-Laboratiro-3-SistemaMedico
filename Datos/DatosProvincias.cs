using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class DatosProvincias
    {
        Conexiones ds = new Conexiones();

        //Metodo para cargar dropdown con provincias

        public List<Tuple<string, string>> DropDownListcargardatos()
        {
            List<Tuple<string, string>> provincias = new List<Tuple<string, string>>();

            string consultaSQLProvincias = "select * from Provincias";
            DataTable tabla = ds.ObtenerTabla("Provincias", consultaSQLProvincias);

            foreach (DataRow row in tabla.Rows)
            {
                string provinciaNombre = row["Descripcion_PRO"].ToString(); // Asumiendo que hay una columna "Nombre"
                string provinciaId = row["Id_Provincias_PRO"].ToString(); // Asumiendo que hay una columna "Id"

                provincias.Add(new Tuple<string, string>(provinciaNombre, provinciaId));
            }

            return provincias;
        }

    }
}
