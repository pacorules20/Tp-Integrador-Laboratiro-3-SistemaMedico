<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerTurnos.aspx.cs" Inherits="Vistas.VerTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            margin-top: 19px;
            margin-right: 0px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="background-color: #0051ff ;">
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblPrincipal" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="25px" ForeColor="White" Text="Turnos"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="LBL_nombreUsuario" runat="server" Font-Names="Arial" Font-Size="Medium" ForeColor="White"></asp:Label>
                <br />
                <br />
            </div>
            <br />
            <br />
            <asp:Label ID="Lbl_BuscarXLegajoPaciente0" runat="server" Text="Buscar por Legajo Paciente:"></asp:Label>
            <br />
            <asp:TextBox ID="Txt_BuscarporLegajo" runat="server" CssClass="auto-style2" ValidationGroup="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txt_BuscarporLegajo" ValidationGroup="1">*</asp:RequiredFieldValidator>
            <asp:Button ID="BTN_BuscarporLegajo0" runat="server" Text="Buscar" OnClick="BTN_BuscarporLegajo_Click" ValidationGroup="1" />
            &nbsp;<asp:Button ID="BTN_BorrarFiltro3" runat="server" Text="Borrar filtro" OnClick="BTN_BorrarFiltro2_Click" />
            <br />
            <br />
            <asp:Label ID="Lbl_BuscarXLegajoPaciente" runat="server" Text="Buscar por id Paciente"></asp:Label>
            <br />
            <asp:TextBox ID="Txt_Buscarporid" runat="server" CssClass="auto-style2" ValidationGroup="2"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_Buscarporid" ValidationGroup="2">*</asp:RequiredFieldValidator>
&nbsp;<asp:Button ID="BTN_BuscarporPaciente" runat="server" Text="Buscar" OnClick="BTN_BuscarporPaciente_Click" ValidationGroup="2" />
            &nbsp;<asp:Button ID="BTN_BorrarFiltro2" runat="server" Text="Borrar filtro" OnClick="BTN_BorrarFiltro2_Click" />
            <br />
            <br />
            <asp:Label ID="LblDni0" runat="server" Text="Buscar por Dia:"></asp:Label>
            <br />
            <asp:DropDownList ID="DDL_BuscarXDia" runat="server" ValidationGroup="3">
                <asp:ListItem>Seleccione un Dia</asp:ListItem>
                <asp:ListItem>Lunes</asp:ListItem>
                <asp:ListItem>Martes</asp:ListItem>
                <asp:ListItem>Miercoles</asp:ListItem>
                <asp:ListItem>Jueves</asp:ListItem>
                <asp:ListItem>Viernes</asp:ListItem>
                <asp:ListItem>Sabado</asp:ListItem>
                <asp:ListItem>Domingo</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DDL_BuscarXDia" InitialValue="Seleccione un Dia" ValidationGroup="3">*</asp:RequiredFieldValidator>
&nbsp;<asp:Button ID="BTN_BuscarXDia" runat="server" Text="Buscar" OnClick="BTN_BuscarXDia_Click" ValidationGroup="3" />
            &nbsp;<asp:Button ID="BTN_BorrarFiltro1" runat="server" Text="Borrar filtro" OnClick="BTN_BorrarFiltro1_Click" />
            <br />
            <br />
            <asp:Label ID="Txt_BuscarXHorario" runat="server" Text="Buscar por Horario:"></asp:Label>
            <br />
            <asp:DropDownList ID="DDL_BuscarXHorario" runat="server" ValidationGroup="4">
                <asp:ListItem>Seleccione un Horario</asp:ListItem>
                <asp:ListItem>6:00 - 7:00</asp:ListItem>
                <asp:ListItem>8:00 - 9:00</asp:ListItem>
                <asp:ListItem>7:00 - 8:00</asp:ListItem>
                <asp:ListItem>10:00 - 11:00</asp:ListItem>
                <asp:ListItem>9:00 - 10:00</asp:ListItem>
                <asp:ListItem>12:00 - 13:00</asp:ListItem>
                <asp:ListItem>11:00 - 12:00</asp:ListItem>
                <asp:ListItem>14:00 - 15:00</asp:ListItem>
                <asp:ListItem>13:00 - 14:00 </asp:ListItem>
                <asp:ListItem>16:00 - 17:00</asp:ListItem>
                <asp:ListItem>17:00 - 18:00</asp:ListItem>
                <asp:ListItem>18:00 - 19:00</asp:ListItem>
                <asp:ListItem>19:00 - 20:00</asp:ListItem>
                <asp:ListItem>21:00 - 22:00</asp:ListItem>
                <asp:ListItem>20:00 - 21:00</asp:ListItem>
            </asp:DropDownList>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DDL_BuscarXHorario" InitialValue="Seleccione un Horario" ValidationGroup="4">*</asp:RequiredFieldValidator>
