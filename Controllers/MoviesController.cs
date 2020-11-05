using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;

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

            return View(movie);
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

       
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(String.Format("Year {0}, Month: {1}",year,month));
        }
    }
} 