using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NegocioLocalidad
    {
        //Metodo de Carga de DDL de localidades

        public List<Tuple<string, string>> DropDownListcargarLocalidades(int id)
        {
            DatosLocalidades dao = new DatosLocalidades();
            return dao.DropDownListcargardatos(id);
        }
    }
}
