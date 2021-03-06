﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModel;

namespace Vidly1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //index is a action
        //we can change it to random
        public ActionResult Random()
        {

            var movie = new Movie() { 
                Name= "3 Idiots"
            };

            List<Customer> customers = new List<Customer> {
                new Customer{ Name = "Bhavik Vashi"},
                new Customer{ Name="Raj Patel"}
            };

            var viewModel = new RandomMovieViewModel { 
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("ID is: "+id);
        }

        public ActionResult Index(int? pageIndex,string sortBy)
        {
            //if user does not provide any argument
            //we have to make pageIndex null able
            //string does not create any problem because it is refrence type

            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if(String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }

            return Content(String.Format("Page Index: {0}, Sort by: {1}",pageIndex,sortBy));
        }

       
        [Route("movies/released/{year:regex(\\d{4}):range(2015,2020)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(String.Format("Year {0}, Month: {1}",year,month));
        }
    }
} 