// // butun melumatları sıfırlayır
// localStorage.clear();

// // key-ə görə məlumatı qaytarır->string
// localStorage.getItem("key")

// // index-ə görə məlumatı qaytarır->string
// localStorage.key(1)

// // məlumat sayını qaytarır
// localStorage.length;

// // key-ə görə məlumatı silir
// localStorage.removeItem("key");

// // key value məlumatı verirsiniz, onu saxlayır
// localStorage.setItem("key","value");


var addToBasketBtn = document.querySelectorAll(".add-to-basket");
var cartCount = document.querySelector(".cart-count");
var cartItems = document.querySelector(".cart-items");

addToBasketBtn.forEach(elem => {
    elem.addEventListener("click", function (e) {
        e.preventDefault();

        let basket = JSON.parse(localStorage.getItem("basket"));

        if (basket == null) {
            basket = {
                items: [],
                count: 0,
                total: 0
            };
        }

        let prudoctId = this.dataset.id;

        let index = basket.items.findIndex((item) => {
            return item.id == prudoctId;
        });

        if (index == -1) {
            let product = {
                id: this.dataset.id,
                price: parseFloat(this.previousElementSibling.innerText),
                name: this.parentNode.children[0].innerText,
                image: this.parentNode.previousElementSibling.getAttribute("src"),
                qty: 1
            };
           

            basket.items.push(product);
        } else {
            basket.items[index].qty++;
        }

        basket = calcTotalAndCount(basket);

        if (cartCount != null)
            cartCount.innerText = basket.count;


        localStorage.setItem("basket", JSON.stringify(basket));
    });
});

let basket = JSON.parse(localStorage.getItem("basket"));

if (basket != null && cartCount != null) {
    cartCount.innerText = basket.count;
}

if(basket!=null && cartItems!=null){

    basket.items.forEach((item,index)=>{
        let td = `<td class="col-sm-8 col-md-6">
                    <div class="media">
                        <a class="thumbnail pull-left" href="#"> 
                            <img class="media-object" src="${item.image}" style="width: 72px; height: 72px;">
                        </a>
                        <div class="media-body ml-2">
                            <h4 class="media-heading"><a href="#">${item.name}</a></h4>
                        </div>
                    </div></td>
                    <td class="col-sm-1 col-md-1" style="text-align: center">
                    <input type="email" class="form-control" id="exampleInputEmail1" value="${item.qty}">
                    </td>
                    <td class="col-sm-1 col-md-1 text-center"><strong>${item.price} ₼</strong></td>
                    <td class="col-sm-1 col-md-1 text-center"><strong>${item.price*item.qty} ₼</strong></td>
                    <td class="col-sm-1 col-md-1">
                        <button type="button" class="btn btn-danger remote-from-basket" data-id="${item.id}">
                            <span class="glyphicon glyphicon-remove"></span> Remove
                        </button>
                    </td>`;
        
        let tr = document.createElement('tr');
        tr.dataset.index = index;
        tr.innerHTML = td;

        cartItems.prepend(tr);
    });
}


var removeBtns = document.querySelectorAll(".remote-from-basket");

removeBtns.forEach(item=>{
    item.addEventListener("click",function(){
        let index = item.parentNode.parentNode.dataset.index;
        basket.items.splice(index,1);
        item.parentNode.parentNode.remove();
        
        basket = calcTotalAndCount(basket);
        localStorage.setItem("basket", JSON.stringify(basket));
    });
})

function calcTotalAndCount(basket) {
    basket.count = 0;
    basket.total = 0;
    basket.items.forEach(item => {
        basket.total += (item.qty * item.price);
        basket.count++;
    });

    return basket;
}