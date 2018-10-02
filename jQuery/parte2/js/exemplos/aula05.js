$(document).ready(function(){
    $("tbody tr:not(.sub)").hide();
    $(".sub th").prepend("<img src='img/mais.jpg' class='maismenos'/>");

    $("img").click(function(){
        if($(this).attr("src") == "img/menos.png"){
            $(this).attr("src", "img/mais.jpg")
            .parents().siblings("tr").hide();
        }else{
            $(this).attr("src", "img/menos.png")
            .parents().siblings("tr").show();
        }
    });
});