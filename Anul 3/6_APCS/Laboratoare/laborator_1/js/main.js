/* Crearea unui joc ghicitorul numerelor

        let isEqual=false
        let start=true

        while(start){
            let userNumber=Number(prompt("Introduceti un numar intre 1 si 10"))
            let randomNumber=Math.floor(Math.random() * 11);

            if(userNumber==randomNumber){
                isEqual=true 
            }
            if(isEqual){
            alert(`Felicitari`)
            start=false
            }
            else{
                alert(`Numarul definit de sistem a fost ${randomNumber}`)
            }
            start=confirm(`Introdu un numar nou !`)
        }
*/

/* Crearea unui program conversie a valutei
        let suma=Number(prompt("Introduceti suma in mdl:"))
        let tipConfirm=confirm(`Doriti sa convertiti in USD ?`)
        let curs=1
        if(confirm){
            curs=Number(prompt(`Introduceti cursul de schimb USD: `))
            console.log(suma/curs.toFixed(2))
        }
        else{
            alert(`Suma se va converti in EUR!`)
            curs=Number(prompt(`Introduceti cursul de schimb EUR: `))
            console.log(suma/curs.toFixed(2))
        }
*/
       
/* Crearea unui program de afisare a temperaturii
    let temperatura=Number(prompt("Introduceti temperatura: "))
    let tipConfirm=confirm(`Doriti sa convertiti in Celsius?`)
    if(confirm){
        alert(((temperatura-32)*0.55).toFixed(2))
    }
    else{
        alert(`Suma se va converti in Fahrenheit!`)
        alert((temperatura*1.8+32).toFixed(2))
    }
*/
    
   


