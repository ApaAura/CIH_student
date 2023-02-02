/* Este dată o matrice cu elementele: ['Apple', 'Banana', 'Strawberry', 'Mango', 'Cherry'] 
afișați toate elementele care au numărul de caractere mai mic decât 7. 
    const fruits=['Apple', 'Banana', 'Strawberry', 'Mango', 'Cherry'] 
    console.log(`Elemente cu mai putin de 7 caractere : `)
    for(let i=0; i<fruits.length;i++){
        if(fruits[i].length<7){
            console.log(fruits[i])
        }
    }
*/

/* Este dată o matrice cu numere aleatorii elaborați o funcție ce va returna media aritmetică a numerelor.
    let c=Number(prompt(`Introduceti numarul de elemente :`))
    let avg=0
    const elemente=[]
    for(let i=0; i<c; i++){
        elemente[i]=Math.floor(Math.random() * 100)+1
    }

    console.log(`Elementele matricii: `)
    console.log(elemente)
    const average=(arr)=>{
        let media=0
        for(let i=0;i<arr.length;i++){
            media+=arr[i]
        }
        return media/arr.length
    }
    console.log(`Average ${average(elemente)}`)
*/

/* Este dat un obiect de forma { id: 25, nume: ‘Doe’, prenume: ‘John’, age: 52, salary: 4500 }, 
elaborați o funcție ce va returna numele complet în consola browserului. 
    const person ={
        id: 25, 
        nume: 'Doe', 
        prenume: 'John', 
        age: 52, 
        salary: 4500 
    }
    console.log(`${person.nume} ${person.prenume}`)
*/

/* Este dată o matrice cu următoarele elemente. Afișați într-o listă ordonată numele, prenumele și vârsta utilizatorilor 
care au salariul mai mare de 600, din matricea de mai sus.
    const angajat=[
        { nume: 'Nola', prenume: 'Aufderhar', age: 28, salary: 645.99 },
        { nume: 'Arielle', prenume: 'Jaskolski', age: 18, salary: 207.82 },
        { nume: 'Jalen', prenume: 'Kulas', age: 23, salary: 838.46 },
        { nume: 'Estella', prenume: 'Thiel', age: 41, salary: 803.32 },
        { nume: 'Felix', prenume: 'Jast', age: 36, salary: 452.35 }
    ]

    const angajatBanos=[]
    for(let i=0; i<angajat.length;i++){
        if(angajat[i].salary>600){
            angajatBanos.push(angajat[i])
        }
    }

    if(angajatBanos.length==0){
        console.log(`Nu sunt angajati cu un salariu mai mare de 600 !`)
    }else{
        console.log(`Angajati cu salariul mai mare de 600 !`)
        for(let i=0; i<angajatBanos.length;i++){
            console.log(`${angajatBanos[i].nume}     ${angajatBanos[i].prenume}      ${angajatBanos[i].age}      ${angajatBanos[i].salary} `)
        }
    }
*/