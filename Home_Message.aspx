<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Home_Message.aspx.cs" Inherits="TimeTraveler.js.Home_Message" %>

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
                                            <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="400%" ForeColor="#ff9601"></asp:Label><br /><br />
                                             <br />
                                             <br />
                                         </div>
                                        <div>
                                        <table>
                                        <tr>
                                        <td style="width:650px">
                                        <br />                                        
                                        <font style="font-size:150%" color="#E3609D" >“Great job imagining where you would like to live when you grow up!</font><br />
                                        <font style="font-size:150%" color="#E3609D" >These are just a few of the thousands of places you could live – and </font><br />
                                        <font style="font-size:150%" color="#E3609D" >you can always change your mind if you visit a new place that you think </font><br />
                                        <font style="font-size:150%" color="#E3609D" >would be a wonderful place to live!"</font><br /><br />

                                        <font style="font-size:150%" color="#E3609D" >You chose to live </font>
                                        <asp:Label ID="lblHome" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="150%" ForeColor="#ff9601"></asp:Label><br />
                                        <font style="font-size:150%" color="#E3609D" >To see what this look like </font>
                                        <asp:HyperLink ID="hypHomeLink" Target="_blank" runat="server">Click Here</asp:HyperLink><br /><br /><br />
                                        
                                        <font style="font-size:150%" color="#E3609D" >"Now let’s take a look at what kind of family you would like to have in the future…”</font><br />
                                        <br /><br /><br /><br />
                                        <div style="margin-left:100px">
                                            <table>
                                            <tr>
                                               <td style="margin-left:10px;width:850px" >
                                                   <a href="Destination1.aspx"><img src="images/Back_button.JPG" style="border-color:White" alt="Please click below" /></a>
                                               </td>
                                               <td>
                                                   <a href="Destination1_2.aspx"><img src="images/next_button_1.png" style="border-color:White" alt="Please click below" /></a>
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
