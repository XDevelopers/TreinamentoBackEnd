window.onload = function(){
    this.document.getElementById("botao").onclick = function(){
        //status = 200, statuText=OK, responseText, responseXML
        var ajax = new XMLHttpRequest();
        // ajax = new ActiveXObject("Microsoft.XMLHTTP");

        // var r = document.getElementById("resposta");
        ajax.onreadystatechange = function(){
            if(ajax.readyState == 4){
                alert(ajax.responseText);
                // r.appendChild(document.createTextNode(ajax.responseText));
                // r.innerHTML = ajax.responseText;

                // var xml = ajax.responseXML;
                // var url = xml.getElementsByTagName("url")[0].firstChild.nodeValue;
                // r.appendChild(document.createTextNode(url));

                //E4X
                // var xml = new XML(ajax.responseText);
                // r.appendChild(document.createTextNode(xml.url));
            }
        }

        ajax.open("POST", "ajax/arquivo.txt");
        // ajax.open("POST", "ajax/arquivo.html");
        // ajax.open("POST", "ajax/arquivo.xml");
        ajax.send(null);
        return false;
    }
}

// window.onload = function(){
//     this.document.getElementById("botao").onclick = function(){
//         //status = 200, statuText=OK, responseText, responseXML
//        requisitar(this.href);
//         return false;
//     }

// }

// function carregando(c){
//     while(c.hasChildNodes()){
//         c.removeChild(c.lastChild);
//     }
//     var img = document.createElement("img");
//     img.setAttribute("src", "ajax/ajax.gif");
//     c.appendChild(img);
// }

// function mostrar(ajax){
//     var r = document.getElementById("resposta");
//     while(r.hasChildNodes()){
//         r.removeChild(r.lastChild);
//     }

//     //var xml = new XML(ajax.responseText);
//     //r.appendChild(document.createTextNode(xml.url));
//     alert(ajax.responseText);
// }

// function requisitar(url){
//     var ajax = iniciaAjax();
//     carregando(document.getElementById("resposta"));
//     ajax.onreadystatechange = function(){
//         if(ajax.readyState == 4){
//             mostrar(ajax);            
//         }
//     }

//     ajax.open("POST", url);
//     ajax.send(null);
// }

// function iniciaAjax(){
//     var ajax = null;
//     if(window.XMLHttpRequest){
//         ajax = new XMLHttpRequest();
//     }else if(window.ActiveXObject){
//         try{
//             ajax = new ActiveXObject("Msxml2.XMLHTTP");
//         }catch(e){
//             ajax = new ActiveXObject("Microsoft.XMLHTTP");
//         }
//     }
// }