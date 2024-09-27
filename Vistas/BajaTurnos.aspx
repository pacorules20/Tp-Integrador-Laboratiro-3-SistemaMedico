<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BajaTurnos.aspx.cs" Inherits="Vistas.BajaTurnos" %>

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
            <asp:Label ID="lblBajaMedicos" runat="server" Text="Baja Turnos" Font-Bold="True" Font-Names="Arial" Font-Size="25px" ForeColor="White"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Label ID="LBL_nombreUsuario" runat="server" Font-Names="Arial" Font-Size="Medium" ForeColor="White"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <p>

        </p>
        <p>

            <asp:Label ID="Label1" runat="server" Text="Id de turno a eliminar: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtEliminar" runat="server" Width="128px" ValidationGroup="2"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtEliminar" ErrorMessage="Ingrese un valor numerico." ValidationExpression="\d+" ValidationGroup="2">*</asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtEliminar" ErrorMessage="Ingrese un valor no vacio." ValidationGroup="2">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtneliminarTurnos" runat="server" Text="Eliminar" OnClick="BtneliminarTurnos_Click" ValidationGroup="2" />

        </p>
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="2" />
        <p>
  

            <asp:Button ID="BtnConfirma" runat="server" OnClick="BTN_Confirmar_Click" Text="Confirmar" Visible="False" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnCancelar" runat="server" OnClick="BtnCancelar_Click" Text="Cancelar" Visible="False" />
        </p>
     

            <asp:Label ID="lbl_Confirmar" runat="server"></asp:Label>


        <p>

            <asp:GridView ID="GrdTurnos" runat="server" AllowPaging="True" OnPageIndexChanging="GrdTurnos_PageIndexChanging" PageSize="5">
            </asp:GridView>

        </p>
        <p>

        <asp:Label ID="lblestado" runat="server"></asp:Label>

        </p>
        <p>

            <asp:HyperLink ID="HPL_agregarMedico" runat="server" NavigateUrl="~/MenuAdministracion.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">Volver al Menu</asp:HyperLink>

        </p>
    </form>
</body>
</html>