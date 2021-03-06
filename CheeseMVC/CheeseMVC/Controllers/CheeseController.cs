﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        //originally this was set up as a list, but it's been changed to a dictionary
        //static private List<string> Cheeses = new List<string>();

        //Cheeses is now a dictionary with key/value corresponding to name/description
        //no longer using a dictionary. instead, refer to list of objects.
        //static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        //Added using CheeseMVC.Models at top so I can access the Cheese datatype/class
        //Created new empty list of Cheese objects. Don't forget () at end.
        //Need keyword 'static' for persistence.
        static List<Cheese> myListOfCheeses = new List<Cheese>();

        // GET: /<controller>/
        public IActionResult Index()
        {

            // Cheeses refers to the list called Cheeses above
            ViewBag.cheeses = myListOfCheeses;
            //Cheeses now refers to the dictionary called Cheeses above
            return View();
        }

        // this displays a form that lets user add new cheese
        //form in in Views under Add, an MVC view page

        public IActionResult Add()
        {
            return View();
        }

        // this receives the input from the add cheese form. parameters are, description name of the cheese.
        //This form lives at /cheese/add
        [HttpPost]
        [Route("Cheese/Add")]
        //Originally this was just name, but added description because it's now a dictionary rather than a list
        public IActionResult NewCheese(string name, string description)
        {
            // add new cheese to my existing cheeses
            //next line looks up the Cheeses dictionary above and adds a new cheese name, description to that dictionary
            myListOfCheeses.Add(new Cheese(name, description) );
            //redirect to index so it displays the whole list of cheese
            return Redirect("/Cheese");
        }

    }
}
