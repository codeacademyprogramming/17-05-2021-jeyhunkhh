let smallPhoto = document.querySelectorAll("#gallery .photo a");
let largePhoto = document.querySelector("#gallery .photo-show");

smallPhoto.forEach((elem) => {
    elem.addEventListener("click", function(e) {
        e.preventDefault();

        document.querySelector("#gallery .photo a img.active").classList.remove("active");

        elem.children[0].classList.add("active");
        let img = elem.getAttribute("href");
        largePhoto.children[0].setAttribute("src", img)
    });
});

