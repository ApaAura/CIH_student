//Obiectul Array
//mozila.org

//Metoda filter
const words=['apple', 'banana', 'cherry', 'date', 'eggplant']
const wordsContainA=words.filter((word)=>word.includes('a'))
console.log(wordsContainA)

//forEach
const myArray=[
    [1,2,3],
    [4,5,6],
    [7,8,9]
]
myArray.forEach(row=>{
    row.forEach(element=>{
        console.log(element)
    })
})

//join
const wordsForJoin=["Salut","cum","merge","azi?"]
const sentence=wordsForJoin.join(" ")
console.log(sentence)

//sort
const numere=[3,1,4,1,5,9,2,6,5,3,5]
const numbers=[1,100,11,2,21,9]
numere.sort()
numbers.sort()
console.log(numere)
console.log(numbers)

//sort numbers
numbers.sort((a,b)=>a-b)//ascending
numbers.sort((a,b)=>b-a)//descending
console.log(numbers)