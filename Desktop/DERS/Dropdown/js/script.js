let myDropdownMenu = document.querySelector("#my-dropdown-menu");

let myDropdown = document.querySelector("#my-dropdown");

myDropdown.addEventListener("mouseover", function () {
    myDropdownMenu.classList.add("hover");
})

myDropdown.addEventListener("mouseout", function () {
    myDropdownMenu.classList.remove("hover");
})