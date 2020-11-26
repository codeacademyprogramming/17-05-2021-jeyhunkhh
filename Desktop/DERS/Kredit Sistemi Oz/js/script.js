let producPrice = document.querySelector("#produc-price");
let period = document.querySelector("#period");
let percent = document.querySelector("#percent");
let tableBody = document.querySelector("#table-body");
let formCredit = document.querySelector(".btn");


formCredit.addEventListener("click",function(){
    tableBody.innerHTML = "";
    if(producPrice.value == "" || producPrice.value <= 0){
        alert("Məhsulun dəyərini yazin. 0 və mənfi ədəd yaza bilməzsiz");
        return;
    };

    if(period.value == "" || period.value <= 0){
        alert("Nece ayliq kredit istediyiniz daxil edinş  0 və mənfi ədəd yaza bilməzsiz");
        return;
    };

    if(percent.value == "" || percent.value <= 0){
        alert("Kredit faizini daxil edin.  0 və mənfi ədəd yaza bilməzsiz");
        return;
    };

    let month = Number(1);
    let total = Number(producPrice.value) + producPrice.value*percent.value/100;
    let paid = total/period.value;

    while(month <= period.value){
    total = total - paid;
    let tarix = moment().add(month, "month").format('L'); 
    
    let trData = document.createElement("tr");
    tableBody.append(trData);

    let ayData = document.createElement("td");
    ayData.innerText = month;
    let tarixData = document.createElement("td");
    tarixData.innerText = tarix;
    let paidData = document.createElement("td");
    paidData.innerText = Math.floor(paid);
    let borcData = document.createElement("td");
    borcData.innerText = Math.floor(total);

    trData.append(ayData);
    trData.append(tarixData);
    trData.append(paidData);
    trData.append(borcData);
    console.log(month, tarix, Math.floor(paid), Math.floor(total));
    month ++;
   };

});

