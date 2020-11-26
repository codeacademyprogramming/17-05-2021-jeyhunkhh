let canvasBtn = document.querySelector("#canvas-btn");

let canvasMenu = document.querySelector("#menu-canvas");

let canvasMenuUl = document.querySelector("#canvas-menu");

let iconBtn = document.querySelector("#icon-button");

canvasBtn.addEventListener("click", function () {
    canvasMenu.classList.add("active");
    canvasMenuUl.classList.add("active");

});

iconBtn.addEventListener("click", function () {
    canvasMenu.classList.remove("active");
    canvasMenuUl.classList.remove("active");
});
