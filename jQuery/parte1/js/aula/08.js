$(document).ready(function(){
    $("span").click(function(){

        // alert($("img").attr("title"));
        // alert($("img").attr("src"));
        // $("img")
        // .attr("src", "img/leao.jpg")
        // .attr("title", "Alimentando Leão");

        // $("img").attr({
        //     src: "img/leao.jpg",
        //     title: "Alimentando Leão"
        // })

        // $("img").removeAttr("src").removeAttr("title").removeAttr("alt");
        // alert($("img").hasClass("destaque"));
        // $("img").addClass("destaque");
        // alert($("img").hasClass("destaque"));
        $("img").toggleClass("destaque");
    });
});