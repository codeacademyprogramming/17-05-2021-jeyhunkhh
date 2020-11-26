let tooltips = document.querySelectorAll('[data-toggle="tooltip"]');

tooltips.forEach(elem => {
    elem.addEventListener("mouseenter", tooltipShow);

    elem.addEventListener("mouseleave", tooltipHide);
});

function tooltipShow() {
    let coordinate = this.getBoundingClientRect();

    let postion = {
        top: 0,
        left: 0
    }

    let tooltip = document.createElement("div");

    tooltip.classList.add("my-tooltip", this.dataset.placement);
    tooltip.innerHTML = this.dataset.title;
    document.body.append(tooltip);

    let tooltipCoordinate = tooltip.getBoundingClientRect();
    let tooltipAfterWidth = 10;

    switch (this.dataset.placement) {
        case "top":
            postion.top = coordinate.top - tooltipCoordinate.height - tooltipAfterWidth;
            postion.left = coordinate.left + (coordinate.width - tooltipCoordinate.width) / 2;
            break;
        case "right":
            postion.top = coordinate.top + (coordinate.height - tooltipCoordinate.height) / 2;
            postion.left = coordinate.left + coordinate.width + tooltipAfterWidth;
            break;
        case "bottom":
            postion.top = coordinate.top + coordinate.height + tooltipAfterWidth;
            postion.left = coordinate.left + (coordinate.width - tooltipCoordinate.width) / 2;
            break;
        case "left":
            postion.top = coordinate.top + (coordinate.height - tooltipCoordinate.height) / 2;
            postion.left = coordinate.left - tooltipCoordinate.width - tooltipAfterWidth;
            break;
        default:
            break;
    }

    tooltip.style.top = postion.top + "px";
    tooltip.style.left = postion.left + "px";
    tooltip.style.opacity = 1;
}

function tooltipHide() {
    document.querySelector(".my-tooltip").remove();
}