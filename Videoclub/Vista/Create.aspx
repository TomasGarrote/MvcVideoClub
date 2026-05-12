<%@ Page Language="C#" AutoEventWireup="true"
CodeFile="Create.aspx.cs"
Inherits="Videoclub.Create" %>

<form runat="server">

<h2>Crear Película</h2>

Titulo: <asp:TextBox ID="txtTitulo" runat="server" /><br />
Genero: <asp:TextBox ID="txtGenero" runat="server" /><br />
Precio: <asp:TextBox ID="txtPrecio" runat="server" /><br />
Fecha:  <asp:TextBox ID="txtFecha" runat="server" /><br />

<asp:Button ID="btn" runat="server"
Text="Guardar"
OnClick="btn_Click" />

</form>