$('.owl-carousel').owlCarousel({
    loop:false,
    margin:10,//comment for no argin betwen cards
    nav:true,
    dots:false,
    navText : ['<span class="fas fa-angle-left fa-lg"></span>',
                '<span class="fas fa-angle-right fa-lg"></span>'],
    responsive:{
        200:{
            items:1
        },
        600:{
            items:2
        },
        1000:{
            items:3
        },
        1300:{
            items:4
        }
    }
})

document.addEventListener('DOMContentLoaded', ()=>{
});