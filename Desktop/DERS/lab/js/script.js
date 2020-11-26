let form = document.querySelector("#form")
let firstName = document.querySelector("#First-name");
let lastName = document.querySelector("#Last-name");
let email = document.querySelector("#Email1");
let password = document.querySelector("#Password1");
let number = 1;
let users = [];


createTable();

form.addEventListener("submit", function(e){
    e.preventDefault();

    if(firstName.value.trim()=="" || lastName.value.trim()=="" || email.value.trim()=="" || password.value.trim()==""){
        alert("bos xana ola bilmez");
    };

    let data = {
        FirstName: firstName.value,
        LastName: lastName.value,
        Email: email.value,
        Password: password.value
    };

    users.push(data);
    localStorage.setItem("Users", JSON.stringify(users));
    
    firstName.value = "";
    lastName.value = "";
    email.value = "";
    password.value = "";
    createTable();
   
});



function createTable(){
    let tBody= document.querySelector(".tbody");
    tBody.innerHTML = "";
    
    for (let i = 0; i < users.length; i++) {
    let tr = document.createElement("tr");

    tr.append(number)

    let tdName = document.createElement("td");
    tdName.innerText = users[i].FirstName;
    tr.append(tdName);
    
    let tdLastName = document.createElement("td");
    tdLastName.innerText = users[i].LastName;
    tr.append(tdLastName);
    
    let tdEmail = document.createElement("td");
    tdEmail.innerText = users[i].Email;
    tr.append(tdEmail);

    let tdPassword = document.createElement("td");
    tdPassword.innerText = users[i].Password;
    tr.append(tdPassword);

    
    tBody.append(tr);
    };
};