using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class AgregarTurno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LBL_nombreUsuario.Text = Session["Nombre"].ToString();

            if (!IsPostBack)
            {
                NegocioEspecialidades esp = new NegocioEspecialidades();

                // Obtener los datos del DropDownListcargardatos1 y agregarlos al DropDownList
                foreach (var especialidades in esp.DropDownListcargarEspecialidades())
                {
                    DDL_Especialidad.Items.Add(new ListItem(especialidades.Item1, especialidades.Item2));
                }

                // Agrega el item placeholder
                DDL_Especialidad.Items.Insert(0, "--SELECCIONA ESPECIALIDAD--");
                //Setea el item como seleccionado
                DDL_Especialidad.SelectedIndex = 0;
                //Deshabilita el item
                DDL_Especialidad.Items[0].Attributes["disabled"] = "disabled";


                // Agrega el item placeholder
                DDL_Horarios.Items.Insert(0, "--SELECCIONA HORA--");
                //Setea el item como seleccionado
                DDL_Horarios.SelectedIndex = 0;
                //Deshabilita el item
                DDL_Horarios.Items[0].Attributes["disabled"] = "disabled";

                // Agrega el item placeholder
                DDL_Dias.Items.Insert(0, "--SELECCIONA DIA--");
                //Setea el item como seleccionado
                DDL_Dias.SelectedIndex = 0;
                //Deshabilita el item
                DDL_Dias.Items[0].Attributes["disabled"] = "disabled";


                // Agrega el item placeholder
                DDl_medico.Items.Insert(0, "--SELECCIONA MEDICO--");
                //Setea el item como seleccionado
                DDl_medico.SelectedIndex = 0;
                //Deshabilita el item
                DDl_medico.Items[0].Attributes["disabled"] = "disabled";
            }
        }

        protected void DDL_Especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            DDl_medico.Items.Clear();
            DDL_Dias.Items.Clear();
            DDL_Horarios.Items.Clear();
            NegocioMedicos med = new NegocioMedicos();

            // Agrega el item placeholder
            DDl_medico.Items.Insert(0, "--SELECCIONA MEDICO--");
            //Deshabilita el item
            DDl_medico.Items[0].Attributes["disabled"] = "disabled";

            // Agrega el item placeholder
            DDL_Horarios.Items.Insert(0, "--SELECCIONA HORA--");
            //Setea el item como seleccionado
            DDL_Horarios.SelectedIndex = 0;
            //Deshabilita el item
            DDL_Horarios.Items[0].Attributes["disabled"] = "disabled";

            // Agrega el item placeholder
            DDL_Dias.Items.Insert(0, "--SELECCIONA DIA--");
            //Setea el item como seleccionado
            DDL_Dias.SelectedIndex = 0;
            //Deshabilita el item
            DDL_Dias.Items[0].Attributes["disabled"] = "disabled";

            // Obtener los datos del DropDownListcargardatos1 y agregarlos al DropDownList
            foreach (var Medicos in med.DropDownListcargardatosMedicos(DDL_Especialidad.SelectedIndex))
            {
                DDl_medico.Items.Add(new ListItem(Medicos.Item1, Medicos.Item2));
            }
        }


        protected void DDl_medico_SelectedIndexChanged(object sender, EventArgs e)
        {
            DDL_Dias.Items.Clear();
            DDL_Horarios.Items.Clear();

            // Agrega el item placeholder
            DDL_Horarios.Items.Insert(0, "--SELECCIONA HORA--");

            DDL_Horarios.SelectedIndex = 0;
            //Deshabilita el item
            DDL_Horarios.Items[0].Attributes["disabled"] = "disabled";

            // Agrega el item placeholder
            DDL_Dias.Items.Insert(0, "--SELECCIONA DIA--");

            DDL_Dias.SelectedIndex = 0;
            //Deshabilita el item
            DDL_Dias.Items[0].Attributes["disabled"] = "disabled";


            NegociosDiasyHorarios diayh = new NegociosDiasyHorarios();

            // Obtener los datos del DropDownListcargardatos1 y agregarlos al DropDownList
            foreach (var Horarios in diayh.CargarHorariosDDL(Convert.ToInt32(DDl_medico.SelectedValue)))
            {

                DDL_Horarios.Items.Add(Horarios);

            }
            foreach (var Dias in diayh.CargarDiasDDL(Convert.ToInt32(DDl_medico.SelectedValue)))
            {
                DDL_Dias.Items.Add(Dias);
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string dia;

            if (DateTime.TryParse(TxtFechaTurno.Text, out DateTime fecha))
            {
                Dictionary<DayOfWeek, string> diasEnEspanol = new Dictionary<DayOfWeek, string>
                {
                    { DayOfWeek.Sunday, "Domingo" },
                    { DayOfWeek.Monday, "Lunes" },
                    { DayOfWeek.Tuesday, "Martes" },
                    { DayOfWeek.Wednesday, "Miércoles" },
                    { DayOfWeek.Thursday, "Jueves" },
                    { DayOfWeek.Friday, "Viernes" },
                    { DayOfWeek.Saturday, "Sábado" }
                };
                DayOfWeek diaDeLaSemana = fecha.DayOfWeek;
                dia = diasEnEspanol[diaDeLaSemana];

                if (dia == DDL_Dias.Text)
                {
                    NegocioTurnos Tur = new NegocioTurnos();
                    NegocioPacientes Pac = new NegocioPacientes();

                    // Verificar que el paciente ingresado exista
                    string nombrePaciente = Pac.ObtenerNombrePaciente(Convert.ToInt32(TxtLeg.Text));

                    if (nombrePaciente != null)
                    {
                        if (Tur.AgregarTurno(DDL_Dias.SelectedValue, DDL_Horarios.SelectedValue, TxtLeg.Text, DDl_medico.SelectedValue, fecha))
                        {
                            lblEstado.Text = "Turno agregado correctamente para " + nombrePaciente + ".";
                        }
                        else
                        {
                            lblEstado.Text = "Turno ya está agregado";
                        }
                    }
                    else
                    {
                        lblEstado.Text = "Error al agregar: El ID del paciente no existe";
                    }

                    TxtLeg.Text = "";
                    DDL_Especialidad.SelectedIndex = 0;
                    DDL_Dias.Items.Clear();
                    DDL_Horarios.Items.Clear();
                    DDl_medico.Items.Clear();

                    // Agrega el item placeholder
                    DDL_Especialidad.SelectedIndex = 0;
                    //Deshabilita el item
                    DDL_Especialidad.Items[0].Attributes["disabled"] = "disabled";

                    // Agrega el item placeholder
                    DDL_Horarios.Items.Insert(0, "--SELECCIONA HORA--");
                    DDL_Horarios.SelectedIndex = 0;
                    //Deshabilita el item
                    DDL_Horarios.Items[0].Attributes["disabled"] = "disabled";

                    // Agrega el item placeholder
                    DDL_Dias.Items.Insert(0, "--SELECCIONA DIA--");
                    DDL_Dias.SelectedIndex = 0;
                    //Deshabilita el item
                    DDL_Dias.Items[0].Attributes["disabled"] = "disabled";

                    // Agrega el item placeholder
                    DDl_medico.Items.Insert(0, "--SELECCIONA MEDICO--");
                    DDl_medico.SelectedIndex = 0;
                    //Deshabilita el item
                    DDl_medico.Items[0].Attributes["disabled"] = "disabled";
                }
                else
                {
                    lblEstado.Text = "No se seleccionó una fecha con el día " + DDL_Dias.Text;
                }
            }
            else
            {
                lblEstado.Text = "No se pudo convertir la fecha en el tipo DateTime ";
            }
        }
    }
}
