using Datos;     // Importación del espacio de nombres Datos donde está la clase DatosMedicos
using Entidades; // Importación del espacio de nombres Entidades donde está la clase Medicos
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NegocioMedicos
    {

        // Funcion de Verificado de Login Medico

        public string VerificarLoginMedico(string userName, string PWD)
        {
            DatosMedicos dat = new DatosMedicos();
            //Consigue el nombre del medico, si las credenciales son validas
            string nombre = dat.LoginMedico(userName, PWD);
            return nombre;
        }

        // Método para agregar un médico a la base de datos

        public int AgregarMedico(string Nombre_ME, string Apellido_ME, string Dni_ME, string Sexo_ME, string Nacionalidad_ME, string Fecha_de_Nacimiento_ME,
         string Direccion_ME, string Id_Localidades_ME, string Id_Provincias_ME, string Correo_Electronico_ME, string Telefono_ME,
         string Especialidad_ME, string Dias_y_Horarios_ME)
        {
            int cantFilas = 0;
            Medicos med = new Medicos
            {
                Nombre_ME1 = Nombre_ME,
                Apellido_ME1 = Apellido_ME,
                Dni_ME1 = Dni_ME,
                Sexo_ME1 = Sexo_ME,
                Nacionalidad_ME1 = Nacionalidad_ME,
                Fecha_de_Nacimiento_ME1 = DateTime.Parse(Fecha_de_Nacimiento_ME),
                Direccion_ME1 = Direccion_ME,
                Id_Localidades_ME1 = Convert.ToInt32(Id_Localidades_ME),
                Id_Provincias_ME1 = Convert.ToInt32(Id_Provincias_ME),
                Correo_Electronico_ME1 = Correo_Electronico_ME,
                Telefono_ME1 = Telefono_ME,
                Especialidad_ME1 = Convert.ToInt32(Especialidad_ME),
                Dias_y_Horarios_ME1 = Dias_y_Horarios_ME,
            };

            DatosMedicos dao = new DatosMedicos();  // Instancia de la clase DatosMedicos para operaciones de datos
            if (dao.existeMedico(med) == false)  // Verifica si el médico ya existe en la base de datos
            {
                cantFilas = dao.agregarMedicos(med);  // Llama al método de la capa de datos para agregar el médico
            }
            else
            {
                cantFilas = 0;  // Si el médico ya existe, no se agrega y se devuelve 0 filas afectadas
            }
            return cantFilas;  // Retorna la cantidad de filas afectadas por la operación de inserción
        }

        // Método para eliminar un médico de la base de datos por su legajo

        public bool EliminarMedico(int leg)
        {
            int cantFilas = 0;
            Medicos med = new Medicos();
            med.Legajo_ME1 = leg;

            DatosMedicos dao = new DatosMedicos();  // Instancia de la clase DatosMedicos para operaciones de datos
            if (dao.existeMedicoPorLegajo(med) == true)  // Verifica si existe un médico con el legajo proporcionado
            {
                cantFilas = dao.eliminarMedicos(med);  // Llama al método de la capa de datos para eliminar el médico
            }

            // Retorna true si se eliminó correctamente (1 fila afectada), de lo contrario retorna false
            return cantFilas == 1;
        }

        // Método para obtener todos los médicos desde la base de datos

        public DataTable ObtenerMedicos()
        {
            DatosMedicos dao = new DatosMedicos();  // Instancia de la clase DatosMedicos para operaciones de datos
            return dao.ObtenerTablaMedicos();  // Obtiene la tabla de médicos desde la capa de datos
        }

        // Método para obtener un medico particular de la db

        public DataTable ObtenerMedicosXlegajo(string Leg)
        {
            DatosMedicos dao = new DatosMedicos();  // Instancia de la clase DatosPacientes para operaciones de datos
            return dao.ObtenerTablaMedicosXlegajo(Leg);
        }

        // Método para obtener los datos para llenar un DropDownList de médicos

        public List<Tuple<string, string>> DropDownListcargardatosMedicos(int i)
        {
            DatosMedicos dao = new DatosMedicos();  // Instancia de la clase DatosMedicos para operaciones de datos
            return dao.DropDownListcargardatos(i);  // Llama al método en la capa de datos para obtener los datos del DropDownList
        }

        // Método para modificar los datos de un médico en la base de datos

        public bool Modificar_Medico(Medicos med)
        {
            DatosMedicos datMedicModf = new DatosMedicos();  // Instancia de la clase DatosMedicos para operaciones de datos
            int FilasAfectadas = datMedicModf.EditarMedicos(med);  // Llama al método de la capa de datos para modificar el médico
            // Retorna true si se modificó correctamente (1 fila afectada), de lo contrario retorna false
            return FilasAfectadas == 1;
        }

        // Verifica existencia de medico por telefono

        public bool VerificarExistenciaTelefono(string telefono)
        {
            DatosMedicos dao = new DatosMedicos();
            return dao.existeMedicoporTelefono(telefono);
        }

        // Verifica existencia de medico por correo

        public bool VerificarExistenciaCorreo(string correo)
        {
            DatosMedicos dao = new DatosMedicos();
            return dao.existeMedicoporCorreo(correo);
        }

        //Verifica existencia de mas de un registro con ese telefono (para el editar)

        public bool VerificarExistenciaMasDeUnTelefono(string telefono)
        {
            DatosMedicos dao = new DatosMedicos();
            if ((dao.existeMedicoporMasDeUnTelefono(telefono)) >= 1) return true;
            return false;
        }

        //Verifica existencia de mas de un registro con ese correo (para el editar)

        public bool VerificarExistenciaMasDeUnCorreo(string correo)
        {
            DatosMedicos dao = new DatosMedicos();
            if ((dao.existeMedicoporMasDeUnCorreo(correo)) >= 1) return true;
            return false;
        }

        //Verifica existencia de mas de un registro con ese dni (para el editar)

        public bool VerificarExistenciaMasDeUnDni(string dni)
        {
            DatosMedicos dao = new DatosMedicos();
            if ((dao.existeMedicoporMasDeUnDni(dni)) >= 1) return true;
            return false;
        }

        //Busca y muestra la tabla medicos en base a una especialidad

        public DataTable ObtenerTablaMedicosXEspecialidad(string especialidad)
        {
            DatosMedicos dao = new DatosMedicos();  // Instancia de la clase DatosPacientes para operaciones de datos
            return dao.ObtenerTablaMedicosXEspecialidad(especialidad);
        }

        // Obtiene la cantidad de X especialidad

        public int ObtenertotaldeEspecialidadx(string especialidad)
        {
            DatosMedicos dao = new DatosMedicos();
            return dao.ObtenerCuentaTotalEspecialidadx(especialidad);
        }

        //Obtiene el total de medicos

        public int ObtenertotalMedicos()
        {
            DatosMedicos dao = new DatosMedicos();
            return dao.ObtenerCuentaTotalMedicos();
        }

    }
}
