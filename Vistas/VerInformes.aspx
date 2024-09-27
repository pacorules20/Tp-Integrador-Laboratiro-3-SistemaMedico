<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerInformes.aspx.cs" Inherits="Vistas.WebForm10" %>

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
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #0051ff ;">
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblInformes" runat="server" Text="Informes" Font-Bold="True" Font-Names="Arial" Font-Size="Larger" ForeColor="White"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label class="ml-4" ID="LBL_nombreUsuario" runat="server" Font-Names="Arial" Font-Size="Medium" ForeColor="White"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <p>

            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Seleccione los meses: "></asp:Label>
&nbsp;</p>
        <p>

            <asp:Label ID="Label3" runat="server" Text="desde: "></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="FechaBusquedaDesde" runat="server" TextMode="Date"></asp:TextBox>

        </p>
        <p>

            <asp:Label ID="Label2" runat="server" Text="hasta: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="FechaBusquedaHasta" runat="server" TextMode="Date"></asp:TextBox>

        </p>
        <p>

        &nbsp;<asp:Button ID="Btn_BuscarInformes" runat="server" Text="Buscar" OnClick="Btn_BuscarInformes_Click" />

        &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Btn_borrarFiltro" runat="server" Text="Borrar filtro" OnClick="Btn_borrarFiltro_Click" />

        </p>
        <p>

            <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Total: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Presentes: "></asp:Label>
            <asp:Label ID="Lbl_Total_Presentes" runat="server" Font-Bold="True" ForeColor="Lime"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Ausentes: "></asp:Label>
            <asp:Label ID="Lbl_Total_Ausentes" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>

        </p>

            <asp:GridView ID="GRD_infome1" runat="server" AutoGenerateColumns="False" Width="935px" CssClass="auto-style1">
                <Columns>
                    <asp:TemplateField HeaderText="ID Turnos">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_IdTurno" runat="server" Text='<%# Bind("Id_Turnos_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dias y Horarios">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_DiasyHorarios" runat="server" Text='<%# Bind("Dias_y_Horarios_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha Turno">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_FechaTurno" runat="server" Text='<%# Bind("Fecha_TU", "{0:yyyy-MM-dd}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Legajo Paciente">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_LegajoPaciente" runat="server" Text='<%# Bind("Legajo_Pac_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Observacion">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_Observacion" runat="server" Text='<%# Bind("Observacion_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Asistencia">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_Asistencia" runat="server" Text='<%# Bind("Asistencia_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <p style="margin-left: 40px">

                <asp:Label ID="LBL_Mensaje" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>

        </p>
        <p style="margin-left: 40px">

                &nbsp;</p>
        <p style="margin-left: 40px">

                <asp:HyperLink ID="HyperLink1" runat="server">Mostrar </asp:HyperLink>

        </p>
        <p style="margin-left: 40px">

            <asp:HyperLink ID="HPL_agregarMedico" runat="server" NavigateUrl="~/MenuAdministracion.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">Volver al Menu</asp:HyperLink>

        </p>
    </form>
</body>
</html>
