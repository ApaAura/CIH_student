//Scrie o funcție care primește ca argument un număr întreg și returnează valoarea sa absolută folosind metoda Math.abs().
const modul=(x)=>{
    return Math.abs(x)
}
console.log(modul(-10))

//Scrie o funcție care primește ca argument un număr întreg și returnează un număr întreg aleatoriu între 0 și numărul dat, folosind metoda Math.random() și Math.floor().
const random=(x)=>{
   return Math.floor(Math.random()*x)
}
console.log(`Un numar aletor intre 0 si 50: ${random(50)}`)

//Creează o funcție care primește două obiecte Date ca argumente și returnează diferența dintre cele două date în zile.
const difference=(date1,date2)=>{
    return Math.abs(date2.getDate()-date1.getDate())
}
//month/day/year
date1=new Date('02/09/2023')
date2=new Date('02/18/2023')
console.log(difference(date1,date2))

//Creează o funcție care primește un obiect Date ca argument și returnează un șir de caractere care indică ziua săptămânii pentru acea dată.
//getDay() returns a integer corresponding to the day of the week (0-Sunday, 1-Monday)
const day=(date)=>{
    let str=``
    let nr=date.getDay()
    switch(nr){
        case 0: str='Duminica'; break;
        case 1: str='Luni'; break;
        case 2: str='Marti'; break;
        case 3: str='Miercuri'; break;
        case 4: str='Joi'; break;
        case 5: str='Vineri'; break;
        case 6: str='Sambata'; break;
        default: str='I do not need a default value :/'
    }
    return str
}
console.log(day(date1))

//Creează o funcție care primește un număr întreg ca argument și returnează data de început a anului calendaristic respectiv (1 ianuarie) pentru acel an.
const initialDate=(number)=>{
    return new Date(number,0,1)
}
console.log(initialDate(2023))

//Validați un șir de caractere pentru a verifica dacă respectă un anumit format: Scrieți o funcție care primește un șir de caractere și un model RegExp  și verifică dacă șirul respectă formatul specificat de model. De exemplu, puteți verifica dacă un număr de telefon are formatul corect sau dacă un șir conține doar litere și cifre.

/*Format of valid phone Number 
(123) 456-7890
(123)456-7890
123-456-7890
1234567890*/
const validPhoneNumber=(str)=>{
    let regExp=/^\(?(\d{3})\)?[- ]?(\d{3})[- ]?(\d{3})$/;
    /*
    ^\(?( - first character may be '('
    (\d{3}) - three numeric digits
    \)? - close paranthesis
    [- ]? - string may containt '-'
    */
    return regExp.test(str)
}
console.log(validPhoneNumber('123456789'))
console.log(validPhoneNumber('abc'))

const onlyLettersAndDigits=(str)=>{
    let regExp=/^[A-Za-z0-9]*$/
    //^ - beginning of the string
    //$ - end of the string
    return regExp.test(str)
}
console.log(onlyLettersAndDigits('number1'))
console.log(onlyLettersAndDigits('number 1'))
console.log(onlyLettersAndDigits('number 1 :)'))


//Înlocuiți un șir de caractere cu alt șir folosind expresii regulate: Scrieți o funcție care primește un șir de caractere, o expresie regulată și un șir de înlocuire. Funcția trebuie să înlocuiască toate aparițiile șablonului din șirul de intrare cu șirul de înlocuire specificat. Acest lucru poate fi util, de exemplu, pentru a înlocui anumite caractere sau cuvinte într-un text.
const newString=(initialStr, regExp, replacement)=>{
    return initialStr.replace(regExp,replacement)
}
let inputString = "JavaScript"
let regex = /a/g
let replacementString = " aici a fost 'a' "
console.log(newString(inputString,regex,replacementString))

//Extrageți informații relevante dintr-un șir de caractere folosind expresii regulate: Scrieți o funcție care primește un șir de caractere și un model RegExp și extrage informațiile relevante din șirul de intrare. De exemplu, puteți extrage numerele de telefon dintr-un text sau adresele de e-mail. Acest lucru poate fi util în situații în care trebuie să procesați o cantitate mare de date și să extrageți informațiile importante.
const important=(text, regex)=>{
    return text.match(regex)
}
let hakerText ='Try to compress the SDD circuit, person@haker.cihcahul.md maybe it will reboot the neural matrix!'
regexEmail=/[\w.-]+@[\w.-]+\.[\w.-]+/g
console.log(important(hakerText, regexEmail))

//Sortați un tablou de obiecte după o proprietate comună: Scrieți o funcție care primește un tablou de obiecte și o proprietate comună, apoi sortați tabloul în ordine crescătoare sau descrescătoare în funcție de acea proprietate.
const sortByProperty=(arr, property,order)=>{
    sortedArr=''
    switch(order){
        case 'asscending': sortedArr=arr.sort((a,b)=>a[property]>b[property]?1:-1); break;
        case 'descending': sortedArr=arr.sort((a,b)=>a[property]<b[property]?1:-1); break;
        default: sortedArr='Not a sort mode !'
    }
    return sortedArr
}
const Angajati = [
    {name: "Name1", sallary: 2500},
    {name: "Name2", sallary: 3700},
    {name: "Name3", sallary: 4300},
    {name: "Name4", sallary: 2900},
];
console.log(sortByProperty(Angajati, "sallary", 'asscending'))
console.log(sortByProperty(Angajati, "sallary", 'descending'))
console.log(sortByProperty(Angajati, "sallary", 'brr'))

