//Implementarea unei funcții care să afișeze un mesaj de confirmare atunci când utilizatorul încearcă să părăsească pagina. Acesta se poate realiza prin atașarea unui listener la evenimentul beforeunload și afișarea unei ferestre modale pentru a cere confirmarea utilizatorului.

window.addEventListener("beforeunload", (event)=>{
    event.preventDefault()
    alert("Sigur doriți să părăsiți pagina?")
})