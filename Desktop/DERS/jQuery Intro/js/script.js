// let cities = document.querySelectorAll(".cities li");

// cities.forEach(elem => {
//     elem.addEventListener("click", function () {
//         this.classList.toggle("active");
//     });
// })

// $(".cities li").click(function () {
//     $(this).toggleClass("active");
// });

// events
// $(".cities li").click(function () {
//     $(this).toggleClass("active");
// });

// $("#fullname").on("input", function () {
//     $(".review").text($(this).val());

//     // $(".review").attr("title", "attribute setted");
//     // console.log($(".review").attr("title"));

//     // if ($(".review").attr("title") == undefined) {
//     //     console.log("title yoxdu");
//     // }
//     // $(".review").removeAttr("title");
//     // $(".review").data("id", 12);
//     // console.log($(".review").data("id"));

//     // $(this).removeClass("form-control").addClass("input-control");

//     // this.style.borderTop = "1px solid red";

//     // $(this).css("border-top", "1px solid red").css("border-bottom", "1px solid red");

//     // $(this).css({
//     //     "border-top": "1px solid #80bdff",
//     //     "border-bottom": "1px solid #80bdff",
//     //     "border-radius": "0px"
//     // });

//     // $(this).parents(".row").addClass("border")
//     // $(this).parentsUntil(".row").addClass("border");

//     // $(this).nextAll().addClass("border");

//     // console.log($(this).siblings("p,label"));

//     // console.log($(".form-group").children().eq(2));

//     // document.querySelector(".form-group").append("<p>salam</p>");

//     // $(".form-group").append("<p>salam</p>");

//     let text = $("<p></p>").text($(this).val());
//     text.click(function () {
//         $(this).remove();
//     });



//     $(".form-group").append(text);
// });

// Content
// .innerText -> .text()-get .text('salam')-set
// .innerHTML -> .html()-get .html('salam')-set
// .value -> .val()-get .val(12)-set

// attribute
// .setAttribute(name,value) -> .attr(name,value)
// .getAttribute(name) -> .attr(name)
// .hasAttribute(name) -> .attr(name)
// .removeAttribute(name) -> .removeAttr(name)

// dataSet
// .dataset.name = "Yolchu"-set -> .data(name,value)
// .dataset.name - get -> .data(name)

// classList
// .classList.add(name,value) -> .addClass(name,value)
// .classList.remove(name) -> .removeClass(name)
// .classList.toggle(name) -> .toggleClass(name)
// .classList.contains(name) -> .hasClass(name)
// .classList.replace(old,new) -> .removeClass(old).addClass(new)

// style
// .style.properyName = value -> .css("property-name",value) 

// navigation
// .parentNode -> .parent()
// .nextElementSibling -> .next()
// .prevoisElementSibling -> .prev()
// .childiren -> .childiren(), .find

// node

// .append() -> append()
// .prepend() -> .prepend()
// .after() -> .after()
// .before() -> .before()
// .remove() -> .remove()
// .removeChild() 


$("#city-form").submit(function (e) {
    e.preventDefault();
    let cityName = $("#city-name").val();
   

    if (!checkName(cityName)) {
        alert("seher adi artiq var");
        return;
    }

    let li = $(`<li class="list-group-item d-flex justify-content-between">
                   <span>${cityName}</span>
                   <i class="fas fa-trash-alt text-danger"></i>
                </li>`);
    $(".cities").append(li);

    $("#city-name").val("");
});

$(document).on("click", ".cities li i", function () {
    $(this).parent().remove();
});

function checkName(name) {
    let r = true;

    $(".cities li span").each(function (index, elem) {
        if (name == $(elem).text()) {
            r = false;
        }
    });

    return r;
}