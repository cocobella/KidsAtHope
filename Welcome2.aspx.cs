// Decompiled with JetBrains decompiler
// Type: TimeTraveler.Welcome2
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler
{
  public class Welcome2 : Page
  {
    protected Label lblName;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      this.lblName.Text = "Hi " + HttpContext.Current.Session["name"].ToString() + "!";
    }
  }
}
