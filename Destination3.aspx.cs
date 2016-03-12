// Decompiled with JetBrains decompiler
// Type: TimeTraveler.Destination3
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler
{
  public class Destination3 : Page
  {
    protected RadioButtonList RadioButtonList1;
    protected TextBox txtOther;
    protected RequiredFieldValidator ReqiredFieldValidator1;
    protected RequiredFieldValidator RequiredFieldValidator2;
    protected ImageButton ImageButton1;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.txtOther.Visible = false;
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
      string str = "";
      switch (this.RadioButtonList1.SelectedIndex)
      {
        case 0:
          str = str.Trim() + "cleaning graffiti";
          break;
        case 1:
          str = str.Trim() + "coaching kids";
          break;
        case 2:
          str = str.Trim() + "volunteering at an animal shelter";
          break;
        case 3:
          str = str.Trim() + "protecting the environment";
          break;
        case 4:
          str = str.Trim() + "mentoring children";
          break;
        case 5:
          str = str.Trim() + "volunteering at homeless shelters";
          break;
        case 6:
          str = this.txtOther.Text.Trim();
          break;
      }
      if (HttpContext.Current.Session == null)
        return;
      HttpContext.Current.Session["communityChoice"] = (object) str;
      this.Response.Redirect("Community_Message.aspx");
    }

    protected void rbSelected(object sender, EventArgs e)
    {
      if (this.RadioButtonList1.SelectedIndex == 6)
        this.txtOther.Visible = true;
      else
        this.txtOther.Visible = false;
    }
  }
}
