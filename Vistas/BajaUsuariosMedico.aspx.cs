using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class BajaUsuariosMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga nombre de usuario en lbl
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();


            if (!IsPostBack)
            {
                //Carga de tabla usuarios
                NegocioUsuarios us = new NegocioUsuarios();
                GrdUsuariosMedico.DataSource = us.ObtenerUsuarios();
                GrdUsuariosMedico.DataBind();
            }
        }

        //Busqueda, muestra de registro y popup de confirmacion

        protected void BtneliminarUsuariosMedico_Click(object sender, EventArgs e)
        {
            NegocioUsuarios us = new NegocioUsuarios();
            GrdUsuariosMedico.DataSource = us.ObtenerUsuariosxId(TxtEliminar.Text);
            GrdUsuariosMedico.DataBind();
            BtnConfirma.Visible = true;
            BtnCancelar.Visible = true;
        }

        //Eliminado de usuario

        protected void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            NegocioUsuarios us = new NegocioUsuarios();

            if (us.Eliminar_Usuarios(Convert.ToInt32(TxtEliminar.Text)))
            {
                TxtEliminar.Text = "";
                GrdUsuariosMedico.DataSource = us.ObtenerUsuarios();
                GrdUsuariosMedico.DataBind();
                lblestado.Text = "Usuario eliminado correctamente.";
                BtnConfirma.Visible = false;
                BtnCancelar.Visible = false;
            }
            else
            {
                lblestado.Text = "Ese ID no existe,Ingrese un ID valido o elimine los turnos de este medico .";
                TxtEliminar.Text = "";
                GrdUsuariosMedico.DataSource = us.ObtenerUsuarios();
                GrdUsuariosMedico.DataBind();
                BtnConfirma.Visible = false;
                BtnCancelar.Visible = false;
            }
        }

        //Cancelado de eliminado
        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnConfirma.Visible = false;
            BtnCancelar.Visible = false;
            NegocioUsuarios us = new NegocioUsuarios();
            GrdUsuariosMedico.DataSource = us.ObtenerUsuarios();
            GrdUsuariosMedico.DataBind();
        }

        //Funcionalidad Paginacion

        protected void GrdUsuariosMedico_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdUsuariosMedico.PageIndex = e.NewPageIndex;
            NegocioUsuarios us = new NegocioUsuarios();
            GrdUsuariosMedico.DataSource = us.ObtenerUsuarios();
            GrdUsuariosMedico.DataBind();
        }
    }
}