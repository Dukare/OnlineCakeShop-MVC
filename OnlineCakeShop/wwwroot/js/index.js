console.clear();

const loginBtn = document.getElementById('login');
const signupBtn = document.getElementById('signup');
const nameInput = document.getElementById('nameInput');
const emailInput = document.getElementById('emailInput');
const passinput = document.getElementById('passinput');
const emailInput2 = document.getElementById('emailInput2');
const passinput2 = document.getElementById('passinput2');
const signUPBtn = document.getElementById('SignUpButton');
const signINBtn = document.getElementById('SignInButton');

loginBtn.addEventListener('click', (e) => {
	let parent = e.target.parentNode.parentNode;
	Array.from(e.target.parentNode.parentNode.classList).find((element) => {
		if (element !== "slide-up") {
			parent.classList.add('slide-up')
		} else {
			signupBtn.parentNode.classList.add('slide-up')
			parent.classList.remove('slide-up')
		}
	});
});

signupBtn.addEventListener('click', (e) => {
	let parent = e.target.parentNode;
	Array.from(e.target.parentNode.classList).find((element) => {
		if (element !== "slide-up") {
			parent.classList.add('slide-up')
		} else {
			loginBtn.parentNode.parentNode.classList.add('slide-up')
			parent.classList.remove('slide-up')
		}
	});
});

//nameInput.addEventListener('change', (e) => {
//	if (!(nameInput.value != null && nameInput.value.length >= 4)) {
//		alert('Name should contain at least 4 characters');
//		return;
//	}
//});

//emailInput.addEventListener('change', (e) => {
//	if (!(emailInput.value != null && emailInput.value != undefined && checkEmail(emailInput.value))) {
//		alert('Email is not in correct format');
//		return;
//	}
//});

//passinput.addEventListener('change', (e) => {
//	if (!(passinput.value != null && passinput.value != undefined && checkPass(passinput.value))) {
//		alert('Password Should contain atleast 6 characters');
//		return;
//	}
//});
signUPBtn.addEventListener('click', (e) => {
	debugger;


	
	
	
	alert('All Clear!');
});


 function checkEmail( email)
{
	return email.match(
		/^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
	);
}
function checkPass(pass)
{
	if (pass.length > 6) {
		return true;
	}
	else {
		return false;
	}
}

signINBtn.addEventListener('click', (e) => {
	
	if (!(emailInput2.value != null && emailInput2.value != undefined && checkEmail(emailInput2.value))) {
		alert('Email is not in correct format');
		return;
	}
	if (!(passinput2.value != null && passinput2.value != undefined && checkPass(passinput2.value))) {
		alert('Password Should contain atleast 6 characters');
		return;
	}
	alert('All Clear!');
});


	