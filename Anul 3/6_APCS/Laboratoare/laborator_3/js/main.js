//functie declarativa
function fullName(firstName='ABC', lastName='abc'){
    return `${firstName} ${lastName}`
}

function pcData(){
    let date=new Date()
    return date
}
console.log(pcData())

//functie expresie (anonima)
const date=function(){
    let date=new Date()
    return date
}

//functie asociativa
const datee= (firstName='ABC', lastName='abc')=>{
    return `${firstName} ${lastName}`
}
const dateee= (firstName='ABC', lastName='abc')=>`${firstName} ${lastName}`
const hello = lastName => `Hello ${lastName}`


//Scrieți o funcție calculateSum care primește 2 parametri și returnează suma lor.
const calculateSum=function(a,b){
    return `${a+b}`
}
console.log(calculateSum(5,6))

//Scrieți o funcție convertToCelsius care primește o temperatură în Fahrenheit și returnează conversia în Celsius.
const convertToCelsius=function(kelvin){
    return `${kelvin-273.15}`
}
const convertCelsius=function(fahrenheit){
    return `${((fahrenheit-32)*5/9).toFixed(4)}`
}
console.log(convertCelsius(450))
console.log(convertToCelsius(450))

//Scrieți o funcție greatest care primește o listă de numere și returnează cel mai mare număr din listă.
const greates=(list)=>{
    let max=list[0]
    for(i=0;i<list.length; i++){
        if(list[i]>max){
            max=list[i]
        }
    }
    return max
}
let nr=[1,2,3,4,5,6]
console.log(greates(nr))

//Scrieți o funcție countVowels care primește un șir de caractere și returnează numărul de vocale din șir.
//const count = str.match(/[aeiou]/gi).length;
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

//Scrieți o funcție reverseString care primește un șir de caractere și returnează șirul inversat.
const reverseString=(sir)=>{
    let reverse=''
    for(let i=sir.length-1;i>=0;i--){
        reverse+=sir[i]
    }
    return reverse
}
console.log(reverseString('olleh'))

//Scrieți o funcție fibonacci care returnează un array cu primele n numere din secvența Fibonacci.
const fibonacci=(n)=>{
    let num1=0
    let num2=1
    let sum
    let arr=[]
    for(i=0;i<n;i++){
        sum=num1+num2;
        num1=num2;
        num2=sum;
        arr[i]=num1
    }
    return arr;
}
console.log(fibonacci(8))

//Scrieți o funcție isPalindrome care primește un șir de caractere și returnează true dacă șirul este un palindrom și false în caz contrar.
const isPalindrome=(sir)=>{
    if(sir==reverseString(sir)){
        return true
    }else{
        return false
    }
}
console.log(isPalindrome('palindrom'))
console.log(isPalindrome('ana'))

//Scrieți o funcție sumArray care primește un array de numere și returnează suma lor.
const sumArray=(arr)=>{
    let sum=0
    for(i=0;i<arr.length;i++){
        sum+=arr[i]
    }
    return sum
}
let nrForSum=[14,21,35,42,55]
console.log(sumArray(nrForSum))

//Scrieți o funcție average care primește un array de numere și returnează media aritmetică a acestora.
const average=(arr)=>{
    let media=0
    for(let i=0;i<arr.length;i++){
        media+=arr[i]
    }
    return media/arr.length
}
let nrForAverage=[14,21,35,42,55]
console.log(average(nrForAverage))

//Scrieți o funcție filterArray care primește un array de numere și un număr x și returnează un array cu numerele mai mari decât x.
const filterArray=(arr, x)=>{
    let biger=[]
    let j=0
    for(let i=0;i<arr.length;i++){
        if(arr[i]>x){
            biger[j]=arr[i]
            j++
        }
    }
}
let arr=[14,21,35,42,55]
console.log(arr, 30)