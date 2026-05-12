using System;
using Videoclub.Controllers;
using Videoclub.Models;

namespace Videoclub
{
    public partial class Details : System.Web.UI.Page
    {
        PeliculasController c = new PeliculasController();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            var p = c.GetById(id);

            lbl.Text =
                "Titulo: " + p.Titulo + "<br/>" +
                "Genero: " + p.Genero + "<br/>" +
                "Precio: " + p.Precio +"<br/>" +
                "Fecha: " + p.Fecha;
            
        }
        protected void btn_Click(object sender, EventArgs e)
        {
           Response.Redirect("Index.aspx");
        }
    }
}