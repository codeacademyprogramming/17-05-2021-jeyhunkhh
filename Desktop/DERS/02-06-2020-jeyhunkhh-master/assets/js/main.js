$(document).ready(function () {

    if($('#courses .courses').length){
        var $grid = $('#courses .courses').isotope({
            itemSelector: '.grid-item',
            percentPosition: true,
        });
        
        $('.filter ul').on('click', 'button', function () {
            $(".filter ul li button.active").removeClass("active");
            $(this).addClass("active");
            var filterValue = $(this).attr('data-filter');
            $grid.isotope({ filter: filterValue });
        });
    }
});