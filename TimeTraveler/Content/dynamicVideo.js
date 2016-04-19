/// <reference path="dynamicVideo.js" />

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

    $('input[name="service"]').click(function () {

        var span = document.getElementById('modalServiceChoice');
        var theOption = $('input[name="service"]:checked').val();

        switch (theOption) {
            case "animals":
                span.innerHTML = "helping animals";
                $("#modalServiceVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_3/animal.mp4");
                break;
            case "children":
                span.innerHTML = "mentoring other children";
                $("#modalServiceVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_3/mentor.mp4");
                break;
            case "coach":
                span.innerHTML = "being a coach";
                $("#modalServiceVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_3/coach.mp4");
                break;
            case "environment":
                span.innerHTML = "protecting the environment";
                $("#modalServiceVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_3/environment.mp4");
                break;
            case "graffiti":
                span.innerHTML = "cleaning up the graffiti";
                $("#modalServiceVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_3/graffiti.mp4");
                break;
            case "homeless":
                span.innerHTML = "helping out at a homeless shelter";
                $("#modalServiceVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_3/homeless.mp4");
                break;
        }

    });

    $('input[name="hobby"]').click(function () {

        var span = document.getElementById('modalHobbyChoice');
        var theOption = $('input[name="hobby"]:checked').val();

        switch (theOption) {
            case "hiking":
                span.innerHTML = "go hiking";
                $("#modalHobbyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_4/hiking.mp4");
                break;
            case "music":
                span.innerHTML = "play an instrument";
                $("#modalHobbyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_4/music.mp4");
                break;
            case "photo":
                span.innerHTML = "take photographs";
                $("#modalHobbyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_4/photo.mp4");
                break;
            case "sport":
                span.innerHTML = "play sports";
                $("#modalHobbyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_4/sport.mp4");
                break;
            case "travel":
                span.innerHTML = "see the world";
                $("#modalHobbyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_4/travel.mp4");
                break;
            case "water":
                span.innerHTML = "play water sports";
                $("#modalHobbyVideo").attr("src", "http://www.thetimetravelerapp.com/video/dest_4/watersports.mp4");
                break;
        }

    });
});
