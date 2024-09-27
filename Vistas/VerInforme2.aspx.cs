using Negocio;
using System;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        NegocioMedicos neg = new NegocioMedicos();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga el nombre de usuario
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();

            if (!IsPostBack)
            {
                NegocioEspecialidades esp = new NegocioEspecialidades();
                // Agrega el item placeholder
                DDLEspecialidades.Items.Insert(0, "--SELECCIONA ESPECIALIDAD--");
                //Setea el item como seleccionado
                DDLEspecialidades.SelectedIndex = 0;
                // Obtener los datos del DropDownListcargardatos1 y agregarlos al DropDownList
                foreach (var especialidades in esp.DropDownListcargarEspecialidades())
                {
                    DDLEspecialidades.Items.Add(new ListItem(especialidades.Item1, especialidades.Item2));
                }

                //Carga el grid de medicos
                GrdInforme2.DataSource = neg.ObtenerMedicos();
                GrdInforme2.DataBind();
            }
        }

        //Ejecuta un procesado de porcentajes de especialidad

        protected void Btn_BuscarInformes_Click(object sender, EventArgs e)
        {
            GrdInforme2.DataSource = neg.ObtenerTablaMedicosXEspecialidad(DDLEspecialidades.SelectedValue);
            GrdInforme2.DataBind();

            float totaldeEspecialidadx = neg.ObtenertotaldeEspecialidadx(DDLEspecialidades.SelectedValue);
            float totalmedicos = neg.ObtenertotalMedicos();

            float porcentajeEspecialidadx = 0;


            if (totalmedicos > 0)
            {
                porcentajeEspecialidadx = (totaldeEspecialidadx * 100) / totalmedicos;
            }

            Lbl_medicos_especialidad.Text = porcentajeEspecialidadx.ToString() + "%";
        }

        //Borra el filtro de especialidades

        protected void Btn_borrarFiltro_Click(object sender, EventArgs e)
        {
            DDLEspecialidades.SelectedIndex = 0;
            Lbl_medicos_especialidad.Text = "";
        }
    }
}