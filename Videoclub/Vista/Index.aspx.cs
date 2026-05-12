using System;
using System.Web;
using Videoclub.Controllers;

namespace Videoclub
{
    public partial class Index : System.Web.UI.Page
    {
        PeliculasController c = new PeliculasController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                gv.DataSource = c.Get();
            gv.DataBind();
        }

        protected void gv_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument) + 1;


            

            if (e.CommandName == "del")
                c.Delete(id);

            if (e.CommandName == "ver")

                Response.Redirect("Detail.aspx?id=" + id);

            if (e.CommandName == "edit")
                Response.Redirect("Edit.aspx?id=" + id);

            Response.Redirect("Index.aspx");
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("peliculas");
            cookie.Value = "";
            cookie.Expires = DateTime.Now.AddDays(-1);

            Response.Cookies.Add(cookie);

            Response.Redirect("Index.aspx");
        }
    }
}