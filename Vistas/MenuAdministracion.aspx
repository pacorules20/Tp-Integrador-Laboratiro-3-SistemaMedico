<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAdministracion.aspx.cs" Inherits="Vistas.MenuAdministracion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div style="background-color:     #0051ff    ;">
            <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="label1" runat="server" Font-Overline="False" Font-Size="25pt" Font-Underline="False" Text="Menu Administrador" ValidateRequestMode="Disabled" ViewStateMode="Disabled" Font-Bold="True" ForeColor="White" Font-Names="Arial"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Label ID="LBL_nombreUsuario" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        </div>
        <br />
            <asp:HyperLink ID="HPL_agregarMedico" runat="server" NavigateUrl="~/AgregarMedico.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Agregar Medico</asp:HyperLink>
&nbsp;<br />
            <asp:HyperLink ID="HPL_agregarMedico0" runat="server" NavigateUrl="~/AgregarPaciente.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Agregar paciente</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HPL_agregarTurno" runat="server" NavigateUrl="~/AgregarTurno.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Agregar Turno</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;<br />
            <asp:HyperLink ID="HPL_agregarTurno0" runat="server" NavigateUrl="~/RegistrarUsuarioMedico.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Registrar Usuario Medico</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:HyperLink ID="HPL_BajoMedico" runat="server" NavigateUrl="~/BajaMedico.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Baja de Medico</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HPL_BajoMedico0" runat="server" NavigateUrl="~/BajaPaciente.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Baja paciente</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HPL_BajoMedico4" runat="server" NavigateUrl="~/BajaTurnos.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Baja Turnos</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HPL_BajoMedico5" runat="server" NavigateUrl="~/BajaUsuariosMedico.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Baja Usuarios Medico</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HPL_BajoMedico1" runat="server" NavigateUrl="~/ModificarMedico.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Modificar de Medico</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HPL_BajoMedico3" runat="server" NavigateUrl="~/CambiaContraseña.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Modificar Contraseña de Usuarios Medico</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HPL_BajoMedico2" runat="server" NavigateUrl="~/ModificarPaciente.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Modificar de paciente</asp:HyperLink>
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HPL_Informes" runat="server" NavigateUrl="~/VerInformes.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Informes asistencia a turnos</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HPL_Informes2" runat="server" NavigateUrl="~/VerInforme2.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">* Informes medicos</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="BTN_CerrarSession" runat="server" Font-Size="X-Large" Text="Cerrar Sesión" BackColor="#16CD56" BorderStyle="None" Font-Bold="True" Font-Names="Arial" ForeColor="White" Height="36px" Width="195px" OnClick="BTN_CerrarSession_Click" />
        </div>
    </form>
</body>
</html>
