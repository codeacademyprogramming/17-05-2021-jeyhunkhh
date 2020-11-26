let btn = document.querySelector('#create-user');
let nameInput = document.querySelector("#Name");
let surnameInput = document.querySelector("#Surname");
let emailInput = document.querySelector("#Password");
let passInput = document.querySelector("#Email");
let tableBody = document.querySelector("tbody");
class User {
    constructor(name, surname, email, password) {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.password = password
    }
};
let users = [];

if (JSON.parse(localStorage.getItem("users")) != null) {
    users = JSON.parse(localStorage.getItem("users"));
    fillTable();
}


btn.addEventListener("click", function(e) {
    e.preventDefault();

    if (nameInput.value.trim() == "" || surnameInput.value.trim() == "" || emailInput.value.trim() == "" || passInput.value.trim() == "") {
        console.log("Null");
        return;
    };
    if (!isNaN(parseFloat(nameInput.value))) {
        console.log("number");
        return;
    }
    if (checkUnique(users, emailInput.value.trim()) == -1) {
        alert("must be unique email");
        clearInput();
        return;
    };
    let newUser = new User(nameInput.value.trim(), surnameInput.value.trim(), emailInput.value.trim(), passInput.value.trim());
    users.push(newUser);
    localStorage.setItem("users", JSON.stringify(users));
    fillTable();
    clearInput();
});

function checkUnique(arr, email) {
    for (let i = 0; i < arr.length; i++) {

        if (arr[i].email == email) {
            if (i == arr.length - 1) {
                return 0;
            };
            return -1;
        }
        return 0
    };
};




function clearInput() {
    nameInput.value = "";
    surnameInput.value = "";
    emailInput.value = "";
    passInput.value = "";
};

function fillTable() {
    tableBody.innerHTML = "";
    users = JSON.parse(localStorage.getItem("users"));
    users.forEach(element => {
        let tr = document.createElement("tr");
        let nameTd = document.createElement("td");
        let surnameTd = document.createElement("td");
        let emailTd = document.createElement("td");
        let passwordTd = document.createElement("td");
        let trash = document.createElement("td");
        let deletebtn = document.createElement("a");
        deletebtn.setAttribute("href", "#");
        let icon = document.createElement("i");
        icon.className = "fas fa-trash text-danger";
        trash.append(deletebtn);
        deletebtn.append(icon);
        nameTd.innerText = element.name;
        surnameTd.innerText = element.surname;
        emailTd.innerText = element.email;
        passwordTd.innerText = element.password;
        tableBody.append(tr);
        tr.append(nameTd);
        tr.append(surnameTd);
        tr.append(emailTd);
        tr.append(passwordTd);
        tr.append(trash);
        deletebtn.addEventListener("click", function() {
            this.parentElement.parentElement.remove();
            users.splice(users.indexOf(element), 1);
            console.log(users)
            if (users.length == 0) {
                localStorage.removeItem("users");
                return;
            }
            localStorage.setItem("users", JSON.stringify(users));

        })

    });

}