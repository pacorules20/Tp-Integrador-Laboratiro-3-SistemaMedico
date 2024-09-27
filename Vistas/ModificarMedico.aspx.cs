using Entidades;
using Negocio;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ModificarMedico : System.Web.UI.Page
    {
        NegocioMedicos medic = new NegocioMedicos(); // Instancia del objeto de negocio para manejar médicos

        // Evento que se ejecuta al cargar la página

        protected void Page_Load(object sender, EventArgs e)
        {
            LBL_nombreUsuario.Text = Session["Nombre"].ToString(); // Establece el nombre de usuario desde la sesión

            if (!IsPostBack)
            {
                Cargarmedico(GRDModificarMedico); // Carga los datos de los médicos en el GridView al cargar la página por primera vez
            }
        }

        // Método para cargar los datos de los médicos en el GridView

        private void Cargarmedico(GridView aux)
        {
            DataTable Tablamedica = medic.ObtenerMedicos(); // Obtiene los datos de los médicos desde el negocio
            aux.DataSource = Tablamedica; // Asigna los datos al GridView
            aux.DataBind(); // Enlaza los datos con el GridView
        }

        // Evento que se ejecuta al editar una fila en el GridView

        protected void GRDModificarMedico_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GRDModificarMedico.EditIndex = e.NewEditIndex; // Establece el índice de edición en el GridView
            Cargarmedico(GRDModificarMedico); // Vuelve a cargar los datos en el GridView
        }

        // Evento que se ejecuta al cancelar la edición de una fila en el GridView

        protected void GRDModificarMedico_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GRDModificarMedico.EditIndex = -1; // Cancela la edición estableciendo el índice de edición a -1
            Cargarmedico(GRDModificarMedico); // Vuelve a cargar los datos en el GridView
        }

        // Evento que se ejecuta al actualizar una fila en el GridView

        protected void GRDModificarMedico_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int indice = e.RowIndex; // Obtiene el índice de la fila que se está actualizando
            GridViewRow tabla = GRDModificarMedico.Rows[indice]; // Obtiene la fila del GridView
            NegocioMedicos neg = new NegocioMedicos();

            if (!(neg.VerificarExistenciaMasDeUnDni(((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("TxtmodificarDni")).Text) && neg.VerificarExistenciaMasDeUnTelefono(((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("txtTelefonoMedico")).Text) && neg.VerificarExistenciaMasDeUnCorreo(((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("txtCorreoMedico")).Text)))
            {
                // Crea un objeto de la entidad Medicos para almacenar los nuevos datos
                Medicos med = new Medicos();
                med.Legajo_ME1 = Convert.ToInt32(((Label)GRDModificarMedico.Rows[e.RowIndex].FindControl("lblEditarLegajo")).Text); // Obtiene y convierte el legajo del médico
                med.Nombre_ME1 = ((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("textNombre")).Text; // Obtiene el nuevo nombre del médico
                med.Apellido_ME1 = ((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("txtApellido")).Text; // Obtiene el nuevo apellido del médico
                med.Dni_ME1 = ((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("TxtmodificarDni")).Text; // Obtiene el nuevo DNI del médico
                med.Sexo_ME1 = ((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("TxtSexomedico")).Text; // Obtiene el nuevo sexo del médico
                med.Nacionalidad_ME1 = ((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("txtNacionalidadmedica")).Text; // Obtiene la nueva nacionalidad del médico
                med.Fecha_de_Nacimiento_ME1 = DateTime.Parse(((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("textFechaNacimiento")).Text); // Obtiene y convierte la nueva fecha de nacimiento del médico
                med.Direccion_ME1 = ((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("TxtDireccionmedica")).Text; // Obtiene la nueva dirección del médico
                med.Id_Localidades_ME1 = Convert.ToInt32(((Label)GRDModificarMedico.Rows[e.RowIndex].FindControl("lblModificallocalidad")).Text); // Obtiene y convierte el nuevo ID de localidad del médico
                med.Id_Provincias_ME1 = Convert.ToInt32(((Label)GRDModificarMedico.Rows[e.RowIndex].FindControl("LblModificarProvincia")).Text); // Obtiene y convierte el nuevo ID de provincia del médico
                med.Correo_Electronico_ME1 = ((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("txtCorreoMedico")).Text; // Obtiene el nuevo correo electrónico del médico
                med.Telefono_ME1 = ((TextBox)GRDModificarMedico.Rows[e.RowIndex].FindControl("txtTelefonoMedico")).Text; // Obtiene el nuevo teléfono del médico
                med.Especialidad_ME1 = Convert.ToInt32(((Label)GRDModificarMedico.Rows[e.RowIndex].FindControl("LblModfEspecialidad")).Text); // Obtiene y convierte la nueva especialidad del médico
                med.Dias_y_Horarios_ME1 = ((Label)GRDModificarMedico.Rows[e.RowIndex].FindControl("lblDiasYhorarios")).Text; // Obtiene los días y horarios del médico

                // Llama al método del negocio para modificar los datos del médico
                medic.Modificar_Medico(med);

                GRDModificarMedico.EditIndex = -1; // Finaliza la edición estableciendo el índice de edición a -1
                Cargarmedico(GRDModificarMedico); // Vuelve a cargar los datos en el GridView
            }
            else
            {
                LBL_Adver.Text = "Algunos de los datos estan repetidos";
                LBL_Adver.Visible = true;
                GRDModificarMedico.EditIndex = -1; // Finaliza la edición estableciendo el índice de edición a -1
                Cargarmedico(GRDModificarMedico); // Vuelve a cargar los datos en el GridView
            }
        }

        //Cambio de pagina GridView

        protected void GRDModificarMedico_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GRDModificarMedico.PageIndex = e.NewPageIndex;
            Cargarmedico(GRDModificarMedico);
        }
    }
}
