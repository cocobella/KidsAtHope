﻿
$(document).ready(function () {

    $('#interestForm :checkbox').click(function () {
        if (document.querySelectorAll('input[type="checkbox"]:checked').length >= 5) {
            $("btnGo").removeClass("disabled");
        } else {
            $("btnGo").addClass("disabled");
        }
    });

    
    $('#btnWelcomeGo').click(function () {
        $.ajax({
            type: "POST",
            url: '/Home/HomeType',
            data: {},
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
        

    $('input[name="whereLive"]').click(function () {

        var span = document.getElementById('modalHomeChoice');
        var theOption = $('input[name="whereLive"]:checked').val();

        switch (theOption) {
            case "downtown":
                span.innerHTML = "downtown";
                $("#modalHomeVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_1/downtown.mp4");
                break;
            case "mountain":
                span.innerHTML = "in the mountains";
                $("#modalHomeVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_1/mountain.mp4");
                break;
            case "ranch":
                span.innerHTML = "on a ranch";
                $("#modalHomeVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_1/ranch.mp4");
                break;
            case "ocean":
                span.innerHTML = "by the ocean";
                $("#modalHomeVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_1/ocean.mp4");
                break;
            case "snow":
                span.innerHTML = "where it snows";
                $("#modalHomeVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_1/snow.mp4");
                break;
            case "suburb":
                span.innerHTML = "in the suburb";
                $("#modalHomeVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_1/suburb.mp4");
                break;
        }

    });

});


    function getInterests(){
        var interests=[];
        $('input:checked').each(function (i) {
            interests[i] = $(this).val();
        });
        return interests
    }



