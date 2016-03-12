<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Welcome.aspx.cs" Inherits="TimeTraveler.js.Welcome" %>


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
                                            <strong><font style="font-size:400%; font-family:Bradley Hand ITC" color="#ff9601">Welcome to the Time Machine!</font></strong>
                                             <br />
                                             <br />
                                         </div>
                                        <div>
                                        <table>
                                        <tr>
                                        <td style="width:650px">
                                        <br />
                                        <font style="font-size:150%" color="#F8E0E0" >I am the Time Traveler and I will guide you to your future.</font><br />                                        
                                        <font style="font-size:150%" color="#F8E0E0" >They call me the Time Traveler because I take students like</font><br />
                                        <font style="font-size:150%" color="#F8E0E0" >you into the future so you can come back to the present and</font><br />
                                        <font style="font-size:150%" color="#F8E0E0" >prepare for your journey of a lifetime!</font><br /><br /><br />
                                        <font style="font-size:150%" color="#F8E0E0" >Are you Ready?</font><br /><br />
                                        <font style="font-size:150%" color="#F8E0E0" >Let's Go!</font><br /><br />
                                        <font style="font-size:125%;margin-left:75px" color="#F8E0E0" ><b>Please enter in your name and grade.</b></font><br />
                                        <br />
                                        <div style="margin-left:100px">
                                            <table>
                                                <tr>
                                                    <td style="width:100px">
                                                        <font style="font-size:125%" color="#F8E0E0" >First Name:</font><br />
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                                        <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="txtName" errormessage="Please enter your name!" ForeColor="White" />

                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <font style="font-size:125%" color="#F8E0E0" >Grade:</font><br />
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="gradeDrop" runat="server"></asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="gradeDrop" ErrorMessage="Select a Grade" ForeColor="White"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <br />
                                                        <asp:ImageButton id="imagebutton1" runat="server"
                                                        AlternateText="ImageButton 1"
                                                        ImageUrl="images/next_button_1.png"
                                                        OnClick="ImageButton_Click"/>
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
                                <embed height="1" src="horse.mp3" width="1" /></div>                        
                        </div>
                    </div>
                </div>
            </div>                 
        </div>
    </section>
</asp:Content>
