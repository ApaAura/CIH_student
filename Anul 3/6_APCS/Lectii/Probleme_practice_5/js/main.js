/*Conversia datelor între obiecte JavaScript și fișiere JSON:
a. Creează un obiect JavaScript cu mai multe proprietăți, inclusiv proprietăți de tipul array sau obiect.
b. Utilizează metoda JSON.stringify() pentru a converti obiectul JavaScript într-un fișier JSON.*/
const elev={
    "name":'Jena',
    "surename":'Doe',
    "grupa": "AAW",
    "cod_grupa":2032,
    "medii_ani_de_studiu": [9.20, 8.40, 9.35],
    "domiciliu":{
        "tara":"MD",
        "cod_postal": 013
    }
}
const elevStr=JSON.stringify(elev)
console.log(elevStr)

/*Validarea datelor JSON:
a. Creează un șir de caractere JSON valid.
b. Creează un șir de caractere JSON invalid.
c. Utilizează metoda JSON.parse() pentru a valida cele două șiruri de caractere JSON.
d. Gestionează eroarea generată de metoda JSON.parse() atunci când încerci să validezi șirul de caractere JSON invalid.*/
const valid ='{"name":"Jena", "surename":"Doe", "grupa":"AAW2023" }';
const invalid ='{name:"Jena", surename:"Doe", grupa:"AAW2023" }';

const validSt=JSON.parse(valid)
console.log(validSt)
//const validNd=JSON.parse(invalid)
//console.log(validNd)
try{
    const validNd = JSON.parse(invalid)
    console.log(validNd)
} catch (error){
    console.log(`Eroare!`)
}

/* Transformarea datelor JSON într-un format personalizat:
a. Creează un șir de caractere JSON care conține date despre un set de utilizatori, inclusiv nume, prenume, dată de naștere etc.
b. Utilizează metoda JSON.parse() cu un al doilea parametru pentru a transforma datele de naștere ale utilizatorilor dintr-un șir de caractere într-un obiect Date.*/
const elevi=`{"elevi":[{"name": "Ana", "surename":"Olaru", "date": "2000-05-15"},{"name": "Vlad", "surename":"Olaru", "date": "1999-09-30"}]}`
const validare=JSON.parse(elevi,(key,value)=>{
    if(key==="date"){
        return new Date(value)
    }else{
        return value
    }
})
console.log(validare)

/*Creează un obiect cu câteva proprietăți (cel puțin trei) și destructurează-l pentru a crea trei variabile separate.*/
//const {name, surename,grupa, cod_grupa, medii_ani_de_studiu}=elev
//console.log(name, surename, grupa, cod_grupa, medii_ani_de_studiu)

/*Creează o funcție care primește un obiect cu cel puțin două proprietăți și returnează o propoziție folosind acele proprietăți. Destructurează obiectul în corpul funcției.*/
const message={
    first: "Hello",
    second: "Java",
    third: "Script"
}
const sentence=(ms)=>{
    const {first, second, third}=ms
    return `${first} ${second}${third} !`
}
console.log(sentence(message))

/*Extrage dintr-un obiect doar anumite proprietăți și asignă-le la variabile separate.*/
const carte={
    "denumire":"Ion",
    "autor": "Liviu Rebreanu",
    "editura":"Arc",
    "anul": 2010
}
const {editura, an}=carte
console.log(editura, an)

/*Creează un tablou cu două obiecte și folosește destructurizarea pentru a accesa proprietățile acestora.*/
const students = [
    { name: "Liviu", surename: "Sirbu", age: 23 },
    { name: "Alina", surename: "Pascal", age: 20 }
]
const [first,second]=students
console.log(first.age)
console.log(second.age)

/*Extrage proprietățile obiectelor imbricate folosind destructurizarea.*/
//obiect imbricat-obiect definit in interiorul altui obiect
const {name, surename, grupa, cod_grupa, medii_ani_de_studiu, domiciliu:{tara, cod_postal}}=elev
console.log(grupa)
console.log(tara)

/*Scrieți o funcție care primește ca argumente două liste de numere întregi și returnează o listă care conține toate numerele din cele două liste, fără elementele duplicate. Utilizați operatorul Spread pentru a combina cele două liste și o buclă for pentru a elimina elementele duplicate.*/
function combineList(list1, list2){
    const combined = [...list1, ...list2];
    const rezult = [];
  
    for (let i = 0; i < combined.length; i++) {
      if (!rezult.includes(combined[i])) {
        rezult.push(combined[i]);
      }
    }
    return rezult;
}
console.log(combineList([1,2,3,4],[4,5,6,7]))

/*Scrieți o funcție care primește ca argumente două obiecte și returnează un nou obiect care combină proprietățile din cele două obiecte. Dacă există proprietăți cu același nume în cele două obiecte, proprietatea din cel de-al doilea obiect va suprascrie proprietatea din primul obiect. Utilizați operatorul Spread pentru a combina cele două obiecte.*/
function combineObiect(obj1, obj2){
    return {...obj1, ...obj2};
}
console.log(combineObiect(elev,carte))

/*Scrieți o funcție care primește ca argumente o listă de numere întregi și returnează valoarea maximă din acea listă. Utilizați operatorul Rest pentru a captura argumentele funcției.s*/
function max(...numere){
    let max = numere[0];
    for (let i = 1; i < numere.length; i++) {
      if (numere[i] > max) {
        max = numere[i];
      }
    }
    return max;
}
console.log(max([1,2,3,4,5,6]))