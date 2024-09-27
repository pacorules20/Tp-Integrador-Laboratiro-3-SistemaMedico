<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarUsuarioMedico.aspx.cs" Inherits="Vistas.RegistrarUsuarioMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:     #0051ff    ;">
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="label1" runat="server" Font-Overline="False" Font-Size="25pt" Font-Underline="False" Text="RegistrarUsuario Medico" ValidateRequestMode="Disabled" ViewStateMode="Disabled" ForeColor="White" Font-Bold="True" Font-Names="Arial"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="LBL_nombreUsuario" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="Large" ForeColor="White"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
        </div>
        <p>
            <asp:Label ID="Label3" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Legajo:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtLegajo" runat="server" ValidationGroup="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtLegajo" ErrorMessage="Ingrese un Legajo" ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtLegajo" ErrorMessage="El campo Legajo solo acepta numeros" ForeColor="Red" ValidationExpression="^[0-9]+$" ValidationGroup="1">*</asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;
            </p>
        <p>
            <asp:Label ID="Label5" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Nombre de Usuario:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtUsuario" runat="server" ValidationGroup="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtUsuario" ErrorMessage="Ingrese un Nombre de Usuario" ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TxtUsuario" ErrorMessage="Apellido muy corto o caracteres numericos presentes." ForeColor="Red" ValidationExpression="[a-zA-Z ]{2,254}" ValidationGroup="1">*</asp:RegularExpressionValidator>
&nbsp;</p>
        <p>
            <asp:Label ID="LblDNI" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Contraseña:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtContraseña" runat="server" Height="22px" MaxLength="8" ValidationGroup="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtContraseña" ErrorMessage="Ingrese Contraseña" ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;</p>
        <p>
            <asp:Label ID="LblDNI0" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Repetir Contraseña:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtContraseñaConfirmar" runat="server" Height="22px" MaxLength="8" ValidationGroup="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtContraseñaConfirmar" ErrorMessage="Ingrese Confirmacion de Contraseña" ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TxtContraseña" ControlToValidate="TxtContraseñaConfirmar" ErrorMessage="Las contraseñas no coinciden." ForeColor="Red" ValidationGroup="1">*</asp:CompareValidator>
            &nbsp;&nbsp;&nbsp;</p>

            <asp:GridView ID="GrdMedicos" runat="server" AllowPaging="True" OnPageIndexChanging="GrdMedicos_PageIndexChanging" PageSize="5">
            </asp:GridView>

        <p>
        <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" Font-Size="Large" OnClick="BtnAgregar_Click" ValidationGroup="1" />
    &nbsp;&nbsp;
            <asp:HyperLink ID="HPL_agregarMedico" runat="server" NavigateUrl="~/MenuAdministracion.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">Volver al Menu</asp:HyperLink>
        </p>
        <asp:Label ID="lblerror" runat="server"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="1" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
