<%@ Page Language="C#" AutoEventWireup="true"
CodeFile="Index.aspx.cs"
Inherits="Videoclub.Index" %>

<form runat="server">

<h2>Películas</h2>

<a href="Create.aspx">Nueva Pelicula</a>

<asp:GridView ID="gv" runat="server"
AutoGenerateColumns="false"
DataKeyNames="Id"
OnRowCommand="gv_RowCommand">

<Columns>
    <asp:BoundField DataField="Id" HeaderText="ID" />
    <asp:BoundField DataField="Titulo" HeaderText="Título" />
    <asp:BoundField DataField="Genero" HeaderText="Género" />
    <asp:BoundField DataField="Precio" HeaderText="Precio" />
    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />

    <asp:ButtonField Text="Ver" CommandName="ver" />

    <asp:ButtonField Text="Editar" CommandName="edit" />
    <asp:ButtonField Text="Borrar" CommandName="del" />
</Columns>

</asp:GridView><br />

    <asp:Button ID="btnReset" runat="server"
Text="Borrar todo"
OnClick="btnReset_Click" />

</form>