// Decompiled with JetBrains decompiler
// Type: TimeTraveler.Question1
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler
{
  public class Question1 : Page
  {
    protected CheckBox chkLaugh;
    protected CheckBox chkDraw;
    protected CheckBox chkComputer;
    protected CheckBox chkRead;
    protected CheckBox chkHelpG;
    protected CheckBox chkHelpY;
    protected CheckBox chkSports;
    protected CheckBox chkOtherLaugh;
    protected CheckBox chkSing;
    protected CheckBox chkMath;
    protected CheckBox chkMake;
    protected CheckBox chkMusic;
    protected CheckBox chkHouse;
    protected CheckBox chkHelpSick;
    protected CheckBox chkHelpHome;
    protected CheckBox chkWrite;
    protected ImageButton imagebutton1;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void ImageButton_Click(object sender, EventArgs e)
    {
      int num = 0;
      string str = "";
      if (this.chkComputer.Checked)
      {
        ++num;
        str = str.Trim() + "Computer,";
      }
      if (this.chkDraw.Checked)
      {
        ++num;
        str = str.Trim() + "Drawing,";
      }
      if (this.chkHelpG.Checked)
      {
        ++num;
        str = str.Trim() + "Helping grown ups,";
      }
      if (this.chkHelpHome.Checked)
      {
        ++num;
        str = str.Trim() + "Help older people or Homeless people,";
      }
      if (this.chkHelpSick.Checked)
      {
        ++num;
        str = str.Trim() + "Help sick or abused animals,";
      }
      if (this.chkHelpY.Checked)
      {
        ++num;
        str = str.Trim() + "Helping kids younger than me,";
      }
      if (this.chkHouse.Checked)
      {
        ++num;
        str = str.Trim() + "Help around my house,";
      }
      if (this.chkLaugh.Checked)
      {
        ++num;
        str = str.Trim() + "Laughing,";
      }
      if (this.chkMake.Checked)
      {
        ++num;
        str = str.Trim() + "Making things or Fixing things,";
      }
      if (this.chkMath.Checked)
      {
        ++num;
        str = str.Trim() + "Solving math problems,";
      }
      if (this.chkMusic.Checked)
      {
        ++num;
        str = str.Trim() + "Music,";
      }
      if (this.chkOtherLaugh.Checked)
      {
        ++num;
        str = str.Trim() + "Making other people laugh,";
      }
      if (this.chkRead.Checked)
      {
        ++num;
        str = str.Trim() + "Reading,";
      }
      if (this.chkSing.Checked)
      {
        ++num;
        str = str.Trim() + "Singing,";
      }
      if (this.chkSports.Checked)
      {
        ++num;
        str = str.Trim() + "Sports,";
      }
      if (this.chkWrite.Checked)
      {
        ++num;
        str = str.Trim() + "Writing,";
      }
      if (num >= 5)
      {
        if (HttpContext.Current.Session == null)
          return;
        HttpContext.Current.Session["Question1"] = (object) str;
        ScriptManager.RegisterStartupScript((Page) this, this.GetType(), "Sucess", "Redirect();", true);
      }
      else
        ScriptManager.RegisterStartupScript((Page) this, this.GetType(), "error", "alert('Please select atleast 5 interests');", true);
    }
  }
}
