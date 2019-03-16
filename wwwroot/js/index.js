$(document).ready(function() {

    var $content = $(".content").waypoint(function(){
       
    },{offset:'30%'}); 

    $(".button").on('click',function(){
        $(".sec3").toggle();
    })
    $(".sec3").toggle();


    $(".menu-toggle").click(function(){
        $(".menu-toggle").toggleClass('active');
        $("nav").toggleClass('active');
    })

    setTimeout(function(){
        if ($('.okay').length > 0) {
          $('.okay').empty();
        }
      }, 5000)
      
})


$(window).on('scroll', function(){
    if($(window).scrollTop()){
        $('header').addClass('black');
    }
    else
    {
        $('header').removeClass('black');
    }

})


