//Creați un eveniment de submit pe un formular HTML și asociați-l cu o funcție JavaScript care să verifice dacă toate câmpurile sunt completate și să afișeze un mesaj de eroare dacă nu sunt.
const form = document.getElementById("myForm");
const verificaCompletare=(event)=>{
  event.preventDefault();
  let name = document.getElementById("name").value;
  let email = document.getElementById("email").value;

  if (name === "" || email === "") {
    alert("Câmpuri obligatorii!")
  }else{
    form.submit();
  }
}
form.addEventListener("submit", verificaCompletare);