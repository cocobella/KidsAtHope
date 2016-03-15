
$(document).ready(function () {

    $('input[type="checkbox"]').click(function () {
        if (document.querySelectorAll('input[type="checkbox"]:checked').length >= 5) {
            $("#btnLetsGoI").removeClass("disabled");
            
        } else {
            $("#btnLetsGoI").addClass("disabled");
        }
    });

    
    $('#btnWelcomeGo').click(function () {
        window.location = '/Home/HomeType';
    });

    $('#btnEduCarGo').click(function () {
        window.location = '/Home/EducationType';
    });

    $('#btnTimeGo').click(function () {
        window.location = '/Home/HowWasYourVisit';
    });

    $('#btnHowGo').click(function () {
        window.location = '/';
    });

    
    
    $('#homeSubmit').click(function () {
        $.ajax({
            type: "POST",
            url: '/Home/HomeType',
            data: JSON.stringify(getItem()),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });

    $('#familySubmit').click(function () {
        $.ajax({
            type: "POST",
            url: '/Home/FamilyType',
            data: JSON.stringify(getItem()),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });

    $('#educationSubmit').click(function () {
        $.ajax({
            type: "POST",
            url: '/Home/EducationType',
            data: JSON.stringify(getItem()),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });
    
    $('#careerSubmit').click(function () {
        $.ajax({
            type: "POST",
            url: '/Home/CareerType',
            data: JSON.stringify(getItem()),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });

    
    $('#commSubmit').click(function () {
        $.ajax({
            type: "POST",
            url: '/Home/CommunityAndServiceType',
            data: JSON.stringify(getItem()),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });

    $('#hobbySubmit').click(function () {
        $.ajax({
            type: "POST",
            url: '/Home/HobbiesAndRecreationType',
            data: JSON.stringify(getItem()),
            contentType: "application/json; charset=UTF-8",
            dataType: "json",
            success: function (data) {
                window.location = data.url;
            }
        });
    });

   $('#interestSubmit').click(function () {
        $.ajax({
            type: "POST",
            url: '/Home/Interests',
            data: JSON.stringify(getInterests()),
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
        $('input:checked').each(function (i) {
            interests[i] = $(this).val();
        });
        return interests
    }

    function getItem() {
        var i;
        i = $('input:checked').val();
        return i
    }



