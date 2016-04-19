
$.ajaxSetup({ cache: false });
$(document).ready(function () {

    $("input[type='checkbox']").click(function () {
        if (document.querySelectorAll("input[type='checkbox']:checked").length >= 5) {
            $("#btnLetsGoI").removeClass("disabled");
            
        } else {
            $("#btnLetsGoI").addClass("disabled");
        }
    });

    $("#btnLetsGo, #btnFamilyGo").click(function (event) {
        var selection = getItem();
        var otherText = getOtherText();
        if (selection == "other") {
            if (otherText.length > 0) {
                $(".vidText").hide();
                $(".vidVideo").hide();
            } else { //don't let them leave with blank other box if other is option picked
                event.preventDefault();
                return false;
            }
        } else {
            $(".vidText").show();
            $(".vidVideo").show();
            if (selection == null) { //make sure they have something selected
                event.preventDefault();
                return false;
            }
        }
    });

    
    $("#btnWelcomeGo").click(function () {
        window.location = "/Home/HomeType";
    });

    $("#btnEduCarGo").click(function () {
        window.location = "/Home/EducationType";
    });

    $("#btnTimeGo").click(function () {
        window.location = "/Home/HowWasYourVisit";
    });

    $("#btnHowGo").click(function () {
        window.location = "/";
    });

    $("input[type='radio']").click(function () {
        if ($("#optOther").is(':checked')) {
            $("#otherText").removeClass("hidden");
        } else {
            $("#otherText").addClass("hidden");
        }
    });

    
    $("#homeSubmit").click(function () {
        $.ajax({
            type: "POST",
            url: "/Home/HomeType",
            data: JSON.stringify({ whereLive: getItem() }),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            },
            error: function (x, y, z) {
                var w = 1;
            }
            
        });
    });

    $("#familySubmit").click(function () {
        $.ajax({
            type: "POST",
            url: "/Home/FamilyType",
            data: JSON.stringify({ familyType: getItem() }),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });

    $("#educationSubmit").click(function () {
        $.ajax({
            type: "POST",
            url: "/Home/EducationType",
            data: JSON.stringify({ education: getItem() }),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });
    

    $("#careerSubmit").click(function () {
        $.ajax({
            type: "POST",
            url: "/Home/CareerType",
            data: JSON.stringify({ 
                selection: getItem(), 
                othertext: getOtherText() 
            }),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });
           
    $("#commSubmit").click(function () {
        $.ajax({
            type: "POST",
            url: "/Home/CommunityAndServiceType",
            data: JSON.stringify(
                {
                    selection: getItem(),
                    othertext: getOtherText()
                }),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });

    $("#hobbySubmit").click(function () {
        $.ajax({
            type: "POST",
            url: "/Home/HobbiesAndRecreationType",
            data: JSON.stringify(
                {
                    selection: getItem(),
                    othertext: getOtherText()
                }),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });

   $("#interestSubmit").click(function () {
        $.ajax({
            type: "POST",
            url: "/Home/Interests",
            data: JSON.stringify({ interest: getInterests() }),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location =data.url;
            }
        });
    });
   


});

    function getInterests(){
        var interests=[];
        $("input:checked").each(function (i) {
            interests[i] = $(this).val();
        });
        return interests;
    }

    function getItem() {
        var i;
        i = $("input:checked").val();
        return i;
    }

    function getOtherText() {
        var txt;
        txt = $("#otherText").val();
        return txt;
    }

