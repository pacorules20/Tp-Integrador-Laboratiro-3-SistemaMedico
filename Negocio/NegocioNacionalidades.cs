using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NegocioNacionalidades
    {
        //Metodo para cargar DDL con nacionalidades

        public List<Tuple<string, string>> DropDownListcargarNacionalidades()
        {
            DatosNacionalidades esp = new DatosNacionalidades();
            return esp.DropDownListcargardatos();
        }
    }
}
