<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Destination2_1.aspx.cs" Inherits="TimeTraveler.js.Destination2_1" %>

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
                                            <strong><font style="font-size:400%; font-family:Bradley Hand ITC" color="#ff9601">Your Next Destination is Here!</font></strong><br /><br />
                                            <strong><font style="font-size:200%; font-family:Bradley Hand ITC" color="#ff9601">Destination 2: Education & Career</font></strong><br />
                                             <br />                                             
                                         </div>
                                        <div>
                                        <table>
                                        <tr>
                                        <td style="width:650px">
                                        <br />
                                        <%-- <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="XX-Large" ForeColor="#ff9601"></asp:Label><br /><br /> --%>
                                        <font style="font-size:150%" color="#E3609D" >Alright, now that you’ve explored where and with whom you want</font><br />
                                        <font style="font-size:150%" color="#E3609D" >to live when you grow up, let us head to your next fantastic</font><br />
                                        <font style="font-size:150%" color="#E3609D" >destination.</font>
                                        <font style="font-size:150%" color="#CEDA32" > This destination is called “Education and Career”!</font><br />                                                      
                                  
                                        <br />
                                        <div style="margin-left:100px">
                                            <table>
                                            <tr>
                                                <td style="margin-left:10px;width:850px">
                                                <img src="images/rsz_1high_school_grad.jpg" style="border-color:White" alt="Please click below" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="margin-left:10px;width:850px">
                                                <font style="font-size:150%" color="#E3609D" >Congratulations!You worked hard for the last 12 years to get to this point – you should be proud of yourself! But your education does not stop here. You are a High School Graduate! You will graduate in the Year: </font>
                                                <asp:Label ID="lblGrade" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="XX-Large" ForeColor="#ff9601"></asp:Label><br /><br />
                                                <asp:HyperLink ID="hypUGLink" Target="_blank" runat="server">Click Here to see how your graduation would look like!</asp:HyperLink><br /><br />
                                                </td>
                                            </tr>
                                            
                                            <tr>
                                               <td style="margin-left:10px;width:850px" >
                                                   <a href="Family_Message.aspx"><img src="images/Back_button.JPG" style="border-color:White" alt="Please click below" /></a>
                                               </td>
                                               <td>
                                                   <a href="Destination2_2.aspx"><img src="images/next_button_1.png" style="border-color:White" alt="Please click below" /></a>
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
