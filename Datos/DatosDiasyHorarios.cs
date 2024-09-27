using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class DatosDiasyHorarios
    {
        Conexiones con = new Conexiones();

        // Metodo para llenar Dropdown con un listado de horarios de un medico

        public List<string> DropdownCargarHorarios(int leg)
        {
            List<string> listaHorarios = new List<string>();

            string ConsultarDias_Horarios = "SELECT DescripcionDia, DescripcionHorario FROM Medicos " +
                                            "JOIN DiasyHorarios DH ON Medicos.Dias_y_Horarios_ME = DH.Id_DiasyHorarios " +
                                            "JOIN Dias D ON DH.Id_Dias = D.Id_Dias " +
                                            "JOIN Horarios H ON DH.Id_Horarios = H.Id_Horarios " +
                                            "WHERE Medicos.Legajo_ME = " + leg;

            DataTable tablaDiasHorarios = con.ObtenerTabla("DiasyHorarios", ConsultarDias_Horarios);

            foreach (DataRow row in tablaDiasHorarios.Rows)
            {
                // Asumiendo que hay un id de horas
                string DescripcionHorario_AUX = row["DescripcionHorario"].ToString(); // Asumiendo que hay un id de días y horas

                // Separar los valores usando .Split
                string[] descripcionHorarioPartes = DescripcionHorario_AUX.Split(',');

                foreach (string aux in descripcionHorarioPartes)
                {
                    listaHorarios.Add(aux);
                }

            }
            return listaHorarios;
        }

        // Funcion para llenar Dropdown con los dias activos de un medico

        public List<string> DropdownCargarDias(int leg)
        {
            List<string> listaDias = new List<string>();


            string ConsultarDias_Horarios = "SELECT DescripcionDia, DescripcionHorario FROM Medicos " +
                                            "JOIN DiasyHorarios DH ON Medicos.Dias_y_Horarios_ME = DH.Id_DiasyHorarios " +
                                            "JOIN Dias D ON DH.Id_Dias = D.Id_Dias " +
                                            "JOIN Horarios H ON DH.Id_Horarios = H.Id_Horarios " +
                                            "WHERE Medicos.Legajo_ME = " + leg;

            DataTable tablaDiasHorarios = con.ObtenerTabla("DiasyHorarios", ConsultarDias_Horarios);

            foreach (DataRow row in tablaDiasHorarios.Rows)
            {
                string DescripcionDia_AUX = row["DescripcionDia"].ToString();

                string[] descripcionDiaPartes = DescripcionDia_AUX.Split('-');
                foreach (string aux in descripcionDiaPartes)
                {
                    listaDias.Add(aux);
                }
            }
            return listaDias;
        }


        // Funcion cargar dias y horarios en ddl

        public List<Tuple<string, string>> DropDownListCargarDiasyHorarios()
        {
            List<Tuple<string, string>> Localidades = new List<Tuple<string, string>>();

            string ConsultarDias_Horarios = " Select DescripcionDia, DescripcionHorario, Id_DiasyHorarios from DiasyHorarios inner join Dias on Dias.Id_Dias = DiasyHorarios.Id_Dias inner join Horarios on Horarios.Id_Horarios = DiasyHorarios.Id_Horarios";
            DataTable tabla = con.ObtenerTabla("DiasyHorarios", ConsultarDias_Horarios);

            foreach (DataRow row in tabla.Rows)
            {
                string provinciaNombre = row["DescripcionDia"].ToString() + " " + row["DescripcionHorario"].ToString(); // Asumiendo que hay una columna "Nombre"
                string provinciaId = row["Id_DiasyHorarios"].ToString(); // Asumiendo que hay una columna "Id"

                Localidades.Add(new Tuple<string, string>(provinciaNombre, provinciaId));
            }

            return Localidades;
        }

    }
}
