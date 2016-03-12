// Decompiled with JetBrains decompiler
// Type: TimeTraveler.js.Home_Message
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler.js
{
  public class Home_Message : Page
  {
    protected Label lblName;
    protected Label lblHome;
    protected HyperLink hypHomeLink;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      this.lblName.Text = "Wow " + HttpContext.Current.Session["name"].ToString() + "!";
      string str = HttpContext.Current.Session["homeChoice"].ToString();
      this.lblHome.Text = str;
      if (str == "In the Downtown/City")
        this.hypHomeLink.NavigateUrl = "http://www.kidsathope.org/DowntownOKCLiving.wmv";
      else if (str == "In the Mountains")
        this.hypHomeLink.NavigateUrl = "http://www.kidsathope.org/LivingintheMountainAreaofSteamboatSpringsColoradoSkiTownUSA.wmv";
      else if (str == "On a Ranch")
        this.hypHomeLink.NavigateUrl = "http://www.kidsathope.org/LifeontheRanchinWesternNebraska.wmv";
      else if (str == "Near the sea")
        this.hypHomeLink.NavigateUrl = "http://www.kidsathope.org/Simple.Living.AboardaBoat.wmv";
      else if (str == "where it snows")
        this.hypHomeLink.NavigateUrl = "http://www.kidsathope.org/Livinginthesnow.wmv";
      else if (str == "In the Suburbs")
        this.hypHomeLink.NavigateUrl = "http://www.kidsathope.org/LouisvilleColoradoTownandNeighborhoodTour.wmv";
    }
  }
}
