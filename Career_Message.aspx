<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Career_Message.aspx.cs" Inherits="TimeTraveler.js.Career_Message" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="container">
        <div id="block1">
            
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
                                            <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="400%" ForeColor="#ff9601"></asp:Label>,                                            
                                             <br />
                                             <br />
                                         </div>
                                        <div>
                                        <table>
                                        <tr>
                                        <td style="width:650px">
                                        <br />
                                        <%-- <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="XX-Large" ForeColor="#ff9601"></asp:Label><br /><br /> --%>
                                        <font style="font-size:150%" color="#E3609D" >Whatever you choose to do, make sure it is something you will really</font><br />
                                        <font style="font-size:150%" color="#E3609D" >enjoy because you will spend a lot of time at this destination. And</font><br />
                                        <font style="font-size:150%" color="#E3609D" >you can start thinking now about what kind of education or training </font><br />                                        
                                        <font style="font-size:150%" color="#E3609D" >you will need for your career choice.</font><br /><br />                                        
                                        <font style="font-size:150%" color="#EE90EC" >Good Luck! It’s fun to visit your future isn’t it?</font><br /><br />                                       

                                        <font style="font-size:150%" color="#E3609D" >You chose to be </font>
                                        <asp:Label ID="lblCareer" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="150%" ForeColor="#ff9601"></asp:Label><br />
                                        
                                        <asp:Label ID="videoLinkLbl" runat="server" Text="To see how it looks like," Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="150%" ForeColor="#E3609D"></asp:Label><br />                                        
                                        <asp:HyperLink ID="hypCareerLink" Target="_blank" runat="server">Click Here</asp:HyperLink><br />                                        
                                                                                
                                        <br /><br /><br />
                                        <div style="margin-left:100px">
                                            <table>
                                            <tr>
                                               <td style="margin-left:10px;width:850px" >
                                                   <a href="Destination2_3.aspx"><img src="images/Back_button.JPG" style="border-color:White" alt="Please click below" /></a>
                                               </td>
                                               <td>
                                                   <a href="Destination3.aspx"><img src="images/next_button_1.png" style="border-color:White" alt="Please click below" /></a>
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
