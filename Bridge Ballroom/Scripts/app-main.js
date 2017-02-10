$(document).ready(function() {

    $(".register-button").click(function (e) {

       var user = $("#userName");
        var password = $("#password");
        var confirmPassword = $("#confirm-password");

        if (user.val() === "") {
            $(".error-message1").css("visibility", "visible");
            $(".register-form div:first-child input").addClass("invalid-box");
        }
        if (password.val() === "") {
            $(".error-message2").css("visibility", "visible");
            $(".register-form div:nth(1) input").addClass("invalid-box");
        }
        if (password.val() !== confirmPassword.val()) {
            $(".error-message3").css("visibility", "visible");
            $(".register-form div:nth(2) input").addClass("invalid-box");        }

      if (isFormValid(user, password, confirmPassword) == false) {
           e.preventDefault();
        }
    });
    $("input").keyup(function () {
       if ($(this).val() !== "") {
            $(this).removeClass("invalid-box");
            $(this).next().css("visibility", "hidden");
        }
    });


});

function isFormValid(user, password, confirmPassword) {

    if (user.val() !== "" && password.val() !== "" && (password.val() === confirmPassword.val())) {
        return true;
    }
    return false;
}