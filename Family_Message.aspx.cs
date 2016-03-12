// Decompiled with JetBrains decompiler
// Type: TimeTraveler.js.Family_Message
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler.js
{
  public class Family_Message : Page
  {
    protected Label lblFamily;
    protected HyperLink hypFamilyLink;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      string str = HttpContext.Current.Session["familyChoice"].ToString();
      this.lblFamily.Text = str;
      if (str == "to be married")
        this.hypFamilyLink.NavigateUrl = "http://www.kidsathope.org/WeddingmessagefromtheskiesoverAfghanistan.wmv";
      else if (str == "to be a mom")
        this.hypFamilyLink.NavigateUrl = "http://www.kidsathope.org/OlympicsPandGThankYouMomCommercial.wmv";
      else if (str == "to be part of a multigeneration family")
        this.hypFamilyLink.NavigateUrl = "http://www.kidsathope.org/Thebenefitsofmulti-generationalhomes.wmv";
      else if (str == "to be a single guy")
        this.hypFamilyLink.NavigateUrl = "http://www.kidsathope.org/2012InspirationalMatchKeithandJosh.wmv";
      else if (str == "to be a single and independent woman")
        this.hypFamilyLink.NavigateUrl = "http://www.kidsathope.org/KathCartersAdvicetoYoungWomen.wmv";
      else if (str == "to be a dad")
        this.hypFamilyLink.NavigateUrl = "http://www.kidsathope.org/SUPERMAN-AFATHERSDAYTRIBUTE.wmv";
    }
  }
}
