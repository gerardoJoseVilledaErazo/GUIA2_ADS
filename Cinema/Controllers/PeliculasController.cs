using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas/Aleatorias
        public ActionResult Aleatorias()
        {
            Pelicula pelicula1 = new Pelicula() {Id = 1, Nombre = "Shrek", Genero = "Animacion, Aventura, Comedia", AnioLanzamiento = "2001", Clasificacion = "PG" };

            //pelicula.nombre = "Shrek"; Otra forma en que se puede añadir

            return View(pelicula1);
        }
    }
}