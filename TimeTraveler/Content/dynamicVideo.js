
$(document).ready(function () {

   
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


    $('input[name="familyType"]').click(function () {

        var span = document.getElementById('modalFamilyChoice');
        var theOption = $('input[name="familyType"]:checked').val();

        switch (theOption) {
            case "dad":
                span.innerHTML = "to be a father";
                $("#modalFamilyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_2/father.mp4");
                break;
            case "mother":
                span.innerHTML = "to be a mother";
                $("#modalFamilyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_2/mother.mp4");
                break;
            case "married":
                span.innerHTML = "to be married";
                $("#modalFamilyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_2/married.mp4");
                break;
            case "man":
                span.innerHTML = "to be a single man";
                $("#modalFamilyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_2/singlemale.mp4");
                break;
            case "woman":
                span.innerHTML = "to be a single woman";
                $("#modalFamilyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_2/singlewoman.mp4");
                break;
            case "multi":
                span.innerHTML = "to live in a multi-generational house";
                $("#modalFamilyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_1_2/multigenerational.mp4");
                break;
        }

    });

    $('input[name="education"]').click(function () {

        var span = document.getElementById('modalEducationChoice');
        var theOption = $('input[name="education"]:checked').val();

        switch (theOption) {
            case "apprentice":
                span.innerHTML = "to become an apprentice / intern";
                $("#modalEducationVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_1/apprentice.mp4");
                break;
            case "university":
                span.innerHTML = "to attend a University";
                $("#modalEducationVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_1/university.mp4");
                break;
            case "career":
                span.innerHTML = "to attend a Vocational / Career school";
                $("#modalEducationVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_1/careerschool.mp4");
                break;
            case "community":
                span.innerHTML = "to go to Community College";
                $("#modalEducationVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_1/community.mp4");
                break;
            
        }

    });

    $('input[name="career"]').click(function () {

        var span = document.getElementById('modalCareerChoice');
        var theOption = $('input[name="career"]:checked').val();

        switch (theOption) {
            case "athlete":
                span.innerHTML = "an athlete";
                $("#modalCareerVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_2/athlete.mp4");
                break;
            case "business":
                span.innerHTML = "run a business";
                $("#modalCareerVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_2/business.mp4");
                break;
            case "designer":
                span.innerHTML = "a designer";
                $("#modalCareerVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_2/designer.mp4");
                break;
            case "engineer":
                span.innerHTML = "an engineer";
                $("#modalCareerVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_2/engineer.mp4");
                break;
            case "medical":
                span.innerHTML = "a doctor or nurse";
                $("#modalCareerVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_2/medical.mp4");
                break;
            case "teacher":
                span.innerHTML = "a teacher";
                $("#modalCareerVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_2_2/teacher.mp4");
                break;
        }

    });
});
