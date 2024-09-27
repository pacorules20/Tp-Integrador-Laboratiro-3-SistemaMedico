using Datos;
using System;
using System.Collections.Generic;
namespace Negocio
{
    public class NegociosDiasyHorarios
    {

        //Metodo para cargar dias a un DDL

        public List<string> CargarDiasDDL(int leg)
        {
            DatosDiasyHorarios diasHoras = new DatosDiasyHorarios();
            return diasHoras.DropdownCargarDias(leg);
        }

        //Metodo para cargar horarios a un DDL

        public List<string> CargarHorariosDDL(int leg)
        {
            DatosDiasyHorarios diasHoras = new DatosDiasyHorarios();
            return diasHoras.DropdownCargarHorarios(leg);
        }

        //Metodo para cargar dias y horarios a un DDL

        public List<Tuple<string, string>> CargarDiasyHorariosDDL()
        {
            DatosDiasyHorarios dao = new DatosDiasyHorarios();
            return dao.DropDownListCargarDiasyHorarios();

        }

    }
}
