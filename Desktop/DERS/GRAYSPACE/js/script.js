let navbar = document.querySelector("#navbar")
let navStart = document.querySelectorAll("#navbar a")
let navEnd = document.querySelectorAll("#navbar .navbar-nav a")


window.addEventListener("scroll", function(){
    if(window.scrollY>100) {
        navbar.classList.add("onscroll")
        navStart.forEach(element => {
            element.classList.add("text-color")
    });
    }else{
        navbar.classList.remove("onscroll")
        navStart.forEach(elem => {
            elem.classList.remove("text-color")
    });
    }
    if(window.scrollY>400){
        navEnd[0].classList.add("scroll-active")
        navEnd[1].classList.remove("scroll-active")
    }else{
        navEnd[0].classList.remove("scroll-active")
    }
    if(window.scrollY>805){
        navEnd[0].classList.remove("scroll-active")
        navEnd[1].classList.add("scroll-active")
        navEnd[2].classList.remove("scroll-active")
    }
    if(window.scrollY>2800){
        navEnd[1].classList.remove("scroll-active")
        navEnd[2].classList.add("scroll-active")
    }
});