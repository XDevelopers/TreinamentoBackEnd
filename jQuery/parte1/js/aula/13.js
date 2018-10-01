$(document).ready(function(){
    $("span").click(function(){

        // alert($("img").css("width"));
        // alert($("img").css("height"));
        // $("img").css({
        //     width: "300px",
        //     background: "#00FF00",
        //     border: "30px solid #B22222"
        // });
        // alert($("img").hasClass("imagem"));
        // $("img").removeClass("imagem");
        $("img").addClass("destaque");

        //LARGURA E ALTURA
        // alert($("img").height());
        // alert($("img").width());
        // alert($("img").innerWidth());
        // alert($("img").outerWidth());

        //POSITION
        alert($("img").position().top);
        alert($("img").position().left);
        alert($("img").offset().top);
        alert($("img").offset().left);
    });
});

