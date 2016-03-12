<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Destination1_2.aspx.cs" Inherits="TimeTraveler.Destination1_2" %>
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
                                    color="white">me</font></a> <span><font color="white">traveller</font></span>
                            </h1>
                        </div>
                    </div>
                    <%--<div class="clear">--%>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- content -->
    <br />
    <div style="margin-left:320px">
        <font style="font-size:250%; font-family:Bradley Hand ITC" color="#ff9601"><b>Destination 1: Home and Family continued</b></font>
    </div>
    <section id="content">
        <div class="bg-top">
        	<div class="bg-top-2">
                <div class="bg">
                    <div class="bg-top-shadow">
                        <div class="main">
                            <div class="gallery p3">
                            	<div class="wrapper indent-bot">
                                    <div id="gallery" class="content">
                                       <div class="wrapper">
                                           <div class="slideshow-container">
                                                <div id="slideshow" class="slideshow"></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div id="thumbs" class="navigation">
                                        <ul class="thumbs noscript">
                                            <li>
                                                <a class="thumb" href="images/marriage_family.jpg" title=""> <img src="images/marriage_family_t.jpg" alt="" /><span></span> </a>
                                            </li> 
                                            <li>
                                                <a class="thumb" href="images/mom_pic_family.jpg" title=""> <img src="images/mom_pic_family_t.jpg" alt="" /> <span></span></a>
                                            </li> 
                                            <li>
                                                <a class="thumb" href="images/multi_generation_family.png" title=""> <img src="images/multi_generation_family_t.png" alt="" /> <span></span></a>
                                            </li> 
                                            <li>
                                                <a class="thumb" href="images/single_guys_family.jpg" title=""> <img src="images/single_guys_family_t.jpg" alt="" /> <span></span></a>
                                            </li> 
                                            <li>
                                                <a class="thumb" href="images/single_women_family.jpg" title=""> <img src="images/single_women_family_t.jpg" alt="" /> <span></span></a>
                                            </li> 
                                            <li>
                                                <a class="thumb" href="images/son_father_family.jpg" title=""> <img src="images/son_father_family_t.jpg" alt="" /> <span></span></a>
                                            </li>           
                                        </ul>
                                    </div>
                                </div>
                                <%--<div class="inner">
                                    <div class="wrapper">
                                        <span class="title img-indent3">HELLO!</span>
                                        <div class="extra-wrap indent-top2">
                                        	<strong>Interior Design</strong> is one of <a target="_blank" href="http://blog.templatemonster.com/free-website-templates/ ">free website templates</a> created by TemplateMonster.com team. This website template is opti mized for 1024X768 screen resolution. It is also XHTML &amp; CSS valid. It has several pages: <a class="color-3" href="index.html">About</a>, <a class="color-3" href="services.html">Services</a>, <a class="color-3" href="catalogue.html">Catalogue</a>, <a class="color-3" href="pricing.html">Pricing</a>, <a class="color-3" href="contacts.html">Contact Us</a> (note that contact us form – doesn’t work).
                                        </div>
                                    </div>
                                </div>--%>
                                <font style="font-size:150%" color="#E3609D">Here are some of the options you can begin to think about for your future family life. Choose which one you think would make you happiest.</font>
                               <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatColumns="6">
                                    <asp:ListItem><font style="font-size:100%" color="#2E9AFE">Married</font>&nbsp&nbsp&nbsp</asp:ListItem>
                                    <asp:ListItem><font style="font-size:100%" color="#2E9AFE">Being a Mom</font>&nbsp&nbsp&nbsp</asp:ListItem>
                                    <asp:ListItem><font style="font-size:100%" color="#2E9AFE">Living in a multi-generational household</font>&nbsp&nbsp&nbsp</asp:ListItem>
                                    <asp:ListItem><font style="font-size:100%" color="#2E9AFE">Being a Single Man</font>&nbsp&nbsp&nbsp</asp:ListItem> 
                                    <asp:ListItem><font style="font-size:100%" color="#2E9AFE">Being a Single Woman</font>&nbsp&nbsp&nbsp</asp:ListItem>  
                                    <asp:ListItem><font style="font-size:100%" color="#2E9AFE">Being a Dad</font>&nbsp&nbsp&nbsp</asp:ListItem> 
                                </asp:RadioButtonList>
                                 <div align="right">
                                <asp:RequiredFieldValidator ID="ReqiredFieldValidator1"  runat="server" ControlToValidate="RadioButtonList1" 
                                    ErrorMessage="Select at least one option!" ForeColor="White" Font-Bold="true" Font-Size="X-Large">  
                                </asp:RequiredFieldValidator>  
                                </div>
                                <div>
                                <br />
                                <table>
                                    <tr>
                                        <td style="margin-left:10px;width:850px" >
                                            <a href="Home_Message.aspx"><img src="images/Back_button.JPG" style="border-color:White" alt="Please click below" /></a>
                                        </td>
                                        <td>
                                            <asp:ImageButton ID="ImageButton1" runat="server" 
                                                ImageUrl="images/next_button_1.png" onclick="ImageButton1_Click"></asp:ImageButton>
                                            <%--<a href="Family_Message.aspx"><img src="images/next_button_1.png" style="border-color:White" alt="Please click below" /></a>--%>
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
        <script type="text/javascript">
            $(window).load(function () {
                // We only want these styles applied when javascript is enabled
                $('div.navigation').css({ 'width': '320px', 'float': 'right' });
                $('div.content').css('display', 'block');

                // Initially set opacity on thumbs and add
                // additional styling for hover effect on thumbs
                var onMouseOutOpacity = 0.5;
                $('#thumbs ul.thumbs li span').opacityrollover({
                    mouseOutOpacity: onMouseOutOpacity,
                    mouseOverOpacity: 0.0,
                    fadeSpeed: 'fast',
                    exemptionSelector: '.selected'
                });

                // Initialize Advanced Galleriffic Gallery
                var gallery = $('#thumbs').galleriffic({
                    delay: 7000,
                    numThumbs: 12,
                    preloadAhead: 6,
                    enableTopPager: false,
                    enableBottomPager: false,
                    imageContainerSel: '#slideshow',
                    controlsContainerSel: '',
                    captionContainerSel: '',
                    loadingContainerSel: '',
                    renderSSControls: true,
                    renderNavControls: true,
                    playLinkText: 'Play Slideshow',
                    pauseLinkText: 'Pause Slideshow',
                    prevLinkText: 'Prev',
                    nextLinkText: 'Next',
                    nextPageLinkText: 'Next',
                    prevPageLinkText: 'Prev',
                    enableHistory: true,
                    autoStart: 7000,
                    syncTransitions: true,
                    defaultTransitionDuration: 900,
                    onSlideChange: function (prevIndex, nextIndex) {
                        // 'this' refers to the gallery, which is an extension of $('#thumbs')
                        this.find('ul.thumbs li span')
						.css({ opacity: 0.5 })
                    },
                    onPageTransitionOut: function (callback) {
                        this.find('ul.thumbs li span').css({ display: 'block' });
                    },
                    onPageTransitionIn: function () {
                        this.find('ul.thumbs li span').css({ display: 'none' });
                    }
                });
            });
	</script>
</asp:Content>
