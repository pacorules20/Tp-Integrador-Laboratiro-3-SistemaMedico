using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NegocioEspecialidades
    {

        // Metodo de Carga de DDL de Especialidades
         
        public List<Tuple<string, string>> DropDownListcargarEspecialidades()
        {
            DatosEspecialidades esp = new DatosEspecialidades();
            return esp.DropDownListcargardatos();
        }
    }
}
