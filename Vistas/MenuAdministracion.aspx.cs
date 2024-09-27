using System;
namespace Vistas
{
    public partial class MenuAdministracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga nombre de usuario en el lbl
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();
        }

        //Elimina las variables session y devuelve al inicio de sesion

        protected void BTN_CerrarSession_Click(object sender, EventArgs e)
        {
            Session["Nombre"] = null;
            Session["Rol"] = null;
            Response.Redirect("IngresodeUsuario.aspx");
        }
    }
}