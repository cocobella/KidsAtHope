using System.Web.Mvc;

namespace TimeTraveler.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
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

        public ActionResult HomeAndFamilyType()
        {
            return View();
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