// Decompiled with JetBrains decompiler
// Type: TimeTraveler.js.Education_Message1
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler.js
{
  public class Education_Message1 : Page
  {
    protected Label lblGradYear;
    protected Label lblEducation;
    protected HyperLink hypEducationLink;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      string str = HttpContext.Current.Session["educationChoice"].ToString();
      this.lblEducation.Text = str;
      int num = Convert.ToInt32(DateTime.Now.Year);
      switch (Convert.ToInt32(HttpContext.Current.Session["grade"]))
      {
        case 4:
          num = num + 9 + 4;
          break;
        case 5:
          num = num + 8 + 4;
          break;
        case 6:
          num = num + 7 + 4;
          break;
        case 7:
          num = num + 6 + 4;
          break;
        case 8:
          num = num + 5 + 4;
          break;
        case 9:
          num = num + 4 + 4;
          break;
        case 10:
          num = num + 3 + 4;
          break;
        case 11:
          num = num + 2 + 4;
          break;
        case 12:
          num = num + 1 + 4;
          break;
      }
      this.lblGradYear.Text = num.ToString();
      if (str == "go to a community college")
        this.hypEducationLink.NavigateUrl = "http://www.kidsathope.org/TransfertoaUniversity-EstrellaMountainCommunityCollege.wmv";
      else if (str == "do an internship/apprenticeship")
        this.hypEducationLink.NavigateUrl = "http://www.kidsathope.org/GoodreasonsforanInternship-myexperience..wmv";
      else if (str == "study at a University")
        this.hypEducationLink.NavigateUrl = "http://www.kidsathope.org/SucceedinginCollege_000.wmv";
      else if (str == "go to a vocational/career school")
        this.hypEducationLink.NavigateUrl = "http://www.kidsathope.org/VocationalSchools.wmv";
    }
  }
}
