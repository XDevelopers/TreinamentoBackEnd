window.onload = function(){
    /* Navegar na Arvore do Documento
    Tipo de Nós (Documento, Elemento, Atributo e Texto)
    Parentesco dos Nós (Pai = parent, Filho=child, Irmão=sibling) */

    var div = document.getElementsByTagName("div").item(0);
    alert(div);//Elemento
    alert(div.parentNode);//pai
    alert(div.childNodes);//filhos

    var ul = div.childNodes.item(0);
    alert(ul);//Primeiro filho (ul)
    alert(ul.nodeName);
    alert(ul.nodeType);//1=Elemento; 2=Atributo; 3=Texto;

    alert(ul.childNodes.length);
    alert(ul.childNodes.item(0));
    alert(ul.firstChild);
    alert(ul.lastChild);

    alert(ul.firstChild.firstChild);
    alert(ul.firstChild.firstChild.nodeValue);
    alert(ul.firstChild.firstChild.nodeName);
    alert(ul.firstChild.firstChild.nodeType);

    var li = ul.firstChild.lastChild.childNodes[1];
    alert(li.firstChild.nodeValue);
    alert(li.previousSibling.firstChild.nodeValue);
    alert(li.nextSibling.firstChild.nodeValue);

    alert(div.firstChild.firstChild.lastChild.lastChild.lastChild.firstChild.firstChild.nodeValue);

    var hr = document.createElement("hr");
    div.appendChild(hr);

    var li = document.createElement("li");
    li.appendChild(document.createTextNode("Teste de Lista"));
    div.firstChild.appendChild();

    var atributo = this.document.createAttribute("style");
    atributo.value = "color:blue";
    li.setAttributeNode(atributo);
    li.setAttribute("style", "color:blue");
    li.style.color = "blue";

    var select = document.createElement("select");
    select.setAttribute("id", "estados");
    var option = this.document.createElement("option");
    option.setAttribute("value", "DF");
    option.appendChild(this.document.createTextNode("Distrito Federal"));
    var option2 = this.document.createElement("option");
    option2.setAttribute("value", "SP");
    option2.appendChild(this.document.createTextNode("São Paulo"));
    select.appendChild(option);
    select.appendChild(option2);
    div.appendChild(select);

    var del = div.firstChild;
    div.removeChild(del);

    var select2 = select.cloneNode(true);
    div.appendChild(select2);

    var option3 = option.cloneNode(true);
    select.appendChild(option3);

}