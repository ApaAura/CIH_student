/*Sarcină practică 7.
1. Creați un program care să genereze un număr aleatoriu între 1 și 1000 și să returneze cel mai apropiat număr prim mai mare decât acesta.
2. Utilizând o buclă "while" iterați prin intervalul de la numărul generat la 1000 și verificați dacă fiecare număr este prim sau nu.
3. Utilizând o instrucțiune "if" verificați dacă numărul este prim și salvați-l într-o variabilă dacă este cel mai apropiat număr prim mai mare decât numărul generat.
4. Utilizând un "break" opriți bucla atunci când cel mai apropiat număr prim mai mare decât numărul generat este găsit
5. Returnați cel mai apropiat număr prim mai mare decât numărul generat sau un mesaj corespunzător dacă nu a fost găsit unul.
6. Adăugați o instrucțiune "return" în interiorul buclei "while" care să returneze cel mai apropiat număr prim mai mare decât numărul generat dacă 
diferența dintre acesta și numărul generat este mai mică decât o anumită valoare prestabilită (de exemplu, 5). 
Aceasta va permite oprirea buclei și returnarea rezultatului când este găsit un număr suficient de apropiat.
7. Testați programul cu diferite numere generate și verificați dacă returnează rezultatele așteptate.

let c=Math.floor(Math.random()*1000)+1
let userNumber=prompt(`Introduceti un numar :`)
let random=c+1
let flag =true
while(flag){
    let isPrime =true
    if(random==1){
        isPrime=false
    }
    for(j=2;j<random;j++){
        if(random%j==0){
            isPrime=false
        }
    }
    if(isPrime){
        if(c-random<userNumber){
            console.log(`Cel mai apropiat numar prim de ${c} este ${random}`)
            flag=false
        }else{
            console.log(`Diferenta dintre ${c} si ${random} este mai mare ca ${userNumber}`)
        }
    }
    else{
        random++
    }
}*/


/* Probleme individuale: 1. Creați un program care să returneze toți factorii primi ai unui număr introdus de utilizator.
    let userNumber=Number(prompt(`Introduceti un numar :`))
    console.log(`Factorii primi ai numarului : ${userNumber}`)
    for(let i=0;i<userNumber;i++)
    {
        if(userNumber%i==0){
            console.log(`${i}`)
        }
    }
*/


/*2. Creați un program care să determine dacă un număr introdus de utilizator este prim sau nu.
    let userNumber= Number(prompt(`Introduceti un numar :`));
    let isprime=userNumber==1? false:true;  
    for(let i=2;i<userNumber;i++){
        userNumber%i==0? isprime*=false :isprime*=true;
    };
    alert(`${userNumber} is ${isprime? 'prime':'not prime'} number`);
*/


/*3. Creați un program care să returneze cel mai mare divizor comun a două numere introduse de utilizator.
    let num1=Number(prompt(`Introduceti un numar :`))
    let num2=Number(prompt(`Introduceti un numar :`))
    while(num1!=num2){
        if(num1>num2){
            num1-=num2
        }else{
            num2-=num1
        }
    }
    console.log(`Cmmdc = ${num1}`)
*/


/*4. Creați un program care să returneze cel mai mic multiplu comun al a două numere introduse de utilizator.
    let num1=Number(prompt(`Introduceti un numar :`))
    let num2=Number(prompt(`Introduceti un numar :`))
    let x=num1
    let y=num2

    while(x!=y){
        if(x>y){
            x-=y
        }else{
            y-=x
        }
    }
    console.log(`cmmmc = ${(num1*num2)/x}`)
*/
    

/*5. Creați un program care să primească ca input un șir de caractere și să returneze numărul de apariții ale fiecărui caracter în șirul introdus 
utilizand o structura de tip switch sau if-else. Utilizand o bucla for sau while, iterati prin șirul de caractere și verificați fiecare caracter cu
ajutorul unei instrucțiuni switch sau if-else și incrementați o variabilă corespunzătoare pentru fiecare caracter.

-------- Example --------
var arr = [];
for(var i = 0; i < 10; i++)
   arr.push.prompt("Enter a number")

-------- Example --------
var arr = prompt("Introduceti un sir de caractere").split("")

    //Needed to be checked more
    let sir="abcdefghijklmnopabcd"
    let position=0

    for(let i=1; i<sir.length;i++){
        let count=0
        while(i<sir.length){
            if(sir[position]==sir[i]){
                count++
            }
        }
        console.log(`Elementul ${i} a aparut de ${count} ori`)
        position++
    }
*/


/*6. Creați un program care să returneze toate numerele prime dintr-un interval dat de numere, folosind o structura de tip while sau for, și verificarea 
fiecarui număr daca este prim sau nu, folosind o metodă de verificare a numerelor prime. Utilizați o instrucțiune "break" pentru a opri
bucla atunci când intervalul specificat a fost parcurs complet.
    let c=Number(prompt(`Introduceti limita intervalului : `))
    for(let k=0;k<c;k++){

        let isPrime =true
        if(k==1){
            isPrime=false
        }
        for(j=2;j<k;j++){
            if(k%j==0){
                isPrime=false
            }
        }
        if(isPrime){
            console.log(k)
        }
    }
*/
    

/*7. Creați un program care să returneze suma și numărul de elemente dintr-un array de numere, utilizand o structura de tip for sau while, și o 
instrucțiune if pentru a verifica dacă elementul este par sau impar. 
    let nrElemente=Number(prompt(`Introduceti numarul de elemente :`))
    var arr = [];
    for(var i = 0; i < nrElemente; i++){
        arr.push(prompt(`Introduceti ${nrElemente} numere : `))
    }
    let suma=0
    let produs=1
    for(let j=1; j<nrElemente; j++){
        suma+=j
        produs*=j
        if(j%2==0){
            console.log(`Numar par`)
        }else{
            console.log(`Numar impar`)
        }
    }

    console.log(`Suma : ${suma}`)
    console.log(`Produs : ${produs}`)
*/