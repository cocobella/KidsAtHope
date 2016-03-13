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

        public ActionResult CareerResult()
        {
            return View();
        }

        public ActionResult CareerType()
        {
            return View();
        }

        public ActionResult CommunityAndServiceType()
        {
            return View();
        }

        public ActionResult CommunityAndServiceTypeResult()
        {
            return View();
        }

        public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";
            
			return View();
		}

        public ActionResult EducationAndCareer()
        {
            return View();
        }

        public ActionResult EducationResult()
        {
            return View();
        }

        public ActionResult EducationType()
        {
            return View();
        }

        public ActionResult HobbiesAndRecreation()
        {
            return View();
        }

        public ActionResult HobbiesAndRecreationResult()
        {
            return View();
        }

        public ActionResult HomeAndFamily()
		{
			return View();	
		}

        [HttpPost]
        public ActionResult HomeAndFamily(string whereLive)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;

            // TODO: Using place holders for the time being
            switch(whereLive)
            {
                case "1":
                    this.TheTraveler.FutureHome = FutureHomeOption.DowntownCity;
                    break;
                case "2":
                    this.TheTraveler.FutureHome = FutureHomeOption.Mountains;
                    break;
                case "3":
                    this.TheTraveler.FutureHome = FutureHomeOption.Ocean;
                    break;
                case "4":
                    this.TheTraveler.FutureHome = FutureHomeOption.Ranch;
                    break;
                case "5":
                    this.TheTraveler.FutureHome = FutureHomeOption.Snowland;
                    break;
                case "6":
                    this.TheTraveler.FutureHome = FutureHomeOption.Suburb;
                    break;

            }

            SessionBag.Current.TheTraveler = this.TheTraveler;

            return RedirectToAction("HomeResult");
        }

        public ActionResult HomeAndFamilyType()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HomeAndFamilyType(string familyType)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;

            // TODO: Using place holders for the time being
            switch (familyType)
            {
                case "1":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.Dad;
                    break;
                case "2":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.Married;
                    break;
                case "3":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.Mother;
                    break;
                case "4":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.Multi_generational;
                    break;
                case "5":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.SingleMale;
                    break;
                case "6":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.SingleWoman;
                    break;
            }

            SessionBag.Current.TheTraveler = this.TheTraveler;

            // TODO: Make sure to redirect to the proper page
            return RedirectToAction("");
        }

        public ActionResult HomeAndFamilyTypeResult()
        {
            return View();
        }

        public ActionResult HomeResult()
        {
            return View();
        }

        public ActionResult HowWasYourVisit()
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

        public ActionResult Pledge()
        {
            return View();
        }

        public ActionResult TimeTravelersLog()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }


	}
}