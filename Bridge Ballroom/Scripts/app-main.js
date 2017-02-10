$(document).ready(function() {

    $(".register-button").click(function (e) {

       var user = $("#userName");
        var password = $("#password");
        var confirmPassword = $("#confirm-password");

        if (user.val() === "") {
           
            $(".error-message1").css("visibility", "visible");
            
        }
        if (password.val() === "") {

            $(".error-message2").css("visibility", "visible");
           
        }
        if (password.val() !== confirmPassword.val()) {

            $(".error-message3").css("visibility", "visible");
        }

      if (isFormValid(user, password, confirmPassword) == false) {
            alert(user.val());
            alert(password.val());
            alert(confirmPassword.val());
            e.preventDefault();
        }
    });
});

function isFormValid(user, password, confirmPassword) {

    if (user.val() !== "" && password.val() !== "" && (password.val() === confirmPassword.val())) {
        return true;
    }
    return false;
}