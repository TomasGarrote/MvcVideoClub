using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Videoclub.Models;

namespace Videoclub.Controllers
{
    public class PeliculasController
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        string cookieName = "peliculas";

        public List<Pelicula> Get()
        {
            HttpCookie c = HttpContext.Current.Request.Cookies[cookieName];
            if (c == null) return new List<Pelicula>();

            return js.Deserialize<List<Pelicula>>(c.Value);
        }

        public void Save(List<Pelicula> lista)
        {
            HttpCookie c = new HttpCookie(cookieName);
            c.Value = js.Serialize(lista);
            c.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(c);
        }

        public void Add(Pelicula p)
        {
            var lista = Get();
            p.Id = lista.Count + 1;
            lista.Add(p);
            Save(lista);
        }

        public void Update(Pelicula p)
        {
            var lista = Get();
            var item = lista.FirstOrDefault(x => x.Id == p.Id);

            if (item != null)
            {
                item.Titulo = p.Titulo;
                item.Genero = p.Genero;
                item.Precio = p.Precio;
                item.Fecha = p.Fecha;
            }

            Save(lista);
        }

        public void Delete(int id)
        {
            var lista = Get();
            lista.RemoveAll(x => x.Id == id);
            Save(lista);
        }

        public Pelicula GetById(int id)
        {
            return Get().FirstOrDefault(x => x.Id == id);
        }
    }
}