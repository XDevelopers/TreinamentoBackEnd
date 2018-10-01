$(document).ready(function(){
    //descendente
    $("div span").css("background-color", "yellow");
    //filhos do elemento
    $("li > ul").css("color", "red");
    //primeiro irmão
    $("#Item1_1 + li").css("color", "blue");
    //todos os irmãos
    $("#Item1_1 ~ li").css("color", "blue");
});
