var nom_cognom = "Ivan Navarro Vargas";
var data_naixement = "04/06/1994";
var separate = data_naixement.split("/");
var year = separate[2];


console.log("El meu nom és " + nom_cognom);
console.log("Vaig néixer el " + data_naixement);
document.write("El meu nom és " + nom_cognom + "<br>");
document.write("Vaig néixer el " + data_naixement + "<br>");

  if ( (year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 & year % 400 ))
  {
    console.log("El meu any de naixement és traspàs.");
    document.write("El meu any de naixement és traspàs." + "<br>");
  }
  else
  {
    console.log("El meu any de naixement no és traspàs.");
    document.write("El meu any de naixement no és traspàs." + "<br>");
  }
