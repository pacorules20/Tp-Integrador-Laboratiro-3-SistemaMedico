<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerInforme2.aspx.cs" Inherits="Vistas.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #0051ff ;">
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblInformes" runat="server" Text="Informe 2" Font-Bold="True" Font-Names="Arial" Font-Size="Larger" ForeColor="White"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label class="ml-4" ID="LBL_nombreUsuario" runat="server" Font-Names="Arial" Font-Size="Medium" ForeColor="White"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <br />
        <p>

            <asp:Label ID="Label1" runat="server" Text="Seleccione una especialidad: "></asp:Label>

        &nbsp;<asp:DropDownList ID="DDLEspecialidades" runat="server" ValidationGroup="2">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DDLEspecialidades" ErrorMessage="&quot;error ingrese una  valido&quot;" InitialValue="--SELECCIONA ESPECIALIDAD--" ValidationGroup="2">*</asp:RequiredFieldValidator>
&nbsp;<asp:Button ID="Btn_BuscarInformes" runat="server" Text="Buscar" OnClick="Btn_BuscarInformes_Click" ValidationGroup="2" />

        &nbsp;<asp:Button ID="Btn_borrarFiltro" runat="server" Text="Borrar filtro" OnClick="Btn_borrarFiltro_Click" />

        </p>
        <p>

            &nbsp;
            <asp:Label ID="Label5" runat="server" Text="Medicos en esta especialidad: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Lbl_medicos_especialidad" runat="server" Font-Bold="True" ForeColor="Lime" Font-Size="Large"></asp:Label>
&nbsp;&nbsp;&nbsp;
            </p>

            <asp:GridView ID="GrdInforme2" runat="server">
            </asp:GridView>

        <asp:ValidationSummary ID="VS_informe2" runat="server" ValidationGroup="2" />
        <p>

            <asp:HyperLink ID="HPL_agregarMedico" runat="server" NavigateUrl="~/MenuAdministracion.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">Volver al Menu</asp:HyperLink>

        </p>
    </form>
</body>
</html>
