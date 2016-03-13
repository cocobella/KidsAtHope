
$(document).ready(function () {
    $('#btnLetsGo').click(function () {
        $('#letsGoModal').modal('show');
    });


    $('#interestForm :checkbox').click(function () {
        if (document.querySelectorAll('input[type="checkbox"]:checked').length >= 5) {
            $("btnGo").removeClass("disabled");
        } else {
            $("btnGo").addClass("disabled");
        }
    });

});
