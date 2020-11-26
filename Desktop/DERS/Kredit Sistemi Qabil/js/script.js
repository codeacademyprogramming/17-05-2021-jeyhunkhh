let productPrice = document.querySelector("#product-price");
let creditMonth = document.querySelector("#credit-month");
let creditPercent = document.querySelector("#credit-percent");
let btnCalculatePercent = document.querySelector("#calculate-percent");
let calculateTable = document.querySelector("#calculate-table");

btnCalculatePercent.addEventListener("click", function () {
    calculateTable.innerHTML = "";
    if (productPrice.value == 0 || creditMonth.value == 0) {
        alert("Yazılan məbləğ və ya ay sayı 0-dan ferqli olmalıdır!");        
    } else {
        for (i = 0; i < creditMonth.value; i ++) {
            let trTable = document.createElement("tr");
            trTable.classList.add("table-secondary");

            let tdMonths = document.createElement("td");
            tdMonths.innerText = i + 1;

            let tdDate = document.createElement("td");
            tdDate.innerText = moment().add(i + 1, 'months').calendar();

            

            let percentPrice = (Number(productPrice.value) * Number(creditPercent.value)) / 100;
            let payment = Math.ceil((Number(productPrice.value) + Number(percentPrice)) / Number(creditMonth.value));
            let remainingDebt = Math.floor(Number(productPrice.value) + Number(percentPrice));
                  
            
            if (i == (creditMonth.value - 1)) {
                remainingDebt -= Number(payment) *i;
                payment = Number(remainingDebt);
                remainingDebt -= Number(payment);
            }else{
                remainingDebt -= (Number(payment) * (i + 1));
            };

            let tdPayment = document.createElement("td");
            tdPayment.innerText = payment;

            let tdRemainingDebt = document.createElement("td");
            tdRemainingDebt.innerText = remainingDebt;

            trTable.append(tdMonths);
            trTable.append(tdDate);
            trTable.append(tdPayment);
            trTable.append(tdRemainingDebt);
            calculateTable.append(trTable);


        }
    }


    // creditMonth.value = "";
})
