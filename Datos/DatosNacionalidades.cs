using System;
using System.Collections.Generic;
using System.Data;


namespace Datos
{
    public class DatosNacionalidades
    {
        // Metodo para cargar Dropdown con Nacionalidades

        Conexiones ds = new Conexiones();
        public List<Tuple<string, string>> DropDownListcargardatos()
        {
            List<Tuple<string, string>> Nacionalidades = new List<Tuple<string, string>>();

            string consultaSQLNacionalidades = "select * from Nacionalidades";
            DataTable tabla = ds.ObtenerTabla("Nacionalidades", consultaSQLNacionalidades);

            foreach (DataRow row in tabla.Rows)
            {
                string nacionalidadNombre = row["Descripcion_NA"].ToString(); // Asumiendo que hay una columna "Descripcion"
                string nacionalidadId = row["Id_Nacionalidad_NA"].ToString(); // Asumiendo que hay una columna "Id"

                Nacionalidades.Add(new Tuple<string, string>(nacionalidadNombre, nacionalidadId));
            }

            return Nacionalidades;
        }
    }
}
