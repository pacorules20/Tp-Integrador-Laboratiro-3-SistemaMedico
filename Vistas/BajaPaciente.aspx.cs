using Negocio;
using System;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class BajaPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga nombre de usuario en lbl
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();

            if (!IsPostBack)
            {
                //Carga tabla pacientes
                NegocioPacientes Pac = new NegocioPacientes();
                GrdPacientes.DataSource = Pac.ObtenerPacientes();
                GrdPacientes.DataBind();
            }
        }

        //Busqueda de paciente por legajo y popup de confirmacion

        protected void BtneliminarPaciente_Click(object sender, EventArgs e)
        {
            NegocioPacientes Pac = new NegocioPacientes();

            GrdPacientes.DataSource = Pac.ObtenerPacientesXlegajo(TxtEliminar.Text);
            GrdPacientes.DataBind();
            BtnConfirma.Visible = true;
            BtnCancelar.Visible = true;

        }

        //Cancelado de eliminacion

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnConfirma.Visible = false;
            BtnCancelar.Visible = false;
            NegocioPacientes Pac = new NegocioPacientes();
            GrdPacientes.DataSource = Pac.ObtenerPacientes();
            GrdPacientes.DataBind();
        }

        //Eliminacion

        protected void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            NegocioPacientes Pac = new NegocioPacientes();

            if (Pac.EliminarPaciente(Convert.ToInt32(TxtEliminar.Text)) == true)
            {
                TxtEliminar.Text = "";
                GrdPacientes.DataSource = Pac.ObtenerPacientes();
                GrdPacientes.DataBind();
                lblestado.Text = "Paciente eliminado correctamente";
                BtnConfirma.Visible = false;
                BtnCancelar.Visible = false;

            }
            else
            {
                lblestado.Text = "Ese Legajo no existe, o hay un turno asociado a ese legajo. Ingrese un Legajo valido o elimine el turno con este paciente.";
                TxtEliminar.Text = "";
                GrdPacientes.DataSource = Pac.ObtenerPacientes();
                GrdPacientes.DataBind();
                BtnConfirma.Visible = false;
                BtnCancelar.Visible = false;
            }

        }

        //Funcionalidad paginado

        protected void GrdPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdPacientes.PageIndex = e.NewPageIndex;
            NegocioPacientes Pac = new NegocioPacientes();
            GrdPacientes.DataSource = Pac.ObtenerPacientes();
            GrdPacientes.DataBind();
        }
    }
}