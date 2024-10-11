$(document).ready(function() {

    $('#login-btn').prop('disabled',true);
    let isValidusername = false;
    let isValidpassword = false;

    $('#username').on('focusout',function(){
        const usernameInput = $('#username');
        const username = $('#username').val();
        const usernameError = $('#username-error');
        const usernamePattern = /^[a-z]{4,25}$/;

        usernameError.text('')
        isValidusername = false;
        $('#login-btn').prop('disabled',true);
        if(!username){
            usernameError.css('color','red').text("please enter a valid username");
            usernameInput.css('border','2px solid red');
            return;
        }
        else if(!usernamePattern.test(username)){
            usernameError.css('color','red').text("please enter 4-25 lowercase letter");
            usernameInput.css('border','2px solid red');
            return;
        }
        else{
            isValidusername = true;
            usernameInput.css('border','2px solid green');
        }
        toggleLoginButton();
    });

    $('#password').on('focusout',function() {
        const password = $(this).val();
        const passwordError = $('#password-error');
        const uppercasePattern = /[A-Z]/;
        const lowercasePattern = /[a-z]/;
        const numberPattern = /[0-9]/;
        const specialCharacterPattern = /[!@#$%^&*(),.?":{}|<>]/;
        
        passwordError.text('');
        $('#login-btn').prop('disabled',true);
        
        isValidpassword = false;
        if(!password){
            $(this).css('border',' 2px solid red ');
            passwordError.css('color', 'red').text("Password cannot be empty");

        } else if (!uppercasePattern.test(password)) {
            $(this).css('border', '2px solid red');
            passwordError.css('color', 'red').text("Password should have at least one uppercase letter");

        } else if (!lowercasePattern.test(password)) {
            $(this).css('border', '2px solid red');
            passwordError.css('color', 'red').text("Password should have at least one lowercase letter");

        } else if (!numberPattern.test(password)) {
            $(this).css('border', '2px solid red');
            passwordError.css('color', 'red').text("Password should have at least one number");

        } else if (!specialCharacterPattern.test(password)) {
            $(this).css('border', '2px solid red');
            passwordError.css('color', 'red').text("Password should have at least one special character");

        } else {
            isValidpassword = true;
            passwordError.text('');
            $(this).css('border', '2px solid green');
        }
        toggleLoginButton();
    });
    function toggleLoginButton() {
        if (isValidpassword && isValidusername){
            $('#login-btn').prop('disabled',false);
        }
    }
});
