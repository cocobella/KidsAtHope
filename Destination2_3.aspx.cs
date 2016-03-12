// Decompiled with JetBrains decompiler
// Type: TimeTraveler.Destination2_3
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler
{
  public class Destination2_3 : Page
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
          str = str.Trim() + "a designer";
          break;
        case 1:
          str = str.Trim() + "an athlete";
          break;
        case 2:
          str = str.Trim() + "a teacher";
          break;
        case 3:
          str = str.Trim() + "an engineer";
          break;
        case 4:
          str = str.Trim() + "a Business Person or an Entrepreneur";
          break;
        case 5:
          str = str.Trim() + "a Medical Personnel";
          break;
        case 6:
          str = this.txtOther.Text.Trim();
          break;
      }
      if (HttpContext.Current.Session == null)
        return;
      HttpContext.Current.Session["careerChoice"] = (object) str;
      this.Response.Redirect("Career_Message.aspx");
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
