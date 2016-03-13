using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTraveler.Models
{
    public class TimeTravelerDetail
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public List<string> Likes { get; set; }
        public FutureHomeOption FutureHome { get; set; }
        public FamilyStyleOption FamilyStyle { get; set; }
        public EducationOption Education { get; set; }
        public CareerOption Career { get; set; }
        public string CareerOther { get; set; }
        public AidingCommunityOption Community { get; set; }
        public string CommunityOther { get; set; }
        public HobbyOption Hobby { get; set; }
        public string HobbyOther { get; set; }
        

        public TimeTravelerDetail()
        {
            this.Likes = new List<string>();
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