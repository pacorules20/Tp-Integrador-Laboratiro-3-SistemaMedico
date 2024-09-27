<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarPaciente.aspx.cs" Inherits="Vistas.AgregarPaciente" %>

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
            <asp:Label ID="label1" runat="server" Font-Overline="False" Font-Size="25pt" Font-Underline="False" Text="Agregar Paciente" ValidateRequestMode="Disabled" ViewStateMode="Disabled" ForeColor="White" Font-Bold="True" Font-Names="Arial"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="LBL_nombreUsuario" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="Large" ForeColor="White"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
        </div>
        <p>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Nombre:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtNombre" ErrorMessage="Ingrese un Nombre" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtNombre" ErrorMessage="Solo se permiten letras en Nombre" ForeColor="Red" ValidationExpression="[a-zA-Z ]{2,254}">*</asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Apellido:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtApellido" ErrorMessage="Ingrese un Apellido" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TxtApellido" ErrorMessage="Solo se permiten letras en Apellido" ForeColor="Red" ValidationExpression="[a-zA-Z ]{2,254}">*</asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Mail:"></asp:Label>
            <asp:TextBox ID="TxtMail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtMail" ErrorMessage="Ingrese un Mail" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TxtMail" ErrorMessage="Ingrese un Mail valido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="LblDNI" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="DNI:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtDNI" runat="server" MaxLength="8"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtDNI" ErrorMessage="Ingrese un DNI" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TxtDNI" ErrorMessage="Solo se permiten numeros en DNI" ForeColor="Red" ValidationExpression="^\d+$">*</asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblTelefono" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Telefono:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtTelefono" runat="server" TextMode="Phone"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtTelefono" ErrorMessage="Ingrese un Telefono" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TxtTelefono" ErrorMessage="Solo se permiten numeros en Telefono" ForeColor="Red" ValidationExpression="\d{0,99}-{0,99}\d{0,99}-{0,99}\d{0,99}-{0,99}\d{0,99}-{0,99}\d{0,99}-{0,99}\d{0,99}-{0,99}\d{0,99}">*</asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="txtSexo" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Genero:"></asp:Label>
            &nbsp;<asp:RadioButtonList ID="CBLGenero" runat="server">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Femenino</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="CBLGenero" ErrorMessage="Seleccione una opcion" ForeColor="Red">*</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="LblNacimiento" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Fecha de Nacimiento:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtNacimiento" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TxtNacimiento" ErrorMessage="Ingrese una Fecha" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblNacionalidad" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Nacionalidad:"></asp:Label>
            &nbsp;<asp:DropDownList ID="DDLNacionalidad" runat="server" Height="21px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="DDLNacionalidad" ErrorMessage="Seleccione una Nacionalidad" ForeColor="Red" InitialValue="--SELECCIONA NACIONALIDAD--">*</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="LblProvincia" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Provincia:"></asp:Label>
            &nbsp;<asp:DropDownList ID="DDLProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLProvincia_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DDLProvincia" ErrorMessage="Seleccione una Provincia" ForeColor="Red" InitialValue="--SELECCIONA PROVINCIA--">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblLocalidad" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Localidad:"></asp:Label>
            &nbsp;<asp:DropDownList ID="DDLlocalidad" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="DDLlocalidad" ErrorMessage="Seleccione una Localidad" ForeColor="Red" InitialValue="--SELECCIONA LOCALIDAD--">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblDireccion" runat="server" BackColor="#999999" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="White" Text="Direccion:"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TxtDireccion" ErrorMessage="Ingrese una Direccion" ForeColor="Red">*</asp:RequiredFieldValidator>
        </p>
        <p>
            &nbsp;</p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        <asp:Button ID="BtnAgregar" runat="server" Font-Size="Large" OnClick="BtnAgregar_Click" Text="Agregar" />
        &nbsp;&nbsp;
        <asp:HyperLink ID="HPL_agregarMedico" runat="server" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" Font-Overline="False" Font-Size="X-Large" ForeColor="White" NavigateUrl="~/MenuAdministracion.aspx">Volver al Menu</asp:HyperLink>
        <p>

            <asp:Label ID="lblerror" runat="server"></asp:Label>

        </p>
    </form>
</body>
</html>
