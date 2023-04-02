//Creați un obiect JavaScript care să aibă cel puțin 3 proprietăți diferite și afișați-le în consolă.
const carte={
    "denumire":"Ion",
    "autor": "Liviu Rebreanu",
    "editura":"Arc",
    "anul": 2000
}
console.log(carte)

const {denumire, autor, editura, an}=carte
console.log(denumire, autor, editura, an)

let obj = JSON.stringify(carte);
console.log(obj)

//Creați o metodă în obiectul creat anterior care să calculeze suma dintre două numere și să returneze rezultatul.
let calculator = {
    sum: (nr1, nr2)=>{
      return nr1 + nr2
    }
}
console.log(calculator.sum(1,2))

//Creați un eveniment de click pe un buton în HTML și asociați-l cu o funcție JavaScript care să schimbe culoarea fundalului paginii.
const changeBtn=document.getElementById("btn")
changeBtn.addEventListener("click", function(){document.body.style.backgroundColor = "gray"})

//Creați o funcție care să primească un argument de tip obiect și să returneze numărul de proprietăți ale acestuia.
let person={
  name: "name",
  age: 18,
  email : "name@gmail.com",
  method : function(){
    console.log("JavaScript")
  }
}
const nrProperties=(obj)=>{
    return Object.keys(obj).length
}
console.log(nrProperties(person))

//Creați o metodă într-un obiect care să primească un șir de caractere și să-l transforme într-un șir de caractere cu litere mari.
let modifyString = {
  upperCase:(str)=>{
    return str.toUpperCase()
  },
  lowerCase:(str)=>{
    return str.toLowerCase()
  }
}
console.log(modifyString.upperCase("JavaScript"))

//Creați un eveniment de mouseover pe un element HTML și asociați-l cu o funcție JavaScript care să afișeze un mesaj în consolă.
const element=document.getElementById("mouseoverParagraf")
element.addEventListener("mouseover", ()=>{console.log('Mouse-ul este deasupra elementului')})

//Creați o funcție care să primească un argument de tip obiect și să verifice dacă acesta are o anumită proprietate și să returneze true sau false în funcție de caz.
const verifyProp=(obj, property)=>{
    return property in obj
}
console.log(verifyProp(person, "age"))
console.log(verifyProp(person, "agee"))

//Creați un eveniment de keypress pe un element HTML și asociați-l cu o funcție JavaScript care să afișeze caracterele tastate într-un element HTML.
const input = document.getElementById("input")
const text = document.getElementById("text")
input.addEventListener("keypress", (event)=>{text.innerHTML+=event.key})

//Creați o metodă într-un obiect care să primească un șir de caractere și să-l transforme într-un șir de caractere cu litere mici.
console.log(modifyString.lowerCase("JavaScript"))

//Creați un obiect JavaScript care să conțină un array de cel puțin 3 numere și o metodă care să calculeze suma acestora și să o returneze.
let sumObject = {
    numbers: [1,2,3],
    suma: function(){
      let sum = 0
      for (let i = 0; i < this.numbers.length; i++){
        sum += this.numbers[i]
      }
      return sum
    }
}
console.log(sumObject.suma());

//Creați un eveniment de resize pe fereastra browser-ului și asociați-l cu o funcție JavaScript care să afișeze dimensiunile ferestrei în consolă.
window.addEventListener('resize', ()=>{console.log(`Latimea ferestrei: ${window.innerWidth}px, Inaltimea ferestrei: ${window.innerHeight}px`);})

//Creați o funcție care să primească un argument de tip obiect și să verifice dacă acesta are o anumită metodă și să returneze true sau false în funcție de caz.
const existMethod = (obj, method)=>{
  return typeof obj[method] === "function"
}
console.log(existMethod(person,'method'))
console.log(existMethod(person,'anotherMethod'))

//Creați un eveniment de scroll pe o secțiune din pagină și asociați-l cu o funcție JavaScript care să afișeze poziția de scroll în consolă.
const section=document.getElementById('section')
section.addEventListener('scroll', ()=>{console.log(section.scrollTop)})

//Creați o metodă într-un obiect care să primească două șiruri de caractere și să le concateneze într-un șir de caractere.
const strObj ={
  concatinare : (str1,str2)=>{
    return str1+str2
  }
}
console.log(strObj.concatinare('Java', 'Script'))

