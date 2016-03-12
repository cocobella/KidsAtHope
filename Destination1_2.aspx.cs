// Decompiled with JetBrains decompiler
// Type: TimeTraveler.Destination1_2
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler
{
  public class Destination1_2 : Page
  {
    protected RadioButtonList RadioButtonList1;
    protected RequiredFieldValidator ReqiredFieldValidator1;
    protected ImageButton ImageButton1;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
      string str = "";
      switch (this.RadioButtonList1.SelectedIndex)
      {
        case 0:
          str = str.Trim() + "to be married";
          break;
        case 1:
          str = str.Trim() + "to be a mom";
          break;
        case 2:
          str = str.Trim() + "to be part of a multigeneration family";
          break;
        case 3:
          str = str.Trim() + "to be a single guy";
          break;
        case 4:
          str = str.Trim() + "to be a single and independent woman";
          break;
        case 5:
          str = str.Trim() + "to be a dad";
          break;
      }
      if (HttpContext.Current.Session == null)
        return;
      HttpContext.Current.Session["familyChoice"] = (object) str;
      this.Response.Redirect("Family_Message.aspx");
    }
  }
}
