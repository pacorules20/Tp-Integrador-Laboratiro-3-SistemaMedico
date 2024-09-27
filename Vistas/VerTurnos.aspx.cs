using Entidades;
using Negocio;
using System;
using System.Data;
using System.Web.UI.WebControls;
namespace Vistas
{
    public partial class VerTurnos : System.Web.UI.Page
    {
        NegocioTurnos negturno = new NegocioTurnos();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga nombre en el header
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();
            if (!IsPostBack)
            {
                //Carga la tabla
                Cargarturno(GRDTurnos);
            }
        }

        //Metodo para cargar la tabla.

        private void Cargarturno(GridView aux)
        {
            string[] partes = LBL_nombreUsuario.Text.Split(',');
            string Nombre = partes[0].Trim();
            string apellido = partes[1].Trim();
            DataTable tablaturno = negturno.ObtenerTurnosxMedico(Nombre, apellido);
            aux.DataSource = tablaturno;
            aux.DataBind();
        }

        //Metodo de actualizacion de valores

        protected void GRDTurnos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Obtener el índice de la fila que se está actualizando
            int index = e.RowIndex;

            GridViewRow row = GRDTurnos.Rows[index];


            //metodo para actualizar valores

            Turnos turn = new Turnos();
            turn.Id_Turnos_TU = Convert.ToInt32(((Label)GRDTurnos.Rows[e.RowIndex].FindControl("lblEditarLegajo")).Text);
            turn.Observacion_TU = ((TextBox)GRDTurnos.Rows[e.RowIndex].FindControl("Txt_Observacion")).Text;
            turn.Asistencia_TU = Convert.ToBoolean(((TextBox)GRDTurnos.Rows[e.RowIndex].FindControl("Txt_Asistencia")).Text);

            negturno.Modificar_Turno(turn);
            GRDTurnos.EditIndex = -1;
            Cargarturno(GRDTurnos);
        }

        //Habilidato de edicion

        protected void GRDTurnos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GRDTurnos.EditIndex = e.NewEditIndex;
            Cargarturno(GRDTurnos);
        }

        //Cancelado de edicion

        protected void GRDTurnos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GRDTurnos.EditIndex = -1;
            Cargarturno(GRDTurnos);
        }

        //Ejecucion de busqueda de turno por dia y horario

        protected void BTN_BuscarXDia_Click(object sender, EventArgs e)
        {
            string[] partes = LBL_nombreUsuario.Text.Split(',');
            string Nombre = partes[0].Trim();
            string apellido = partes[1].Trim();
            DataTable tablaturno = negturno.BuscarTurnoPorDiaYHorario(Nombre, apellido, DDL_BuscarXDia.SelectedValue);
            GRDTurnos.DataSource = tablaturno;
            GRDTurnos.DataBind();
            if (GRDTurnos.Rows.Count == 0)
            {
                lblEstado.Text = "No hay turnos con estos parametros";
                BorrarFiltros();
            }
            else
            {
                lblEstado.Visible = false;
            }
        }

        //Ejecucion de busqueda de turno por legajo

        protected void BTN_BuscarporLegajo_Click(object sender, EventArgs e)
        {
            string[] partes = LBL_nombreUsuario.Text.Split(',');
            string Nombre = partes[0].Trim();
            string apellido = partes[1].Trim();
            int legajo = Convert.ToInt32(Txt_BuscarporLegajo.Text);
            DataTable tablaturno = negturno.BuscarTurnoporLegajo(Nombre, apellido, legajo);
            GRDTurnos.DataSource = tablaturno;
            GRDTurnos.DataBind();
            if (GRDTurnos.Rows.Count == 0)
            {
                lblEstado.Text = "No hay turnos con estos parametros";
                BorrarFiltros();
            }
            else
            {
                lblEstado.Visible = false;
            }
        }

        //Ejecucion de busqueda de turno por horario

        protected void Btn_BuscarXhorario_Click(object sender, EventArgs e)
        {
            string[] partes = LBL_nombreUsuario.Text.Split(',');
            string Nombre = partes[0].Trim();
            string apellido = partes[1].Trim();
            DataTable tablaturno = negturno.BuscarTurnoPorDiaYHorario(Nombre, apellido, DDL_BuscarXHorario.SelectedValue);
            GRDTurnos.DataSource = tablaturno;
            GRDTurnos.DataBind();
            if (GRDTurnos.Rows.Count == 0)
            {
                lblEstado.Text = "No hay turnos con estos parametros";
                BorrarFiltros();
            }
            else
            {
                lblEstado.Visible = false;
            }
        }

        //Ejecucion de busqueda de turno por fecha

        protected void Btn_BuscarXFecha_Click(object sender, EventArgs e)
        {
            string[] partes = LBL_nombreUsuario.Text.Split(',');
            string Nombre = partes[0].Trim();
            string apellido = partes[1].Trim();
            DataTable tablaturno = negturno.BuscarTurnoPorFechaBusqueda(Nombre, apellido, Txt_FechaBusqueda.Text);
            GRDTurnos.DataSource = tablaturno;
            GRDTurnos.DataBind();
            if (GRDTurnos.Rows.Count == 0)
            {
                lblEstado.Text = "No hay turnos con estos parametros";
                BorrarFiltros();
            }
            else
            {
                lblEstado.Visible = false;
            }
        }

        //Borrado de filtro de id

        protected void BTN_BorrarFiltro2_Click(object sender, EventArgs e)
        {
            BorrarFiltros();
            Cargarturno(GRDTurnos);
        }

        //Borrado de filtro de dia

        protected void BTN_BorrarFiltro1_Click(object sender, EventArgs e)
        {
            BorrarFiltros();
            Cargarturno(GRDTurnos);
        }

        //Borrado de filtro por horario

        protected void BTN_BorrarFiltro_Click(object sender, EventArgs e)
        {
            BorrarFiltros();
            Cargarturno(GRDTurnos);
        }

        //Borrado de filtro por busqueda

        protected void BTN_BorrarFiltro0_Click(object sender, EventArgs e)
        {
            BorrarFiltros();
            Cargarturno(GRDTurnos);
        }

        //Ejecuta una busqueda de turno por el id de paciente

        protected void BTN_BuscarporPaciente_Click(object sender, EventArgs e)
        {
            string[] partes = LBL_nombreUsuario.Text.Split(',');
            string Nombre = partes[0].Trim();
            string apellido = partes[1].Trim();
            int id = Convert.ToInt32(Txt_Buscarporid.Text);
            DataTable tablaturno = negturno.BuscarTurnoPorIdPaciente(Nombre, apellido, id);
            GRDTurnos.DataSource = tablaturno;
            GRDTurnos.DataBind();
            if (GRDTurnos.Rows.Count == 0)
            {
                lblEstado.Text = "No hay turnos con estos parametros";
                BorrarFiltros();
            }
            else
            {
                lblEstado.Visible = false;
            }
        }

        private void BorrarFiltros()
        {
            Txt_Buscarporid.Text = "";
            DDL_BuscarXDia.SelectedIndex = 0;
            DDL_BuscarXHorario.SelectedIndex = 0;
            Txt_FechaBusqueda.Text = "";
        }
    }
}