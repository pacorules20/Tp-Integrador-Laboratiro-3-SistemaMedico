using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class DatosLocalidades
    {
        Conexiones ds = new Conexiones();

        //Funcion para cargar DDL con localidades

        public List<Tuple<string, string>> DropDownListcargardatos(int id)
        {
            List<Tuple<string, string>> Localidades = new List<Tuple<string, string>>();

            string consultaSQLProvincias = "select * from Localidades WHERE Id_Provincias_LO = '" + id + "'";
            DataTable tabla = ds.ObtenerTabla("Localidades", consultaSQLProvincias);

            foreach (DataRow row in tabla.Rows)
            {
                string provinciaNombre = row["Descripcion_LO"].ToString(); // Asumiendo que hay una columna "Nombre"
                string provinciaId = row["Id_Localidades_LO"].ToString(); // Asumiendo que hay una columna "Id"

                Localidades.Add(new Tuple<string, string>(provinciaNombre, provinciaId));
            }

            return Localidades;
        }
    }
}
