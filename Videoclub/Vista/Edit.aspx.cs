using System;
using Videoclub.Controllers;
using Videoclub.Models;

namespace Videoclub
{
    public partial class Edit : System.Web.UI.Page
    {
        PeliculasController c = new PeliculasController();
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                var p = c.GetById(id);

                txtTitulo.Text = p.Titulo;
                txtGenero.Text = p.Genero;
                txtPrecio.Text = p.Precio.ToString();
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Pelicula p = new Pelicula
            {
                Id = id,
                Titulo = txtTitulo.Text,
                Genero = txtGenero.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text)
            };

            c.Update(p);

            Response.Redirect("Index.aspx");
        }
    }
}