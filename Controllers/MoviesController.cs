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

            //return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index","Home", new { page=1, sortBy="name"});
            //RedirectToAction(Name of the action ,Controller, extra data);
        }
    }
}