const year_one = 1948;
var read_year = prompt('Entra el teu any de naixement', 'Exemple: 1492');
var your_year = parseInt(read_year);
var transition_year = 4;

var total_transition_year = (your_year - year_one) / transition_year;
console.log("Desde 1948 al teu naixement hi ha " + total_transition_year + " anys de traspàs.");
document.write("Desde 1948 al teu naixement hi ha " + total_transition_year + " anys de traspàs.");
