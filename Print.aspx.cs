// Decompiled with JetBrains decompiler
// Type: TimeTraveler.js.Print_Message
// Assembly: TimeTraveler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 52D5A313-8F46-46AD-8B87-DDDD41E9485F
// Assembly location: F:\GiveCamp\bin\TimeTraveler.dll

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTraveler.js
{
  public class Print_Message : Page
  {
    protected Label lblName0;
    protected Label lblName;
    protected Label lblName1;
    protected Label lblName2;
    protected Label lblName3;
    protected Label lblName4;
    protected Label lblName5;
    protected Label lblName6;
    protected Label lblName7;
    protected Button btnPrint;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.Session == null)
        return;
      string str1 = "";
      string str2 = "Hi " + HttpContext.Current.Session["name"].ToString() + ",";
      string str3 = str1 + "Wow, what a trip you just experienced! You visited your future. Not everyone knows how to do that, but you do. How cool was that?! As a Time Traveler you discovered that you have many of the skills and talents you will need on your journey to your destinations. " + "You listed: " + HttpContext.Current.Session["Question1"].ToString() + "Each one of those will help you succeed at each destination. Take a moment and think how your talents will be of importance to you. As importantly, you will continue to get better with each of your talents and you will pick up more on the way. Remember, the harder you try the better you will get. So always try your best in everything you do. Never Give Up. " + "Every Time Traveler keeps a log of their adventures - Here is your Log:";
      string str4 = "•\tToday you time traveled to Home and Family and you said you would like to live " + HttpContext.Current.Session["homeChoice"].ToString();
      string str5 = "•\tYou see yourself " + HttpContext.Current.Session["familyChoice"].ToString();
      string str6 = "•\tYou also visited your future Education and Career and after high school graduation, you decided to go to " + HttpContext.Current.Session["educationChoice"].ToString();
      string str7 = "•\tYour career choice was to be a " + HttpContext.Current.Session["careerChoice"].ToString();
      string str8 = "•\tYou would like to serve your Community by " + HttpContext.Current.Session["communityChoice"].ToString();
      string str9 = "•\tFinally, as a Hobby or for Recreation you would like to play " + HttpContext.Current.Session["hobbyChoice"].ToString();
      string str10 = "We are proud that you've become an official Time Traveler. Remember you can time travel whenever you want and what you learn in school, at home and in your community will make you very successful and happy when you grow up at all four destinations! ";
      this.lblName0.Text = str2;
      this.lblName.Text = str3;
      this.lblName1.Text = str4;
      this.lblName2.Text = str5;
      this.lblName3.Text = str6;
      this.lblName4.Text = str7;
      this.lblName5.Text = str8;
      this.lblName6.Text = str9;
      this.lblName7.Text = str10;
    }
  }
}
