using Negocio;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class CambiaContraseñaaspx : System.Web.UI.Page
    {
        NegocioUsuarios Usu = new NegocioUsuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga nombre de usuario de sesion
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();
            if (!IsPostBack)
            {
                //Carga el grid de usuarios
                CargaGridUsuario(GRDModificarUsuario);
            }

        }

        //Funcion de carga de grid de usuario

        public void CargaGridUsuario(GridView aux)
        {
            DataTable TablaUsusario = Usu.ObtenerUsuarios();
            aux.DataSource = TablaUsusario;
            aux.DataBind();

        }

        //Habilitado de edicion

        protected void GRDModificarUsuario_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GRDModificarUsuario.EditIndex = e.NewEditIndex;
            CargaGridUsuario(GRDModificarUsuario);
        }

        //Cancelado de edicion

        protected void GRDModificarUsuario_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GRDModificarUsuario.EditIndex = -1;
            CargaGridUsuario(GRDModificarUsuario);
        }

        //Funcion de actualizado de grid

        protected void GRDModificarUsuario_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //metodo para obtener el indice
            int indice = e.RowIndex;
            GridViewRow tabla = GRDModificarUsuario.Rows[indice];
            //metodo para actualizar valores



            int idTemp = Convert.ToInt32(((Label)GRDModificarUsuario.Rows[e.RowIndex].FindControl("LblIdMedico")).Text);
            string usuarioTemp = ((TextBox)GRDModificarUsuario.Rows[e.RowIndex].FindControl("TB_NombreUsuario")).Text;
            string contraTemp = ((TextBox)GRDModificarUsuario.Rows[e.RowIndex].FindControl("TxtContraseña")).Text;


            Usu.Modificar_Usuarios(idTemp, usuarioTemp, contraTemp);
            GRDModificarUsuario.EditIndex = -1;
            CargaGridUsuario(GRDModificarUsuario);
        }

        //Funcionalidad paginado

        protected void GRDModificarUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GRDModificarUsuario.PageIndex = e.NewPageIndex;
            CargaGridUsuario(GRDModificarUsuario);
        }
    }
}