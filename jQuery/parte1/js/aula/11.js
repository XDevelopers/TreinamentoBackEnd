// append(); //dentro na ultima posição
// prepend(); //dentro na primeira posição
// after(); //fora e após o elemento
// before(); //fora e antes do elemento
// wrap(); //envolve com outro elemento
// clone(); //faz uma copia do elemento
$(document).ready(function(){
    $("span").click(function(){
        // $("ul").append("<li>Dentro e na Ultima posição</li>");
        // $("ul").prepend("<li>Dentro e na Primeira posição</li>");
        // $("ul").before("<h1>Fora e Antes do elemento</h1>");
        // $("ul").after("<h1>Fora e Depois do elemento</h1>");

        // $("ul").wrap("<p></p>");
        $("ul").append($("li").clone());
    });
});