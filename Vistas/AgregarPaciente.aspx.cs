using Negocio;
using System;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class AgregarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Asigna el nombre de usuario almacenado en sesión al control LBL_nombreUsuario
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();

            // Verifica si la página se está cargando por primera vez
            if (!IsPostBack)
            {
                NegocioProvincia suc = new NegocioProvincia();

                // Llena el DropDownList DDLProvincia con datos de provincias obtenidos desde la capa de negocio
                foreach (var provincia in suc.DropDownListcargarProvincias())
                {
                    DDLProvincia.Items.Add(new ListItem(provincia.Item1, provincia.Item2));
                }

                // Llena el DropDownList DDLNacionalidad con datos de nacionalidades obtenidos desde la capa de negocio
                NegocioNacionalidades Nacionalidades = new NegocioNacionalidades();
                foreach (var Nacionalidad in Nacionalidades.DropDownListcargarNacionalidades())
                {
                    DDLNacionalidad.Items.Add(new ListItem(Nacionalidad.Item1, Nacionalidad.Item2));
                }

                // Agrega un item placeholder y lo deshabilita en el DropDownList DDLProvincia
                DDLProvincia.Items.Insert(0, "--SELECCIONA PROVINCIA--");
                DDLProvincia.Items[0].Selected = true;
                DDLProvincia.Items[0].Attributes["disabled"] = "disabled";

                // Agrega un item placeholder y lo deshabilita en el DropDownList DDLlocalidad
                DDLlocalidad.Items.Insert(0, "--SELECCIONA LOCALIDAD--");
                DDLlocalidad.Items[0].Selected = true;
                DDLlocalidad.Items[0].Attributes["disabled"] = "disabled";

                // Agrega un item placeholder y lo deshabilita en el DropDownList DDLNacionalidad
                DDLNacionalidad.Items.Insert(0, "--SELECCIONA NACIONALIDAD--");
                DDLNacionalidad.Items[0].Selected = true;
                DDLNacionalidad.Items[0].Attributes["disabled"] = "disabled";
            }

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Crea una instancia de NegocioPacientes para interactuar con la lógica de negocio de los pacientes
            NegocioPacientes neg = new NegocioPacientes();

            // Verificacion de existencias de campos unique

            if (neg.VerificarExistenciaTelefono(TxtTelefono.Text) == true)
            {
                lblerror.Text = "El Teléfono ya está registrado";
                return;
            }

            if (neg.VerificarExistenciaCorreo(TxtMail.Text) == true)
            {
                lblerror.Text = "El correo ya está registrado";
                return;
            }


            // Intenta agregar un nuevo paciente utilizando los datos ingresados en los controles de la página
            int exito = neg.AgregarPaciente(TxtNombre.Text, TxtApellido.Text, TxtDNI.Text, CBLGenero.SelectedValue,
                                          DDLNacionalidad.SelectedValue, TxtNacimiento.Text, TxtDireccion.Text,
                                          DDLlocalidad.SelectedValue, DDLProvincia.SelectedValue, TxtMail.Text,
                                          TxtTelefono.Text);

            // Muestra un mensaje en lblerror según el resultado de la operación de agregado
            if (exito >= 1)
            {
                lblerror.Text = "Agregado correctamente";
            }
            else
            {
                lblerror.Text = "Error al agregar";
            }

            // Limpia los campos del formulario después de agregar el paciente
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDNI.Text = "";
            DDLNacionalidad.SelectedIndex = 0;
            TxtDireccion.Text = "";
            DDLlocalidad.SelectedIndex = 0;
            DDLProvincia.SelectedIndex = 0;
            TxtMail.Text = "";
            TxtTelefono.Text = "";
            DDLlocalidad.Items.Clear();
            DDLlocalidad.Items.Insert(0, "--SELECCIONA LOCALIDAD--");
            DDLlocalidad.Items[0].Selected = true;
            DDLlocalidad.Items[0].Attributes["disabled"] = "disabled";
            TxtNacimiento.Text = "";
        }

        //Llena el DDL de localidades al seleccionar provincia.

        protected void DDLProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia el DropDownList DDLlocalidad cuando se selecciona una nueva provincia
            DDLlocalidad.Items.Clear();

            // Crea una instancia de NegocioLocalidad para obtener las localidades de la provincia seleccionada
            NegocioLocalidad Loc = new NegocioLocalidad();

            // Llena el DropDownList DDLlocalidad con las localidades obtenidas
            foreach (var localidad in Loc.DropDownListcargarLocalidades(DDLProvincia.SelectedIndex))
            {
                DDLlocalidad.Items.Add(new ListItem(localidad.Item1, localidad.Item2));
            }
        }

    }
}
