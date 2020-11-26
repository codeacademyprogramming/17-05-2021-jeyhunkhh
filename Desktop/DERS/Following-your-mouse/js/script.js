let btn = document.querySelector(".btn");
let follow = document.querySelector(".follow");

btn.addEventListener("mousemove", function (e) {
  e.preventDefault();
  follow.classList.remove("d-none");
  follow.style.position = "absolute";
  follow.style.left = `${e.offsetX+10}px`;
  follow.style.top = `${e.offsetY+10}px`;
});

btn.addEventListener("mouseout", function () {
  follow.classList.add("d-none");
});
