<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Family_Message.aspx.cs" Inherits="TimeTraveler.js.Family_Message" %>

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
                                            <strong><font style="font-size:400%; font-family:Bradley Hand ITC" color="#ff9601">Fun, isn't it?</font></strong>
                                             <br />
                                             <br />
                                         </div>
                                        <div>
                                        <table>
                                        <tr>
                                        <td style="width:650px">
                                        <br />
                                        <%-- <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="XX-Large" ForeColor="#ff9601"></asp:Label><br /><br /> --%>
                                        <font style="font-size:150%" color="#E3609D" >“It may seem funny now to think about the type of family you would like</font><br />
                                        <font style="font-size:150%" color="#E3609D" >to have when you grow up, but in order to be a Time Traveler it is </font><br />
                                        <font style="font-size:150%" color="#E3609D" >important."</font><br /><br /><br />
                                         
                                        <font style="font-size:150%" color="#E3609D" >Your family choice was </font>
                                        <asp:Label ID="lblFamily" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="150%" ForeColor="#ff9601"></asp:Label><br />
                                        <font style="font-size:150%" color="#E3609D" >To see what that looks like, </font>
                                        <asp:HyperLink ID="hypFamilyLink" Target="_blank" runat="server">Click Here</asp:HyperLink><br /><br />
                                        
                                        <font style="font-size:150%" color="#E3609D" >These are just a few different kinds of families – you can imagine </font><br />
                                        <font style="font-size:150%" color="#E3609D" >whatever kind of family you would want to be a part of. </font><br />
                                        <br /><br /><br /><br /><br /><br />
                                        <div style="margin-left:100px">
                                            <table>
                                            <tr>
                                               <td style="margin-left:10px;width:850px" >
                                                   <a href="Destination1_2.aspx"><img src="images/Back_button.JPG" style="border-color:White" alt="Please click below" /></a>
                                               </td>
                                               <td>
                                                   <a href="Destination2_1.aspx"><img src="images/next_button_1.png" style="border-color:White" alt="Please click below" /></a>
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
