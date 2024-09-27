using Negocio;
using System;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class BajaTurnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga nombre de usuario en LBL
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();

            if (!IsPostBack)
            {
                //Carga de tabla turnos
                NegocioTurnos tur = new NegocioTurnos();
                GrdTurnos.DataSource = tur.ObtenerTurnos();
                GrdTurnos.DataBind();
            }
        }

        //Busqueda de registro y popup de confirmacion

        protected void BtneliminarTurnos_Click(object sender, EventArgs e)
        {
            NegocioTurnos tur = new NegocioTurnos();
            GrdTurnos.DataSource = tur.ObtenerTurnosXLeg(TxtEliminar.Text);
            GrdTurnos.DataBind();
            BtnConfirma.Visible = true;
            BtnCancelar.Visible = true;

        }

        //Eliminacion de turno

        protected void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            NegocioTurnos tur = new NegocioTurnos();

            if (tur.Eliminar_Turnos(Convert.ToInt32(TxtEliminar.Text)))
            {
                TxtEliminar.Text = "";
                GrdTurnos.DataSource = tur.ObtenerTurnos();
                GrdTurnos.DataBind();
                lblestado.Text = "usuario eliminado correctamente";
                BtnConfirma.Visible = false;
                BtnCancelar.Visible = false;
            }
            else
            {
                lblestado.Text = "Ese ID de turno no existe,Ingrese un ID valido .";
                TxtEliminar.Text = "";
                GrdTurnos.DataSource = tur.ObtenerTurnos();
                GrdTurnos.DataBind();
                BtnConfirma.Visible = false;
                BtnCancelar.Visible = false;
            }
        }

        //Cancelado de eliminacion

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            NegocioTurnos tur = new NegocioTurnos();
            GrdTurnos.DataSource = tur.ObtenerTurnos();
            GrdTurnos.DataBind();
            TxtEliminar.Text = "";
            BtnConfirma.Visible = false;
            BtnCancelar.Visible = false;
        }

        //Funcionalidad paginado

        protected void GrdTurnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdTurnos.PageIndex = e.NewPageIndex;
            NegocioTurnos tur = new NegocioTurnos();
            GrdTurnos.DataSource = tur.ObtenerTurnos();
            GrdTurnos.DataBind();
        }
    }
}
