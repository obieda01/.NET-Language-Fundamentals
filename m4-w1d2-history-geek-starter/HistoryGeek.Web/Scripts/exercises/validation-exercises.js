$(document).ready(function() {
    $("#register").validate({

        debug: true,
        rule: {
            EmailAddress: {
                required: true,
            },
            Password: {
                required: true,
                minlength: 8, //requires at least 8 characters

            },


        }


    });


});