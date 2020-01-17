var read_name = prompt('Entra el teu nom:', 'Exemple: Gumersindo');
var nom = Array.from(read_name);
var i;

console.log("El teu nom desglossat és així: ");
document.write("El teu nom desglossat és així: ");

for (i = 0; i < nom.length; i++)
{
  console.log(nom[i] + " ");
  document.write(nom[i] + " ");
}
