using Negocio;
using System;
namespace Vistas
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga el nombre de usuario el la LBL
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();

            if (!IsPostBack)
            {
                //Carga los medicos
                NegocioMedicos med = new NegocioMedicos();
                GrdMedicos.DataSource = med.ObtenerMedicos();
                GrdMedicos.DataBind();
            }
        }

        //Busqueda de medico y popup de confirmacion

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            NegocioMedicos med = new NegocioMedicos();

            GrdMedicos.DataSource = med.ObtenerMedicosXlegajo(TxtLegajoEliminar.Text);
            GrdMedicos.DataBind();
            BtnConfirma.Visible = true;
            BtnCancelar.Visible = true;
        }

        //Eliminacion de medico

        protected void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            NegocioMedicos med = new NegocioMedicos();

            if (med.EliminarMedico(Convert.ToInt32(TxtLegajoEliminar.Text)))
            {
                TxtLegajoEliminar.Text = "";
                GrdMedicos.DataSource = med.ObtenerMedicos();
                GrdMedicos.DataBind();
                lblestado.Text = "Eliminado correctamente";
                BtnConfirma.Visible = false;
                BtnCancelar.Visible = false;
            }
            else
            {
                lblestado.Text = "Ese Legajo no existe, o hay un turno o cuenta asociado a ese medico. Ingrese un Legajo valido o elimine el turno con este medico.";
                TxtLegajoEliminar.Text = "";
                GrdMedicos.DataSource = med.ObtenerMedicos();
                GrdMedicos.DataBind();
                BtnConfirma.Visible = false;
                BtnCancelar.Visible = false;
            }

        }

        //Cancelado de eliminacion
        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnConfirma.Visible = false;
            BtnCancelar.Visible = false;
            NegocioMedicos med = new NegocioMedicos();
            GrdMedicos.DataSource = med.ObtenerMedicos();
            GrdMedicos.DataBind();
        }

        //Funcionalidad paginado

        protected void GrdMedicos_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GrdMedicos.PageIndex = e.NewPageIndex;
            NegocioMedicos med = new NegocioMedicos();
            GrdMedicos.DataSource = med.ObtenerMedicos();
            GrdMedicos.DataBind();
        }
    }



}