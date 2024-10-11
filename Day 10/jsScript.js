document.getElementById('username').addEventListener('focusout', function() {
    const usernameInput = document.getElementById('username');
    const username = usernameInput.value;
    const usernameError = document.getElementById('username-error');
    const usernamePattern = /^[a-z]{4,25}$/;

    usernameError.textContent = '';

    if (!username) {
        usernameError.style.color = 'red';
        usernameError.textContent = "Please enter a valid username";
        usernameInput.style.border = '2px solid red';
    } else if (!usernamePattern.test(username)) {
        usernameError.style.color = 'red';
        usernameError.textContent = "Please enter 4-25 lowercase letters";
        usernameInput.style.border = '2px solid red';
    } else {
        usernameInput.style.border = '2px solid green';
    }
});

document.getElementById('password').addEventListener('focusout', function() {
    const passwordInput = document.getElementById('password');
    const password = passwordInput.value;
    const passwordError = document.getElementById('password-error');
    const uppercasePattern = /[A-Z]/;
    const lowercasePattern = /[a-z]/;
    const numberPattern = /[0-9]/;
    const specialCharacterPattern = /[!@#$%^&*(),.?":{}|<>]/;

    passwordError.textContent = '';

    if (password.trim() === "") {
        passwordInput.style.border = '2px solid red';
        passwordError.style.color = 'red';
        passwordError.textContent = "Password cannot be empty";
    } else if (!uppercasePattern.test(password)) {
        passwordInput.style.border = '2px solid red';
        passwordError.style.color = 'red';
        passwordError.textContent = "Password should have at least one uppercase letter";
    } else if (!lowercasePattern.test(password)) {
        passwordInput.style.border = '2px solid red';
        passwordError.style.color = 'red';
        passwordError.textContent = "Password should have at least one lowercase letter";
    } else if (!numberPattern.test(password)) {
        passwordInput.style.border = '2px solid red';
        passwordError.style.color = 'red';
        passwordError.textContent = "Password should have at least one number";
    } else if (!specialCharacterPattern.test(password)) {
        passwordInput.style.border = '2px solid red';
        passwordError.style.color = 'red';
        passwordError.textContent = "Password should have at least one special character";
    } else {
        passwordError.textContent = '';
        passwordInput.style.border = '2px solid green';
    }
});