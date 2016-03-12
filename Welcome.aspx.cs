// Decompiled with JetBrains decompiler
// Type: TimeTraveler.js.Welcome
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler.js
{
  public class Welcome : Page
  {
    protected TextBox txtName;
    protected RequiredFieldValidator reqName;
    protected DropDownList gradeDrop;
    protected RequiredFieldValidator RequiredFieldValidator1;
    protected ImageButton imagebutton1;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (this.Page.IsPostBack)
        return;
      this.gradeDrop.Items.Clear();
      this.gradeDrop.Items.Insert(0, new ListItem(string.Empty));
      this.gradeDrop.Items.Insert(1, new ListItem("4"));
      this.gradeDrop.Items.Insert(2, new ListItem("5"));
      this.gradeDrop.Items.Insert(3, new ListItem("6"));
      this.gradeDrop.Items.Insert(4, new ListItem("7"));
      this.gradeDrop.Items.Insert(5, new ListItem("8"));
      this.gradeDrop.Items.Insert(6, new ListItem("9"));
      this.gradeDrop.Items.Insert(7, new ListItem("10"));
      this.gradeDrop.Items.Insert(8, new ListItem("11"));
      this.gradeDrop.Items.Insert(9, new ListItem("12"));
      this.txtName.Focus();
    }

    protected void ImageButton_Click(object sender, ImageClickEventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      HttpContext.Current.Session["name"] = (object) this.txtName.Text;
      HttpContext.Current.Session["grade"] = (object) this.gradeDrop.SelectedItem.Value;
      this.Response.Redirect("Question1.aspx");
    }
  }
}
