$(function(){
    QUnit.test("Teste Básico", function(assert){
        assert.ok(true, "Teste ok() bem sucedido");
        var valor = "XTI";
        assert.equal(valor, "XTI", "Teste equal() bem sucedido, compara valor");
        assert.propEqual(valor, "XTI", "Teste propEqual() bem sucedido, compara valor e tipo");
    });

    QUnit.module("Modulo Ajax");
    QUnit.test("Abre conexão", function(assert){
        assert.ok(true, "Conexão Aberta");
    });

    QUnit.test("Teste Assincrono", function(assert){
        var done = assert.async();
        $.ajax({
            url: "js/ajax/arquivos/arquivo.txt",
            dataType: "text",
            success: function(resultado){
                assert.ok((resultado.length > 1), "Arquivo foi recebido com sucesso");
                // QUnit.start();
                done();
            }
        });
    })

});