&nbsp;<asp:Button ID="Btn_BuscarXhorario" runat="server" Text="Buscar" OnClick="Btn_BuscarXhorario_Click" ValidationGroup="4" />
            &nbsp;<asp:Button ID="BTN_BorrarFiltro" runat="server" Text="Borrar filtro" OnClick="BTN_BorrarFiltro_Click" />
            <br />
            <br />
            <asp:Label ID="Lbl_BuscarXFecha" runat="server" Text="Buscar por Fecha:"></asp:Label>
            <br />

            <asp:TextBox ID="Txt_FechaBusqueda" runat="server" TextMode="Date" ValidationGroup="5"></asp:TextBox>

            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Txt_FechaBusqueda" ValidationGroup="5">*</asp:RequiredFieldValidator>
&nbsp;<asp:Button ID="Btn_BuscarXFecha" runat="server" Text="Buscar" OnClick="Btn_BuscarXFecha_Click" ValidationGroup="5" />

            &nbsp;<asp:Button ID="BTN_BorrarFiltro0" runat="server" Text="Borrar filtro" OnClick="BTN_BorrarFiltro0_Click" />

            <asp:GridView ID="GRDTurnos" runat="server" AutoGenerateEditButton="True" OnRowCancelingEdit="GRDTurnos_RowCancelingEdit" OnRowEditing="GRDTurnos_RowEditing" OnRowUpdating="GRDTurnos_RowUpdating" AutoGenerateColumns="False" Width="935px" CssClass="auto-style1" AllowPaging="True" PageSize="5">
                <Columns>
                    <asp:TemplateField HeaderText="ID Turnos">
                        <EditItemTemplate>
                            <asp:Label ID="lblEditarLegajo" runat="server" Text='<%# Bind("Id_Turnos_TU") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Lbl_IdTurno" runat="server" Text='<%# Bind("Id_Turnos_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dias y Horarios">
                        <EditItemTemplate>
                            <asp:Label ID="Txt_DiasyHorarios" runat="server" Text='<%# Bind("Dias_y_Horarios_TU") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Lbl_DiasyHorarios" runat="server" Text='<%# Bind("Dias_y_Horarios_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha Turno">
                        <EditItemTemplate>
                            <asp:Label ID="Txt_FechaTurno" runat="server" Text='<%# Bind("Fecha_TU", "{0:yyyy-MM-dd}") %>' TextMode="Date"></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Lbl_FechaTurno" runat="server" Text='<%# Bind("Fecha_TU", "{0:yyyy-MM-dd}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Legajo Paciente">
                        <EditItemTemplate>
                            <asp:Label ID="Txt_LegajoPaciente" runat="server" Text='<%# Bind("Legajo_Pac_TU") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Lbl_LegajoPaciente" runat="server" Text='<%# Bind("Legajo_Pac_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Observacion">
                        <EditItemTemplate>
                            <asp:TextBox ID="Txt_Observacion" runat="server" Text='<%# Bind("Observacion_TU") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Lbl_Observacion" runat="server" Text='<%# Bind("Observacion_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Asistencia">
                        <EditItemTemplate>
                            <asp:TextBox ID="Txt_Asistencia" runat="server" Text='<%# Bind("Asistencia_TU") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Lbl_Asistencia" runat="server" Text='<%# Bind("Asistencia_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />

            <asp:Label ID="lblEstado" runat="server"></asp:Label>
            <br />

            <br />
            <asp:HyperLink ID="HPL_agregarMedico" runat="server" NavigateUrl="~/MenuMedico.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">Volver al Menu</asp:HyperLink>

        </div>
    </form>
</body>
</html>
