const head = document.head
const body = document.body
//console.log(body.childNodes)

body.childNodes.forEach(element =>{
    //console.log(element)
})

//Cautam elementul dupa ID
const primulParagraf = document.getElementById('primul') 
const paragraf = document.querySelector('p')
const paragrafe = document.querySelectorAll('.container')
const listaParagrafe = document.getElementsByTagName('p')
const elements = document.getElementsByClassName('container')

/*Array.from(listaParagrafe).forEach(p =>{
    console.log(p)
})*/

const nodeParagrafe = document.querySelectorAll('p')
const container = document.querySelector('.container')

container.childNodes.forEach(p=>{
    p.addEventListener('click', ()=>{
        p.remove()
    })
})
//console.log(nodeParagrafe)