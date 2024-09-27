<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarMedico.aspx.cs" Inherits="Vistas.ModificarMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <div style="background-color:     #0051ff    ;">
                    <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="label1" runat="server" Font-Overline="False" Font-Size="25pt" Font-Underline="False" Text="Modificar Medico" ValidateRequestMode="Disabled" ViewStateMode="Disabled" ForeColor="White" Font-Bold="True" Font-Italic="False" Font-Names="Arial"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LBL_nombreUsuario" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="White"></asp:Label>
            <br />

            <br />
        </div>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GRDModificarMedico" runat="server" AutoGenerateEditButton="True" OnRowCancelingEdit="GRDModificarMedico_RowCancelingEdit" OnRowEditing="GRDModificarMedico_RowEditing" OnRowUpdating="GRDModificarMedico_RowUpdating" AutoGenerateColumns="False" Width="237px" AllowPaging="True" OnPageIndexChanging="GRDModificarMedico_PageIndexChanging" PageSize="5">
                <Columns>
                    <asp:TemplateField HeaderText="Legajo">
                        <EditItemTemplate>
                            <asp:Label ID="lblEditarLegajo" runat="server" Text='<%# Bind("Legajo") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_Legajomedico" runat="server" Text='<%# Bind("Legajo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <EditItemTemplate>
                            <asp:TextBox ID="textNombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LblNombreMedico" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Apellido">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtApellido" runat="server" Text='<%# Bind("Apellido") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LblApellidoMedico" runat="server" Text='<%# Bind("Apellido") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dni">
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtmodificarDni" runat="server" Text='<%# Bind("Dni") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Lbl_dniMedico" runat="server" Text='<%# Bind("Dni") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Sexo">
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtSexomedico" runat="server" Text='<%# Bind("Sexo") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblSexualidadMedica" runat="server" Text='<%# Bind("Sexo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nacionalidad">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNacionalidadmedica" runat="server" Text='<%# Bind("Nacionalidad") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LblNacionalidadMedica" runat="server" Text='<%# Bind("Nacionalidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha de Nacimiento">
                        <EditItemTemplate>
                            <asp:TextBox ID="textFechaNacimiento" runat="server" Text='<%# Bind("[Fecha de Nacimiento]", "{0:yyyy-MM-dd}") %>' TextMode="Date"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblFechaNacimentoMedico" runat="server" Text='<%# Bind("[Fecha de Nacimiento]", "{0:yyyy-MM-dd}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Direccion">
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtDireccionmedica" runat="server" Text='<%# Bind("Direccion") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDireccionmedico" runat="server" Text='<%# Bind("Direccion") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Localidad">
                        <EditItemTemplate>
                            <asp:Label ID="lblModificallocalidad" runat="server" Text='<%# Bind("Localidad") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblIdLocalidadMedico" runat="server" Text='<%# Bind("Localidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Provincia">
                        <EditItemTemplate>
                            <asp:Label ID="LblModificarProvincia" runat="server" Text='<%# Bind("Provincia") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblIdProvinciamedico" runat="server" Text='<%# Bind("Provincia") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Correo Electronico">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCorreoMedico" runat="server" Text='<%# Bind("[Correo Electronico]") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblCorreomedico" runat="server" Text='<%# Bind("[Correo Electronico]") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Telefono">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTelefonoMedico" runat="server" Text='<%# Bind("Telefono") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LblTelefonoMedico" runat="server" Text='<%# Bind("Telefono") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Especialidad">
                        <EditItemTemplate>
                            <asp:Label ID="LblModfEspecialidad" runat="server" Text='<%# Bind("Especialidad") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblEspecialidadmedica" runat="server" Text='<%# Bind("Especialidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dias y Horarios">
                        <EditItemTemplate>
                            <asp:Label ID="lblDiasYhorarios" runat="server" Text='<%# Bind("[Dias y Horarios]") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDiasyHorarios" runat="server" Text='<%# Bind("[Dias y Horarios]") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <asp:Label ID="lblLegajoMedico" runat="server" Text="Label"></asp:Label>
                </EmptyDataTemplate>
            </asp:GridView>
            <asp:Label ID="LBL_Adver" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <asp:HyperLink ID="HPL_agregarMedico" runat="server" NavigateUrl="~/MenuAdministracion.aspx" Font-Overline="False" Font-Size="X-Large" BackColor="#0D40AC" BorderColor="Black" Font-Bold="True" Font-Names="Arial" ForeColor="White">Volver al Menu</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
