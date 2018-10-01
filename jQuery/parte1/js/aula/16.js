$(document).ready(function(){
    // $(":text").keyup(function(){
    //     $("#msg").text($(this).val());
    // });

    // $(":text").bind("keyup", function(){
    //     $("#msg").text($(this).val());
    // });

    function msg(e){
        $("#msg").text($(this).val());
    }
    // $(":text").keyup(msg).focus(msg).blur(msg);
    $(":text").bind("keyup focus blur", msg);
    $("fieldset").delegate(":text", "keyup", msg);
    // $(":button").bind("click", function(){
    //     // $(":text").unbind("keyup", msg);

    //     // $(":text").val("Texto Incluido via jQuery");
    //     // $(":text").trigger("focus");

    //     $("fieldset").prepend("Outro: <input type='text' name='outro'>");
    // });

    $(":button").bind("click", function(e, src, width){
        $("#msg").append($("<img/>").attr("src", src).css("width", width))
    });
    
    $(":button").trigger("click", ["img/leao.jpg", "90px"]);
});