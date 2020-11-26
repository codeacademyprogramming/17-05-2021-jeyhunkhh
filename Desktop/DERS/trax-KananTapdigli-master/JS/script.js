$(function () {

    $(document).on('click', '.bullet-count-1', (element) => {

        ///------------------------///

        /// Zoom-In-Bullet-Line ///

        $('.bullet-line').removeClass('zoomIn')
        $('.bullet-line').css('opacity', '0')

        $(element.target).next().addClass('zoomIn')
        $(element.target).next().css('opacity', '1')

        ///------------------------///


        ///------------------------///

        /// Shpwing-Header-Texts-With-Animation ///
        if ($('.text-part-2-1').hasClass('fadeInUp')) {
            $('.text-part-2-1').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-2-2').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-2-3').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-2-4').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.header-banner-2').removeClass('fadeIn').addClass('fadeOut').css('animation-delay', '0s')
        } else {
            $('.text-part-3-1').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-3-2').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-3-3').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-3-4').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.header-banner-3').removeClass('fadeIn').addClass('fadeOut').css('animation-delay', '0s')
        }


        $('.text-part-1-1').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.text-part-1-2').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.text-part-1-3').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.text-part-1-4').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.header-banner-1').removeClass('fadeOut').addClass('fadeIn').css('animation-delay', '0s')
        $('.overlay').css('opacity', '.8')
        $(".overlay").animate({
            opacity: 0.6,
        }, 1500, function () {});



        ///------------------------///

    })



    $(document).on('click', '.bullet-count-2', (element) => {

        ///------------------------///

        /// Zoom-In-Bullet-Line ///

        $('.bullet-line').removeClass('zoomIn')
        $('.bullet-line').css('opacity', '0')

        $(element.target).next().addClass('zoomIn')
        $(element.target).next().css('opacity', '1')

        ///------------------------///


        ///------------------------///

        /// Shpwing-Header-Texts-With-Animation ///

        if ($('.text-part-3-1').hasClass('fadeInUp')) {
            $('.text-part-3-1').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-3-2').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-3-3').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-3-4').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.header-banner-3').removeClass('fadeIn').addClass('fadeOut').css('animation-delay', '0s')
        } else {

            $('.text-part-1-1').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-1-2').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-1-3').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-1-4').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.header-banner-1').removeClass('fadeIn').addClass('fadeOut').css('animation-delay', '0s')
        }

        $('.text-part-2-1').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.text-part-2-2').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.text-part-2-3').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.text-part-2-4').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.header-banner-2').removeClass('fadeOut').addClass('fadeIn').css('animation-delay', '0s')
        $('.overlay').css('opacity', '.8')
        $(".overlay").animate({
            opacity: 0.6,
        }, 1500, function () {});



        ///------------------------///

    })

    $(document).on('click', '.bullet-count-3', (element) => {

        ///------------------------///

        /// Zoom-In-Bullet-Line ///

        $('.bullet-line').removeClass('zoomIn')
        $('.bullet-line').css('opacity', '0')

        $(element.target).next().addClass('zoomIn')
        $(element.target).next().css('opacity', '1')

        ///------------------------///


        ///------------------------///

        /// Shpwing-Header-Texts-With-Animation ///

        if ($('.text-part-1-1').hasClass('fadeInUp')) {
            $('.text-part-1-1').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-1-2').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-1-3').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-1-4').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.header-banner-1').removeClass('fadeIn').addClass('fadeOut').css('animation-delay', '0s')
        } else {
            $('.text-part-2-1').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-2-2').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-2-3').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.text-part-2-4').removeClass('fadeInUp').addClass('fadeOutDown').css('animation-delay', '0s')
            $('.header-banner-2').removeClass('fadeIn').addClass('fadeOut').css('animation-delay', '0s')
        }


        $('.text-part-3-1').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.text-part-3-2').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.text-part-3-3').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.text-part-3-4').removeClass('fadeOutDown').addClass('fadeInUp').css('animation-delay', '1s')
        $('.header-banner-3').removeClass('fadeOut').addClass('fadeIn').css('animation-delay', '0s')
        $('.overlay').css('opacity', '.8')
        $(".overlay").animate({
            opacity: 0.6,
        }, 1500, function () {});


        ///------------------------///

    })

    ///------------------------///

    // Opening-Closing-Nav-Menu //


    $(document).on('click', '.burger-menu', () => {
        $('.burger-nav').css('right', `0`)
        $('.general-overlay').fadeIn();
        $('body').css('overflow', 'hidden')
    })

    $(document).on('click', '.nav-x', () => {
        $('.burger-nav').css('right', '-1500px')
        $('.general-overlay').fadeOut();
        $('body').css('overflow', 'visible')
    })

    $(document).on('click', '.general-overlay', () => {
        $('.burger-nav').css('right', '-1500px')
        $('.general-overlay').fadeOut();
        $('body').css('overflow', 'visible')
    })

    $(document).keyup(function (e) {
        if (e.keyCode === 27) {
            $('.burger-nav').css('right', '-1500px')
            $('.general-overlay').fadeOut();
        }
    });

    ///------------------------///

    $('.i-b-span').mouseenter(function () {
        $('.span-special-background').css('opacity', '0')
    }).mouseleave(function () {
        $('.span-special-background').css('opacity', '1')
    });

    ///------------------------///



    ///------------------------///

    $('.slide-images').slick({
        arrows: false
    });

    ///------------------------///




    ///------------------------///


    $('.main-5th-bottom').slick({
        dots: false,
        infinite: false,
        arrows: false,
        slidesToShow: 4,
        slidesToScroll: 1,
        responsive: [{
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 1,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    });

    ///------------------------///


    ///------------------------///

    $(document).on('click', '.price-button-year', () => {
        $('.price-buttons-background').css('transform','translateX(93%')
        $('.price-button-month').css('color','#384141')
        $('.price-button-year').css('color','white')
    })

    $(document).on('click', '.price-button-month', () => {
        $('.price-buttons-background').css('transform','translateX(0%')
        $('.price-button-month').css('color','white')
        $('.price-button-year').css('color','#384141')
    })

    ///------------------------///

    $('.main-6th-slider').slick({
        dots: false,
        infinite: false,
        arrows: false,
        slidesToShow: 3,
        slidesToScroll: 1,
        responsive: [{
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 1,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    });
   
    $('.main-6th-slider-element').mouseenter(function () {
        $('.main-6th-slider-special-element').css('background-color', 'white')
        $('.special-pricing-title').css('color', '#384141')
        $('.special-pricing-version').css('color', 'black')
        $('.special-pricing-price').css('color','black')
        $('.special-pricing-list li').css('color','#808080')
        $('.special-button').css('background-color','#24cdd5')
        

    }).mouseleave(function () {
        $('.main-6th-slider-special-element').css('background-color', '#27323D')
        $('.special-pricing-title').css('color', 'white')
        $('.special-pricing-version').css('color', 'white')
        $('.special-pricing-price').css('color','white')
        $('.special-pricing-list li').css('color','white')
        $('.special-button').css('background-color','#26313c')

    });


});