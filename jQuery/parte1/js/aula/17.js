$(document).ready(function(){
    $("span:eq(0)").click(function(){
        // $("div").hide();
        // $("div").hide("normal");//normal, fast, slow
        // $("div").hide("fast");//normal, fast, slow
        // $("div").hide("slow");//normal, fast, slow
        $("div").hide(3000);
    });
    $("span:eq(1)").click(function(){
        // $("div").show();
        // $("div").show("normal");//normal, fast, slow
        // $("div").show("fast");//normal, fast, slow
        // $("div").show("slow");//normal, fast, slow
        $("div").show(3000);
    });
    $("span:eq(2)").click(function(){
        // $("div").toggle();
        // $("div").toggle("normal");//normal, fast, slow
        // $("div").toggle("fast");//normal, fast, slow
        // $("div").toggle("slow");//normal, fast, slow
        $("div").toggle(3000);
    });
});