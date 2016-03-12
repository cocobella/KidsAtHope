<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Welcome2.aspx.cs" Inherits="TimeTraveler.Welcome2" %>
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
                            <table>           
                            <tr>  
                            <td style="width:700px">               
                            <asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Names="Bradley Hand ITC" Font-Size="XX-Large" ForeColor="#ff9601"></asp:Label><br /><br /><br />
                            <font style="font-size:135%" color="#FA58AC" >You are about to go on a wonderful adventure into the future. We call that Time Travel.</font><br /><br />
                            <font style="font-size:135%" color="#FA58AC" >Every kid can learn to Time Travel!Time Travel is using your imagination to think about what you would like to be, do, and try in the future.</font><br /><br />
                            <font style="font-size:135%" color="#FA58AC" >When you think about what you want to be or do when you grow up, you are Time Traveling.</font><br /><br />
                            <font style="font-size:135%" color="#FA58AC" >Have you ever thought about what your want to be when you grow up?</font><br /><br />
                            <font style="font-size:135%" color="#FA58AC" >How about what kind of family you want? Who do you want to help when you are an adult? And what kind of things would you like to do for fun when you’re an adult that you may not be able to do now?</font><br /><br />
                            <font style="font-size:135%" color="#FA58AC" >Think about that and let’s start Time Traveling!</font><br /><br />
                            </td>
                            <td>
                            <img src="images/tt_image_front_2.png" style="border-color:White" alt="Please click below" />
                            </td>
                            </tr>
                            </table>
                            <center><a href="Destination1.aspx"><img src="images/Button1.JPG" alt="Please click"/></a></center>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
