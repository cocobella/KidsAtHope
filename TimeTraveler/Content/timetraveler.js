
$(document).ready(function () {

    $('#interestForm :checkbox').click(function () {
        if (document.querySelectorAll('input[type="checkbox"]:checked').length >= 5) {
            $("btnGo").removeClass("disabled");
        } else {
            $("btnGo").addClass("disabled");
        }
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
