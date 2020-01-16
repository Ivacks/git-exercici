var year_one = 1948;
var read_year = prompt('Entra el teu any de naixement', 'Exemple: 1492');
var your_year = parseInt(read_year);
var year_check = false;

do {
  year_one++;
  if ( (year_one % 4 == 0 && year_one % 100 != 0) || (year_one % 100 == 0 & year_one % 400 )){
      if (year_one == your_year){
        year_check = true;
      }
    console.log(year_one + " es un any de traspàs. ");
    document.write(year_one + " es un any de traspàs. " + "<br>");
  }

} while (your_year >= year_one);

if (year_check){
  console.log(your_year + ", el teu any de naixement, es un any de traspàs.");
  document.write(your_year + ", el teu any de naixement, es un any de traspàs." + "<br>");
}else {
  console.log(your_year + ", el teu any de naixement, no es un any de traspàs.");
  document.write(your_year + ", el teu any de naixement, no es un any de traspàs." + "<br>");
}
