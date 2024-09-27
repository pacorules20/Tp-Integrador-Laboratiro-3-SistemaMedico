using Negocio;
using System;
namespace Vistas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Asignado de Sesion y redireccion

        void IniciarSesion(string nombre, string rol)
        {
            //Cookie de Nombre
            Session["Nombre"] = nombre;
            //Cookie de Rol
            Session["Rol"] = rol;
            //Redirige a pagina correspondiente
            string redirect = (rol == "Medico") ? "MenuMedico.aspx" : "MenuAdministracion.aspx";
            Response.Redirect(redirect);
        }

        //Desarrolla el proceso de login para un administrador

        protected void Btn_SesionAdm_click(object sender, EventArgs e)
        {
            NegocioAdmins neg = new NegocioAdmins();
            string valorNombre = neg.VerificarLoginAdmin(tbUsuario.Text, tbContraseña.Text);
            //Si los datos son validos, inicia sesion. Caso contrario, muestra msj error.
            if (valorNombre != null)
            {
                IniciarSesion(valorNombre, "Administrador");
            }
            //Si el usuario sigue en la pagina, el login fallo y vera este msj.
            lblError.Text = "Credenciales invalidas.";
            limpiarTextboxes();
        }

        //Desarrolla el proceso de login para un medico

        protected void Btn_SesionMed_Click(object sender, EventArgs e)
        {
            NegocioMedicos neg = new NegocioMedicos();
            string valorNombre = neg.VerificarLoginMedico(tbUsuario.Text, tbContraseña.Text);
            //Verificar si la data es valida
            if (valorNombre != null)
            {
                IniciarSesion(valorNombre, "Medico");
            }
            //Si el usuario sigue en la pagina, el login fallo y vera este msj.
            lblError.Text = "Credenciales invalidas.";
            limpiarTextboxes();
        }

        //Limpia las textboxes

        private void limpiarTextboxes()
        {
            tbContraseña.Text = "";
            tbUsuario.Text = "";
        }
    }
}