// Decompiled with JetBrains decompiler
// Type: TimeTraveler.js.Destination2_1
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler.js
{
  public class Destination2_1 : Page
  {
    protected Label lblGrade;
    protected HyperLink hypUGLink;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      int num1 = Convert.ToInt32(DateTime.Now.Year);
      int num2 = Convert.ToInt32(HttpContext.Current.Session["grade"]);
      this.hypUGLink.NavigateUrl = "http://www.kidsathope.org/ScrippsRanchHighGraduation2008CapThrow.wmv";
      if (num2 == 4)
        num1 += 9;
      else if (num2 == 5)
        num1 += 8;
      else if (num2 == 6)
        num1 += 7;
      else if (num2 == 7)
        num1 += 6;
      else if (num2 == 8)
        num1 += 5;
      else if (num2 == 9)
        num1 += 4;
      else if (num2 == 10)
        num1 += 3;
      else if (num2 == 11)
        num1 += 2;
      else if (num2 == 12)
        ++num1;
      this.lblGrade.Text = num1.ToString();
    }
  }
}
