<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Print.aspx.cs" Inherits="TimeTraveler.js.Print_Message" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                                            <strong><font style="font-size:400%; font-family:Bradley Hand ITC" color="#ff9601">Summary Page – Time Traveler’s Log </font></strong>
                                             <br />
                                             <br />
                                         </div>
                                        <div>
                                        <table>
                                        <tr>
                                        <td style="width:650px">
                                        <br />
                                        <asp:Label ID="lblName0" runat="server" Text="" Font-Bold="true" Font-Size="150%" ForeColor="#FFFFFF"></asp:Label><br />
                                        <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Size="150%" ForeColor="#FFFFFF"></asp:Label><br />
                                        <br />
                                        <asp:Label ID="lblName1" runat="server" Text="" Font-Bold="true" Font-Size="150%" ForeColor="#FFFFFF"></asp:Label><br />
                                        <asp:Label ID="lblName2" runat="server" Text="" Font-Bold="true" Font-Size="150%" ForeColor="#FFFFFF"></asp:Label><br />
                                        <asp:Label ID="lblName3" runat="server" Text="" Font-Bold="true" Font-Size="150%" ForeColor="#FFFFFF"></asp:Label><br />
                                        <asp:Label ID="lblName4" runat="server" Text="" Font-Bold="true" Font-Size="150%" ForeColor="#FFFFFF"></asp:Label><br />
                                        <asp:Label ID="lblName5" runat="server" Text="" Font-Bold="true" Font-Size="150%" ForeColor="#FFFFFF"></asp:Label><br />
                                        <asp:Label ID="lblName6" runat="server" Text="" Font-Bold="true" Font-Size="150%" ForeColor="#FFFFFF"></asp:Label><br />
                                        <br />
                                        <asp:Label ID="lblName7" runat="server" Text="" Font-Bold="true" Font-Size="150%" ForeColor="#FFFFFF"></asp:Label>
                                        <br /><br />
                                        <div align="center">                                            
                                            <font style="font-size:150%" color="#FFFFFF">Click Here to Print a Copy of Your Log</font><br /><br />
                                            <asp:Button runat="server" Text="Click here to Print" ID="btnPrint" OnClientClick="javascript:window.print();" target="_blank"/><br /><br />
                                            <font style="font-size:150%" color="#FF9900">Thank you for taking a trip into your future with me, the Time Traveler! These are your goals and dreams, but they can change as you continue your journey through life and that’s ok! Keep doing your very best and remember we believe All Kids are Capable of Success, NO EXCEPTIONS!</font><br />
                                        </div>
                                                                                
                                        <div style="margin-left:100px">
                                            <table>
                                            <tr>
                                               <td style="margin-left:10px;width:850px" >
                                                   <a href="Summary.aspx"><img src="images/Back_button.JPG" style="border-color:White" alt="Please click below" /></a>
                                               </td>
                                               <td>                                                    
                                                   <a href="Title.aspx"><img src="images/next_button_1.png" style="border-color:White" alt="Please click below" /></a>
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
