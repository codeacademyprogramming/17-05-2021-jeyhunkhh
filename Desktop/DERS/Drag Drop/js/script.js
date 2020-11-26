let mainArea = document.querySelector("#main-area");
let secondArea = document.querySelector("#second-area");
let ball = document.querySelector(".ball");
let activeArea = mainArea;

let position = {
    x: 0,
    y: 0,
    movementPx: 20
};

if (mainArea != null) {
    mainArea.addEventListener("keydown", function (e) {
        switch (e.which) {
            case 38:
                position.y -= position.movementPx;
                break;
            case 40:
                position.y += position.movementPx;
                break;
            case 37:
                position.x -= position.movementPx;
                break;
            case 39:
                position.x += position.movementPx;
                break;
        }

        setBallPostion();
    });

    mainArea.addEventListener("click", function (e) {
        if (activeArea != mainArea) {
            return false;
        }

        if (e.target.classList.contains("ball")) {
            return;
        }

        position.x = e.offsetX - (ball.getBoundingClientRect().width / 2);
        position.y = e.offsetY - (ball.getBoundingClientRect().height / 2);

        setBallPostion();
    });


    secondArea.addEventListener("keydown", function (e) {
        switch (e.which) {
            case 38:
                position.y -= position.movementPx;
                break;
            case 40:
                position.y += position.movementPx;
                break;
            case 37:
                position.x -= position.movementPx;
                break;
            case 39:
                position.x += position.movementPx;
                break;
        }

        setBallPostion();
    });

    secondArea.addEventListener("click", function (e) {
        if (activeArea != secondArea) {
            return false;
        }

        if (e.target.classList.contains("ball")) {
            return;
        }
        console.log(e);
        position.x = e.offsetX - (ball.getBoundingClientRect().width / 2);
        position.y = e.offsetY + mainArea.getBoundingClientRect().height + 5 - (ball.getBoundingClientRect().height / 2);

        setBallPostion();
    });
}



function setBallPostion() {
    if (position.y < 0) {
        position.y = 0;
    }

    if (position.x < 0) {
        position.x = 0;
    }

    if (position.x > mainArea.getBoundingClientRect().width - ball.getBoundingClientRect().width) {
        position.x = mainArea.getBoundingClientRect().width - ball.getBoundingClientRect().width;
    }

    if (position.y > mainArea.getBoundingClientRect().height - ball.getBoundingClientRect().height) {
        position.y = mainArea.getBoundingClientRect().height - ball.getBoundingClientRect().height;
    }

    // let exit = {
    //     start: activeArea.getBoundingClientRect().width * 44 / 100,
    //     end: activeArea.getBoundingClientRect().width - mainArea.getBoundingClientRect().width * 44 / 100 - ball.getBoundingClientRect().width,
    //     bottom: activeArea.getBoundingClientRect().height - ball.getBoundingClientRect().height / 2,
    // };

    // if (exit.start < position.x && exit.end > position.x && position.y >= exit.bottom) {
    //     activeArea = secondArea;
    // } else {
    //     activeArea = mainArea;
    // }

    // console.log(activeArea);

    // if (activeArea == mainArea) {
    //     if (position.x > mainArea.getBoundingClientRect().width - ball.getBoundingClientRect().width) {
    //         position.x = mainArea.getBoundingClientRect().width - ball.getBoundingClientRect().width;
    //     }

    //     if (position.y > mainArea.getBoundingClientRect().height - ball.getBoundingClientRect().height) {
    //         position.y = mainArea.getBoundingClientRect().height - ball.getBoundingClientRect().height;
    //     }
    // } else {

    // }

    ball.style.top = position.y + "px";
    ball.style.left = position.x + "px"
}


// Drag and drop


var balls = document.querySelectorAll(".balls .ball");
var firstBasket = document.querySelector("#first-basket");
var secondBasket = document.querySelector("#second-basket");

balls.forEach(elem => {
    elem.addEventListener("dragstart", function (e) {
        e.dataTransfer.setData("ballId", this.id);
    });

    elem.addEventListener("dragend", function (e) {
        console.log("dragend");
    });

    elem.addEventListener("dragenter", function (e) {
        console.log(e.target);
    });
});

firstBasket.addEventListener("drop", function (e) {
    let ballId = e.dataTransfer.getData("ballId");
    firstBasket.append(document.getElementById(ballId));
});

firstBasket.addEventListener("dragover", function (e) {
    e.preventDefault();
});

secondBasket.addEventListener("drop", function (e) {
    let ballId = e.dataTransfer.getData("ballId");
    secondBasket.append(document.getElementById(ballId));
});

secondBasket.addEventListener("dragover", function (e) {
    e.preventDefault();
});

