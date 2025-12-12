using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Año { get; set; }

        public Pelicula(string titulo, string genero, int Año) 
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Año = Año;
        }
    }
}
