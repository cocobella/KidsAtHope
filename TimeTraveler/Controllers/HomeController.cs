﻿using System.Web.Mvc;
using TimeTraveler.Models;

namespace TimeTraveler.Controllers
{

    
	public class HomeController : Controller
	{
        
        public TimeTravelerDetail TheTraveler { get; set; }

        public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";
            
			return View();
		}

		public ActionResult HomeAndFamily()
		{
			return View();	
		}

        public ActionResult Interests()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }


	}
}