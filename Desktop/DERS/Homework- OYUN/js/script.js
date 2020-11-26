let area = document.querySelector("#game .area");
let ball = document.querySelector("#game .area .ball");
let move = 15;

area.addEventListener("click", function (e) {
  if (e.target.className == "ball") {
    return;
  }

  ball.style.top = e.offsetY - ball.offsetWidth / 2 + "px";
  ball.style.left = e.offsetX - ball.offsetWidth / 2 + "px";

  if (parseInt(ball.style.left) <= move) {
    ball.style.left = 0 + "px";
  }
  if (parseInt(ball.style.top) <= move) {
    ball.style.top = 0 + "px";
  }
  if (parseInt(ball.style.left) > area.offsetWidth - move * 2) {
    ball.style.left = parseInt(area.offsetWidth - ball.offsetWidth) + "px";
  }
  if (parseInt(ball.style.top) > area.offsetHeight - move * 2) {
      ball.style.top = parseInt(area.offsetHeight - ball.offsetHeight) + "px";
    }
});

area.addEventListener("keydown", function (e) {
  
  if (e.keyCode == 37) {
    ball.style.left = parseInt(ball.style.left) - move + "px";
    if (parseInt(ball.style.left) <= move) {
      ball.style.left = 0 + "px";
      return;
    }
  }
  if (e.keyCode == 38) {
    ball.style.top = parseInt(ball.style.top) - move + "px";
    if (parseInt(ball.style.top) <= move) {
      ball.style.top = 0 + "px";
      return;
    }
  }
  if (e.keyCode == 39) {
    ball.style.left = parseInt(ball.style.left) + move + "px";
    if (parseInt(ball.style.left) > area.offsetWidth - move * 2) {
      ball.style.left = parseInt(area.offsetWidth - ball.offsetWidth) + "px";
      return;
    }
  }
  if (e.keyCode == 40 && parseInt(ball.style.top) < 399) {
    ball.style.top = parseInt(ball.style.top) + move + "px";
    if (parseInt(ball.style.top) > area.offsetHeight - move * 2) {
      ball.style.top = parseInt(area.offsetHeight - ball.offsetHeight) + "px";
      return;
    }
  }
});
