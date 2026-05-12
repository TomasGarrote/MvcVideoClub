using System;

namespace Videoclub.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
    }
}