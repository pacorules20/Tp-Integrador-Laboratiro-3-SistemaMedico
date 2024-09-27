using Negocio;
using System;

namespace Vistas
{
    public partial class RegistrarUsuarioMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {

                LBL_nombreUsuario.Text = Session["Nombre"].ToString();


                NegocioMedicos med = new NegocioMedicos();
                GrdMedicos.DataSource = med.ObtenerMedicos();
                GrdMedicos.DataBind();

            }

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            NegocioUsuarios neg = new NegocioUsuarios();

            // Verificar que no exista una cuenta con ese medico
            if (neg.ExisteCuentaPorLegajo(TxtLegajo.Text) == false)
            {

                bool exito = neg.AgregarUsuario(TxtLegajo.Text, TxtUsuario.Text, TxtContraseña.Text);
                if (exito)
                {
                    lblerror.Text = "Usuario agregado correctamente.";
                }
                else
                {
                    lblerror.Text = "Error al agregar Usuario.";
                }
            }
            else
            {
                lblerror.Text = "Este medico ya tiene una cuenta asociada.";
            }
            //Limpiar TB
            LimpiarTB();
        }

        private void LimpiarTB()
        {
            TxtContraseña.Text = "";
            TxtContraseñaConfirmar.Text = "";
            TxtLegajo.Text = "";
            TxtUsuario.Text = "";
        }

        protected void GrdMedicos_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GrdMedicos.PageIndex = e.NewPageIndex;
            NegocioMedicos med = new NegocioMedicos();
            GrdMedicos.DataSource = med.ObtenerMedicos();
            GrdMedicos.DataBind();
        }
    }
}