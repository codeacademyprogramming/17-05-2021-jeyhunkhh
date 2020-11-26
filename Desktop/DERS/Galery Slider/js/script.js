let imageItems = document.querySelectorAll(".product-slider .images a");
let baseImage = document.querySelector(".product-slider .base-image a");

let popup = document.querySelector(".popup");
let popupImage = document.querySelector(".popup .content img");
let popupCloseIcon = document.querySelector(".popup .content .close-model")

imageItems.forEach((elem) => {
    elem.addEventListener("click", function (e) {
        e.preventDefault();

        if (this.classList.contains("active")) {
            return;
        }

        document.querySelector(".product-slider .images a.active").classList.remove("active");

        this.classList.add("active");

        let img = this.getAttribute("href");

        baseImage.children[0].setAttribute("src", img);
    });
});


baseImage.addEventListener("click", function (e) {
    e.preventDefault();
    let image = baseImage.children[0].getAttribute("src");

    popupImage.setAttribute("src", image);

    popup.classList.add("opened");
});


popupCloseIcon.addEventListener("click", function () {
    closePopup();
});

popup.addEventListener("click", function (e) {
    if (e.target.classList.contains("popup")) {
        closePopup();
    }
});

function closePopup() {
    popup.classList.remove("opened");
}