﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EKapp.Models;

namespace EKapp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shawshank Redumption!",
                Id = 17,
                AuthorName = "Tom",
                Actress = "Jerry",
                Budget = 10541545,
                Earning = 500000000,
            };

            //ViewData["Movie"] = movie;
            return View(movie);
            //return Content("Hi MSK");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });


        }
       

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //Attributewise route
        //[Route("movies/released/{year}/{month:regex(\\d{2}):rang(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            if (month > 12)
            {
                return Content("Error");
            }
            
            return Content(year + "/" + month + "<br> The year and month of the publishing movie");
        }
    }
}