// Decompiled with JetBrains decompiler
// Type: TimeTraveler.Destination1
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler
{
  public class Destination1 : Page
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
          str = str.Trim() + "In the Downtown/City";
          break;
        case 1:
          str = str.Trim() + "In the Mountains";
          break;
        case 2:
          str = str.Trim() + "On a Ranch";
          break;
        case 3:
          str = str.Trim() + "Near the sea";
          break;
        case 4:
          str = str.Trim() + "where it snows";
          break;
        case 5:
          str = str.Trim() + "In the Suburbs";
          break;
      }
      if (HttpContext.Current.Session == null)
        return;
      HttpContext.Current.Session["homeChoice"] = (object) str;
      this.Response.Redirect("Home_Message.aspx");
    }
  }
}
