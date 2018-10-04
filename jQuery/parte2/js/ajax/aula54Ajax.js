$(function(){
    $("#botao").click(function(){
        // $.ajax({
        //     type: "GET",
        //     url: "js/ajax/arquivos/arquivo.html",
        //     dataType: "html", //html, json, jsonp, text, xml, script
        //     success: function(resultado){
        //         // alert(resultado);
        //         $("#resposta").append(resultado);
        //     }
        // });

        $.getJSON("http://api.flickr.com/services/feeds/photos_public.gne?jsoncallback=?",
            {
                tags: "Brasilia",
                tagmode: "any",
                format: "json"
            },
            function(data){
                $.each(data.items, function(i, item){
                    $("#resposta").append($("<img>")
                    .attr("src", item.media.m));
                    if(i == 3) return false;
                });
            }
        );
        return false;
    });
});

