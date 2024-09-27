using Entidades;
using Negocio;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ModificarPaciente : System.Web.UI.Page
    {
        // Instancia del objeto de negocio para manejar pacientes
        NegocioPacientes negpaciente = new NegocioPacientes();

        // Evento que se ejecuta al cargar la página
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se establece el nombre de usuario desde la sesión
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();

            // Si no es una solicitud de postback (primera carga de la página)
            if (!IsPostBack)
            {
                // Cargar los datos de los pacientes en el GridView
                CargarPaciente(GRDModificarPaciente);
            }
        }

        // Método para cargar los datos de los pacientes en el GridView

        private void CargarPaciente(GridView aux)
        {
            DataTable TablaPaciente = negpaciente.ObtenerPacientes(); // Obtiene los datos de los pacientes desde el negocio
            aux.DataSource = TablaPaciente; // Asigna los datos al GridView
            aux.DataBind(); // Enlaza los datos con el GridView
        }

        // Evento que se ejecuta al editar una fila en el GridView

        protected void GridViewPacienteMOD_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GRDModificarPaciente.EditIndex = e.NewEditIndex; // Establece el índice de edición en el GridView
            CargarPaciente(GRDModificarPaciente); // Vuelve a cargar los datos en el GridView
        }

        // Evento que se ejecuta al cancelar la edición de una fila en el GridView

        protected void GridViewPacienteMOD_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GRDModificarPaciente.EditIndex = -1; // Cancela la edición estableciendo el índice de edición a -1
            CargarPaciente(GRDModificarPaciente); // Vuelve a cargar los datos en el GridView
        }

        // Evento que se ejecuta al actualizar una fila en el GridView

        protected void GridViewPacienteMOD_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int index = e.RowIndex; // Obtiene el índice de la fila que se está actualizando
            GridViewRow row = GRDModificarPaciente.Rows[index]; // Obtiene la fila del GridView
            NegocioPacientes neg = new NegocioPacientes();

            if (!(neg.VerificarExistenciaMasDeUnDni(((TextBox)row.FindControl("TxtmodificarDni")).Text) && neg.VerificarExistenciaMasDeUnTelefono(((TextBox)row.FindControl("txtTelefono")).Text) && neg.VerificarExistenciaMasDeUnCorreo(((TextBox)row.FindControl("txtCorreo")).Text)))
            {

                // Crea un objeto de la entidad Pacientes para almacenar los nuevos datos
                Pacientes pac = new Pacientes();
                pac.Legajo_PA1 = Convert.ToInt32(((Label)row.FindControl("lblEditarLegajo")).Text); // Obtiene y convierte el legajo del paciente
                pac.Nombre_PA = ((TextBox)row.FindControl("txtNombre")).Text; // Obtiene el nuevo nombre del paciente
                pac.Apellido_PA = ((TextBox)row.FindControl("textApellido")).Text; // Obtiene el nuevo apellido del paciente
                pac.Dni_PA = ((TextBox)row.FindControl("TxtmodificarDni")).Text; // Obtiene el nuevo DNI del paciente
                pac.Sexo_PA = ((TextBox)row.FindControl("TxtSexo")).Text; // Obtiene el nuevo sexo del paciente
                pac.Nacionalidad_PA = ((TextBox)row.FindControl("txtNacionalidad")).Text; // Obtiene la nueva nacionalidad del paciente
                pac.Fecha_de_nacimiento_PA = DateTime.Parse(((TextBox)row.FindControl("textFechaNacimiento")).Text); // Obtiene y convierte la nueva fecha de nacimiento del paciente
                pac.Direccion_PA = ((TextBox)row.FindControl("TxtDireccio")).Text; // Obtiene la nueva dirección del paciente
                pac.Id_localidades_PA = Convert.ToInt32(((Label)row.FindControl("lblModificallocalidad")).Text); // Obtiene y convierte el nuevo ID de localidad del paciente
                pac.Id_provincias_PA = Convert.ToInt32(((Label)row.FindControl("LblModificarProvincia")).Text); // Obtiene y convierte el nuevo ID de provincia del paciente
                pac.Correo_electronico_PA = ((TextBox)row.FindControl("txtCorreo")).Text; // Obtiene el nuevo correo electrónico del paciente
                pac.Telefono_PA = ((TextBox)row.FindControl("txtTelefono")).Text; // Obtiene el nuevo teléfono del paciente

                // Llama al método del negocio para modificar los datos del paciente
                negpaciente.Modificar_Paciente(pac);

                GRDModificarPaciente.EditIndex = -1; // Finaliza la edición estableciendo el índice de edición a -1
                CargarPaciente(GRDModificarPaciente); // Vuelve a cargar los datos en el GridView
            }
            else
            {
                LBL_Adver.Text = "Algunos de los datos estan repetidos";
                LBL_Adver.Visible = true;
                GRDModificarPaciente.EditIndex = -1; // Finaliza la edición estableciendo el índice de edición a -1
                CargarPaciente(GRDModificarPaciente); // Vuelve a cargar los datos en el GridView
            }


        }

        //Cambio de pagina GridView

        protected void GRDModificarPaciente_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GRDModificarPaciente.PageIndex = e.NewPageIndex;
            CargarPaciente(GRDModificarPaciente);
        }
    }
}
