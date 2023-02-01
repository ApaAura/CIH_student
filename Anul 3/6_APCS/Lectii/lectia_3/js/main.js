const addNumbers=(a,b, callback)=>{
    return callback(a,b)
}

const sum=(a,b)=>{
    return a+b
}
//console.log(addNumbers(12,8,sum))

const countLetters=(words, callback)=>{
    return callback(words)
}
const totalLetter=(words)=>{
    return words.join('').length
}
//console.log(countLetters((['Java','Script']), totalLetter))

const sumNumbers=(numbers, callback)=>{
    return callback(numbers)
}

const addArray=(numbers)=>{
    return numbers.reduce((a,b)=>a+b)
}
//console.log(sumNumbers(([1,2,3,4,5]), addArray))

const findMax=(numbers, callback)=>{
    return callback(numbers)
}

const maxNumber=(numbers)=>{
    return Math.max(...numbers)
}
//console.log(findMax([1,2,3,4,5],maxNumber))

const findMin=(numbers,callback)=>{
    return callback(numbers)
}

const minNumber=(numbers)=>{
    return Math.min(...numbers)
}
//console.log(findMin([1,2,3,4,5], minNumber))