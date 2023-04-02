// Crearea unui buton de tip toggle care să schimbe culoarea fundalului când este apăsat. Pentru aceasta, se va folosi metoda addEventListener() pentru a detecta evenimentul de click și se va modifica proprietatea CSS backgroundColor a elementului selectat pentru a schimba culoarea de fundal.
const butonToggle = document.getElementById("buton-toggle")
let culoareCurenta = "white"
butonToggle.addEventListener("click",()=>{
  if (culoareCurenta === "white"){
    document.body.style.backgroundColor = "#56869a"
    culoareCurenta = "#56869a"
  }else{
    document.body.style.backgroundColor = "white"
    culoareCurenta = "white"
  }
})

