// const produs={
//     name:'Asus VivoBook',
//     pret: 12000,
//     disponibilitate: true,
//     descriere:'About the product' 
// }
// const app=document.getElementById('app')
// app.innerHTML+=`<p>Nume: ${produs.name}</p>`
// app.innerHTML+=`<p>Pret: ${produs.pret}</p>`
// app.innerHTML+=`<p>Disponibilitate: ${produs.disponibilitate?'In stoc':'Lipsa stoc'}</p>`
// app.innerHTML+=`<p>Descriere : ${produs.descriere}</p>`


// const display=(obiect)=>{
//     for (const key in obiect) {
//         if(typeof obiect[key] ==='object'){
//             display(obiect[key])
//         }else{
//             console.log(`${key}: ${obiect[key]}`) 
//         }
//     }
// }
// const user={
//     name:'Name',
//     surename:'Surname',
//     email:'ns@gmail.com',
//     pasword:'p@ssword',
//     adress:{
//         tara:'MD',
//         codPostal: 5050,
//         oras:'Cahul',
//         strada:'str. Strada 56'
//     }
// }
// display(user)


// const car={
//     marca:'Marca',
//     model:'Model',
//     anul_fabricatiei:2010,
//     km_parcursi:'120 000'
// }
// const displayCar=(car)=>{
//     const app=document.getElementById('app')
//     for (const key in car) {
//         app.innerHTML+= `<p></p><b>${key}:${car[key]}</b></p>`
//     }
// }
// displayCar(car)

// let nameUser=prompt('Introduceti numele: ')
// let emailUser=prompt('Introduceti email-ul: ')
// let phoneUser=prompt('Introduceti numarul de telefon: ')
// let dateOfBirthUser=prompt('Introduceti data nasterii: ')

// const userWeb={
//     name: (nameUser.length===0)?alert(`Nume invalid !`):nameUser,
//     email: (emailUser.length===0)?alert(`Email invalid !`):emailUser,
//     phone_number: (phoneUser.length===0)?alert(`Numar invalid !`):phoneUser,
//     data_nasterii: (dateOfBirthUser.length===0)?alert(`Data invalida !`):dateOfBirthUser
// }

const restaurant={
    nume:`Denumire`,
    meniu:{
        produs1:{
            nume:"Pizza 1",
            pret: 100
        },
        produs2:{
            nume:"Pizza 1",
            pret: 100
        },
        produs3:{
            nume:"Pizza 1",
            pret: 100
        },
    }
}

const displayRestaurant=(obiect)=>{
    const app=document.getElementById('app')
    app.innerHTML+=`<h2>${obiect.nume}</h2>`
    for (const key in obiect.meniu){
       app.innerHTML+=`<div class="card" id=${key}>
        <p>Nume: ${obiect.meniu[key].nume}</p>
        <p>Pret: ${obiect.meniu[key].pret}</p>
        </div>`
    }
}
displayRestaurant(restaurant)