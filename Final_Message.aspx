<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Final_Message.aspx.cs" Inherits="TimeTraveler.js.Final_Message" %>

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
                                            <strong><font style="font-size:400%; font-family:Bradley Hand ITC" color="#ff9601">How was your visit to the future?</font></strong>
                                             <br />
                                             <br />
                                         </div>
                                        <div>
                                        <table>
                                        <tr>
                                        <td style="width:650px">
                                        <br />
                                        <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="150%" ForeColor="#ff9601"></asp:Label>
                                        <font style="font-size:150%" color="#E3609D" >, you have been on a pretty exciting adventure with the Time </font><br />
                                        <font style="font-size:150%" color="#E3609D" >Traveler visiting your future in Home & Family; Education & Career, </font><br />
                                        <font style="font-size:150%" color="#E3609D" >Community & Service and Hobbies & Recreation!</font><br /><br />  
                                        <font style="font-size:150%" color="#DA6D32" >You learned it is important to have goals at all the destinations, but it is</font><br />
                                        <font style="font-size:150%" color="#DA6D32" >OK to change those goals along the way as long as you always have  </font><br />  
                                        <font style="font-size:150%" color="#DA6D32" >goals and dreams to look forward to.</font><br /><br />  
                                        <font style="font-size:150%" color="#2BBDB3" >You will be successful and happy in whatever you choose as long as you  </font><br />  
                                        <font style="font-size:150%" color="#2BBDB3" >try your hardest to make it happen.</font><br /><br />
                                        <font style="font-size:150%" color="#2B74BD" >Because at Kids at Hope we believe that ALL CHILDREN ARE CAPABLE OF SUCCESS, NO EXCEPTIONS!</font><br /><br />
                                        <font style="font-size:150%" color="#CEDA32" >Have Fun and Thanks for Time Traveling!</font><br /> 
                                        
                                        <font style="font-size:150%" color="#CEDA32" >Click Next to get a summary of your journey today!</font><br />                                                                              
                                  
                                        <br /><br />
                                        <div style="margin-left:100px">
                                            <table>
                                            <tr>
                                               <td style="margin-left:10px;width:850px" >
                                                   <a href="Hobbies_Message.aspx"><img src="images/Back_button.JPG" style="border-color:White" alt="Please click below" /></a>
                                               </td>
                                               <td>
                                                   <a href="Summary.aspx"><img src="images/next_button_1.png" style="border-color:White" alt="Please click below" /></a>
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
