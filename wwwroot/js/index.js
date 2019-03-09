$(document).ready(function() {

    var $content = $(".content").waypoint(function(){
       
    },{offset:'30%'}); 

    $(".button").on('click',function(){
        $(".sec3").toggle();
    })
    $(".sec3").toggle();
})


$(window).on('scroll', function(){
    if($(window).scrollTop()){
        $('nav').addClass('black');
    }
    else
    {
        $('nav').removeClass('black');
    }

})


