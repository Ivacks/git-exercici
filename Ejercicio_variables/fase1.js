var nom = "Ivan";
var cognom1 = "Navarro";
var cognom2 = "Vargas";
var dia = 15;
var mes = 01;
var any = 2020;

var totnom = cognom1 + " " + cognom2 + "," + nom;
console.log(totnom);
/*<p id="totnom">
totnom = cognom1 + " " + cognom2 + "," + nom;
</p>*/
//document.body.innerHTML = totnom;
document.write(totnom);

var data = dia + "/" + mes + "/" + any;
console.log(data);
document.write("<br>" + data);
