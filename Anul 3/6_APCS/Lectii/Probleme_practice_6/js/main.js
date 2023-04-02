//Sarcină practică Scrie un script JavaScript care să afișeze conținutul text al unui element HTML utilizând proprietatea innerText. Asigură-te că scriptul tău selectează elementul corect și afișează textul în mod corect.
const element = document.getElementById("element")
let text = element.innerText
console.log(text)

//Sarcină practică Scrie un script JavaScript care să afișeze conținutul HTML al unui element HTML utilizând proprietatea innerHTML. Asigură-te că scriptul tău selectează elementul corect și afișează HTML-ul în mod corect.
const elementHtml = document.getElementById("element")
let html = element.innerHTML
console.log(html)

//Sarcină practică Scrie un script JavaScript care să modifice conținutul text al unui element HTML utilizând proprietatea innerText. Asigură-te că scriptul tău selectează elementul corect și modifică textul în mod corect.
const elementModify = document.getElementById("element-modificat")
elementModify.innerText = "Noul text al elementului"

//Sarcină practică Scrie un script JavaScript care să modifice conținutul HTML al unui element HTML utilizând proprietatea innerHTML. Asigură-te că scriptul tău selectează elementul corect și modifică HTML-ul în mod corect.
elementModify.innerHTML = "<strong>Noul conținut HTML al elementului</strong>"

//Sarcină practică Scrie un script JavaScript care să modifice stilul CSS al unui element HTML utilizând proprietatea style. Asigură-te că scriptul tău selectează elementul corect și modifică stilul în mod corect.
const paragraf = document.getElementById("element")
paragraf.style.color = "blue"
paragraf.style.fontSize = "20px"
paragraf.style.fontWeight = "bold"

//Sarcină practică Scrie un script JavaScript care să adauge un element HTML într-un element existent utilizând metoda appendChild(). Asigură-te că scriptul tău selectează elementul existent și creează noul element în mod corect.
const div = document.getElementById("div")
let elementulNou = document.createElement("p")
elementulNou.innerText = "Element nou adăugat"
div.appendChild(elementulNou)

//Sarcină practică Scrie un script JavaScript care să creeze un element HTML nou și să-l adauge într-un element existent utilizând metoda appendChild(). Asigură-te că scriptul tău creează noul element și îl adaugă în elementul existent în mod corect.
let newElement = document.createElement("p")
newElement.innerText = "newElement"
div.appendChild(newElement)

//Sarcină practică Scrie un script JavaScript care să șteargă un element HTML utilizând metoda removeChild(). Asigură-te că scriptul tău selectează elementul corect și îl șterge în mod corect.
const parent = document.getElementById("parentDiv")
const child = document.getElementById("div-micut")
parent.removeChild(child)

//Sarcină practică Scrie un script JavaScript care să sorteze elementele HTML în funcție de anumite criterii (de exemplu, ordine alfabetică sau ordine numerică). Asigură-te că scriptul tău selectează elementele corecte și le sortează în mod corect.
const table = document.getElementById("table");
const rows = table.getElementsByTagName("tr");
const arr = Array.from(rows);
arr.sort((a, b) => {
  const cellA = a.getElementsByTagName("td")[0].textContent
  const cellB = b.getElementsByTagName("td")[0].textContent
  return cellA - cellB
})
while (table.firstChild){
  table.removeChild(table.firstChild)
}
arr.forEach((row) =>{
  table.appendChild(row)
})