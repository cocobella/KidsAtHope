// Decompiled with JetBrains decompiler
// Type: TimeTraveler.js.Community_Message
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler.js
{
  public class Community_Message : Page
  {
    protected Label lblName;
    protected Label lblCommunity;
    protected Label lblVideo;
    protected HyperLink hypCommunityLink;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      this.lblName.Text = HttpContext.Current.Session["name"].ToString();
      string str = HttpContext.Current.Session["communityChoice"].ToString();
      this.lblCommunity.Text = str;
      this.lblVideo.Visible = true;
      if (str == "cleaning graffiti")
        this.hypCommunityLink.NavigateUrl = "http://www.kidsathope.org/Studentshelpwithgraffiticlean-up.wmv";
      else if (str == "coaching kids")
        this.hypCommunityLink.NavigateUrl = "http://www.kidsathope.org/KidsSoccerCoaching3-U6.wmv";
      else if (str == "volunteering at an animal shelter")
        this.hypCommunityLink.NavigateUrl = "http://www.kidsathope.org/Wash.AnimalRescueLeague-AnAnimalShelterLikeNoOther.wmv";
      else if (str == "protecting the environment")
        this.hypCommunityLink.NavigateUrl = "http://www.kidsathope.org/Studentslearnhowtoprotecttheenvironment.wmv";
      else if (str == "mentoring children")
        this.hypCommunityLink.NavigateUrl = "http://www.kidsathope.org/HundredsOfKidsWaitingForMentors.wmv";
      else if (str == "volunteering at homeless shelters")
      {
        this.hypCommunityLink.NavigateUrl = "http://www.kidsathope.org/SutterMedicalNetworkStaffVolunteersatHomelessShelter.wmv";
      }
      else
      {
        this.lblVideo.Visible = false;
        this.hypCommunityLink.Visible = false;
      }
    }
  }
}
