/*
Sarcină practică 1. Scrieți un script care cere utilizatorului să introducă numele său folosind
prompt() și să afișeze un mesaj de bun venit folosind alert().

let userName=prompt("Introduceti numele: ")
let helloUser=alert(`Salut ${userName} !` )
*/


/*
Sarcină practică 2. Scrieți un script care cere utilizatorului să introducă un număr folosind
prompt() și să verifice dacă acesta este par sau impar folosind operatorul modulo(%) și alert()
pentru a afișa rezultatul.

let data=Number(prompt(`Introduceti un numar : `))
if(data%2==0){
    alert(`Numarul ${data} este par`)
}
else{
    alert(`Numarul ${data} este impar`)
}
*/


/*
Sarcină practică 3. Scrieți un script care cere utilizatorului să confirme dacă dorește să continue
folosind confirm() și să afișeze un mesaj diferit în funcție de răspunsul utilizatorului.

let start=true
while(start){
    let data=Number(prompt(`Introduceti un numar : `))
    if(data%2==0){
        alert(`Numarul ${data} este par`)
    }
    else{
        alert(`Numarul ${data} este impar`)
    }
    start=confirm(`Doriti sa mai incercati ?`)
}
*/


/*
Sarcină practică 4. Scrieți un script care declară și inițializează două variabile, una cu un număr și
cealaltă cu un șir, apoi concatenează cele două valori și afișează rezultatul folosind console.log()

let number=10
let sir='sir'
console.log(number+sir)
*/


/*
Sarcină practică 5. Scrieți un script care declară o variabilă cu o valoare de tip șir și verifică dacă
aceasta este goală folosind proprietatea length și console.log() pentru a afișa rezultatul.

let sir='sir'
if(sir.length==0){
    console.log(`Sirul nu contine caractere`)
}
else{
    console.log(`Sirul ${sir} contine ${sir.length} caractere`)
}
*/

