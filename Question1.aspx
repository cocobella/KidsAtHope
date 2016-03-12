<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Question1.aspx.cs" Inherits="TimeTraveler.Question1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="container">
        <div id="block1">
            <div class="row-1">
                <div class="main">
                    <div class="container_12">
                        <div class="grid_12">
                            <nav>
                            <ul style="border-width:thick; border-color:white" class="menu">
                                <li><a class="active" href="Title.aspx">Home</a></li>
                                <li><a href="AboutTT.aspx">About Time Traveler</a></li>
                            </ul>
                        </nav>
                        </div>
                    </div>
                    <div class="clear">
                    </div>
                </div>
            </div>
            <div class="row-2">
                <div class="main">
                    <div class="container_12">
                        <div class="grid_9">
                            <h1>
                                <a class="logo" href="Title.aspx"><font color="white">T</font><strong>i</strong><font
                                    color="white">me</font></a> <span><font color="white">traveler</font></span>
                            </h1>
                        </div>
                    </div>
                    <div class="clear">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <section id="content">
        <div class="bg-top">
        	<div class="bg-top-2">
                <div class="bg">
                    <div class="bg-top-shadow">
                        <div class="main">
                            <div class="gallery p3">
                                <div class="wrapper indent-bot">
                                        <div class="wrapper" style="width:900px">
                                            <br />
                                            <strong><font style="font-size:250%; font-family:Bradley Hand ITC" color="#ff9601">Take a Minute to Think </font></strong><br /><br />
                                            <font style="font-size:135%" color="#FA58AC" >Let’s begin by thinking about what skills and talents you already have.</font><br />
                                            <font style="font-size:135%" color="#FA58AC" >Please look at the following list and decide which of these phrases you think best describe you. Choose at least 5 – you can choose more of course!
                                            </font>
                                             <br />
                                             <br />
                                         </div>
                                        <div>
                                        <table style="margin-left:50px">
<tr>
<td style="width:400px"><asp:CheckBox ID="chkLaugh" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like to laugh</font></b></td>
<td><asp:CheckBox ID="chkDraw" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like art/drawing</font></b></td>
</tr>
<tr>
<td><asp:CheckBox ID="chkComputer" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like computers</font></b></td>
<td><asp:CheckBox ID="chkRead" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like reading</font></b></td>
</tr>
<tr>
<td><asp:CheckBox ID="chkHelpG" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like helping grown ups</font></b></td>
<td><asp:CheckBox ID="chkHelpY" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like helping kids younger than me</font></b></td>
</tr>
<tr>
<td><asp:CheckBox ID="chkSports" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like sports</font></b></td>
<td><asp:CheckBox ID="chkOtherLaugh" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like making other people laugh&nbsp&nbsp</font></b></td>
</tr>
<tr>
<td><asp:CheckBox ID="chkSing" runat="server"></asp:CheckBox>&nbsp&nbsp<font style="font-size:120%" color="#2E9AFE"><b>I like to sing</b></font></td>
<td><asp:CheckBox ID="chkMath" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like solving math problems</font></b></td>
</tr>
<tr>
<td><asp:CheckBox ID="chkMake" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like making things or fixing things</font></b></td>
<td><asp:CheckBox ID="chkMusic" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like music</font></b></td>
</tr>
<tr>
<td><asp:CheckBox ID="chkHouse" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I help around my house</font></b></td>
<td><asp:CheckBox ID="chkHelpSick" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like to help sick or abused animals</font></b></td>
</tr>
<tr>
<td><asp:CheckBox ID="chkHelpHome" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like to help older people or homeless people</font></b></td>
<td><asp:CheckBox ID="chkWrite" runat="server"></asp:CheckBox>&nbsp&nbsp<b><font style="font-size:120%" color="#2E9AFE">I like to write</font></b></td>
</tr>
</table>
<div style="margin-left:800px">
<asp:ImageButton id="imagebutton1" runat="server"
                                                        AlternateText="ImageButton 1"
                                                        ImageUrl="images/next_button_1.png"
                                                        OnClick="ImageButton_Click"/>
</div>
</div>
                                </div>
                            </div>                        
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

<script type="text/javascript">
function Redirect()
{
    alert("Wow! These talents and skills will help you in your future as an adult. We know that you have a lot more than just the few we listed here. We just want to show you that even with just these skills and talents you are already preparing for a successful future!");
    window.location="Welcome2.aspx";
}
</script>
</asp:Content>
