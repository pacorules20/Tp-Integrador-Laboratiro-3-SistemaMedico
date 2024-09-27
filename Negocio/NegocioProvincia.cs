using Datos;
using System;
using System.Collections.Generic;


namespace Negocio
{
    public class NegocioProvincia
    {
        //Metodo para cargar DDL con provincias

        public List<Tuple<string, string>> DropDownListcargarProvincias()
        {
            DatosProvincias dao = new DatosProvincias();
            return dao.DropDownListcargardatos();
        }
    }
}
