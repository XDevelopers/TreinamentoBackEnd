$(document).ready(function(){
    $("a[name=menu]").css("background", "#CCC");

    $("a[href*=min]").css("background", "#CCC");
    $("a[href$=js]").css("background", "red");
    $("a[href^=mailto]").css("background", "#CCC");

    $("a[name!=menu]").css("background", "#CCC");
});