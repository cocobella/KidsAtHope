<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Education_Message1.aspx.cs" Inherits="TimeTraveler.js.Education_Message1" %>

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
                                            <strong><font style="font-size:400%; font-family:Bradley Hand ITC" color="#ff9601">Excellent Choice!</font></strong>
                                             <br />
                                             <br />
                                         </div>
                                        <div>
                                        <table>
                                        <tr>
                                        <td style="width:650px">
                                        <br />
                                        <%-- <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="XX-Large" ForeColor="#ff9601"></asp:Label><br /><br /> --%>
                                        <font style="font-size:150%" color="#E3609D" >"Remember these are just a few of the options available to you. Talk with</font><br />
                                        <font style="font-size:150%" color="#E3609D" >a caring adult about other choices you may have and you will be on your </font><br />                                        
                                        <font style="font-size:150%" color="#E3609D" >way to success!"</font><br /><br />             
                                        <font style="font-size:150%" color="#EE90EC" >If you choose to go to a 4 year university, your College Graduation Date will be: </font>                                                                             
                                        <asp:Label ID="lblGradYear" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="XX-Large" ForeColor="#ff9601"></asp:Label><br /><br />                                     
                                        <br /><br />
                                        

                                        <font style="font-size:150%" color="#E3609D" >After High School, you decided to </font>
                                        <asp:Label ID="lblEducation" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="150%" ForeColor="#ff9601"></asp:Label><br />
                                        <font style="font-size:150%" color="#E3609D" >To see what that looks like, </font>
                                        <asp:HyperLink ID="hypEducationLink" Target="_blank" runat="server">Click Here</asp:HyperLink><br />
                                                                                                         
                                        <br /><br /><br />
                                        <div style="margin-left:100px">
                                            <table>
                                            <tr>
                                               <td style="margin-left:10px;width:850px" >
                                                   <a href="Destination2_2.aspx"><img src="images/Back_button.JPG" style="border-color:White" alt="Please click below" /></a>
                                               </td>
                                               <td>
                                                   <a href="Destination2_3.aspx"><img src="images/next_button_1.png" style="border-color:White" alt="Please click below" /></a>
                                               </td>
                                            </tr>
                                            </table>
                                        </div>
                                        </td>
                                        <td>
                                            <img src="images/tt_image_front_2.png" style="border-color:White" alt="Please click below" />
                                        </td>
                                        </tr>
                                        </table>
                                        </div>
                                </div>
                            </div>                        
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
