
$(document).ready(function () {

    $('#interestForm :checkbox').click(function () {
        if (document.querySelectorAll('input[type="checkbox"]:checked').length >= 5) {
            $("btnGo").removeClass("disabled");
        } else {
            $("btnGo").addClass("disabled");
        }
    });

    
    $('#btnWelcomeGo').click(function () {
        window.location = '/Home/HomeType';
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



