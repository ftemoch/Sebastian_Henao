﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clase12.Models;

namespace Clase12.Controllers
{
	public class MoviesController : Controller
	{
		private ApplicationDbContext _context;

		public MoviesController()
		{
			_context = new ApplicationDbContext();
		}
		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		// GET: Movie
		public ViewResult ListaMovies()
		{
			//var movies = GetMovies();
			var Movies = _context.Movies.ToList();
			return View(Movies);

		}
		public ActionResult Details(int id)
		{
			//var movies = GetMovies().SingleOrDefault(c => c.ID == id);
			var movies = _context.Movies.SingleOrDefault(c => c.ID == id);
			if (movies == null)
				return HttpNotFound();
			return View(movies);
		}
		private IEnumerable<Movie> GetMovies()
		{
			return new List<Movie>
			{
				//new Movie {ID=1, Nombre= "Detras del ultimo no hay nadie"},
				//new Movie {ID=2, Nombre= "Mano peluda"}
			};
		}

	}
}