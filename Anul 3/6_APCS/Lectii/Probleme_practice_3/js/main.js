//Scrieți o funcție multiplyBy care primește un număr și returnează o altă funcție care primește un alt număr și îl înmulțește cu numărul primit în prima funcție.

const multiplyBy=(y, callback)=>{
    return y*callback
}
const factor={
    x: 5,
    getX: function(){
        return this.x
    }
}
const unboundGetX=factor.getX
const boundGetX = getX = unboundGetX.bind(factor)

console.log(boundGetX())
console.log(multiplyBy(5, boundGetX()))

//Second
const multiplyBy2=(y)=>{
    return function(x){return y*x}.bind(y)
}
const factor2=multiplyBy2(5)
console.log(factor2(10))

//Scrieți o funcție counter care returnează o funcție anonimă care, atunci când este apelată, incrementează și returnează un număr.
const counter=()=>{
    return (i)=>{
        i++
        return i
    }
}
console.log(counter()(5))

//Scrieți o funcție createAdder care primește un număr și returnează o altă funcție care, atunci când este apelată, adaugă numărul primit în prima funcție la argumentul său.
const createAdder=(num1)=>{
    return function(num2){
        arguments[0]=num1 
        return  arguments[0]
    }
}
console.log(createAdder(5)(4))

//Scrieți o funcție makeArray care returnează o funcție anonimă care poate adăuga sau returna valori într-un array.
const makeArray=function(arr,c){
    arr.push(c)
    return arr
}
const array=[3,4,7]
console.log(makeArray(array,8))

/*Scrieți o funcție createObject care returnează un obiect cu o proprietate greet care este o funcție anonimă care afișează Hello!. 
Utilizați call sau apply pentru a schimba valoarea this în interiorul funcției.*/
const createObject=()=>{
    return person={
        message: "Hello!",
        greet:()=>{
            return this.message
        }
    }
}
console.log(createObject())

(()=>{
    //apelarea unei functii anonime
})()