//Selectați un sub-tablou de elemente care îndeplinesc o anumită condiție: Scrieți o funcție care primește un tablou și o condiție și returnează un sub-tablou de elemente care îndeplinesc acea condiție. De exemplu, puteți selecta toate numerele pare dintr-un tablou de numere.
const verifyPare=(arr, regex)=>{
    return arr.filter(regex)
}
arr=[1,2,3,4,5,6,7,8,9,10]
let nrPare=verifyPare(arr, (num)=>{return num%2===0})
console.log(nrPare)

//Calculează suma sau produsul elementelor unui tablou: Scrieți o funcție care primește un tablou și calculează suma sau produsul tuturor elementelor. Acest lucru poate fi util pentru calcularea mediei sau pentru obținerea produsului total al unui număr de valori.
const Suma=(matrice)=>{
    return matrice.reduce((sum, element)=>sum+element,0)
}
console.log(Suma(arr))
const Produs=(matrice)=>{
    return matrice.reduce((prod,element)=>prod*element,1)
}
console.log(Produs(arr))

//Găsiți elementul maxim sau minim dintr-un tablou: Scrieți o funcție care primește un tablou și returnează cel mai mare sau cel mai mic element din acesta. Acest lucru poate fi util pentru găsirea celei mai mari sau celei mai mici valori dintr-un set de date.
// ... - transmiterea elementelor ca argumente separate
const elMax=(matrice)=>{
    return Math.max(...matrice)
}
const elMin=(matrice)=>{
    return Math.min(...matrice)
}
console.log(elMax(arr))
console.log(elMin(arr))

//Concatenați două sau mai multe tablouri: Scrieți o funcție care primește două sau mai multe tablouri și returnează un nou tablou care conține toate elementele din acele tablouri concatenate. Acest lucru poate fi util pentru combinarea mai multor seturi de date într-unul singur.
const concatinare=(str,strr)=>{
    return str+strr
}
console.log('Java','Script')

//Filtrați elementele unui tablou pe baza unui criteriu: Scrieți o funcție care primește un tablou de numere și un număr minim și returnează un sub-tablou care conține numerele mai mari sau egale cu acel număr minim.
const part=(matrice, minim)=>{
    return matrice.filter(element=>element>=minim)
}
console.log(part([2,34,55,6,8,27], 20))

//Filtrați elementele unui tablou pe baza unui șablon RegExp: Scrieți o funcție care primește un tablou de șiruri de caractere și un șablon RegExp și returnează un sub-tablou care conține doar șirurile de caractere care se potrivesc cu acel șablon.
const fit=(sir, regex)=>{
    return sir.filter(element=>regex.test(element))
}
console.log(fit(["Elementele", "unui", "tablou", "cu", "cuvinte"],/^u/))

//Filtrați elementele unui tablou pe baza proprietăților lor: Scrieți o funcție care primește un tablou de obiecte și un nume de proprietate și returnează un sub-tablou care conține doar obiectele care au acea proprietate setată la o valoare specifică. De exemplu, puteți filtra un tablou de obiecte student pe baza notei lor la un test.
const checkGrade=(tablou, property, minimalGrade)=>{
    return tablou.filter(element=>element[property]===minimalGrade)
}
const studenti=[
    { name: "Name1", grade: 6 },
    { name: "Name2", grade: 9 },
    { name: "Name3", grade: 10 },
    { name: "Name4", grade: 9 }
]
console.log(checkGrade(studenti, "grade", 10))

//Scrieți o funcție care primește un tablou de obiecte și un nume de proprietate și returnează un sub-tablou care conține doar obiectele care au acea proprietate setată la o anumită valoare. De exemplu, puteți filtra un tablou de obiecte utilizator pe baza rolului utilizatorului.
const checkRole=(tablou, property, role)=>{
    return tablou.filter(element=>element[property]===role)
}
const utilizator=[
    { name: "Name1", role:'admin' },
    { name: "Name2", role:'user' },
    { name: "Name3", role:'user' },
    { name: "Name4", role:'admin' }
]
console.log(checkRole(utilizator, "role", "admin"))

//Scrieți o funcție care primește două tablouri de obiecte și un nume de proprietate comună și returnează un sub-tablou din primul tablou care conține obiectele care au o valoare din proprietatea comună care se regăsește în al doilea tablou. De exemplu, puteți filtra un tablou de obiecte produs pe baza unui tablou de ID-uri.
const checkID=(tablou1, tablou2, propetry)=>{
    return //needed to be finished
}
//Scrieți o funcție care primește un tablou de obiecte și un șablon RegExp și returnează un sub- tablou care conține doar obiectele care conțin șiruri de caractere care se potrivesc cu acel șablon. De exemplu, puteți filtra un tablou de obiecte mesaj pe baza unui șablon care corespunde cuvintelor cheie.
const checkMessage=(tablou,regex)=>{
    return //needed to be finished
}