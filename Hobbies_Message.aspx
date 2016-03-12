<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Hobbies_Message.aspx.cs" Inherits="TimeTraveler.js.Hobbies_Message" %>

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
                                            <strong><font style="font-size:400%; font-family:Bradley Hand ITC" color="#ff9601">Cool, right?</font></strong>
                                             <br />
                                             <br /><br /><br /><br /><br /><br />
                                         </div>
                                        <div>
                                        <table>
                                        <tr>
                                        <td style="width:650px">
                                        <br />
                                        <%-- <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="XX-Large" ForeColor="#ff9601"></asp:Label><br /><br /> --%>
                                        <font style="font-size:150%" color="#E3609D" >"Grown ups like to have fun too! That’s why Hobbies & Recreation is</font><br />
                                        <font style="font-size:150%" color="#E3609D" >just as important a destination to think about as the other three."</font><br /><br />
                                        <br /><br />
                                        <font style="font-size:150%" color="#E3609D" >As a hobby, you would like to  </font>
                                        <asp:Label ID="lblHobby" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="150%" ForeColor="#ff9601"></asp:Label><br />
                                        <asp:Label ID="lblVideo" runat="server" Text="To See What that Looks Like," Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="150%" ForeColor="#E3609D"></asp:Label><br />
                                        <asp:HyperLink ID="hypHobbyLink" Target="_blank" runat="server">Click Here</asp:HyperLink><br /><br />
                                        
                                        <font style="font-size:150%" color="#E3609D" >These are just a few of the MILLIONS of things you can do for fun</font><br />  
                                        <font style="font-size:150%" color="#E3609D" > as an adult – the sky is the limit!"</font><br />                                                                              
                                  
                                        <br /><br /><br /><br />
                                        <div style="margin-left:100px">
                                            <table>
                                            <tr>
                                               <td style="margin-left:10px;width:850px" >
                                                   <a href="Destination4.aspx"><img src="images/Back_button.JPG" style="border-color:White" alt="Please click below" /></a>
                                               </td>
                                               <td>
                                                   <a href="Final_Message.aspx"><img src="images/next_button_1.png" style="border-color:White" alt="Please click below" /></a>
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