//Creați un eveniment de touchstart pe un element HTML și asociați-l cu o funcție JavaScript care să afișeze coordonatele touch-ului în consolă.
const touch = document.getElementById('touch')
touch.addEventListener('touchstart', (event)=>{
        const touchX = event.touches[0].clientX
        const touchY = event.touches[0].clientY
        console.log(`x=${touchX}, y=${touchY}`)
})

//Creați o funcție care să primească un argument de tip obiect și să verifice dacă acesta este un array și să returneze true sau false în funcție de caz.
const isArray=()=>{
  return Array.isArray(obj)
}
console.log(isArray('JavaScript'))
console.log(isArray([1,2,3]))

//Creați un eveniment de contextmenu pe un element HTML și asociați-l cu o funcție JavaScript care să afișeze un meniu contextual.
const showContextMenu=(event)=>{
  event.preventDefault()

  const contextMenu = document.getElementById("context-menu")
  contextMenu.style.top = event.clientY + "px"
  contextMenu.style.left = event.clientX + "px"
  contextMenu.style.display = "block"
}
const hideContextMenu=()=>{
  const contextMenu = document.getElementById("context-menu")
  contextMenu.style.display = "none"
}
const doAction=(action)=>{
  alert("Ai selectat acțiunea " + action);
}

//Creați o metodă într-un obiect care să primească un număr și să returneze valoarea absolută a acestuia.
const absObj={
  absolute: (nr)=>{
    return Math.abs(nr)
  }
}
console.log(absObj.absolute(-1))

//Creați un eveniment de drag pe un element HTML și asociați-l cu o funcție JavaScript care să afișeze poziția elementului în timpul tragerii.
const dragElement=(event)=>{
  const draggedElement = event.target;
  const offsetX = event.clientX - draggedElement.offsetLeft;
  const offsetY = event.clientY - draggedElement.offsetTop;
  
  document.onmousemove = (event)=> {
    let newX = event.clientX - offsetX;
    let newY = event.clientY - offsetY;
    draggedElement.style.left = newX + "px";
    draggedElement.style.top = newY + "px";
    
    console.log("Poziția elementului: (" + newX + ", " + newY + ")");
  }
  document.onmouseup = function() {
    document.onmousemove = null;
  }
}

//Creați o funcție care să primească două argumente de tip număr și să returneze numărul mai mare dintre cele două.
const bigNumber=(nr1,nr2)=>{
  if(nr1>nr2){
    return nr1
  }else {return nr2}
}
console.log(bigNumber(1,-1))

//Creați un eveniment de input pe un element HTML de tip input și asociați-l cu o funcție JavaScript care să afișeze valoarea introdusă în consolă.
const afiseazaValoare=()=>{
  var inputNume = document.getElementById("numeVal");
  console.log("Valoarea introdusă este: " + inputNume.value);
}

//Creați o metodă într-un obiect care să primească un șir de caractere și să returneze numărul de caractere.
const strObject={
  nrCaractere : (sir)=>{
    return sir.length
  },
  inversare: (sir)=>{
    return sir.split("").reverse().join("")
  }
}
console.log(strObject.nrCaractere('JavaScript'))

//Creați un eveniment de blur pe un element HTML și asociați-l cu o funcție JavaScript care să afișeze un mesaj de validare.
const validateInput=(event)=> {
  let inputElement = event.target;
  if (inputElement.value === "") {
    alert("Acest câmp este obligatoriu!");
    inputElement.focus();
  } else {
    alert("Inputul este valid.");
  }
}

//Creați o funcție care să primească un argument de tip număr și să returneze valoarea sa în metri.
const meter=(nr)=>{
  return nr/100
}
console.log(meter(2000))

//Creați un eveniment de change pe un element HTML și asociați-l cu o funcție JavaScript care să afișeze noua valoare în consolă.
const afiseazaNume=()=>{
  var inputNume = document.getElementById("numeChange");
  console.log("Noul nume este: " + inputNume.value);
}

//Creați o metodă într-un obiect care să primească un șir de caractere și să returneze același șir, dar inversat.
console.log(strObject.inversare("tpircSavaJ"))