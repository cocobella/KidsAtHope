// Decompiled with JetBrains decompiler
// Type: TimeTraveler.js.Hobbies_Message
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler.js
{
  public class Hobbies_Message : Page
  {
    protected Label lblHobby;
    protected Label lblVideo;
    protected HyperLink hypHobbyLink;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      string str = HttpContext.Current.Session["hobbyChoice"].ToString();
      this.lblHobby.Text = str;
      this.lblVideo.Visible = true;
      if (str == "hike")
        this.hypHobbyLink.NavigateUrl = "http://www.kidsathope.org/HikingFifthPeakwithQuinOurJRT.wmv";
      else if (str == "learn photography")
        this.hypHobbyLink.NavigateUrl = "http://www.kidsathope.org/FromCEOtowildlifephotographer.wmv";
      else if (str == "play a sport")
        this.hypHobbyLink.NavigateUrl = "http://www.kidsathope.org/JoinCarlsbadsAdultSportsLeague.wmv";
      else if (str == "learn how to play a musical instrument")
        this.hypHobbyLink.NavigateUrl = "http://www.kidsathope.org/AndyMcKee-Guitar-Drifting-www.candyrat.com.wmv";
      else if (str == "travel around the world")
        this.hypHobbyLink.NavigateUrl = "http://www.kidsathope.org/MOVERemixed-1Minute.1Man.1EpicJourney..wmv";
      else if (str == "play watersports")
      {
        this.hypHobbyLink.NavigateUrl = "http://www.kidsathope.org/Flyboard-CoolestWaterJetPackEVER.wmv";
      }
      else
      {
        this.lblVideo.Visible = false;
        this.hypHobbyLink.Visible = false;
      }
    }
  }
}
