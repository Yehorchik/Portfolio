$(document).ready(function() {

    var $content = $(".content").waypoint(function(){
       
    },{offset:'30%'}); 
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


