// x = an + b
// n = [0,1,2,3,4,5,6...]

// Equação     Seleção
// 2n          2*0=0; 2*1=2; 2*2=4;        (par)
// 2n+1        2*0+1=1; 2*1+1=3; 2*2+1=5;  (impar)
// 3n+1        3*0+1=1; 3*1+1=4; 3*2+1=7;  (3 em 3)
// 4n-1        4*0-1=-1; 4*1-1=3; 4*2-1=7  (3, 7, 11)
// 4n          4*0=0; 4*1=4; 4*2=8;        (4, 8, 12)

$(document).ready(function(){
    $("#filmes tbody tr:odd").addClass("impar");
    
    $("#filmes tbody tr").hover(
        function(){$(this).addClass("destaque");},
        function(){$(this).removeClass("destaque");}
    );
});