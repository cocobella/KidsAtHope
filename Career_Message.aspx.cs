// Decompiled with JetBrains decompiler
// Type: TimeTraveler.js.Career_Message
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler.js
{
  public class Career_Message : Page
  {
    protected Label lblName;
    protected Label lblCareer;
    protected Label videoLinkLbl;
    protected HyperLink hypCareerLink;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      this.lblName.Text = HttpContext.Current.Session["name"].ToString() + ",";
      string str = HttpContext.Current.Session["careerChoice"].ToString();
      this.lblCareer.Text = str;
      this.videoLinkLbl.Visible = true;
      if (str == "a designer")
        this.hypCareerLink.NavigateUrl = "http://www.kidsathope.org/CareersforDesignMajors.wmv";
      else if (str == "an athlete")
        this.hypCareerLink.NavigateUrl = "http://www.kidsathope.org/ADayintheLife-BryanClay.wmv";
      else if (str == "a teacher")
        this.hypCareerLink.NavigateUrl = "http://www.kidsathope.org/TheMostCreativeTeacherEver.wmv";
      else if (str == "an engineer")
        this.hypCareerLink.NavigateUrl = "http://www.kidsathope.org/Engineersarecool-ProducedbyArupfortheHKIE2009PresidentialAddress.wmv";
      else if (str == "a Business Person or an Entrepreneur")
        this.hypCareerLink.NavigateUrl = "http://www.kidsathope.org/WhatisEntrepreneurship-.wmv";
      else if (str == "a Medical Personnel")
      {
        this.hypCareerLink.NavigateUrl = "http://www.kidsathope.org/ADayintheLifeofFamilyMedicine.wmv";
      }
      else
      {
        this.videoLinkLbl.Visible = false;
        this.hypCareerLink.Visible = false;
      }
    }
  }
}
