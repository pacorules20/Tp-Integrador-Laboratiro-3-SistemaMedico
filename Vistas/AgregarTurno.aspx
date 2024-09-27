<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarTurno.aspx.cs" Inherits="Vistas.AgregarTurno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
                <div style="background-color:     #0051ff    ;">
                    <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="label1" runat="server" Font-Overline="False" Font-Size="25pt" Font-Underline="False" Text="Agregar Turno" ValidateRequestMode="Disabled" ViewStateMode="Disabled" ForeColor="White" Font-Bold="True" Font-Italic="False" Font-Names="Arial"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LBL_nombreUsuario" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="White"></asp:Label>
            <br />

            <br />
        </div>
        <div class="auto-style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <asp:Label ID="Label2" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="White" Text="Legajo Paciente:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtLeg" runat="server" MaxLength="8"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtLeg" ErrorMessage="Ingrese un legajo" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TxtLeg" ErrorMessage="Solo se permiten numeros en legajo" ForeColor="Red" ValidationExpression="^\d+$">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="White" Text="Especialidad:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDL_Especialidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_Especialidad_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DDL_Especialidad" ErrorMessage="Seleccione una Especialidad" ForeColor="Red" InitialValue="--SELECCIONA ESPECIALIDAD--">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="White" Text="Medico:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDl_medico" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDl_medico_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="DDl_medico" ErrorMessage="Seleccione un Medico" ForeColor="Red" InitialValue="--SELECCIONA MEDICO--">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="White" Text="Dia"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDL_Dias" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="DDL_Dias" ErrorMessage="Seleccione un Dia" ForeColor="Red" InitialValue="--SELECCIONA DIA--">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="White" Text="Horario:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDL_Horarios" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="DDL_Horarios" ErrorMessage="Seleccione un  Horario" ForeColor="Red" InitialValue="--SELECCIONA HORA--">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="LblNacimiento" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Fecha de turno:"></asp:Label>
            &nbsp; <asp:TextBox ID="TxtFechaTurno" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            <br />
            <br />
            <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
            &nbsp;<asp:HyperLink ID="HPL_agregarMedico" runat="server" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" Font-Overline="False" Font-Size="X-Large" ForeColor="White" NavigateUrl="~/MenuAdministracion.aspx">Volver al Menu</asp:HyperLink>
            <br />
            <asp:Label ID="lblEstado" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
