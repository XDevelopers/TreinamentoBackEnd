$(document).ready(function(){
    $("span").click(function(){
        var img = $("<img/>", {
            src: "img/leao.jpg",
            title: "Leão",
            click: function(){alert("Leão");}
        });

        var ul = $("<ul/>").append($("<li/>").append("Programador de Interface WEB"));

        $("body").append(img).append(ul);
    });
});