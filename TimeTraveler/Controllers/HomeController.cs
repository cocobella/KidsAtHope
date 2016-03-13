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

        public ActionResult CareerType()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CareerType(string career, string otherText)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;

            switch(career)
            {
                case "athlete":
                    this.TheTraveler.Career = CareerOption.Athlete;
                    break;
                case "business":
                    this.TheTraveler.Career = CareerOption.Business;
                    break;
                case "designer":
                    this.TheTraveler.Career = CareerOption.Designer;
                    break;
                case "engineer":
                    this.TheTraveler.Career = CareerOption.Engineer;
                    break;
                case "medical":
                    this.TheTraveler.Career = CareerOption.Medical;
                    break;
                case "teacher":
                    this.TheTraveler.Career = CareerOption.Teacher;
                    break;
                case "other":
                    this.TheTraveler.Career = CareerOption.Other;
                    this.TheTraveler.CareerOther = otherText.Trim();
                    break; 
            }

            SessionBag.Current.TheTraveler = this.TheTraveler;

            return RedirectToAction("CareerResult");
        }

        public ActionResult CareerResult()
        {
            return View();
        }

        public ActionResult CommunityAndServiceType()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CommunityAndServiceType(string service, string otherText)
        {

            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;

            switch(service)
            {
                case "animals":
                    this.TheTraveler.Community = AidingCommunityOption.Animals;
                    break;
                case "children":
                    this.TheTraveler.Community = AidingCommunityOption.Children;
                    break;
                case "coach":
                    this.TheTraveler.Community = AidingCommunityOption.Coach;
                    break;
                case "environment":
                    this.TheTraveler.Community = AidingCommunityOption.Environment;
                    break;
                case "graffiti":
                    this.TheTraveler.Community = AidingCommunityOption.GraffitiCleanup;
                    break;
                case "homeless":
                    this.TheTraveler.Community = AidingCommunityOption.Homeless;
                    break;
                case "other":
                    this.TheTraveler.Community = AidingCommunityOption.Other;
                    this.TheTraveler.CommunityOther = otherText.Trim();
                    break;
            }

            SessionBag.Current.TheTraveler = this.TheTraveler;

            return RedirectToAction("CommunityAndServiceTypeResult");
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

        public ActionResult EducationType()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EducationType(string education)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;

            switch(education)
            {
                case "apprentice":
                    this.TheTraveler.Education = EducationOption.Apprenticeship;
                    break;
                case "career":
                    this.TheTraveler.Education = EducationOption.CareerSchool;
                    break;
                case "community":
                    this.TheTraveler.Education = EducationOption.CommunityCollege;
                    break;
                case "university":
                    this.TheTraveler.Education = EducationOption.University;
                    break;
            }

            SessionBag.Current.TheTraveler = this.TheTraveler;

            return RedirectToAction("EducationResult");
        }

        public ActionResult EducationResult()
        {
            return View();
        }

        public ActionResult HobbiesAndRecreation()
        {
            return View();
        }
        
        [HttpPost] 
        public ActionResult HobbiesAndRecreation(string hobby, string otherText)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;

            switch(hobby)
            {
                case "hiking":
                    this.TheTraveler.Hobby = HobbyOption.Hiking;
                    break;
                case "music":
                    this.TheTraveler.Hobby = HobbyOption.Music;
                    break;
                case "photo":
                    this.TheTraveler.Hobby = HobbyOption.Photography;
                    break;
                case "sport":
                    this.TheTraveler.Hobby = HobbyOption.Sport;
                    break;
                case "travel":
                    this.TheTraveler.Hobby = HobbyOption.Travel;
                    break;
                case "water":
                    this.TheTraveler.Hobby = HobbyOption.WaterSport;
                    break;
                case "other":
                    this.TheTraveler.Hobby = HobbyOption.Other;
                    this.TheTraveler.HobbyOther = otherText.Trim();
                    break;
                
            }

            SessionBag.Current.TheTraveler = this.TheTraveler;

            return RedirectToAction("HobbiesAndRecreationResult");
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

            switch (whereLive)
            {
                case "downtown":
                    this.TheTraveler.FutureHome = FutureHomeOption.DowntownCity;
                    break;
                case "mountain":
                    this.TheTraveler.FutureHome = FutureHomeOption.Mountains;
                    break;
                case "ocean":
                    this.TheTraveler.FutureHome = FutureHomeOption.Ocean;
                    break;
                case "ranch":
                    this.TheTraveler.FutureHome = FutureHomeOption.Ranch;
                    break;
                case "snow":
                    this.TheTraveler.FutureHome = FutureHomeOption.Snowland;
                    break;
                case "suburb":
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
            
            switch (familyType)
            {
                case "dad":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.Dad;
                    break;
                case "married":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.Married;
                    break;
                case "mother":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.Mother;
                    break;
                case "multi":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.Multi_generational;
                    break;
                case "man":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.SingleMale;
                    break;
                case "woman":
                    this.TheTraveler.FamilyStyle = FamilyStyleOption.SingleWoman;
                    break;
            }

            SessionBag.Current.TheTraveler = this.TheTraveler;

            // TODO: Make sure to redirect to the proper page
            return RedirectToAction("HomeAndFamilyTypeResult");
        }

        public ActionResult HomeAndFamilyTypeResult()
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