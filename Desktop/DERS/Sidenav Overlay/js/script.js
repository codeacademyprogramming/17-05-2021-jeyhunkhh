let overlayBtn = document.querySelector("#overlay-or-hide");

let overMenuUl = document.querySelector("#over-menu");

let iconBtn = document.querySelector("#icon-button");

overlayBtn.addEventListener("click", function () {
    overMenuUl.classList.add("active");
});

iconBtn.addEventListener("click", function () {
    overMenuUl.classList.remove("active");
});
