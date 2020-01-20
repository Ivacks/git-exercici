/* var read_name = prompt('Entra ') */
var list = new Array();
list.push('I');
list.push('V');
list.push('A');
list.push('N');

var i;
for (i = 0; i < list.length; i++)
{
console.log(list[i]);
document.write(" " + list[i] + " ");
  if((list[i] == 'A') || (list[i] == 'E') || (list[i] == 'I') || (list[i] == 'O') || (list[i] == 'U'))
  {
    console.log("VOCAL");
    document.write("VOCAL");
  }
  else
  {
    console.log("CONSONANT");
    document.write("CONSONANT");
  }

  if ((list[i] == '0') || (list[i] == '1') || (list[i] == '2') || (list[i] == '3') || (list[i] == '4') || (list[i] == '5') || (list[i] == '6') || (list[i] == '7') || (list[i] == '8') || (list[i] == '9'))
  {
    console.log("El nom de les persones no contenen números");
    document.write("El nom de les persones no contenen números");
  }


}
