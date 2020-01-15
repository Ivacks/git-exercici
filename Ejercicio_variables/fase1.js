var nom = "Ivan";
var cognom1 = "Navarro";
var cognom2 = "Vargas";
var dia = 15;
var mes = 01;
var any = 2020;

var totnom = cognom1 + " " + cognom2 + " " + nom;
console.log(totnom);
document.body.innerHTML = "<h1>" + cognom1 + " " + cognom2 + "," + nom + "</h1>";


var data = dia + "/" + mes + "/" + any;
console.log(data);
document.body.innerHTML = "<h3>" + dia + "/" + mes + "/" + any + "</h3>";
