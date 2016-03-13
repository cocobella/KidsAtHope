using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTraveler.Models
{
    public class TimeTravelerDetail
    {
        private const string MAIN_SITE_URL = "http://www.thetimetravelerapp.com/video/";

        public string Name { get; set; }
        public int Grade { get; set; }

        public string GraduationYear
        {
            get
            {
                try
                {
                    // Get the difference between Senior HS and current
                    int diff = 12 - this.Grade;

                    // IF they're doing this past July then we need to add a year to account for the fact that schools wrap the "school year" 
                    if (DateTime.Now.Month >= 7) diff++;

                    return DateTime.Now.AddYears(diff).ToString("yyyy");
                }
                catch 
                {
                    return DateTime.Now.ToString("yyyy");
                }
            }
        }

        public List<string> Likes { get; set; }

        public FutureHomeOption FutureHome { get; set; }
        public string FutureHomeToText
        {
            get
            {
                switch(this.FutureHome)
                {
                    case FutureHomeOption.DowntownCity:
                        return "in the City";
                    case FutureHomeOption.Mountains:
                        return "in the mountains";
                    case FutureHomeOption.Ocean:
                        return "by the ocean";
                    case FutureHomeOption.Ranch:
                        return "on a ranch";
                    case FutureHomeOption.Snowland:
                        return "in a snowy land";
                    case FutureHomeOption.Suburb:
                        return "in the suburbs";
                    default:
                        return string.Empty;
                }
            }
        }
        public string FutureHomeVideo
        {
            get
            {
                switch(FutureHome)
                {
                    case FutureHomeOption.DowntownCity:
                        return string.Format("{0}dest1_1/downtown.mp4", MAIN_SITE_URL);
                    case FutureHomeOption.Mountains:
                        return string.Format("{0}dest1_1/mountain.mp4", MAIN_SITE_URL);
                    case FutureHomeOption.Ocean:
                        return string.Format("{0}dest1_1/ocean.mp4", MAIN_SITE_URL);
                    case FutureHomeOption.Ranch:
                        return string.Format("{0}dest1_1/ranch.mp4", MAIN_SITE_URL);
                    case FutureHomeOption.Snowland:
                        return string.Format("{0}dest1_1/snow.mp4", MAIN_SITE_URL);
                    case FutureHomeOption.Suburb:
                        return string.Format("{0}dest1_1/suburb.mp4", MAIN_SITE_URL);
                    default:
                        return string.Empty;
                }
            }
        }

        public FamilyStyleOption FamilyStyle { get; set; }
        public string FamilyStyleToText
        {
            get
            {
                switch(this.FamilyStyle)
                {
                    case FamilyStyleOption.Dad:
                        return "as a father";
                    case FamilyStyleOption.Married:
                        return "married";
                    case FamilyStyleOption.Mother:
                        return "as a mother";
                    case FamilyStyleOption.Multi_generational:
                        return "in a multi-generational family";
                    case FamilyStyleOption.SingleMale:
                        return "as a single man";
                    case FamilyStyleOption.SingleWoman:
                        return "as a single woman";
                    default:
                        return string.Empty;
                }
            }
        }
        public string FamilyStyleVideo
        {
            get
            {
                switch(this.FamilyStyle)
                {
                    case FamilyStyleOption.Dad:
                        return string.Format("{0}dest_1_2/father.mp4", MAIN_SITE_URL);
                    case FamilyStyleOption.Married:
                        return string.Format("{0}dest_1_2/married.mp4", MAIN_SITE_URL);
                    case FamilyStyleOption.Mother:
                        return string.Format("{0}dest_1_2/mother.mp4", MAIN_SITE_URL);
                    case FamilyStyleOption.Multi_generational:
                        return string.Format("{0}dest_1_2/multigenerational.mp4", MAIN_SITE_URL);
                    case FamilyStyleOption.SingleMale:
                        return string.Format("{0}dest_1_2/singlemale.mp4", MAIN_SITE_URL);
                    case FamilyStyleOption.SingleWoman:
                        return string.Format("{0}dest_1_2/singlewoman.mp4", MAIN_SITE_URL);
                    default:
                        return string.Empty;
                }
            }
        }

        public EducationOption Education { get; set; }
        public string EducationToText
        {
            get
            {
                switch (this.Education) {
                    case EducationOption.Apprenticeship:
                        return "an apprenticeship";
                    case EducationOption.CareerSchool:
                        return "Career School";
                    case EducationOption.CommunityCollege:
                        return "Community College";
                    case EducationOption.University:
                        return "Univeristy";
                    default:
                        return string.Empty;
                }

            }
        }
        public string EducationVideo
        {
            get
            {
                switch(this.Education)
                {
                    case EducationOption.Apprenticeship:
                        return string.Format("{0}dest_2_1/apprentice.mp4", MAIN_SITE_URL);
                    case EducationOption.CareerSchool:
                        return string.Format("{0}dest_2_1/careerschool.mp4", MAIN_SITE_URL);
                    case EducationOption.CommunityCollege:
                        return string.Format("{0}dest_2_1/community.mp4", MAIN_SITE_URL);
                    case EducationOption.University:
                        return string.Format("{0}dest_2_1/university.mp4", MAIN_SITE_URL);
                    default:
                        return string.Empty;
                }
            }
        }
        
        public CareerOption Career { get; set; }
        public string CareerOther { get; set; }
        public string CareerToText
        {
            get
            {
                switch(this.Career)
                {
                    case CareerOption.Athlete:
                        return "Athlete";
                    case CareerOption.Business:
                        return "Business-person";
                    case CareerOption.Designer:
                        return "Designer";
                    case CareerOption.Engineer:
                        return "Engineer";
                    case CareerOption.Medical:
                        return "Nurse / Doctor";
                    case CareerOption.Teacher:
                        return "Teacher";
                    case CareerOption.Other:
                        return this.CareerOther;
                    default:
                        return string.Empty;
                }
            }
        }
        public string CareerVideo
        {
            get
            {
                switch (this.Career)
                {
                    case CareerOption.Athlete:
                        return string.Format("{0}dest_2_2/athlete.mp4", MAIN_SITE_URL);
                    case CareerOption.Business:
                        return string.Format("{0}dest_2_2/business.mp4", MAIN_SITE_URL);
                    case CareerOption.Designer:
                        return string.Format("{0}dest_2_2/designer.mp4", MAIN_SITE_URL);
                    case CareerOption.Engineer:
                        return string.Format("{0}dest_2_2/engineer.mp4", MAIN_SITE_URL);
                    case CareerOption.Medical:
                        return string.Format("{0}dest_2_2/medical.mp4", MAIN_SITE_URL);
                    case CareerOption.Teacher:
                        return string.Format("{0}dest_2_2/teacher.mp4", MAIN_SITE_URL);
                    default:
                        return string.Empty;
                }

            }
        }

        public AidingCommunityOption Community { get; set; }
        public string CommunityOther { get; set; }
        public string CommunityToText
        {
            get
            {
                switch(this.Community)
                {
                    case AidingCommunityOption.Animals:
                        return "Helping Animals";
                    case AidingCommunityOption.Children:
                        return "Mentoring children";
                    case AidingCommunityOption.Coach:
                        return "Being a Coach";
                    case AidingCommunityOption.Environment:
                        return "Protecting the environment";
                    case AidingCommunityOption.GraffitiCleanup:
                        return "Helping clean up graffiti";
                    case AidingCommunityOption.Homeless:
                        return "Helping out at a Homeless Shelter";
                    case AidingCommunityOption.Other:
                        return this.CommunityOther;
                    default:
                        return string.Empty;
                }
            }
        }
        public string CommunityVideo
        {
            get
            {
                switch(this.Community)
                {
                    case AidingCommunityOption.Animals:
                        return string.Format("{0}dest_3/animal.mp4", MAIN_SITE_URL);
                    case AidingCommunityOption.Children:
                        return string.Format("{0}dest_3/mentor.mp4", MAIN_SITE_URL);
                    case AidingCommunityOption.Coach:
                        return string.Format("{0}dest_3/coach.mp4", MAIN_SITE_URL);
                    case AidingCommunityOption.Environment:
                        return string.Format("{0}dest_3/environment.mp4", MAIN_SITE_URL);
                    case AidingCommunityOption.GraffitiCleanup:
                        return string.Format("{0}dest_3/graffiti.mp4", MAIN_SITE_URL);
                    case AidingCommunityOption.Homeless:
                        return string.Format("{0}dest_3/homeless.mp4", MAIN_SITE_URL);
                    default:
                        return string.Empty;
                }
            }
        }

        public HobbyOption Hobby { get; set; }
        public string HobbyOther { get; set; }
        public string HobbyToText
        {
            get
            {
                switch(this.Hobby)
                {
                    case HobbyOption.Hiking:
                        return "Go Hiking";
                    case HobbyOption.Music:
                        return "Play an instrument";
                    case HobbyOption.Photography:
                        return "Do Photography";
                    case HobbyOption.Sport:
                        return "Play Sports";
                    case HobbyOption.Travel:
                        return "Go Travel";
                    case HobbyOption.WaterSport:
                        return "Play Water Sports";
                    case HobbyOption.Other:
                        return this.HobbyOther;
                    default:
                        return string.Empty;
                }
            }
        }
        public string HobbyVideo
        {
            get
            {
                switch(this.Hobby)
                {
                    case HobbyOption.Hiking:
                        return string.Format("{0}dest_4/hiking.mp4", MAIN_SITE_URL);
                    case HobbyOption.Music:
                        return string.Format("{0}dest_4/music.mp4", MAIN_SITE_URL);
                    case HobbyOption.Photography:
                        return string.Format("{0}dest_4/photo.mp4", MAIN_SITE_URL);
                    case HobbyOption.Sport:
                        return string.Format("{0}dest_4/sport.mp4", MAIN_SITE_URL);
                    case HobbyOption.Travel:
                        return string.Format("{0}dest_4/travel.mp4", MAIN_SITE_URL);
                    case HobbyOption.WaterSport:
                        return string.Format("{0}dest_4/watersports.mp4", MAIN_SITE_URL);
                    default:
                        return string.Empty;
                }
            }
        }

        public string GraduationVideo { get { return string.Format("{0}Graduation/graduation.mp4", MAIN_SITE_URL); } }

        public TimeTravelerDetail()
        {
            this.Likes = new List<string>();
            this.Education = EducationOption.Apprenticeship;
            this.Community = AidingCommunityOption.Animals;
            this.Hobby = HobbyOption.Hiking;
            this.FamilyStyle = FamilyStyleOption.Dad;
            this.FutureHome = FutureHomeOption.DowntownCity;
            this.Name = "Your Uncle Bob";
            this.Grade = 4;
            this.Career = CareerOption.Athlete;
                        
        }
    }

    public enum FutureHomeOption
    {
        DowntownCity,
        Mountains,
        Ranch, 
        Ocean,
        Snowland,
        Suburb
    }

    public enum FamilyStyleOption
    {
        Married,
        SingleMale,
        SingleWoman,
        Dad,
        Mother,
        Multi_generational
    }

    public enum EducationOption
    {
        CommunityCollege,
        University,
        CareerSchool,
        Apprenticeship
    }

    public enum CareerOption
    {
        Designer,
        Athlete,
        Teacher,
        Engineer,
        Business,
        Medical,
        Other
    }

    public enum AidingCommunityOption
    {
        GraffitiCleanup,
        Coach,
        Animals,
        Environment,
        Children,
        Homeless,
        Other
    }

    public enum HobbyOption
    {
        Hiking,
        Photography,
        Sport,
        Music, 
        Travel,
        WaterSport,
        Other
    }
}