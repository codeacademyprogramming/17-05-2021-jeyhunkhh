let form = document.querySelector("#form");
let addEntry = document.querySelector(".add-entry");
let workExperience = document.querySelector(".work-experience");


addEntry.addEventListener("click", function (e) {
  e.preventDefault();
  
  let formClone = form.cloneNode(true);
  formClone.classList.remove("d-none");
  workExperience.prepend(formClone);

  formClone.addEventListener("submit", function (e) {
    e.preventDefault();
    this.remove();
  });
});
