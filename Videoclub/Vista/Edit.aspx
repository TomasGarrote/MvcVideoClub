<%@ Page Language="C#" AutoEventWireup="true"
CodeFile="Edit.aspx.cs"
Inherits="Videoclub.Edit" %>

<form runat="server">

<h2>Editar</h2>

Titulo: <asp:TextBox ID="txtTitulo" runat="server" /><br />
Genero: <asp:TextBox ID="txtGenero" runat="server" /><br />
Precio: <asp:TextBox ID="txtPrecio" runat="server" /><br />

<asp:Button ID="btn" runat="server"
Text="Guardar"
OnClick="btn_Click" />

</form>