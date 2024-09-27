using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class DatosEspecialidades
    {
        Conexiones ds = new Conexiones();

        //Funcion para cargar DDL con especialidades

        public List<Tuple<string, string>> DropDownListcargardatos()
        {
            List<Tuple<string, string>> Especialidades = new List<Tuple<string, string>>();

            string consultaSQLProvincias = "select * from Especialidades";
            DataTable tabla = ds.ObtenerTabla("Especialidades", consultaSQLProvincias);

            foreach (DataRow row in tabla.Rows)
            {
                string provinciaNombre = row["Descripcion_ES"].ToString(); // Asumiendo que hay una columna "Nombre"
                string provinciaId = row["Id_Especialidad_ES"].ToString(); // Asumiendo que hay una columna "Id"

                Especialidades.Add(new Tuple<string, string>(provinciaNombre, provinciaId));
            }

            return Especialidades;
        }
    }
}
