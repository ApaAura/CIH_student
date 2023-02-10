//Scrie o funcție care să primească un număr și să returneze &quot;par&quot; dacă numărul este par sau &quot;impar&quot; dacă numărul este impar.
const paritate=(n)=>{
    if(n%2==0){
        return console.log(`Numarul ${n} este par !`)
    }else{
        return console.log(`Numarul ${n} este impar !`)
    }
}
paritate(5)
paritate(6)

//Scrie o funcție care să primească o listă de numere și să returneze suma acestora.
const suma=(elements)=>{
    let suma=0
    for(let i=0; i<elements.length;i++){
        suma+=elements[i]
    }
    return suma
}
arrNumbers=[1,2,3,4,5]
console.log(`Suma elementelor este ${suma(arrNumbers)}`)

//Scrie o funcție care să primească un string și să returneze cel mai lung cuvânt din acesta.
const determineLength=(elements)=>{
    lungime=elements[0].length
    for(let i=1; i<elements.length;i++){
        if(elements[i].length>lungime){
            lungime=elements[i].length
        }
    }
    for(let i=1; i<elements.length;i++){
        if(elements[i].length==lungime){
            return elements[i]
        }
    }
}
arrWords=[`iarna`, `primavara`, `vara`, `toamna`]
console.log(determineLength(arrWords))

//Scrie o funcție care să primească un număr și să returneze faptorialul acestuia.
const factorial=(n)=>{
    produs=1
    for(i=1;i<n;i++){
        produs*=i
    }
    return produs
}
console.log(factorial(5))

//Scrie o funcție care să primească o listă de numere și să returneze cel mai mare număr din această listă.
const bigNumber=(list)=>{
    big=0
    for(i=0;i<list.length;i++){
        if(list[i]>big){
            big=list[i]
        }
    }
    return big
}
list=[-1,1,2,3,4,5,6]
console.log(bigNumber(list))

//Scrie o funcție care să primească un string și să returneze numărul de vocale din acesta.
const countVowels=(sir)=>{
    let nrVocale=0
    let vocale='aeiou'
    for(i=0;i<sir.length;i++){
        if(vocale.includes(sir[i])){
            nrVocale++
        }
    }
    return nrVocale
}
console.log(countVowels('JavaScript'))

//Scrie o funcție care să primească o listă de numere și să returneze media aritmetică a acestora.
const average=(arr)=>{
    let media=0
    for(let i=0;i<arr.length;i++){
        media+=arr[i]
    }
    return media/arr.length
}
let nrForAverage=[14,21,35,42,55]
console.log(average(nrForAverage))

//Scrie o funcție care să primească un string și să returneze string-ul inversat.
const reverseString=(sir)=>{
    let reverse=''
    for(let i=sir.length-1;i>=0;i--){
        reverse+=sir[i]
    }
    return reverse
}
console.log(reverseString('tpircSavaJ'))

//Scrie o funcție care să primească o listă de numere și să returneze cel mai mic număr din această listă.
const smallNumber=(list)=>{
    small=0
    for(i=0;i<list.length;i++){
        if(list[i]<small){
            small=list[i]
        }
    }
    return small
}
console.log(smallNumber(list))

//Scrie o funcție care să primească un string și să returneze numărul de consoane din acesta.
const countConsonant=(sir)=>{
    let nrConsoane=0
    let consoane='qwrtypsdfghjklzxcvbnm'
    for(i=0;i<sir.length;i++){
        if(consoane.includes(sir[i])){
            nrConsoane++
        }
    }
    return nrConsoane
}
console.log(countConsonant('javascript'))

// Scrie o funcție care să primească o listă de numere și să returneze suma numerelor pare din această listă.
const sumaPare=(list)=>{
    let suma=0
    for(i=0;i<list.length;i++){
        if(list[i]%2==0){
            suma+=list[i]
        }
    }
    return suma
}
console.log(sumaPare(list))

//Scrie o funcție care să primească o listă de numere și să returneze suma numerelor impare din această listă.
const sumaImpare=(list)=>{
    let suma=0
    for(i=0;i<list.length;i++){
        if(list[i]%2!=0){
            suma+=list[i]
        }
    }
    return suma
}
console.log(sumaImare(list))
