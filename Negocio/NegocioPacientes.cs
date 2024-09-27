using Datos;     // Importación del espacio de nombres Datos donde está la clase DatosPacientes
using Entidades; // Importación del espacio de nombres Entidades donde está la clase Pacientes
using System;
using System.Data;

namespace Negocio
{
    public class NegocioPacientes
    {
        private Conexiones conect = new Conexiones();  // Instancia de la clase Conexiones para manejar la conexión a la base de datos

        // Método para agregar un paciente nuevo a la base de datos

        public int AgregarPaciente(string nombre_PA, string apellido_PA, string dni_PA, string sexo_PA, string nacionalidad_PA, string fecha_de_nacimiento_PA,
            string direccion_PA, string id_localidades_PA, string id_provincias_PA, string correo_electronico_PA, string telefono_PA)
        {
            int cantFilas = 0;
            Pacientes pac = new Pacientes();

            // Asignación de los datos del paciente desde los parámetros del método
            pac.Nombre_PA = nombre_PA;
            pac.Apellido_PA = apellido_PA;
            pac.Correo_electronico_PA = correo_electronico_PA;
            pac.Fecha_de_nacimiento_PA = DateTime.Parse(fecha_de_nacimiento_PA);
            pac.Direccion_PA = direccion_PA;
            pac.Dni_PA = dni_PA;
            pac.Id_localidades_PA = Convert.ToInt32(id_localidades_PA);
            pac.Id_provincias_PA = Convert.ToInt32(id_provincias_PA);
            pac.Telefono_PA = telefono_PA;
            pac.Sexo_PA = sexo_PA;
            pac.Nacionalidad_PA = nacionalidad_PA;

            DatosPacientes dao = new DatosPacientes();  // Instancia de la clase DatosPacientes para operaciones de datos
            if (dao.existePaciente(pac) == false)  // Verifica si el paciente ya existe en la base de datos
            {
                cantFilas = dao.agregarPaciente(pac);  // Llama al método de la capa de datos para agregar el paciente
            }
            else
            {
                cantFilas = 0;  // Si el paciente ya existe, no se agrega y se devuelve 0 filas afectadas
            }
            return cantFilas;  // Retorna la cantidad de filas afectadas por la operación de inserción
        }

        // Método para eliminar un paciente de la base de datos por su legajo

        public bool EliminarPaciente(int leg)
        {
            int cantFilas = 0;
            Pacientes pa = new Pacientes();
            pa.Legajo_PA1 = leg;

            DatosPacientes dao = new DatosPacientes();  // Instancia de la clase DatosPacientes para operaciones de datos
            if (dao.existePacientePorLegajo(pa) == true)  // Verifica si existe un paciente con el legajo proporcionado
            {
                cantFilas = dao.eliminarPacientes(pa);  // Llama al método de la capa de datos para eliminar el paciente
            }

            // Retorna true si se eliminó correctamente (1 fila afectada), de lo contrario retorna false
            return cantFilas == 1;
        }

        // Método para obtener todos los pacientes desde la base de datos

        public DataTable ObtenerPacientes()
        {
            DatosPacientes dao = new DatosPacientes();  // Instancia de la clase DatosPacientes para operaciones de datos
            return dao.ObtenerTablaPacientes();  // Obtiene la tabla de pacientes desde la capa de datos

        }

        // Método para obtener un paciente de la db por legajo

        public DataTable ObtenerPacientesXlegajo(string Leg)
        {
            DatosPacientes dao = new DatosPacientes();  // Instancia de la clase DatosPacientes para operaciones de datos
            return dao.ObtenerTablarPacientesXlegajo(Leg);
        }

        // Método para obtener el nombre completo de un paciente por su legajo

        public string ObtenerNombrePaciente(int leg)
        {
            DatosPacientes dao = new DatosPacientes();  // Instancia de la clase DatosPacientes para operaciones de datos
            return dao.ObtenerNombrePaciente(leg);  // Obtiene el nombre completo del paciente desde la capa de datos
        }

        // Método para modificar los datos de un paciente en la base de datos

        public bool Modificar_Paciente(Pacientes pac)
        {
            DatosPacientes pacmodf = new DatosPacientes();  // Instancia de la clase DatosPacientes para operaciones de datos
            int FilasAfectadas = pacmodf.EditarPaciente(pac);  // Llama al método de la capa de datos para modificar el paciente
            // Retorna true si se modificó correctamente (1 fila afectada), de lo contrario retorna false
            return FilasAfectadas == 1;
        }

        //Verifica la existencia del paciente por Telefono

        public bool VerificarExistenciaTelefono(string telefono)
        {
            DatosPacientes dao = new DatosPacientes();
            return dao.existePacienteporTelefono(telefono);
        }

        //Verifica la existencia del paciente por Correo

        public bool VerificarExistenciaCorreo(string correo)
        {
            DatosPacientes dao = new DatosPacientes();
            return dao.existePacienteporCorreo(correo);
        }

        //Verifica existencia de mas de un registro con ese telefono (para el editar)

        public bool VerificarExistenciaMasDeUnTelefono(string telefono)
        {
            DatosPacientes dao = new DatosPacientes();
            if ((dao.existePacienteporMasDeUnTelefono(telefono)) >= 1) return true;
            return false;
        }

        //Verifica existencia de mas de un registro con ese correo (para el editar)

        public bool VerificarExistenciaMasDeUnCorreo(string correo)
        {
            DatosPacientes dao = new DatosPacientes();
            if ((dao.existePacienteporMasDeUnCorreo(correo)) >= 1) return true;
            return false;
        }

        //Verifica existencia de mas de un registro con ese dni (para el editar)

        public bool VerificarExistenciaMasDeUnDni(string dni)
        {
            DatosPacientes dao = new DatosPacientes();
            if ((dao.existePacienteporMasDeUnDni(dni)) >= 1) return true;
            return false;
        }
    }
}
