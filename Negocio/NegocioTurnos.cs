using Datos;
using Entidades;
using System;
using System.Data;

namespace Negocio
{
    public class NegocioTurnos
    {
        // Método para agregar un nuevo turno.

        public bool AgregarTurno(string Dia, string Horario, string Legajo_Pac_Tu, string Legajo_Med, DateTime fecha)
        {
            Turnos Tur = new Turnos();
            Tur.Dias_y_Horarios_TU = Dia + "_" + Horario;
            Tur.Legajo_Pac_TU1 = Convert.ToInt32(Legajo_Pac_Tu);
            Tur.Legajo_Med_TU = Convert.ToInt32(Legajo_Med);
            Tur.Fecha_TU1 = fecha;

            DatosTurnos dao = new DatosTurnos();
            int cantFilas = dao.agregarTruno(Tur);

            return cantFilas == 1; // Retorna true si se agregó correctamente el turno, de lo contrario false.
        }

        // Método para obtener los turnos de un médico por nombre y apellido.

        public DataTable ObtenerTurnosxMedico(string nombre, string apellido)
        {
            DatosTurnos dao = new DatosTurnos();
            return dao.ObtenerTablaturnosxMedico(nombre, apellido);
        }

        // Método para obtener todos los turnos.

        public DataTable ObtenerTurnos()
        {
            DatosTurnos dao = new DatosTurnos();
            return dao.ObtenerTablaturnos();
        }

        // Método para obtener la tabla de turnos por legajo

        public DataTable ObtenerTurnosXLeg(string Leg)
        {
            DatosTurnos dao = new DatosTurnos();  // Instancia de la clase DatosPacientes para operaciones de datos
            return dao.ObtenerTablaTurnosXLeg(Leg);
        }

        // Método para obtener los turnos dentro de un rango de fechas para informes.

        public DataTable ObtenerTurnosInformes1(string fechaInicio, string fechaFinal)
        {
            DatosTurnos dao = new DatosTurnos();
            return dao.ObtenerTablaturnosInformes1(fechaInicio, fechaFinal);
        }

        // Método para obtener el total de turnos presentes dentro de un rango de fechas.

        public int ObtenerTotalTurnosPresentes(string fechaInicio, string fechaFinal)
        {
            DatosTurnos dao = new DatosTurnos();
            return dao.ObtenerCuentaTotalTurnosPresentes(fechaInicio, fechaFinal);
        }

        // Método para obtener el total de turnos ausentes dentro de un rango de fechas.

        public int ObtenerTotalTurnosAusentes(string fechaInicio, string fechaFinal)
        {
            DatosTurnos dao = new DatosTurnos();
            return dao.ObtenerCuentaTotalTurnosAusentes(fechaInicio, fechaFinal);
        }

        // Método para modificar un turno existente.

        public bool Modificar_Turno(Turnos tur)
        {
            DatosTurnos turmod = new DatosTurnos();
            int FilasAfectadas = turmod.EditarTurno(tur);
            return FilasAfectadas == 1; // Retorna true si se modificó correctamente el turno, de lo contrario false.
        }

        // Método para buscar turnos por legajo (nombre, apellido y legajo).

        public DataTable BuscarTurnoporLegajo(string nombre, string apellido, int legajo)
        {
            DatosTurnos dao = new DatosTurnos();
            return dao.FiltrarTurnosPorLegajo(nombre, apellido, legajo);
        }

        // Método para buscar turnos por id (nombre, apellido y id).

        public DataTable BuscarTurnoPorIdPaciente(string nombre, string apellido, int id)
        {
            DatosTurnos dao = new DatosTurnos();
            return dao.FiltrarTurnosPorid(nombre, apellido, id);
        }

        // Método para buscar turnos por día y horario (nombre, apellido y día/horario).

        public DataTable BuscarTurnoPorDiaYHorario(string nombre, string apellido, string DiaHorario)
        {
            DatosTurnos dao = new DatosTurnos();
            return dao.FiltrarTurnosPorDiaYHorario(nombre, apellido, DiaHorario);
        }

        // Método para buscar turnos por fecha de búsqueda (nombre, apellido y fecha).

        public DataTable BuscarTurnoPorFechaBusqueda(string nombre, string apellido, string fecha)
        {
            DatosTurnos dao = new DatosTurnos();
            return dao.FiltrarTurnosPorFechaBusqueda(nombre, apellido, fecha);
        }

        // Método para eliminar un turno por su ID.

        public bool Eliminar_Turnos(int id)
        {
            Turnos tur = new Turnos();
            tur.Id_Turnos_TU = id;

            DatosTurnos dao = new DatosTurnos();
            if (dao.existeTurno(tur))
            {
                int cantFilas = dao.eliminarTurno(tur);
                return cantFilas == 1; // Retorna true si se eliminó correctamente el turno, de lo contrario false.
            }
            else
            {
                return false; // Retorna false si el turno no existe.
            }
        }
    }
}
