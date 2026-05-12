using System;
using Videoclub.Controllers;
using Videoclub.Models;

namespace Videoclub
{
    public partial class Create : System.Web.UI.Page
    {
        PeliculasController c = new PeliculasController();

        protected void btn_Click(object sender, EventArgs e)
        {
            Pelicula p = new Pelicula
            {
                Titulo = txtTitulo.Text,
                Genero = txtGenero.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Fecha = Convert.ToDateTime(txtFecha.Text)
            };

            c.Add(p);

            Response.Redirect("Index.aspx");
        }
    }
}