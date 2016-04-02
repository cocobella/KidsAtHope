﻿using System.Web.Mvc;
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
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }

        [HttpPost]
        public ActionResult CareerType(string selection, string otherText="") {        
#if DEBUG
            if (selection == null) throw new System.Exception("Argument is NULL");
#endif 

            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            switch (selection)
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

            //return RedirectToAction("CommunityAndServiceType");
            return Json(new { result = "Redirect", url = Url.Action("CommunityAndServiceType", "Home") });
        }

        public ActionResult CommunityAndServiceType()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }

        [HttpPost]
        public ActionResult CommunityAndServiceType(string selection, string otherText="")  {

#if DEBUG
            if (selection == null) throw new System.Exception("Argument is NULL");
#endif 

            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            switch (selection)
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

            //return RedirectToAction("HobbiesAndRecreationType");
            return Json(new { result = "Redirect", url = Url.Action("HobbiesAndRecreationType", "Home") });
        }

        public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";
            
			return View();
		}

        public ActionResult EducationAndCareer()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            return View(this.TheTraveler);
        }

        public ActionResult EducationType()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }

        [HttpPost]
        public ActionResult EducationType(string education)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            switch (education)
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

            //return RedirectToAction("CareerType");
            return Json(new { result = "Redirect", url = Url.Action("CareerType", "Home") });
        }

        public ActionResult HobbiesAndRecreationType()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }
        
        [HttpPost] 
        public ActionResult HobbiesAndRecreationType(string selection, string otherText="")
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            switch (selection)
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

            //return RedirectToAction("TimeTravelersLog");
            return Json(new { result = "Redirect", url = Url.Action("TimeTravelersLog", "Home") });
        }
        
        public ActionResult HomeType()
		{
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }

        [HttpPost]
        public ActionResult HomeType(string whereLive)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

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

            //return RedirectToAction("FamilyType");
            return Json(new { result = "Redirect", url = Url.Action("FamilyType", "Home") });
        }

        public ActionResult FamilyType()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }

        [HttpPost]
        public ActionResult FamilyType(string familyType)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

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

            //return RedirectToAction("EducationAndCareer");
            return Json(new { result = "Redirect", url = Url.Action("EducationAndCareer", "Home") });
        }

        public ActionResult HowWasYourVisit()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }

        public ActionResult Interests()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }
        
        [HttpPost]
        public ActionResult Interests(string[] interest)
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();
            if (this.TheTraveler.Likes == null) this.TheTraveler.Likes = new System.Collections.Generic.List<string>();

            foreach (string s in interest)
            {
                this.TheTraveler.Likes.Add(s);
            }

            SessionBag.Current.TheTraveler = this.TheTraveler;

            //return RedirectToAction("Welcome");
            return Json(new { result = "Redirect", url = Url.Action("Welcome", "Home") });
        }

        public ActionResult Pledge()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }

        public ActionResult TimeTravelersLog()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }

        public ActionResult TimeTravelersLogPrint()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }

        public ActionResult Welcome()
        {
            this.TheTraveler = SessionBag.Current.TheTraveler as TimeTravelerDetail;
            if (this.TheTraveler == null) this.TheTraveler = new TimeTravelerDetail();

            return View(this.TheTraveler);
        }


    }
}