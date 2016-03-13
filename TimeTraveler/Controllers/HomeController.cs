using System.Web.Mvc;
using TimeTraveler.Models;

namespace TimeTraveler.Controllers
{

    
	public class HomeController : Controller
	{
        
        public TimeTravelerDetail TheTraveler { get; set; }

        public ActionResult Index()
		{
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();
            SessionBag.Current.TheTraveler = this.TheTraveler;

			return View();
		}

        [HttpPost]
        public ActionResult Index(string theName, string grade)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();
            this.TheTraveler.Name = theName;

            int g = 0;
            int.TryParse(grade, out g);
            this.TheTraveler.Grade = g;

            SessionBag.Current.TheTraveler = this.TheTraveler;

            return RedirectToAction("Interests");
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
        
        [HttpPost]
        public ActionResult Interests(string[] interest)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;

            foreach(string s in interest)
            {
                this.TheTraveler.Likes.Add(s);
            }

            SessionBag.Current.TheTraveler = this.TheTraveler;

            return RedirectToAction("HomeAndFamily");
        }

        public ActionResult Welcome()
        {
            return View();
        }


	}
}