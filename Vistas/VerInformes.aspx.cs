using Negocio;
using System;

namespace Vistas
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        NegocioTurnos tur = new NegocioTurnos(); // Instancia del objeto de negocio para manejar turnos

        // Evento que se ejecuta al cargar la página

        protected void Page_Load(object sender, EventArgs e)
        {
            LBL_nombreUsuario.Text = Session["Nombre"].ToString(); // Establece el nombre de usuario desde la sesión
        }

        // Evento que se ejecuta al hacer clic en el botón "Buscar Informes"

        protected void Btn_BuscarInformes_Click(object sender, EventArgs e)
        {
            LBL_Mensaje.Text = ""; // Limpia el mensaje de error

            // Verifica que las fechas de búsqueda no estén vacías
            if (FechaBusquedaDesde.Text != "" && FechaBusquedaHasta.Text != "")
            {
                // Verifica que la fecha de inicio sea menor o igual a la fecha de fin
                if (Convert.ToDateTime(FechaBusquedaDesde.Text) <= Convert.ToDateTime(FechaBusquedaHasta.Text))
                {
                    // Obtiene los turnos según el intervalo de fechas y los asigna al GridView
                    GRD_infome1.DataSource = tur.ObtenerTurnosInformes1(FechaBusquedaDesde.Text, FechaBusquedaHasta.Text);
                    GRD_infome1.DataBind();

                    // Obtiene el total de turnos presentes y ausentes en el intervalo de fechas
                    int totalPresentes = tur.ObtenerTotalTurnosPresentes(FechaBusquedaDesde.Text, FechaBusquedaHasta.Text);
                    int totalAusentes = tur.ObtenerTotalTurnosAusentes(FechaBusquedaDesde.Text, FechaBusquedaHasta.Text);

                    // Calcula el total de turnos
                    int total = totalAusentes + totalPresentes;
                    int porcentajePresentes = 0;
                    int porcentajeAusentes = 0;

                    // Calcula los porcentajes de turnos presentes y ausentes si hay al menos un turno
                    if (total > 0)
                    {
                        porcentajePresentes = (totalPresentes * 100) / total;
                        porcentajeAusentes = (totalAusentes * 100) / total;
                    }

                    // Muestra los porcentajes en etiquetas correspondientes
                    Lbl_Total_Presentes.Text = porcentajePresentes.ToString() + "%";
                    Lbl_Total_Ausentes.Text = porcentajeAusentes.ToString() + "%";
                }
                else
                {
                    LBL_Mensaje.Text = "Error, ingrese un intervalo de fechas válido"; // Muestra mensaje de error si el intervalo de fechas no es válido
                }
            }
            else
            {
                LBL_Mensaje.Text = "Error, ingrese fecha de búsqueda para el informe"; // Muestra mensaje de error si falta alguna fecha de búsqueda
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Borrar Filtro"

        protected void Btn_borrarFiltro_Click(object sender, EventArgs e)
        {
            GRD_infome1.DataSource = ""; // Limpia el origen de datos del GridView
            GRD_infome1.DataBind(); // Vuelve a enlazar el GridView para limpiarlo visualmente
            FechaBusquedaDesde.Text = ""; // Limpia el campo de fecha de búsqueda desde
            FechaBusquedaHasta.Text = ""; // Limpia el campo de fecha de búsqueda hasta
            Lbl_Total_Presentes.Text = ""; // Limpia la etiqueta de total de turnos presentes
            Lbl_Total_Ausentes.Text = ""; // Limpia la etiqueta de total de turnos ausentes
        }
    }
}
