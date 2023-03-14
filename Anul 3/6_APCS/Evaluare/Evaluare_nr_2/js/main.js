//Creează o funcție care primește ca argument un obiect cu o proprietate numită persoane care este un tablou de obiecte, fiecare obiect având proprietățile nume și varsta. Funcția trebuie să returneze numele persoanei celei mai în vârstă.
const task1={
    person:[
        {name:"Ligia Teodora", age:32},
        {name:"Popescu Ion", age:22},
        {name:"Postolache Cristina", age:45},
        {name:"Stoica Vladislav", age:15}
    ]
}
const maxAge=(obj)=>{
    let maxAge = 0
    let nameMaxAge = ''
    
    for (let i = 0; i < obj.person.length; i++){
      if (obj.person[i].age > maxAge){
        maxAge = obj.person[i].age
        nameMaxAge = obj.person[i].name
      }
    }
    return nameMaxAge
}
console.log(maxAge(task1))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită studenti care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta și note (care este un tablou de numere). Funcția trebuie să returneze media notelor pentru fiecare student.
const task2={
    students:[
        {name:"Ligia Teodora", age:15, marks:[6,8,7]},
        {name:"Popescu Ion", age:12,  marks:[8,9,10,10]},
        {name:"Postolache Cristina", age:17,  marks:[10,8,9]},
        {name:"Stoica Vladislav", age:10,  marks:[7,9,9]}
    ]
}
const average=(obj)=>{
    const averages = []
    for (let i = 0; i < obj.students.length; i++){
      const note = obj.students[i].marks
      let sum = 0
      for (let j = 0; j < note.length; j++){
        sum += note[j]
      }
      const med = sum / note.length
      averages.push({name: obj.students[i].name, average: med})
    }
    return averages
}
console.log(average(task2))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită articole care este un tablou de obiecte, fiecare obiect având proprietățile titlu, autor și data. Funcția trebuie să returneze un tablou cu titlurile articolelor scrise de un anumit autor.
const task3={
    articole:[
        {titlu:"Ion", autor:"Liviu Rebreanu", data:1965},
        {titlu:"Mara", autor:"Liviu Ioan Slavici", data:1890},
        {titlu:"Padurea Spanzuratilor", autor:"Liviu Rebreanu", data:1920},
        {titlu:"Cezara", autor:"Mihai Eminescu", data:1932}
    ]
}
const articoleAutor=(obj, autor)=>{
    const titluri = [];
    for (let i = 0; i < obj.articole.length; i++){
      if (obj.articole[i].autor === autor){
        titluri.push(obj.articole[i].titlu)
      }
    }
    return titluri;
}
console.log(articoleAutor(task3, 'Liviu Rebreanu'))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită studenti care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta și note (care este un tablou de numere). Funcția trebuie să returneze un tablou cu numele studenților care au media notelor mai mare decât 8. 
const averageBiggerThan8=(obj)=>{
    const averages = []
    for (let i = 0; i < obj.students.length; i++){
      const note = obj.students[i].marks
      let sum = 0
      for (let j = 0; j < note.length; j++){
        sum += note[j]
      }
      if(sum / note.length>8){
        averages.push({name: obj.students[i].name, average: sum / note.length})
      }
    }
    return averages
}
console.log(averageBiggerThan8(task2))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită persoane care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta și oras. Funcția trebuie să returneze un tablou cu obiecte, fiecare obiect având proprietățile nume și oras.
const task5={
    persoane:[
        {name:'Ligia Teodora', age:32, city:'Cahul'},
        {name:"Popescu Ion", age:22,  city:"Balti"},
        {name:"Postolache Cristina", age:45,city:"Chisinau"},
        {name:"Stoica Vladislav", age:15,  city:"Orhei"}
    ]
}
const numeOrase=(obj)=>{
    const numeOrase = []
    for (let i = 0; i < obj.persoane.length; i++){
      const {name, city} = obj.persoane[i]
      numeOrase.push({name, city})
    }
    return numeOrase
}
console.log(numeOrase(task5))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită produse care este un tablou de obiecte, fiecare obiect având proprietățile nume, pret și disponibil (care este o valoare booleană). Funcția trebuie să returneze un tablou cu numele produselor care sunt disponibile și au un preț mai mic decât 100 de lei.
const task6={
    produse:[
        {nume:'product_name1', pret:150, disponibil: true},
        {nume:'product_name2', pret:85, disponibil: true},
        {nume:'product_name3', pret:20, disponibil: true},
        {nume:'product_name4', pret:85, disponibil: false}
    ]
}
const verify_product=(obj)=>{
    const list = []
    for (let i = 0; i < obj.produse.length; i++){
      const {nume, pret, disponibil} = obj.produse[i]
      if (disponibil && pret < 100){
        list.push(nume)
      }
    }
    return list
}
console.log(verify_product(task6))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită produse care este un tablou de obiecte, fiecare obiect având proprietățile nume, pret și categorie. Funcția trebuie să returneze un obiect cu proprietățile categorie1, categorie2, categorie3 etc., fiecare categorie conținând un tablou cu numele produselor din acea categorie.
const task7={
  obiecte:[
      {nume:'product_name1', pret:150, categorie: 'gospodarie'},
      {nume:'product_name2', pret:85, categorie: 'gospodarie'},
      {nume:'product_name3', pret:20, categorie: 'produs alimentar'},
      {nume:'product_name4', pret:85, categorie: 'produs alimentar'}
  ]
}
const generate_category=(obj)=>{
  const newObject={}
  const obiecte=obj.obiecte
  for(let i=0; i<obiecte.length;i++){
    const obiect = obiecte[i]
    if(!newObject[obiect.categorie]){
      newObject[obiect.categorie] = []
    }
    newObject[obiect.categorie].push(obiect.nume)
  }
  return newObject
}
console.log(generate_category(task7))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită produse care este un tablou de obiecte, fiecare obiect având proprietățile nume, pret și stoc (care reprezintă numărul de produse disponibile în stoc). Funcția trebuie să returneze un tablou cu obiecte, fiecare obiect având proprietățile nume și cantitate, unde cantitate este egală cu minimul dintre 3 și numărul de produse disponibile în stoc.
const task8={
  produse:[
      {nume:'product_name1', pret:150, stoc: 2},
      {nume:'product_name2', pret:85, stoc: 15},
      {nume:'product_name3', pret:20, stoc: 8},
      {nume:'product_name4', pret:85, stoc: 25}
  ]
}
const verify_stoc=(obj)=>{
  const stoc=[]
  const produse=obj.produse
  for(let i=0;i<produse.length;i++){
    const produs=obj.produse[i]
    const cantitate=Number(Math.min(3 , produs.stoc))
    stoc.push({nume: produs.nume, cantitate: cantitate})
  }
  return stoc
}
console.log(verify_stoc(task8))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită carti care este un tablou de obiecte, fiecare obiect având proprietățile titlu, autor și an. Funcția trebuie să returneze un obiect cu proprietatea anulPublicatiei care să conțină un alt obiect cu fiecare an distinct din tabloul de cărți, alături de o listă cu toate cărțile publicate în acel an.
const task9={
  carti:[
    {titlu:"Ion", autor:"Liviu Rebreanu", an:1965},
    {titlu:"Mara", autor:"Liviu Ioan Slavici", an:1890},
    {titlu:"Padurea Spanzuratilor", autor:"Liviu Rebreanu", an:1920},
    {titlu:"Cezara", autor:"Mihai Eminescu", an:1890}
  ]
}
const group_book=(obj)=>{
  const newObject={}
  const carti=obj.carti
  for(let i=0;i<carti.length; i++){
    const carte=carti[i]
    const anPublicatie=carte.an
    if(!newObject[anPublicatie]){
      newObject[anPublicatie]=[]
    }
    newObject[anPublicatie].push({titlu: carte.titlu, autor: carte.autor})
  }
  return {anulPublicatiei: newObject}
}
console.log(group_book(task9))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită comenzi care este un tablou de obiecte, fiecare obiect având proprietățile produs, cantitate și pret. Funcția trebuie să calculeze valoarea totală a tuturor comenzilor. 
const task10={
  comenzi:[
    {produs:"name", cantitate:10, pret:180},
    {produs:"name", cantitate:17, pret:200},
    {produs:"name", cantitate:3, pret:25},
    {produs:"name", cantitate:16, pret:60}
  ]
}
const calculate_value=(obj)=>{
  const comenzi=obj.comenzi
  let pretTotal=0
  for(let i=0; i<comenzi.length;i++){
    const comanda=comenzi[i]
    pretTotal+=comanda.cantitate*comanda.pret
  }
  return pretTotal
}
console.log(calculate_value(task10))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită studenti care este un tablou de obiecte, fiecare obiect având proprietățile nume, note1, note2 și note3 (care sunt tablouri de numere). Funcția trebuie să returneze un tablou cu numele studenților care au media notelor peste 7 pentru fiecare dintre cele trei semestre.
const task11={
  studenti:[
    {nume:"student1", note1:[7,8,7,9], note2:[10,8,9.20,9], note3:[7.80,8,9,9.35]},
    {nume:"student2", note1:[7,8,5,6], note2:[9.40,7,7.20,9], note3:[8.80,7,9.12,9]},
    {nume:"student3", note1:[5,8,6.85,6], note2:[7.66,8.33,9.20,9], note3:[7,7,9,9.35]},
    {nume:"student4", note1:[7,8,9], note2:[10,8,9.20,9], note3:[7.4,8,9,9]}
  ]
}
const goodGrade=(obj)=>{
  const studenti=obj.studenti
  const finalList=[]
  for(let i=0;i<studenti.length;i++){
    const student=studenti[i]
    const med1= student.note1.reduce((acc, cur) => acc + cur) / student.note1.length;
    const med2= student.note2.reduce((acc, cur) => acc + cur) / student.note1.length;
    const med3= student.note3.reduce((acc, cur) => acc + cur) / student.note1.length;

    if(med1>7 && med2>7 && med3>7){
      finalList.push(student.nume)
    }
  }
  return finalList
}
console.log(goodGrade(task11))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită carti care este un tablou de obiecte, fiecare obiect având proprietățile titlu, autor și an. Funcția trebuie să returneze un tablou cu toți autorii distinct din tabloul de cărți.
const group_book_autor=(obj)=>{
  let autori=[]
  for(let i=0; i<obj.carti.length;i++){
    let autor=obj.carti[i].autor
    if(!autori.includes(autor)){
      autori.push(autor)
    }
  }
  return autori
}
console.log(group_book_autor(task9))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită persoane care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta și oras. Funcția trebuie să returneze numele persoanelor care locuiesc într-un anumit oraș.
const task13={
  persoane:[
      {name:'Ligia Teodora', age:32, city:'Cahul'},
      {name:"Popescu Ion", age:22,  city:"Bucuresti"},
      {name:"Postolache Cristina", age:45,city:"Cahul"},
      {name:"Stoica Vladislav", age:25,  city:"Cluj"}
  ]
}
const verify_city=(obj,city)=>{
  let finalList=[]
  for(let i=0; i<obj.persoane.length;i++){
    let persoana=obj.persoane[i]
    if(persoana.city===city){
      finalList.push(persoana.name)
    }
  }
  return finalList
}
console.log(verify_city(task13,"Cahul"))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită produse care este un tablou de obiecte, fiecare obiect având proprietățile nume, pret și categorie. Funcția trebuie să returneze prețul minim și prețul maxim pentru fiecare categorie.
const pret=(obj)=>{
  let produseGrupate = {}
  for (let i = 0; i < obj.obiecte.length; i++){
    let obiect = obj.obiecte[i]
    if (!produseGrupate.hasOwnProperty(obiect.categorie)){
      produseGrupate[obiect.categorie] = []
    }
    produseGrupate[obiect.categorie].push(obiect.pret)
  }

  let preturi = {}
  for (let categorie in produseGrupate) {
    let preturiCategorie = produseGrupate[categorie]
    let pretMinim = Math.min(...preturiCategorie)
    let pretMaxim = Math.max(...preturiCategorie)
    preturi[categorie] = {
      pretMinim: pretMinim,
      pretMaxim: pretMaxim
    };
  }
  return preturi;
}
console.log(pret(task7))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită studenti care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta și note. Funcția trebuie să returneze un tablou cu numele studenților care au obținut cel puțin o notă mai mică decât 5.
const task15={
  students:[
      {name:"Ligia Teodora", age:15, marks:[6,4,7]},
      {name:"Popescu Ion", age:12,  marks:[8,9,10,3]},
      {name:"Postolache Cristina", age:17,  marks:[10,8,9]},
      {name:"Stoica Vladislav", age:10,  marks:[7,9,9]}
  ]
}
//.some() returnează true dacă cel puțin un element din tablou îndeplinește condiția specificată
const verify_negative_grade=(obj)=>{
  return obj.students.filter((student) => {
    return student.marks.some((nota) => nota < 5)
  })
  .map((student) => student.name)
}
console.log(verify_negative_grade(task15))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită angajati care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta, salariu și departament. Funcția trebuie să calculeze media salariilor pentru fiecare departament.
const task16={
  angajati:[
    {nume:'angajat1', varsta:39, salariu: 3000, departament: 'HR'},
    {nume:'angajat2', varsta:22, salariu: 5000, departament: 'copywriting'},
    {nume:'angajat3', varsta:18, salariu: 4500, departament: 'copywriting'},
    {nume:'angajat4', varsta:34, salariu: 1200, departament: 'HR'}
  ]
}
const verify_salary=(obj)=>{
  const salariiDepartamente = obj.angajati.reduce((grupuri, angajat) => {
    if (!grupuri[angajat.departament]) {grupuri[angajat.departament] = {
        numarAngajati: 0,
        salarii: 0,
      }
    }
    grupuri[angajat.departament].numarAngajati++
    grupuri[angajat.departament].salarii += angajat.salariu
    return grupuri
  }, {})
  //.entries() transforma obiectul într-un tablou de perechi [cheie, valoare] pentru itera fiecare grup
  return Object.entries(salariiDepartamente).map(([departament, { numarAngajati, salarii }]) => ({departament,mediaSalariilor: salarii / numarAngajati,}));
}
console.log(verify_salary(task16))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită elevi care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta și note (care este un tablou de obiecte cu proprietățile materie și nota). Funcția trebuie să calculeze media notelor pentru fiecare elev și să returneze un tablou cu numele elevilor și media notelor lor.
const calculate_average=(obj)=>{
  return obj.students.map(function(elev){
    var totalNote = 0
    var numarNote = 0
    for (var i = 0; i < elev.marks.length; i++){
      totalNote += elev.marks[i].nota
      numarNote++
    }
    return {
      nume: elev.name,
      media: totalNote / numarNote
    }
  })
}
console.log(calculate_average(task15))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită comenzi care este un tablou de obiecte, fiecare obiect având proprietățile produs, cantitate și pret. Funcția trebuie să calculeze valoarea totală a comenzilor pentru fiecare produs și să returneze un obiect cu aceste valori.
const calculate_value_obj=(obj)=>{
  const comenzi=obj.comenzi
  let pretTotal=0
  for(let i=0; i<comenzi.length;i++){
    const comanda=comenzi[i]
    pretTotal+=comanda.cantitate*comanda.pret
  }
  return {total: pretTotal}
}
console.log(calculate_value_obj(task10))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită angajati care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta, salariu și departament. Funcția trebuie să returneze un tablou cu numele angajaților dintr-un anumit departament și salariile lor.
const sort_departament=(obj, departamentCautat)=>{
  const finalList = [];
  for (let i = 0; i < obj.angajati.length; i++){
    const angajat = obj.angajati[i];
    if (angajat.departament === departamentCautat){
      const angajatRezultat = {
        nume: angajat.nume,
        salariu: angajat.salariu
      };
      finalList.push(angajatRezultat)
    }
  }
  return finalList
}
console.log(sort_departament(task16, 'HR'))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită produse care este un tablou de obiecte, fiecare obiect având proprietățile nume, pret și categorie. Funcția trebuie să returneze numele produsului cu cel mai mic preț din fiecare categorie.
const verify_cheap=(products)=>{
  let cheapestProducts = {}
  for (let i = 0; i < products.length; i++) {
    let product = products[i]
    if (!(product.categorie in cheapestProducts)) {
      cheapestProducts[product.categorie] = product
    } else if (product.pret < cheapestProducts[product.categorie].pret) {
      cheapestProducts[product.categorie] = product
    }
  }
  let result = []
  for (let category in cheapestProducts) {
    result.push(cheapestProducts[category].nume)
  }
  return result;
}
console.log(verify_cheap(task7))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită produse care este un tablou de obiecte, fiecare obiect având proprietățile nume, pret și disponibil (care este o valoare booleană). Funcția trebuie să returneze un tablou cu numele produselor care sunt disponibile.
const verify_disponibility=(obj)=>{
  const list = []
  for (let i = 0; i < obj.produse.length; i++){
    const {nume, disponibil} = obj.produse[i]
    if (disponibil){
      list.push(nume)
    }
  }
  return list
}
console.log(verify_disponibility(task6))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită elevi care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta și note (care este un tablou de obiecte cu proprietățile materie și nota). Funcția trebuie să returneze numele elevilor care au nota medie mai mare sau egală cu 9.
const task24={
  elevi:[
    {nume:"name1", varsta:14, note:[ 
      { materie: "Matematica", nota: 9 },
      { materie: "Limba Romana", nota: 10 }
    ]},
    {nume:"name2", varsta:16, note:[ 
      { materie: "Matematica", nota: 7 },
      { materie: "Limba Romana", nota: 7 },
      { materie: "Istorie", nota: 10 }
    ]},
    {nume:"name2", varsta:18, note:[ 
      { materie: "Matematica", nota: 8 },
      { materie: "Limba Romana", nota: 9 }
    ]}
  ]
}
const verify_grade=(obj)=>{
  return obj.elevi.filter((elev) => {
    const average = elev.note.reduce((sum, grade) => sum + grade.nota, 0) / elev.note.length;
    return average >= 9;
  })
  .map((elev) => elev.nume);
}
console.log(verify_grade(task24))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită produse care este un tablou de obiecte, fiecare obiect având proprietățile nume, pret și categorie. Funcția trebuie să returneze numele produselor care au prețul mai mic decât 10 și care fac parte din categoria "fructe".
const task25={
  produse:[
    {nume:'product_name1', pret:50, categorie: 'legume'},
    {nume:'product_name2', pret:85, categorie: 'legume'},
    {nume:'product_name3', pret:8, categorie: 'fructe'},
    {nume:'product_name4', pret:30, categorie: 'fructe'}
  ]
}
const verify_category=(obj)=>{
  return obj.produse
    .filter((produs) => produs.pret < 10 && produs.categorie === "fructe").map((produs) => produs.nume);
}
//
console.log(verify_category(task25))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită filme care este un tablou de obiecte, fiecare obiect având proprietățile titlu, durata și genuri (care este un tablou de genuri). Funcția trebuie să returneze numele tuturor filmelor care au durata mai mică sau egală cu 90 de minute și care fac parte din genul "comedie".
const task26={
  filme:[
      {titlu:'title1', durata:80, genul: 'comedie'},
      {titlu:'title2', durata:150, genul: 'stiintific'},
      {titlu:'title3', durata:110, genul: 'comedie'},
      {titlu:'title4', durata:100, genul: 'drama'}
  ]
}
const verify_movie=(obj)=>{
  const finalList = []
  for (let i = 0; i < obj.filme.length; i++){
    const time = obj.filme[i].durata
    const genre = obj.filme[i].genul
    if (time <= 90 && genre ==='comedie'){
      finalList.push(obj.filme[i].titlu)
    }
  }
  return finalList
}
console.log(verify_movie(task26))
//Creează o funcție care primește ca argument un obiect cu o proprietate numită persoane care este un tablou de obiecte, fiecare obiect având proprietățile nume, varsta și oras. Funcția trebuie să returneze numele tuturor persoanelor care au vârsta mai mare sau egală cu 18 ani și care locuiesc în orașul "Cluj".
const sort_people=(obj)=>{
  let finalList=[]
  for(let i=0; i<obj.persoane.length;i++){
    let persoana=obj.persoane[i]
    if(persoana.city ==="Cluj" && persoana.age>=18){
      finalList.push(persoana.name)
    }
  }
  return finalList
}
console.log(sort_people(task13))
