<%@ Page Title="" Language="C#" MasterPageFile="~/pagAdministrador/administradorMP.Master" AutoEventWireup="true" CodeBehind="PerfilAdministrador.aspx.cs" Inherits="Sistema_Universitario.pagAdministrador.PerfilAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContemAdministrador" runat="server">

    <p>
    Dni
    <asp:TextBox ID="txtDni" runat="server" ReadOnly="True"></asp:TextBox>
</p>
<p>
    Nombre
    <asp:TextBox ID="txtNombre" runat="server"  ReadOnly="True"></asp:TextBox>
</p>
<p>
    Apellidos
    <asp:TextBox ID="txtApellidos" runat="server" ReadOnly="True"></asp:TextBox>
</p>
<p>
    E-mail
    <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True"></asp:TextBox>
</p>
<p>
    Telefono
    <asp:TextBox ID="txtTelefono" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;</p>
<p>
    Sexo&nbsp;
    <asp:TextBox ID="txtSexo" runat="server" ReadOnly="True"></asp:TextBox>
</p>
<p>
    Direccion
    <asp:TextBox ID="txtDireccion" runat="server" ReadOnly="True"></asp:TextBox>
</p>
<p>
    Estado Civil
    <asp:TextBox ID="txtEstadocivil" runat="server" ReadOnly="True"></asp:TextBox>
</p>
<p>
    Fecha de nacimiento
    <asp:TextBox ID="txtFechaDeNacimineto" runat="server" ReadOnly="True"></asp:TextBox>
</p>

</asp:Content>
